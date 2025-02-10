namespace PerfumeriaPOS
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentasContado;
        private System.Windows.Forms.Button btnVentasCredito;
        private System.Windows.Forms.Button btnPagosParciales;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnClientes = new Button();
            btnProductos = new Button();
            btnVentasContado = new Button();
            btnVentasCredito = new Button();
            btnPagosParciales = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(108, 123);
            btnClientes.Margin = new Padding(6, 7, 6, 7);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(433, 74);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(108, 246);
            btnProductos.Margin = new Padding(6, 7, 6, 7);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(433, 74);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentasContado
            // 
            btnVentasContado.Location = new Point(108, 369);
            btnVentasContado.Margin = new Padding(6, 7, 6, 7);
            btnVentasContado.Name = "btnVentasContado";
            btnVentasContado.Size = new Size(433, 74);
            btnVentasContado.TabIndex = 2;
            btnVentasContado.Text = "Ventas de Contado";
            btnVentasContado.UseVisualStyleBackColor = true;
            btnVentasContado.Click += btnVentasContado_Click;
            // 
            // btnVentasCredito
            // 
            btnVentasCredito.Location = new Point(108, 492);
            btnVentasCredito.Margin = new Padding(6, 7, 6, 7);
            btnVentasCredito.Name = "btnVentasCredito";
            btnVentasCredito.Size = new Size(433, 74);
            btnVentasCredito.TabIndex = 3;
            btnVentasCredito.Text = "Ventas a Crédito";
            btnVentasCredito.UseVisualStyleBackColor = true;
            btnVentasCredito.Click += btnVentasCredito_Click;
            // 
            // btnPagosParciales
            // 
            btnPagosParciales.Location = new Point(108, 615);
            btnPagosParciales.Margin = new Padding(6, 7, 6, 7);
            btnPagosParciales.Name = "btnPagosParciales";
            btnPagosParciales.Size = new Size(433, 74);
            btnPagosParciales.TabIndex = 4;
            btnPagosParciales.Text = "Pagos Parciales";
            btnPagosParciales.UseVisualStyleBackColor = true;
            btnPagosParciales.Click += btnPagosParciales_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(108, 738);
            btnReportes.Margin = new Padding(6, 7, 6, 7);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(433, 74);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes Financieros";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(108, 862);
            btnSalir.Margin = new Padding(6, 7, 6, 7);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(433, 74);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 1108);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(btnVentasContado);
            Controls.Add(btnVentasCredito);
            Controls.Add(btnPagosParciales);
            Controls.Add(btnReportes);
            Controls.Add(btnSalir);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainMenu";
            Text = "Menú Principal - Perfumería POS";
            Load += MainMenu_Load;

            ResumeLayout(false);
        }
    }
}
