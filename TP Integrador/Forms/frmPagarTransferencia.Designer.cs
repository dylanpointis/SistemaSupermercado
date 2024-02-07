namespace TP_Integrador
{
    partial class frmPagarTransferencia
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
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoloNumero1 = new TP_Integrador.ControlesUsuario.textBoxSoloNumero();
            this.textBoxSoloTexto1 = new TP_Integrador.ControlesUsuario.textBoxSoloTexto();
            this.SuspendLayout();
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(120, 40);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(69, 20);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto: ";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(114, 326);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 19;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Numero de cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "CBU: ";
            // 
            // textBoxSoloNumero1
            // 
            this.textBoxSoloNumero1.Location = new System.Drawing.Point(77, 210);
            this.textBoxSoloNumero1.Name = "textBoxSoloNumero1";
            this.textBoxSoloNumero1.Size = new System.Drawing.Size(182, 24);
            this.textBoxSoloNumero1.TabIndex = 25;
            // 
            // textBoxSoloTexto1
            // 
            this.textBoxSoloTexto1.Location = new System.Drawing.Point(77, 152);
            this.textBoxSoloTexto1.Name = "textBoxSoloTexto1";
            this.textBoxSoloTexto1.Size = new System.Drawing.Size(179, 24);
            this.textBoxSoloTexto1.TabIndex = 26;
            // 
            // frmPagarTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 407);
            this.Controls.Add(this.textBoxSoloTexto1);
            this.Controls.Add(this.textBoxSoloNumero1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblMonto);
            this.Name = "frmPagarTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagar";
            this.Load += new System.EventHandler(this.frmPagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private ControlesUsuario.textBoxSoloNumero textBoxSoloNumero1;
        private ControlesUsuario.textBoxSoloTexto textBoxSoloTexto1;
    }
}