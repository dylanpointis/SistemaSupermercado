namespace TP_Integrador
{
    partial class frmInfoEnvio
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDirección = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOpcion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCorreo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(95, 241);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(74, 46);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(121, 20);
            this.txtLocalidad.TabIndex = 2;
            // 
            // txtDirección
            // 
            this.txtDirección.Location = new System.Drawing.Point(75, 191);
            this.txtDirección.Name = "txtDirección";
            this.txtDirección.Size = new System.Drawing.Size(120, 20);
            this.txtDirección.TabIndex = 4;
            this.txtDirección.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección";
            this.label2.Visible = false;
            // 
            // cmbOpcion
            // 
            this.cmbOpcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcion.FormattingEnabled = true;
            this.cmbOpcion.Items.AddRange(new object[] {
            "Envío a domicilio",
            "Envío a sucursal del Correo"});
            this.cmbOpcion.Location = new System.Drawing.Point(74, 99);
            this.cmbOpcion.Name = "cmbOpcion";
            this.cmbOpcion.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcion.TabIndex = 5;
            this.cmbOpcion.SelectedIndexChanged += new System.EventHandler(this.cmbOpcion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opción de envío";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sucursal del correo";
            this.label4.Visible = false;
            // 
            // cmbCorreo
            // 
            this.cmbCorreo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorreo.FormattingEnabled = true;
            this.cmbCorreo.Items.AddRange(new object[] {
            "Sucursal OCA",
            "Sucursal Correo Argentino"});
            this.cmbCorreo.Location = new System.Drawing.Point(74, 142);
            this.cmbCorreo.Name = "cmbCorreo";
            this.cmbCorreo.Size = new System.Drawing.Size(121, 21);
            this.cmbCorreo.TabIndex = 7;
            this.cmbCorreo.Visible = false;
            // 
            // frmInfoEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOpcion);
            this.Controls.Add(this.txtDirección);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmInfoEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInfoEnvio";
            this.Load += new System.EventHandler(this.frmInfoEnvio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDirección;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOpcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCorreo;
    }
}