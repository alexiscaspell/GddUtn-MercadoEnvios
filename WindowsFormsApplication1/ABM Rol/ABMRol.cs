﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.ABM_Rol;
using WindowsFormsApplication1.Clases;
using WindowsFormsApplication1.Generar_Publicación;
using WindowsFormsApplication1.Login.ClasesLogin;

namespace WindowsFormsApplication1.ABM_Rol
{
    public partial class ABMRol : Form
    {
        private List<Rol> rubros;
        private RolRepository repositorio = new RolRepository();
        private Form formAnterior;
        private Usuario user;
        private List<Rol> roles;
        private Rol rolSeleccionado;

        public ABMRol(Form formAnterior,Usuario user)
        {
            this.formAnterior = formAnterior;
            this.user = user;
            InitializeComponent();
        }

        private void ABMRol_Load(object sender, EventArgs e)
        {
            roles = repositorio.obtenerRolesDe(user);

            rolSeleccionado = roles[0];
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            inicializarDataGrid();

            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            foreach (Rol rol in roles)
            {
                tablaRoles.Rows.Add(rol.nombre, rol.habilitado);
            }
        }

        private void inicializarDataGrid()
        {
            DataGridViewTextBoxColumn cNombre = new DataGridViewTextBoxColumn();
            cNombre.HeaderText = "Nombre";
            cNombre.ReadOnly = true;
            tablaRoles.Columns.Add(cNombre);
            DataGridViewTextBoxColumn cHabilitado = new DataGridViewTextBoxColumn();
            cHabilitado.HeaderText = "Habilitado";
            cHabilitado.ReadOnly = true;
            tablaRoles.Columns.Add(cHabilitado);
        }

        private void Eliminar_Button_Click(object sender, EventArgs e)
        {
            repositorio.eliminarRolDe(user, rolSeleccionado);
        }

        private void tablaRoles_Click(object sender, EventArgs e)
        {
            rolSeleccionado = roles[tablaRoles.CurrentCell.RowIndex];
        }

        private void ABMRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            formAnterior.Close();
        }

        private void Volver_Button_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            Hide();
        }
    }
}
