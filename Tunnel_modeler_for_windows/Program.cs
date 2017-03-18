using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeler.Tunnel.Windows
{
    static class Program
    {
        public static MDI_Parent mdi_parent;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mdi_parent = new MDI_Parent();
            Application.Run(mdi_parent);
        }
    }
}
