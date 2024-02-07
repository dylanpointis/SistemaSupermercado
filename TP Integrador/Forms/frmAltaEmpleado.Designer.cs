namespace TP_Integrador.Forms
{
    partial class frmAltaEmpleado
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSueldoEmp = new System.Windows.Forms.TextBox();
            this.txtRolEmp = new System.Windows.Forms.TextBox();
            this.txtHorarioEmp = new System.Windows.Forms.TextBox();
            this.txtApellidoEmp = new System.Windows.Forms.TextBox();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Rol empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(85, 359);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSueldoEmp
            // 
            this.txtSueldoEmp.Location = new System.Drawing.Point(73, 307);
            this.txtSueldoEmp.Name = "txtSueldoEmp";
            this.txtSueldoEmp.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoEmp.TabIndex = 15;
            // 
            // txtRolEmp
            // 
            this.txtRolEmp.Location = new System.Drawing.Point(73, 245);
            this.txtRolEmp.Name = "txtRolEmp";
            this.txtRolEmp.Size = new System.Drawing.Size(100, 20);
            this.txtRolEmp.TabIndex = 14;
            // 
            // txtHorarioEmp
            // 
            this.txtHorarioEmp.Location = new System.Drawing.Point(73, 184);
            this.txtHorarioEmp.Name = "txtHorarioEmp";
            this.txtHorarioEmp.Size = new System.Drawing.Size(100, 20);
            this.txtHorarioEmp.TabIndex = 13;
            // 
            // txtApellidoEmp
            // 
            this.txtApellidoEmp.Location = new System.Drawing.Point(73, 123);
            this.txtApellidoEmp.Name = "txtApellidoEmp";
            this.txtApellidoEmp.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEmp.TabIndex = 12;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(73, 62);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 11;
            // 
            // frmAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 397);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtSueldoEmp);
            this.Controls.Add(this.txtRolEmp);
            this.Controls.Add(this.txtHorarioEmp);
            this.Controls.Add(this.txtApellidoEmp);
            this.Controls.Add(this.txtNombreEmp);
            this.Name = "frmAltaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSueldoEmp;
        private System.Windows.Forms.TextBox txtRolEmp;
        private System.Windows.Forms.TextBox txtHorarioEmp;
        private System.Windows.Forms.TextBox txtApellidoEmp;
        private System.Windows.Forms.TextBox txtNombreEmp;
    }
}