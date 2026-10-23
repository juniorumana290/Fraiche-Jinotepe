namespace ModuloUsuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private readonly string Users = "C:\\Users\\junio\\Downloads\\Proyecto final EsenciaStockPro\\ModuloUsuarios\\Usuarios\\Usuarios.txt";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgvUsuarios.Columns.Add("Codigo de Usuario", "Codigo de Usuario");
            dgvUsuarios.Columns.Add("Usuario", "Usuario");
            dgvUsuarios.Columns.Add("Rol", "Rol");
            dgvUsuarios.Columns.Add("Estado", "Estado");
            dgvUsuarios.Columns.Add("Contraseña Usuario", "Contraseña Usuario");

        }
        private void FiltrarUsuarios()
        {
            string texto = txtBuscarUsuario.Text.Trim();

            dgvUsuarios.CurrentCell = null;

            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
            {
                string estado = fila.Cells["Estado"].Value?.ToString() ?? "";
                string codigousuario = fila.Cells["Codigo de Usuario"].Value?.ToString() ?? "";
                string rol = fila.Cells["Rol"].Value?.ToString() ?? "";
                string usuario = fila.Cells["Usuario"].Value?.ToString() ?? "";
                fila.Visible = texto == ""
                    || codigousuario.Contains(texto, StringComparison.OrdinalIgnoreCase)
                    || estado.Contains(texto, StringComparison.OrdinalIgnoreCase)
                    || rol.Contains(texto, StringComparison.OrdinalIgnoreCase)
                    || usuario.Contains(texto, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoUsuario.Text) ||
        string.IsNullOrWhiteSpace(txtUsuario.Text))

            {
                MessageBox.Show("Completa el código y el usuario.");
                return;
            }

            string codigo = txtCodigoUsuario.Text.Trim();
            string usuario = txtUsuario.Text.Trim().Replace(";", ",");
            string rol = txtRolUsuario.Text.Trim();
            string estado = txtEstadoUsuario.Text.Trim();
            string contraseña = txtContraseñaUsuario.Text.Trim();

            dgvUsuarios.Rows.Add(codigo, usuario, rol, estado, contraseña);
            File.AppendAllText(Users, $"{codigo};{usuario};{rol};{estado};{contraseña}{Environment.NewLine}");

            txtCodigoUsuario.Clear();
            txtUsuario.Clear();
            txtRolUsuario.Clear();
            txtEstadoUsuario.Clear();
            txtContraseñaUsuario.Focus();
            FiltrarUsuarios();
        }

        private void btnCargarUsuarios_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Users))
            {
                MessageBox.Show("No se encontró el usuario");
                return;
            }

            dgvUsuarios.Rows.Clear();

            foreach (string linea in File.ReadAllLines(Users))
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] d = linea.Split(';');
                if (d.Length < 4) continue;

                dgvUsuarios.Rows.Add(d[0], d[1], d[2], d[3]);
                FiltrarUsuarios();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Clear();
            txtBuscarUsuario.Focus();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
