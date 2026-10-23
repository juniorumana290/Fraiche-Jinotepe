namespace Modulo_Ventas
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnInventario = new ToolStripButton();
            btnVentas = new ToolStripButton();
            btnUsuarios = new ToolStripButton();
            btnCerrarSesión = new ToolStripButton();
            pnlVentas = new Panel();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            pnlTotal = new Panel();
            lblTotal = new Label();
            lblTotalTexto = new Label();
            rbTransferencia = new RadioButton();
            rbTarjeta = new RadioButton();
            rbEfectivo = new RadioButton();
            txtPrecio = new TextBox();
            nudCantidad = new NumericUpDown();
            cmbProducto = new ComboBox();
            txtCliente = new TextBox();
            lblPrecio = new Label();
            lblMetodo = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            lblCliente = new Label();
            lblRegistrarVenta = new Label();
            panel1 = new Panel();
            btnCargar = new Button();
            dgvVentas = new DataGridView();
            pnlCard2 = new Panel();
            lblTotalDia = new Label();
            label2 = new Label();
            pnlCard1 = new Panel();
            lblVentasHoy = new Label();
            label1 = new Label();
            lblTituloLista = new Label();
            toolStrip1.SuspendLayout();
            pnlVentas.SuspendLayout();
            pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            pnlCard2.SuspendLayout();
            pnlCard1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnInventario, btnVentas, btnUsuarios, btnCerrarSesión });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(719, 28);
            toolStrip1.TabIndex = 5;
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
            btnUsuarios.Click += btnUsuarios_Click;
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
            // pnlVentas
            // 
            pnlVentas.BackColor = Color.FromArgb(255, 247, 249);
            pnlVentas.BorderStyle = BorderStyle.FixedSingle;
            pnlVentas.Controls.Add(btnLimpiar);
            pnlVentas.Controls.Add(btnRegistrar);
            pnlVentas.Controls.Add(pnlTotal);
            pnlVentas.Controls.Add(rbTransferencia);
            pnlVentas.Controls.Add(rbTarjeta);
            pnlVentas.Controls.Add(rbEfectivo);
            pnlVentas.Controls.Add(txtPrecio);
            pnlVentas.Controls.Add(nudCantidad);
            pnlVentas.Controls.Add(cmbProducto);
            pnlVentas.Controls.Add(txtCliente);
            pnlVentas.Controls.Add(lblPrecio);
            pnlVentas.Controls.Add(lblMetodo);
            pnlVentas.Controls.Add(lblCantidad);
            pnlVentas.Controls.Add(lblProducto);
            pnlVentas.Controls.Add(lblCliente);
            pnlVentas.Controls.Add(lblRegistrarVenta);
            pnlVentas.Location = new Point(14, 75);
            pnlVentas.Margin = new Padding(3, 4, 3, 4);
            pnlVentas.Name = "pnlVentas";
            pnlVentas.Size = new Size(280, 509);
            pnlVentas.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(158, 453);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 31);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(41, 453);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(109, 31);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar Venta";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.FromArgb(255, 227, 234);
            pnlTotal.BorderStyle = BorderStyle.FixedSingle;
            pnlTotal.Controls.Add(lblTotal);
            pnlTotal.Controls.Add(lblTotalTexto);
            pnlTotal.Location = new Point(41, 383);
            pnlTotal.Margin = new Padding(3, 4, 3, 4);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Size = new Size(231, 53);
            pnlTotal.TabIndex = 13;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(138, 31, 74);
            lblTotal.Location = new Point(131, 16);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "C$ 0.00";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Location = new Point(11, 16);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(97, 20);
            lblTotalTexto.TabIndex = 0;
            lblTotalTexto.Text = "Total a pagar";
            // 
            // rbTransferencia
            // 
            rbTransferencia.AutoSize = true;
            rbTransferencia.Location = new Point(200, 349);
            rbTransferencia.Margin = new Padding(3, 4, 3, 4);
            rbTransferencia.Name = "rbTransferencia";
            rbTransferencia.Size = new Size(72, 24);
            rbTransferencia.TabIndex = 12;
            rbTransferencia.Text = "Transf.";
            rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(125, 349);
            rbTarjeta.Margin = new Padding(3, 4, 3, 4);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(74, 24);
            rbTarjeta.TabIndex = 11;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            rbTarjeta.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Checked = true;
            rbEfectivo.Location = new Point(41, 349);
            rbEfectivo.Margin = new Padding(3, 4, 3, 4);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(83, 24);
            rbEfectivo.TabIndex = 10;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(158, 272);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(75, 27);
            txtPrecio.TabIndex = 9;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(46, 272);
            nudCantidad.Margin = new Padding(3, 4, 3, 4);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(75, 27);
            nudCantidad.TabIndex = 8;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(46, 203);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(183, 28);
            cmbProducto.TabIndex = 7;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(46, 120);
            txtCliente.Margin = new Padding(3, 4, 3, 4);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(183, 27);
            txtCliente.TabIndex = 6;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(158, 247);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(41, 316);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(122, 20);
            lblMetodo.TabIndex = 4;
            lblMetodo.Text = "Método de pago";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(41, 247);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(69, 20);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(41, 176);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(69, 20);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Producto";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(41, 93);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblRegistrarVenta
            // 
            lblRegistrarVenta.AutoSize = true;
            lblRegistrarVenta.Font = new Font("Georgia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistrarVenta.ForeColor = Color.FromArgb(138, 31, 74);
            lblRegistrarVenta.Location = new Point(41, 17);
            lblRegistrarVenta.Name = "lblRegistrarVenta";
            lblRegistrarVenta.Size = new Size(207, 29);
            lblRegistrarVenta.TabIndex = 0;
            lblRegistrarVenta.Text = "Registrar Venta";
            lblRegistrarVenta.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 249);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(dgvVentas);
            panel1.Controls.Add(pnlCard2);
            panel1.Controls.Add(pnlCard1);
            panel1.Controls.Add(lblTituloLista);
            panel1.ForeColor = Color.FromArgb(255, 192, 192);
            panel1.Location = new Point(305, 75);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 509);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.FromArgb(184, 82, 122);
            btnCargar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.FromArgb(255, 247, 249);
            btnCargar.Location = new Point(119, 392);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(155, 45);
            btnCargar.TabIndex = 4;
            btnCargar.Text = "Cargar Ventas";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(255, 247, 249);
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Location = new Point(51, 168);
            dgvVentas.Margin = new Padding(3, 4, 3, 4);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(274, 200);
            dgvVentas.TabIndex = 3;
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.FromArgb(255, 240, 244);
            pnlCard2.BorderStyle = BorderStyle.FixedSingle;
            pnlCard2.Controls.Add(lblTotalDia);
            pnlCard2.Controls.Add(label2);
            pnlCard2.Location = new Point(214, 48);
            pnlCard2.Margin = new Padding(3, 4, 3, 4);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(153, 66);
            pnlCard2.TabIndex = 2;
            // 
            // lblTotalDia
            // 
            lblTotalDia.AutoSize = true;
            lblTotalDia.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDia.ForeColor = Color.FromArgb(138, 31, 74);
            lblTotalDia.Location = new Point(30, 31);
            lblTotalDia.Name = "lblTotalDia";
            lblTotalDia.Size = new Size(66, 23);
            lblTotalDia.TabIndex = 1;
            lblTotalDia.Text = "C$ 0.00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(30, 3);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Total del día";
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.FromArgb(255, 240, 244);
            pnlCard1.BorderStyle = BorderStyle.FixedSingle;
            pnlCard1.Controls.Add(lblVentasHoy);
            pnlCard1.Controls.Add(label1);
            pnlCard1.Location = new Point(42, 48);
            pnlCard1.Margin = new Padding(3, 4, 3, 4);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(153, 66);
            pnlCard1.TabIndex = 1;
            // 
            // lblVentasHoy
            // 
            lblVentasHoy.AutoSize = true;
            lblVentasHoy.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentasHoy.ForeColor = Color.Black;
            lblVentasHoy.Location = new Point(27, 31);
            lblVentasHoy.Name = "lblVentasHoy";
            lblVentasHoy.Size = new Size(20, 23);
            lblVentasHoy.TabIndex = 1;
            lblVentasHoy.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(27, 3);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Ventas de Hoy";
            label1.Click += label1_Click_1;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLista.ForeColor = Color.FromArgb(138, 31, 74);
            lblTituloLista.Location = new Point(42, 19);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(152, 18);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Ventas Registradas";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(719, 600);
            Controls.Add(panel1);
            Controls.Add(pnlVentas);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModuloVentas";
            Load += frmVentas_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlVentas.ResumeLayout(false);
            pnlVentas.PerformLayout();
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            pnlCard2.ResumeLayout(false);
            pnlCard2.PerformLayout();
            pnlCard1.ResumeLayout(false);
            pnlCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnInventario;
        private ToolStripButton btnVentas;
        private ToolStripButton btnUsuarios;
        private ToolStripButton btnCerrarSesión;
        private Panel pnlVentas;
        private Label lblPrecio;
        private Label lblMetodo;
        private Label lblCantidad;
        private Label lblProducto;
        private Label lblCliente;
        private Label lblRegistrarVenta;
        private ComboBox cmbProducto;
        private TextBox txtCliente;
        private TextBox txtPrecio;
        private NumericUpDown nudCantidad;
        private RadioButton rbTransferencia;
        private RadioButton rbTarjeta;
        private RadioButton rbEfectivo;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Panel pnlTotal;
        private Label lblTotal;
        private Label lblTotalTexto;
        private Panel panel1;
        private Panel pnlCard1;
        private Label lblTituloLista;
        private Panel pnlCard2;
        private DataGridView dgvVentas;
        private Button btnCargar;
        private Label lblVentasHoy;
        private Label label1;
        private Label lblTotalDia;
        private Label label2;
    }
}
