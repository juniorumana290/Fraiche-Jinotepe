namespace Fraiche_Jinotepe
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            label1 = new Label();
            btnConfirmar = new Button();
            pnlLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Location = new Point(14, 208);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.IndianRed;
            label3.Location = new Point(14, 249);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            label3.Click += label3_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(255, 224, 192);
            txtContraseña.Location = new Point(129, 246);
            txtContraseña.Margin = new Padding(3, 4, 3, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(114, 27);
            txtContraseña.TabIndex = 4;
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(255, 224, 192);
            txtUsuario.Location = new Point(129, 201);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 149);
            label1.Name = "label1";
            label1.Size = new Size(185, 39);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            label1.Click += label1_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.IndianRed;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.Black;
            btnConfirmar.Location = new Point(86, 347);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(168, 51);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar ";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += button1_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(255, 240, 244);
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Controls.Add(btnConfirmar);
            pnlLogin.Controls.Add(label1);
            pnlLogin.Controls.Add(txtContraseña);
            pnlLogin.Controls.Add(label2);
            pnlLogin.Controls.Add(label3);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Cursor = Cursors.IBeam;
            pnlLogin.Location = new Point(220, 25);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(333, 402);
            pnlLogin.TabIndex = 7;
            pnlLogin.Paint += panel1_Paint;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(597, 453);
            Controls.Add(pnlLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label label1;
        private Button btnConfirmar;
        private Panel pnlLogin;
    }
}
