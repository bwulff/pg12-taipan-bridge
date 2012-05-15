using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TainPan_StockDataLoader
{
    static class Program
    {
        public static TPDatabase db;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // init TaiPan DB COM
            db = new TPDatabase();

            // init GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
