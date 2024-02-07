namespace TP_Integrador
{
    partial class frmEnvios
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
            this.grillaEnvios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaEnvios
            // 
            this.grillaEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEnvios.Location = new System.Drawing.Point(44, 73);
            this.grillaEnvios.Name = "grillaEnvios";
            this.grillaEnvios.Size = new System.Drawing.Size(933, 289);
            this.grillaEnvios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Envios de: ";
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.Firebrick;
            this.btnDarDeBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.White;
            this.btnDarDeBaja.Location = new System.Drawing.Point(44, 383);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(92, 24);
            this.btnDarDeBaja.TabIndex = 10;
            this.btnDarDeBaja.Text = "Dar de baja";
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 470);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaEnvios);
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEnvios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaEnvios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDarDeBaja;
    }
}