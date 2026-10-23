using ModuloUsuarios;
using System.Reflection;

namespace Modulo_Ventas
{
    public partial class frmVentas : Form
    {
        private readonly string pathVentas = @"C:\Users\junio\Downloads\Proyecto final EsenciaStockPro\Modulo Ventas\datos.txt";
        private readonly string pathProductos = @"C:\Users\junio\Downloads\Proyecto final EsenciaStockPro\ModuloInventario\productos.txt";

        public frmVentas()
        {
            InitializeComponent();
        }


        private readonly Dictionary<string, decimal> precios = new();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            dgvVentas.Columns.Add("Numero", "N°");
            dgvVentas.Columns.Add("Fecha", "Fecha");
            dgvVentas.Columns.Add("Cliente", "Cliente");
            dgvVentas.Columns.Add("Producto", "Producto");
            dgvVentas.Columns.Add("Cantidad", "Cant.");
            dgvVentas.Columns.Add("Metodo", "Método");
            dgvVentas.Columns.Add("Total", "Total");

            CargarProductos();
            CargarVentas();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || cmbProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Escribe el cliente y selecciona un producto.");
                return;
            }

            // 1. Verificar que haya stock suficiente
            int cantidadVendida = (int)nudCantidad.Value;
            int disponible = StockDisponible(cmbProducto.Text);

            if (disponible < 0)
            {
                MessageBox.Show("No se encontró el producto en el inventario.");
                return;
            }
            if (disponible == 0)
            {
                MessageBox.Show("Este producto está agotado.");
                return;
            }
            if (cantidadVendida > disponible)
            {
                MessageBox.Show($"Solo hay {disponible} unidades disponibles.");
                return;
            }

            // 2. Registrar la venta (igual que antes)
            string numero = (dgvVentas.Rows.Count + 1).ToString();
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            string cliente = txtCliente.Text.Trim().Replace(";", ",");
            string producto = cmbProducto.Text;
            string cantidad = nudCantidad.Value.ToString();
            string metodo = rbEfectivo.Checked ? "Efectivo"
                          : rbTarjeta.Checked ? "Tarjeta" : "Transferencia";
            string total = CalcularTotal().ToString("N2");

            dgvVentas.Rows.Add(numero, fecha, cliente, producto, cantidad, metodo, total);

            File.AppendAllText(pathVentas,
                $"{numero};{fecha};{cliente};{producto};{cantidad};{metodo};{total}{Environment.NewLine}");

            // 3. Descontar del inventario
            DescontarStock(producto, cantidadVendida);

            ActualizarResumen();
            LimpiarCampos();

            // 4. Alerta de stock bajo o agotado
            int restante = disponible - cantidadVendida;

            if (restante == 0)
            {
                MessageBox.Show($"¡Atención! \"{producto}\" quedó agotado.",
                    "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (restante < StockMinimo)
            {
                MessageBox.Show($"Stock bajo: de \"{producto}\" quedan solo {restante} unidades.",
                    "Stock bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarProductos();
            CargarVentas();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null &&
    precios.TryGetValue(cmbProducto.SelectedItem.ToString(), out decimal p))
            {
                txtPrecio.Text = p.ToString();
            }
            CalcularTotal();
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void CargarProductos()
        {
            cmbProducto.Items.Clear();
            precios.Clear();

            if (!File.Exists(pathProductos))
            {
                MessageBox.Show("No se encontró el archivo de productos del inventario.");
                return;
            }

            foreach (string linea in File.ReadAllLines(pathProductos))
            {
                string[] d = linea.Split(';');
                if (d.Length < 4) continue;
                if (!decimal.TryParse(d[3], out decimal precio)) continue;

                if (!precios.ContainsKey(d[1]))
                {
                    cmbProducto.Items.Add(d[1]);
                    precios[d[1]] = precio;
                }
            }
        }

        private void CargarVentas()
        {
            dgvVentas.Rows.Clear();

            if (File.Exists(pathVentas))
            {
                foreach (string linea in File.ReadAllLines(pathVentas))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    string[] d = linea.Split(';');
                    if (d.Length < 7) continue;

                    dgvVentas.Rows.Add(d[0], d[1], d[2], d[3], d[4], d[5], d[6]);
                }
            }

            ActualizarResumen();
        }

        private decimal CalcularTotal()
        {
            decimal.TryParse(txtPrecio.Text, out decimal precio);
            decimal total = precio * nudCantidad.Value;
            lblTotal.Text = "C$ " + total.ToString("N2");
            return total;
        }

        private void ActualizarResumen()
        {
            string hoy = DateTime.Now.ToString("dd/MM/yyyy");
            int ventasHoy = 0;
            decimal totalDia = 0;

            foreach (DataGridViewRow fila in dgvVentas.Rows)
            {
                if (fila.Cells["Fecha"].Value?.ToString() != hoy) continue;

                ventasHoy++;
                if (decimal.TryParse(fila.Cells["Total"].Value?.ToString(), out decimal t))
                    totalDia += t;
            }

            lblVentasHoy.Text = ventasHoy.ToString();
            lblTotalDia.Text = "C$ " + totalDia.ToString("N2");
        }

        private void LimpiarCampos()
        {
            txtCliente.Clear();
            cmbProducto.SelectedIndex = -1;
            txtPrecio.Clear();
            nudCantidad.Value = 1;
            rbEfectivo.Checked = true;
            lblTotal.Text = "C$ 0.00";
            txtCliente.Focus();
        }
        private const int StockMinimo = 10;

        // Devuelve cuántas unidades hay de un producto (o -1 si no existe)
        private int StockDisponible(string nombre)
        {
            if (!File.Exists(pathProductos)) return -1;

            foreach (string linea in File.ReadAllLines(pathProductos))
            {
                string[] d = linea.Split(';');
                if (d.Length < 4) continue;

                if (d[1] == nombre && int.TryParse(d[2], out int stock))
                    return stock;
            }
            return -1;
        }

        // Resta la cantidad vendida en el archivo del inventario
        private void DescontarStock(string nombre, int cantidad)
        {
            string[] lineas = File.ReadAllLines(pathProductos);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] d = lineas[i].Split(';');
                if (d.Length < 4 || d[1] != nombre) continue;
                if (!int.TryParse(d[2], out int stock)) continue;

                d[2] = (stock - cantidad).ToString();   // d[2] = cantidad en stock
                lineas[i] = string.Join(";", d);
                break;
            }

            File.WriteAllLines(pathProductos, lineas);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.FormClosed += (s, args) => this.Show();
            ventas.Show();
            this.Hide();

            frmUsuarios usuarios = new frmUsuarios();
            usuarios.FormClosed += (s, args) => this.Show();
            usuarios.Show();
            this.Hide();
        }
    }
}
