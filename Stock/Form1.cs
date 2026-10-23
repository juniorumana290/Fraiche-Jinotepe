using Modulo_Ventas;
using System.Drawing.Drawing2D;
namespace Stock
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
            RedondearPanel(pnlBienvenida, 14);
            pnlBienvenida.Resize += (s, e) => RedondearPanel(pnlBienvenida, 14);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            ModuloInventario.Inventario inventario = new ModuloInventario.Inventario();

            inventario.FormClosed += (s, args) => this.Show();

            inventario.Show();
            this.Hide();
        }

        private void pnlBienvenida_Paint(object sender, PaintEventArgs e)
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

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click_1(object sender, EventArgs e)
        {
            ModuloInventario.Inventario inventario = new ModuloInventario.Inventario();

            inventario.FormClosed += (s, args) => this.Show();

            inventario.Show();
            this.Hide();
        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.FormClosed += (s, args) => this.Show();
            ventas.Show();
            this.Hide();
        }
    }
}
