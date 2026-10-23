using System.Collections;
using System.Drawing.Drawing2D;

namespace Fraiche_Jinotepe
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            RedondearPanel(pnlLogin, 14);
            pnlLogin.Resize += (s, e) => RedondearPanel(pnlLogin, 14);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El usuario está vacío, es necesario que lo ingreses.",
                    "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (usuario.All(char.IsDigit))
            {
                MessageBox.Show("El usuario no puede ser numérico, debe contener letras.",
                    "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("La contraseña está vacía, es necesario que la ingreses.",
                    "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña.Focus();
                return;
            }

            if (!int.TryParse(txtContraseña.Text.Trim(), out int contraseña))
            {
                MessageBox.Show("La contraseña es incorrecta.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            if (contraseña != 010203)
            {
                MessageBox.Show("La contraseña es incorrecta.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
                return;
            }

            Stock.Stock frmStock = new Stock.Stock();
            frmStock.FormClosed += (s, args) => this.Close();
            frmStock.Show();
            this.Hide();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RedondearPanel(Panel panel, int radio)
        {
            int d = radio * 2;
            var ruta = new GraphicsPath();
            ruta.AddArc(0, 0, d, d, 180, 90);
            ruta.AddArc(panel.Width - d, 0, d, d, 270, 90);
            ruta.AddArc(panel.Width - d, panel.Height - d, d, d, 0, 90);
            ruta.AddArc(0, panel.Height - d, d, d, 90, 90);
            ruta.CloseFigure();
            panel.Region = new Region(ruta);
        }
    }
}
