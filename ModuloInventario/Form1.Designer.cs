namespace ModuloInventario
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnCargar = new Button();
            btnGuardar = new Button();
            txtPrecioProducto = new TextBox();
            txtCantidadProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEliminar = new Button();
            btnAgregarStock = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnInventario = new ToolStripButton();
            btnVentas = new ToolStripButton();
            btnUsuarios = new ToolStripButton();
            btnCerrarSesión = new ToolStripButton();
            pnlLista = new Panel();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            dgvProductos = new DataGridView();
            lblTituloLista = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 247, 249);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 113);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(376, 429);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 249);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCargar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(txtPrecioProducto);
            panel1.Controls.Add(txtCantidadProducto);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(txtCodigoProducto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 429);
            panel1.TabIndex = 3;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(177, 333);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(86, 31);
            btnCargar.TabIndex = 10;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(39, 333);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(17, 283);
            txtPrecioProducto.Margin = new Padding(3, 4, 3, 4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(259, 27);
            txtPrecioProducto.TabIndex = 8;
            txtPrecioProducto.TextChanged += textBox4_TextChanged;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(17, 215);
            txtCantidadProducto.Margin = new Padding(3, 4, 3, 4);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(259, 27);
            txtCantidadProducto.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(17, 148);
            txtNombreProducto.Margin = new Padding(3, 4, 3, 4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(259, 27);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(17, 77);
            txtCodigoProducto.Margin = new Padding(3, 4, 3, 4);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(259, 27);
            txtCodigoProducto.TabIndex = 5;
            txtCodigoProducto.TextChanged += txtCodigoProducto_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 259);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 191);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 125);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 48);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 5);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos del producto";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(217, 387);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(86, 387);
            btnAgregarStock.Margin = new Padding(3, 4, 3, 4);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(103, 31);
            btnAgregarStock.TabIndex = 11;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnInventario, btnVentas, btnUsuarios, btnCerrarSesión });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(719, 28);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            toolStripLabel1.ForeColor = Color.FromArgb(255, 128, 128);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(152, 25);
            toolStripLabel1.Text = "EsenciaStockPro";
            toolStripLabel1.Click += toolStripLabel1_Click;
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
            btnInventario.Click += btnInventario_Click;
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
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.BackColor = Color.FromArgb(255, 247, 249);
            pnlLista.BorderStyle = BorderStyle.FixedSingle;
            pnlLista.Controls.Add(btnAgregarStock);
            pnlLista.Controls.Add(btnEliminar);
            pnlLista.Controls.Add(btnLimpiar);
            pnlLista.Controls.Add(txtBuscar);
            pnlLista.Controls.Add(lblBuscar);
            pnlLista.Controls.Add(dgvProductos);
            pnlLista.Controls.Add(lblTituloLista);
            pnlLista.Location = new Point(329, 113);
            pnlLista.Margin = new Padding(3, 4, 3, 4);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(376, 429);
            pnlLista.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(255, 192, 192);
            btnLimpiar.Location = new Point(243, 68);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(127, 31);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar busqueda";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(122, 68);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(114, 27);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(65, 73);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(59, 20);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar :";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 227, 234);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(255, 247, 249);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(138, 31, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(74, 29, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 143, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(74, 29, 51);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(241, 205, 217);
            dgvProductos.Location = new Point(47, 113);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(274, 200);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.CellFormatting += dgvProductos_CellFormatting;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloLista.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloLista.Location = new Point(75, 5);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(249, 32);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Productos Registrados";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(719, 600);
            Controls.Add(pnlLista);
            Controls.Add(toolStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pestaña de Intentario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlLista.ResumeLayout(false);
            pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtPrecioProducto;
        private TextBox txtCantidadProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private Button btnCargar;
        private Button btnGuardar;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnInventario;
        private ToolStripButton btnVentas;
        private ToolStripButton btnUsuarios;
        private ToolStripButton btnCerrarSesión;
        private Panel pnlLista;
        private Label lblTituloLista;
        private DataGridView dgvProductos;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregarStock;
    }
}
