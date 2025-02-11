using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PerfumeriaPOS.DB_manager;

namespace PerfumeriaPOS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                lblMensaje.Text = "Por favor, ingrese usuario y contraseña.";
                return;
            }

            // Validar credenciales en la base de datos
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // Credenciales válidas, abrir el menú principal
                        lblMensaje.Text = "Inicio de sesión exitoso.";
                        MainMenu mainForm = new MainMenu();
                        this.Hide();
                        mainForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        lblMensaje.Text = "Usuario o contraseña incorrectos.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
