
namespace TP_Integrador
{
    partial class frmIniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesion));
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnOcultarClave = new System.Windows.Forms.Button();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.btnMostrarCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(85, 134);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(100, 23);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(85, 45);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(85, 90);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarse.Location = new System.Drawing.Point(85, 163);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnOcultarClave
            // 
            this.btnOcultarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcultarClave.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultarClave.Image")));
            this.btnOcultarClave.Location = new System.Drawing.Point(54, 83);
            this.btnOcultarClave.Name = "btnOcultarClave";
            this.btnOcultarClave.Size = new System.Drawing.Size(25, 27);
            this.btnOcultarClave.TabIndex = 15;
            this.btnOcultarClave.UseVisualStyleBackColor = true;
            this.btnOcultarClave.Click += new System.EventHandler(this.btnOcultarClave_Click);
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClave.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarClave.Image")));
            this.btnMostrarClave.Location = new System.Drawing.Point(54, 83);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(25, 27);
            this.btnMostrarClave.TabIndex = 16;
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            this.btnMostrarClave.Click += new System.EventHandler(this.btnMostrarClave_Click);
            // 
            // btnMostrarCuentas
            // 
            this.btnMostrarCuentas.Location = new System.Drawing.Point(85, 230);
            this.btnMostrarCuentas.Name = "btnMostrarCuentas";
            this.btnMostrarCuentas.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarCuentas.TabIndex = 17;
            this.btnMostrarCuentas.Text = "Mostrar cuentas";
            this.btnMostrarCuentas.UseVisualStyleBackColor = true;
            this.btnMostrarCuentas.Click += new System.EventHandler(this.btnMostrarCuentas_Click);
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 265);
            this.Controls.Add(this.btnMostrarCuentas);
            this.Controls.Add(this.btnMostrarClave);
            this.Controls.Add(this.btnOcultarClave);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 304);
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnOcultarClave;
        private System.Windows.Forms.Button btnMostrarClave;
        private System.Windows.Forms.Button btnMostrarCuentas;
    }
}

