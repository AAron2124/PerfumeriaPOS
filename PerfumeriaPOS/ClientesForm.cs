using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PerfumeriaPOS
{
    public partial class ClientesForm : Form
    {
        private string connectionString = "Server=localhost;Database=perfumeria;User ID=root;Password=tu_contraseña;";

        public ClientesForm()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM CLIENTES";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO CLIENTES (IDCLIENTES, NOMBRE, APATERNO, AMATERNO, CALLE, NUMERO, COLONIA, TELEFONO) " +
                                   "VALUES (@id, @nombre, @apaterno, @amaterno, @calle, @numero, @colonia, @telefono)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apaterno", txtApaterno.Text);
                    cmd.Parameters.AddWithValue("@amaterno", txtAmaterno.Text);
                    cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@colonia", txtColonia.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente agregado correctamente.");
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar cliente: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IDCLIENTES"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM CLIENTES WHERE IDCLIENTES = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idCliente);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente eliminado.");
                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IDCLIENTES"].Value);
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE CLIENTES SET NOMBRE=@nombre, APATERNO=@apaterno, AMATERNO=@amaterno, " +
                                       "CALLE=@calle, NUMERO=@numero, COLONIA=@colonia, TELEFONO=@telefono WHERE IDCLIENTES=@id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", idCliente);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@apaterno", txtApaterno.Text);
                        cmd.Parameters.AddWithValue("@amaterno", txtAmaterno.Text);
                        cmd.Parameters.AddWithValue("@calle", txtCalle.Text);
                        cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                        cmd.Parameters.AddWithValue("@colonia", txtColonia.Text);
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cliente actualizado.");
                        CargarClientes();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar cliente: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para editar.");
            }
        }
    }
}
