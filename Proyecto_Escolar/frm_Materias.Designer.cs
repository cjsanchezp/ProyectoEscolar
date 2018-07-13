namespace Proyecto_Escolar
{
    partial class frm_Materias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(62, 51);
            this.txtMateria.MaxLength = 40;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(295, 20);
            this.txtMateria.TabIndex = 1;
            this.txtMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMateria_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 90);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(152, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(279, 90);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvMateria
            // 
            this.dgvMateria.AllowUserToAddRows = false;
            this.dgvMateria.AllowUserToDeleteRows = false;
            this.dgvMateria.AllowUserToResizeColumns = false;
            this.dgvMateria.AllowUserToResizeRows = false;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(16, 129);
            this.dgvMateria.MultiSelect = false;
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.ReadOnly = true;
            this.dgvMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateria.Size = new System.Drawing.Size(338, 188);
            this.dgvMateria.TabIndex = 5;
            this.dgvMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(62, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 20);
            this.txtId.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.label1);
            this.Name = "frm_Materias";
            this.Text = "Altas/Bajas/Cambio de Materia";
            this.Load += new System.EventHandler(this.frm_Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}