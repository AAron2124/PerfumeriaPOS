using System;
using System.Windows.Forms;

namespace PerfumeriaPOS
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu()); // Iniciar en Men� Principal
        }
    }
}
