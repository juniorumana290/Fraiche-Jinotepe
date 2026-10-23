using Modulo_Ventas;

namespace ModuloInventario
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }
        private readonly string path = @"C:\Users\junio\Downloads\Proyecto final EsenciaStockPro\ModuloInventario\productos.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("Codigo", "Código");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("Precio", "Precio");
        }

        private void FiltrarProductos()
        {
            string texto = txtBuscar.Text.Trim();

            dgvProductos.CurrentCell = null;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                string codigo = fila.Cells["Codigo"].Value?.ToString() ?? "";
                string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";

                fila.Visible = texto == ""
                    || codigo.Contains(texto, StringComparison.OrdinalIgnoreCase)
                    || nombre.Contains(texto, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ||
        string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Completa el código y el nombre.");
                return;
            }
            if (!int.TryParse(txtCantidadProducto.Text, out _) ||
                !decimal.TryParse(txtPrecioProducto.Text, out _))
            {
                MessageBox.Show("Cantidad y precio deben ser números.");
                return;
            }

            string codigo = txtCodigoProducto.Text.Trim();
            string nombre = txtNombreProducto.Text.Trim().Replace(";", ",");
            string cantidad = txtCantidadProducto.Text.Trim();
            string precio = txtPrecioProducto.Text.Trim();

            dgvProductos.Rows.Add(codigo, nombre, cantidad, precio);
            File.AppendAllText(path, $"{codigo};{nombre};{cantidad};{precio}{Environment.NewLine}");

            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtPrecioProducto.Clear();
            txtCodigoProducto.Focus();
            FiltrarProductos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("No se encontró el archivo de productos.");
                return;
            }

            dgvProductos.Rows.Clear();

            foreach (string linea in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(';');
                if (d.Length < 4) continue;

                dgvProductos.Rows.Add(d[0], d[1], d[2], d[3]);
                FiltrarProductos();
            }
            MostrarAlertaStock();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            txtBuscar.Focus();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.FormClosed += (s, args) => this.Show();
            ventas.Show();
            this.Hide();
        }
        private const int StockMinimo = 10;

        // Avisa qué productos tienen menos de 10 unidades
        private void MostrarAlertaStock()
        {
            var bajos = new List<string>();

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out int cantidad)
                    && cantidad < StockMinimo)
                {
                    bajos.Add($"• {fila.Cells["Nombre"].Value}: {cantidad} unidades");
                }
            }

            if (bajos.Count > 0)
            {
                MessageBox.Show(
                    "Productos con stock bajo (menos de 10):" + Environment.NewLine + Environment.NewLine
                    + string.Join(Environment.NewLine, bajos),
                    "Alerta de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProductos.Columns[e.ColumnIndex].Name != "Cantidad") return;

            if (int.TryParse(e.Value?.ToString(), out int cantidad) && cantidad < StockMinimo)
            {
                e.CellStyle.ForeColor = Color.Firebrick;
                e.CellStyle.BackColor = Color.FromArgb(255, 205, 210);
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto de la tabla.");
                return;
            }

            if (!int.TryParse(txtCantidadProducto.Text, out int unidades) || unidades <= 0)
            {
                MessageBox.Show("Escribe en Cantidad cuántas unidades quieres agregar (un número mayor que 0).");
                return;
            }

            DataGridViewRow fila = dgvProductos.CurrentRow;
            string codigo = fila.Cells["Codigo"].Value?.ToString() ?? "";

            string[] lineas = File.ReadAllLines(path);

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] d = lineas[i].Split(';');
                if (d.Length < 4 || d[0] != codigo) continue;
                if (!int.TryParse(d[2], out int actual)) continue;

                int nuevo = actual + unidades;
                d[2] = nuevo.ToString();                 // d[2] = cantidad en stock
                lineas[i] = string.Join(";", d);
                File.WriteAllLines(path, lineas);

                fila.Cells["Cantidad"].Value = nuevo.ToString();   // actualiza la tabla
                txtCantidadProducto.Clear();

                MessageBox.Show($"Se agregaron {unidades} unidades. Ahora hay {nuevo}.");
                return;
            }
            MessageBox.Show("No se encontró el producto en el archivo.");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto de la tabla.");
                return;
            }

            DataGridViewRow fila = dgvProductos.CurrentRow;
            string codigo = fila.Cells["Codigo"].Value?.ToString() ?? "";
            string nombre = fila.Cells["Nombre"].Value?.ToString() ?? "";

            var r = MessageBox.Show(
                $"¿Eliminar \"{nombre}\" del inventario? Esta acción no se puede deshacer.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r != DialogResult.Yes) return;

            // Quitar la línea del archivo
            var lineas = File.ReadAllLines(path).ToList();
            lineas.RemoveAll(l =>
            {
                string[] d = l.Split(';');
                return d.Length >= 4 && d[0] == codigo;
            });
            File.WriteAllLines(path, lineas);

            // Quitar la fila de la tabla
            dgvProductos.Rows.Remove(fila);

            MessageBox.Show("Producto eliminado.");
        }

        private void txtCodigoProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
