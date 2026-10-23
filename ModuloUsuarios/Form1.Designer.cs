namespace ModuloUsuarios
{
    partial class frmUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            pnlLista = new Panel();
            btnEliminarUsuario = new Button();
            btnLimpiar = new Button();
            txtBuscarUsuario = new TextBox();
            lblBuscar = new Label();
            dgvUsuarios = new DataGridView();
            lblTituloLista = new Label();
            panel1 = new Panel();
            txtContraseñaUsuario = new TextBox();
            lblContraseñaUsuario = new Label();
            btnCargarUsuarios = new Button();
            btnGuardarUsuario = new Button();
            txtEstadoUsuario = new TextBox();
            txtRolUsuario = new TextBox();
            txtUsuario = new TextBox();
            txtCodigoUsuario = new TextBox();
            lblEstadoUsuario = new Label();
            lblRolUsuario = new Label();
            lblUsuario = new Label();
            lblCodigoUsuario = new Label();
            label1 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnInventario = new ToolStripButton();
            btnVentas = new ToolStripButton();
            btnUsuarios = new ToolStripButton();
            btnCerrarSesión = new ToolStripButton();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLista
            // 
            pnlLista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLista.BackColor = Color.FromArgb(255, 247, 249);
            pnlLista.BorderStyle = BorderStyle.FixedSingle;
            pnlLista.Controls.Add(btnEliminarUsuario);
            pnlLista.Controls.Add(btnLimpiar);
            pnlLista.Controls.Add(txtBuscarUsuario);
            pnlLista.Controls.Add(lblBuscar);
            pnlLista.Controls.Add(dgvUsuarios);
            pnlLista.Controls.Add(lblTituloLista);
            pnlLista.Location = new Point(335, 86);
            pnlLista.Margin = new Padding(3, 4, 3, 4);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(376, 429);
            pnlLista.TabIndex = 7;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.FromArgb(255, 192, 192);
            btnEliminarUsuario.Location = new Point(104, 392);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(159, 31);
            btnEliminarUsuario.TabIndex = 12;
            btnEliminarUsuario.Text = "Eliminar Usuarios";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
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
            // txtBuscarUsuario
            // 
            txtBuscarUsuario.Location = new Point(122, 68);
            txtBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarUsuario.Name = "txtBuscarUsuario";
            txtBuscarUsuario.Size = new Size(114, 27);
            txtBuscarUsuario.TabIndex = 3;
            txtBuscarUsuario.TextChanged += txtBuscarUsuario_TextChanged;
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
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 227, 234);
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(255, 247, 249);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(138, 31, 74);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(74, 29, 51);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 143, 168);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(74, 29, 51);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(241, 205, 217);
            dgvUsuarios.Location = new Point(65, 125);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(277, 234);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // lblTituloLista
            // 
            lblTituloLista.AutoSize = true;
            lblTituloLista.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloLista.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloLista.Location = new Point(75, 5);
            lblTituloLista.Name = "lblTituloLista";
            lblTituloLista.Size = new Size(244, 31);
            lblTituloLista.TabIndex = 0;
            lblTituloLista.Text = "Usuarios Registrados ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 247, 249);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtContraseñaUsuario);
            panel1.Controls.Add(lblContraseñaUsuario);
            panel1.Controls.Add(btnCargarUsuarios);
            panel1.Controls.Add(btnGuardarUsuario);
            panel1.Controls.Add(txtEstadoUsuario);
            panel1.Controls.Add(txtRolUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtCodigoUsuario);
            panel1.Controls.Add(lblEstadoUsuario);
            panel1.Controls.Add(lblRolUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblCodigoUsuario);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(8, 86);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 429);
            panel1.TabIndex = 6;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Location = new Point(17, 352);
            txtContraseñaUsuario.Margin = new Padding(3, 4, 3, 4);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.Size = new Size(259, 27);
            txtContraseñaUsuario.TabIndex = 12;
            // 
            // lblContraseñaUsuario
            // 
            lblContraseñaUsuario.AutoSize = true;
            lblContraseñaUsuario.Location = new Point(17, 324);
            lblContraseñaUsuario.Name = "lblContraseñaUsuario";
            lblContraseñaUsuario.Size = new Size(83, 20);
            lblContraseñaUsuario.TabIndex = 11;
            lblContraseñaUsuario.Text = "Contraseña";
            // 
            // btnCargarUsuarios
            // 
            btnCargarUsuarios.BackColor = Color.FromArgb(255, 192, 192);
            btnCargarUsuarios.Location = new Point(172, 391);
            btnCargarUsuarios.Margin = new Padding(3, 4, 3, 4);
            btnCargarUsuarios.Name = "btnCargarUsuarios";
            btnCargarUsuarios.Size = new Size(86, 31);
            btnCargarUsuarios.TabIndex = 10;
            btnCargarUsuarios.Text = "Cargar";
            btnCargarUsuarios.UseVisualStyleBackColor = false;
            btnCargarUsuarios.Click += btnCargarUsuarios_Click;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.BackColor = Color.FromArgb(255, 192, 192);
            btnGuardarUsuario.Location = new Point(40, 391);
            btnGuardarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(86, 31);
            btnGuardarUsuario.TabIndex = 9;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // txtEstadoUsuario
            // 
            txtEstadoUsuario.Location = new Point(17, 283);
            txtEstadoUsuario.Margin = new Padding(3, 4, 3, 4);
            txtEstadoUsuario.Name = "txtEstadoUsuario";
            txtEstadoUsuario.Size = new Size(259, 27);
            txtEstadoUsuario.TabIndex = 8;
            // 
            // txtRolUsuario
            // 
            txtRolUsuario.Location = new Point(17, 215);
            txtRolUsuario.Margin = new Padding(3, 4, 3, 4);
            txtRolUsuario.Name = "txtRolUsuario";
            txtRolUsuario.Size = new Size(259, 27);
            txtRolUsuario.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(17, 148);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(259, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtCodigoUsuario
            // 
            txtCodigoUsuario.Location = new Point(17, 77);
            txtCodigoUsuario.Margin = new Padding(3, 4, 3, 4);
            txtCodigoUsuario.Name = "txtCodigoUsuario";
            txtCodigoUsuario.Size = new Size(259, 27);
            txtCodigoUsuario.TabIndex = 5;
            // 
            // lblEstadoUsuario
            // 
            lblEstadoUsuario.AutoSize = true;
            lblEstadoUsuario.Location = new Point(17, 259);
            lblEstadoUsuario.Name = "lblEstadoUsuario";
            lblEstadoUsuario.Size = new Size(58, 20);
            lblEstadoUsuario.TabIndex = 4;
            lblEstadoUsuario.Text = "Estado ";
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Location = new Point(17, 191);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(31, 20);
            lblRolUsuario.TabIndex = 3;
            lblRolUsuario.Text = "Rol";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(17, 125);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // lblCodigoUsuario
            // 
            lblCodigoUsuario.AutoSize = true;
            lblCodigoUsuario.Location = new Point(17, 48);
            lblCodigoUsuario.Name = "lblCodigoUsuario";
            lblCodigoUsuario.Size = new Size(131, 20);
            lblCodigoUsuario.TabIndex = 1;
            lblCodigoUsuario.Text = "Código de usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 5);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 0;
            label1.Text = "Añadir Usuarios";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnInventario, btnVentas, btnUsuarios, btnCerrarSesión });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(719, 28);
            toolStrip1.TabIndex = 8;
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
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 600);
            Controls.Add(toolStrip1);
            Controls.Add(pnlLista);
            Controls.Add(panel1);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmUsuarios_Load;
            pnlLista.ResumeLayout(false);
            pnlLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLista;
        private Button btnAgregarStock;
        private Button btnEliminarUsuario;
        private Button btnLimpiar;
        private TextBox txtBuscarUsuario;
        private Label lblBuscar;
        private DataGridView dgvUsuarios;
        private Label lblTituloLista;
        private Panel panel1;
        private Button btnCargarUsuarios;
        private Button btnGuardarUsuario;
        private TextBox txtEstadoUsuario;
        private TextBox txtRolUsuario;
        private TextBox txtUsuario;
        private TextBox txtCodigoUsuario;
        private Label lblEstadoUsuario;
        private Label lblRolUsuario;
        private Label lblUsuario;
        private Label lblCodigoUsuario;
        private Label label1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnInventario;
        private ToolStripButton btnVentas;
        private ToolStripButton btnUsuarios;
        private ToolStripButton btnCerrarSesión;
        private TextBox txtContraseñaUsuario;
        private Label lblContraseñaUsuario;
    }
}
