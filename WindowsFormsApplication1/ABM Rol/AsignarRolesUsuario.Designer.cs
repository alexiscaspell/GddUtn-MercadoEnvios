﻿namespace WindowsFormsApplication1.ABM_Rol
{
    partial class AsignarRolesUsuario
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.usuariosDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(497, 441);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.usuariosDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(584, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Usuarios:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(439, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(137, 28);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Roles";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // usuariosDataGrid
            // 
            this.usuariosDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usuariosDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usuariosDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.usuariosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosDataGrid.Location = new System.Drawing.Point(16, 59);
            this.usuariosDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosDataGrid.MultiSelect = false;
            this.usuariosDataGrid.Name = "usuariosDataGrid";
            this.usuariosDataGrid.ReadOnly = true;
            this.usuariosDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usuariosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuariosDataGrid.Size = new System.Drawing.Size(568, 353);
            this.usuariosDataGrid.TabIndex = 2;
            this.usuariosDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsuariosDataGrid_CellClick);
            this.usuariosDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuariosDataGrid_CellContentClick);
            // 
            // AsignarRolesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 479);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AsignarRolesUsuario";
            this.Text = "AsignarRolesUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AsignarRolesUsuario_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AsignarRolesUsuario_FormClosed);
            this.Load += new System.EventHandler(this.AsignarRolesUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView usuariosDataGrid;
    }
}