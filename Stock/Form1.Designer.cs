namespace Stock
{
    partial class Stock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            pnlBienvenida = new Panel();
            pictureBox1 = new PictureBox();
            lblNombreUsuario = new Label();
            label4 = new Label();
            lblBienvenida = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnInventario = new ToolStripButton();
            btnVentas = new ToolStripButton();
            btnUsuarios = new ToolStripButton();
            btnCerrarSesión = new ToolStripButton();
            pnlBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.Anchor = AnchorStyles.None;
            pnlBienvenida.BackColor = Color.FromArgb(255, 240, 244);
            pnlBienvenida.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBienvenida.BorderStyle = BorderStyle.FixedSingle;
            pnlBienvenida.Controls.Add(pictureBox1);
            pnlBienvenida.Controls.Add(lblNombreUsuario);
            pnlBienvenida.Controls.Add(label4);
            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Location = new Point(105, 37);
            pnlBienvenida.Margin = new Padding(3, 4, 3, 4);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(416, 281);
            pnlBienvenida.TabIndex = 1;
            pnlBienvenida.Paint += pnlBienvenida_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 157);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.FromArgb(255, 128, 128);
            lblNombreUsuario.Location = new Point(159, 51);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(95, 28);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "Shneider!";
            lblNombreUsuario.Click += label1_Click_1;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(92, 58, 73);
            label4.Location = new Point(63, 95);
            label4.Name = "label4";
            label4.Size = new Size(296, 72);
            label4.TabIndex = 3;
            label4.Text = "Gestiona tu inventario y registra los pagos de tus ventas desde un solo lugar.";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Georgia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(74, 29, 51);
            lblBienvenida.Location = new Point(33, 4);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(351, 47);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "¡Bienvenido!";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            lblBienvenida.Click += label2_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnInventario, btnVentas, btnUsuarios, btnCerrarSesión });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(597, 28);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = Color.FromArgb(255, 128, 128);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(152, 25);
            toolStripLabel1.Text = "EsenciaStockPro";
            // 
            // btnInventario
            // 
            btnInventario.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInventario.Image = (Image)resources.GetObject("btnInventario.Image");
            btnInventario.ImageTransparentColor = Color.Magenta;
            btnInventario.Margin = new Padding(10, 1, 0, 2);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(79, 25);
            btnInventario.Text = "Inventario";
            btnInventario.Click += btnInventario_Click_1;
            // 
            // btnVentas
            // 
            btnVentas.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageTransparentColor = Color.Magenta;
            btnVentas.Margin = new Padding(10, 1, 0, 2);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(56, 25);
            btnVentas.Text = "Ventas";
            btnVentas.Click += btnVentas_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUsuarios.Image = (Image)resources.GetObject("btnUsuarios.Image");
            btnUsuarios.ImageTransparentColor = Color.Magenta;
            btnUsuarios.Margin = new Padding(10, 1, 0, 2);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(69, 25);
            btnUsuarios.Text = "Usuarios";
            // 
            // btnCerrarSesión
            // 
            btnCerrarSesión.Alignment = ToolStripItemAlignment.Right;
            btnCerrarSesión.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCerrarSesión.Image = (Image)resources.GetObject("btnCerrarSesión.Image");
            btnCerrarSesión.ImageTransparentColor = Color.Magenta;
            btnCerrarSesión.Name = "btnCerrarSesión";
            btnCerrarSesión.Size = new Size(100, 25);
            btnCerrarSesión.Text = "Cerrar Sesión";
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(597, 453);
            Controls.Add(toolStrip1);
            Controls.Add(pnlBienvenida);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel de Inicio";
            Load += Stock_Load;
            pnlBienvenida.ResumeLayout(false);
            pnlBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlBienvenida;
        private Label label4;
        private Label lblBienvenida;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnInventario;
        private ToolStripButton btnVentas;
        private ToolStripButton btnUsuarios;
        private ToolStripButton btnCerrarSesión;
        private Label lblNombreUsuario;
        private PictureBox pictureBox1;
    }
}
