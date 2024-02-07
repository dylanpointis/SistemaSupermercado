
namespace TP_Integrador
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.btnReclamos = new System.Windows.Forms.Button();
            this.btnAdministrarUsuarios = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProgramarEnvios = new System.Windows.Forms.Button();
            this.btnVerEnvio = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 54);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sistema supermercado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(762, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "lblUsuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnVerPedidos);
            this.panel2.Controls.Add(this.btnDescuentos);
            this.panel2.Controls.Add(this.btnConsultarVentas);
            this.panel2.Controls.Add(this.btnReclamos);
            this.panel2.Controls.Add(this.btnAdministrarUsuarios);
            this.panel2.Controls.Add(this.btnProveedores);
            this.panel2.Controls.Add(this.btnProductos);
            this.panel2.Controls.Add(this.btnProgramarEnvios);
            this.panel2.Controls.Add(this.btnVerEnvio);
            this.panel2.Controls.Add(this.btnComprar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1134, 106);
            this.panel2.TabIndex = 0;
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDescuentos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuentos.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuentos.Image")));
            this.btnDescuentos.Location = new System.Drawing.Point(822, 0);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(122, 106);
            this.btnDescuentos.TabIndex = 13;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDescuentos.UseVisualStyleBackColor = true;
            this.btnDescuentos.Visible = false;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultarVentas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarVentas.Image")));
            this.btnConsultarVentas.Location = new System.Drawing.Point(700, 0);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(122, 106);
            this.btnConsultarVentas.TabIndex = 12;
            this.btnConsultarVentas.Text = "Consultar ventas";
            this.btnConsultarVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarVentas.UseVisualStyleBackColor = true;
            this.btnConsultarVentas.Visible = false;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // btnReclamos
            // 
            this.btnReclamos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReclamos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReclamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReclamos.Image = ((System.Drawing.Image)(resources.GetObject("btnReclamos.Image")));
            this.btnReclamos.Location = new System.Drawing.Point(600, 0);
            this.btnReclamos.Name = "btnReclamos";
            this.btnReclamos.Size = new System.Drawing.Size(100, 106);
            this.btnReclamos.TabIndex = 11;
            this.btnReclamos.Text = "Reclamos";
            this.btnReclamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReclamos.UseVisualStyleBackColor = true;
            this.btnReclamos.Visible = false;
            this.btnReclamos.Click += new System.EventHandler(this.btnReclamos_Click_1);
            // 
            // btnAdministrarUsuarios
            // 
            this.btnAdministrarUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdministrarUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdministrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrarUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnAdministrarUsuarios.Image")));
            this.btnAdministrarUsuarios.Location = new System.Drawing.Point(500, 0);
            this.btnAdministrarUsuarios.Name = "btnAdministrarUsuarios";
            this.btnAdministrarUsuarios.Size = new System.Drawing.Size(100, 106);
            this.btnAdministrarUsuarios.TabIndex = 10;
            this.btnAdministrarUsuarios.Text = "Usuarios";
            this.btnAdministrarUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdministrarUsuarios.UseVisualStyleBackColor = true;
            this.btnAdministrarUsuarios.Visible = false;
            this.btnAdministrarUsuarios.Click += new System.EventHandler(this.btnAdministrarUsuarios_Click_1);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(400, 0);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(100, 106);
            this.btnProveedores.TabIndex = 9;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Visible = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(300, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(100, 106);
            this.btnProductos.TabIndex = 8;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Visible = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnProgramarEnvios
            // 
            this.btnProgramarEnvios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProgramarEnvios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProgramarEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProgramarEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramarEnvios.Image = ((System.Drawing.Image)(resources.GetObject("btnProgramarEnvios.Image")));
            this.btnProgramarEnvios.Location = new System.Drawing.Point(200, 0);
            this.btnProgramarEnvios.Name = "btnProgramarEnvios";
            this.btnProgramarEnvios.Size = new System.Drawing.Size(100, 106);
            this.btnProgramarEnvios.TabIndex = 7;
            this.btnProgramarEnvios.Text = "Programar envíos";
            this.btnProgramarEnvios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProgramarEnvios.UseVisualStyleBackColor = true;
            this.btnProgramarEnvios.Visible = false;
            this.btnProgramarEnvios.Click += new System.EventHandler(this.btnProgramarEnvios_Click_1);
            // 
            // btnVerEnvio
            // 
            this.btnVerEnvio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerEnvio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEnvio.Image = ((System.Drawing.Image)(resources.GetObject("btnVerEnvio.Image")));
            this.btnVerEnvio.Location = new System.Drawing.Point(100, 0);
            this.btnVerEnvio.Name = "btnVerEnvio";
            this.btnVerEnvio.Size = new System.Drawing.Size(100, 106);
            this.btnVerEnvio.TabIndex = 2;
            this.btnVerEnvio.Text = "Ver envio";
            this.btnVerEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerEnvio.UseVisualStyleBackColor = true;
            this.btnVerEnvio.Visible = false;
            this.btnVerEnvio.Click += new System.EventHandler(this.btnVerEnvio_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnComprar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprar.Image")));
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnComprar.Location = new System.Drawing.Point(0, 0);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(100, 106);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Visible = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click_1);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerPedidos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnVerPedidos.Image")));
            this.btnVerPedidos.Location = new System.Drawing.Point(944, 0);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(122, 106);
            this.btnVerPedidos.TabIndex = 14;
            this.btnVerPedidos.Text = "Ver pedidos";
            this.btnVerPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Visible = false;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProgramarEnvios;
        private System.Windows.Forms.Button btnVerEnvio;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnConsultarVentas;
        private System.Windows.Forms.Button btnReclamos;
        private System.Windows.Forms.Button btnAdministrarUsuarios;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Button btnVerPedidos;
    }
}