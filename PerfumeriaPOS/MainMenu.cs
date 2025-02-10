using System;
using System.Windows.Forms;

namespace PerfumeriaPOS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.MainMenu_Load);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar datos o configurar la interfaz
            Console.WriteLine("Menú Principal cargado correctamente.");
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Abre el formulario de Clientes
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.ShowDialog(); // Abre la ventana y espera hasta que se cierre
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.ShowDialog();
        }


        private void btnVentasContado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir módulo de Ventas de Contado");
        }

        private void btnVentasCredito_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir módulo de Ventas a Crédito");
        }

        private void btnPagosParciales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir módulo de Control de Pagos Parciales");
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir módulo de Reportes Financieros");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
