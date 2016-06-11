﻿namespace WindowsFormsApplication1.ComprarOfertar
{
    partial class ComprarOfertar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRubros = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBorrarDescripcion = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarRubros = new System.Windows.Forms.Button();
            this.btnAbrirPublicacion = new System.Windows.Forms.Button();
            this.btnUltimaPag = new System.Windows.Forms.Button();
            this.btnPrimerPag = new System.Windows.Forms.Button();
            this.btnSiguientePag = new System.Windows.Forms.Button();
            this.btnAnteriorPag = new System.Windows.Forms.Button();
            this.Publicaciones_Datagrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Publicaciones_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(12, 503);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRubros);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnBorrarDescripcion);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregarRubros);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 78);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros:";
            // 
            // txtRubros
            // 
            this.txtRubros.Location = new System.Drawing.Point(95, 48);
            this.txtRubros.Name = "txtRubros";
            this.txtRubros.ReadOnly = true;
            this.txtRubros.Size = new System.Drawing.Size(295, 23);
            this.txtRubros.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(522, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(180, 38);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(741, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(103, 38);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Sin filtros!";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnBorrarDescripcion
            // 
            this.btnBorrarDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarDescripcion.Location = new System.Drawing.Point(396, 17);
            this.btnBorrarDescripcion.Name = "btnBorrarDescripcion";
            this.btnBorrarDescripcion.Size = new System.Drawing.Size(103, 23);
            this.btnBorrarDescripcion.TabIndex = 2;
            this.btnBorrarDescripcion.Text = "Borrar descripción";
            this.btnBorrarDescripcion.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(23, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(95, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(295, 23);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rubro/s:";
            // 
            // btnAgregarRubros
            // 
            this.btnAgregarRubros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRubros.Location = new System.Drawing.Point(396, 46);
            this.btnAgregarRubros.Name = "btnAgregarRubros";
            this.btnAgregarRubros.Size = new System.Drawing.Size(103, 23);
            this.btnAgregarRubros.TabIndex = 3;
            this.btnAgregarRubros.Text = "Agregar rubros";
            this.btnAgregarRubros.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPublicacion
            // 
            this.btnAbrirPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirPublicacion.Location = new System.Drawing.Point(685, 495);
            this.btnAbrirPublicacion.Name = "btnAbrirPublicacion";
            this.btnAbrirPublicacion.Size = new System.Drawing.Size(180, 38);
            this.btnAbrirPublicacion.TabIndex = 18;
            this.btnAbrirPublicacion.Text = "Abrir Publicacion";
            this.btnAbrirPublicacion.UseVisualStyleBackColor = true;
            // 
            // btnUltimaPag
            // 
            this.btnUltimaPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimaPag.Location = new System.Drawing.Point(418, 503);
            this.btnUltimaPag.Name = "btnUltimaPag";
            this.btnUltimaPag.Size = new System.Drawing.Size(75, 23);
            this.btnUltimaPag.TabIndex = 17;
            this.btnUltimaPag.Text = "Ultima";
            this.btnUltimaPag.UseVisualStyleBackColor = true;
            // 
            // btnPrimerPag
            // 
            this.btnPrimerPag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerPag.Location = new System.Drawing.Point(287, 503);
            this.btnPrimerPag.Name = "btnPrimerPag";
            this.btnPrimerPag.Size = new System.Drawing.Size(75, 23);
            this.btnPrimerPag.TabIndex = 14;
            this.btnPrimerPag.Text = "Primera";
            this.btnPrimerPag.UseVisualStyleBackColor = true;
            // 
            // btnSiguientePag
            // 
            this.btnSiguientePag.Location = new System.Drawing.Point(393, 503);
            this.btnSiguientePag.Name = "btnSiguientePag";
            this.btnSiguientePag.Size = new System.Drawing.Size(19, 23);
            this.btnSiguientePag.TabIndex = 16;
            this.btnSiguientePag.Text = ">";
            this.btnSiguientePag.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorPag
            // 
            this.btnAnteriorPag.Location = new System.Drawing.Point(368, 503);
            this.btnAnteriorPag.Name = "btnAnteriorPag";
            this.btnAnteriorPag.Size = new System.Drawing.Size(19, 23);
            this.btnAnteriorPag.TabIndex = 15;
            this.btnAnteriorPag.Text = "<";
            this.btnAnteriorPag.UseVisualStyleBackColor = true;
            // 
            // Publicaciones_Datagrid
            // 
            this.Publicaciones_Datagrid.AllowUserToAddRows = false;
            this.Publicaciones_Datagrid.AllowUserToDeleteRows = false;
            this.Publicaciones_Datagrid.AllowUserToResizeColumns = false;
            this.Publicaciones_Datagrid.AllowUserToResizeRows = false;
            this.Publicaciones_Datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Publicaciones_Datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Publicaciones_Datagrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Publicaciones_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Publicaciones_Datagrid.Location = new System.Drawing.Point(12, 96);
            this.Publicaciones_Datagrid.MultiSelect = false;
            this.Publicaciones_Datagrid.Name = "Publicaciones_Datagrid";
            this.Publicaciones_Datagrid.ReadOnly = true;
            this.Publicaciones_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Publicaciones_Datagrid.Size = new System.Drawing.Size(853, 380);
            this.Publicaciones_Datagrid.TabIndex = 13;
            // 
            // ComprarOfertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 546);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirPublicacion);
            this.Controls.Add(this.btnUltimaPag);
            this.Controls.Add(this.btnPrimerPag);
            this.Controls.Add(this.btnSiguientePag);
            this.Controls.Add(this.btnAnteriorPag);
            this.Controls.Add(this.Publicaciones_Datagrid);
            this.Name = "ComprarOfertar";
            this.Text = "ComprarOfertar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Publicaciones_Datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRubros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBorrarDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarRubros;
        private System.Windows.Forms.Button btnAbrirPublicacion;
        private System.Windows.Forms.Button btnUltimaPag;
        private System.Windows.Forms.Button btnPrimerPag;
        private System.Windows.Forms.Button btnSiguientePag;
        private System.Windows.Forms.Button btnAnteriorPag;
        private System.Windows.Forms.DataGridView Publicaciones_Datagrid;
    }
}