namespace TP_Integrador.Forms
{
    partial class frmVerPedidos
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
            this.grillaPedidos = new System.Windows.Forms.DataGridView();
            this.grillaPedido_Producto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedido_Producto)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaPedidos
            // 
            this.grillaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPedidos.Location = new System.Drawing.Point(63, 67);
            this.grillaPedidos.Name = "grillaPedidos";
            this.grillaPedidos.Size = new System.Drawing.Size(551, 316);
            this.grillaPedidos.TabIndex = 0;
            this.grillaPedidos.SelectionChanged += new System.EventHandler(this.grillaPedidos_SelectionChanged);
            // 
            // grillaPedido_Producto
            // 
            this.grillaPedido_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaPedido_Producto.Location = new System.Drawing.Point(696, 67);
            this.grillaPedido_Producto.Name = "grillaPedido_Producto";
            this.grillaPedido_Producto.Size = new System.Drawing.Size(351, 316);
            this.grillaPedido_Producto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pedidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Productos comprados";
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grillaPedido_Producto);
            this.Controls.Add(this.grillaPedidos);
            this.Name = "frmVerPedidos";
            this.Text = "frmVerPedidos";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaPedido_Producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaPedidos;
        private System.Windows.Forms.DataGridView grillaPedido_Producto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}