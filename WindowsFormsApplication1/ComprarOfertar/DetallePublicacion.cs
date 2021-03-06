﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Calificar;
using WindowsFormsApplication1.Clases;

namespace WindowsFormsApplication1.ComprarOfertar
{
    public partial class DetallePublicacion : Form
    {
        private Form formAnterior;
        private Publicacion publicacion;
        private Usuario user;
        private bool botonComprarActivado;

        public DetallePublicacion(Publicacion publicacionSeleccionada, Form formAnterior, Usuario usuario,bool botonComprarActivado)
        {
            this.botonComprarActivado = botonComprarActivado;
            this.publicacion = publicacionSeleccionada;
            this.formAnterior = formAnterior;
            user = usuario;
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            CompraRepository compraRepo = new CompraRepository();

            string mensaje = compraRepo.validacionDeCompra(publicacion,user);

            if (mensaje!="todo piolaa")
            {
                MessageBox.Show(mensaje.ToUpper());
                return;
            }

            if (publicacion.sosSubasta())
            {
                Ofertar ofertar = new Ofertar(publicacion, user, formAnterior);
                Hide();
                ofertar.ShowDialog();
            }
            else
            {
                Comprar comprar = new Comprar(publicacion, user, formAnterior);
                Hide();
                comprar.ShowDialog();
            }
        }

        private void DetallePublicacion_Load(object sender, EventArgs e)
        {
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            visibilidad.Text = publicacion.visibilidad.nombre;
            fechaFin.Text = publicacion.fechaVencimiento.ToString();
            fechaInicio.Text = publicacion.fechaInicio.ToString();
            estado.Text = publicacion.estado.nombre;
            tipo.Text = publicacion.tipo.nombre;
            rubro.Text = publicacion.rubro.descripcionCorta;
            descripcion.Text = publicacion.descripcion;
            precio.Text = publicacion.precio.ToString();
            stock.Text = publicacion.stock.ToString();
            username.Text = publicacion.responsable.nick;
            codigoPublicacion.Text = publicacion.id.ToString();
            btnComprar.Visible = botonComprarActivado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Close();
        }

        private void DetallePublicacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            formAnterior.Show();
        }
    }
}
