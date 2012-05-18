using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TainPan_StockDataLoader
{
    static class Program
    {
        public static TPDatabase db;
        public static Hypertable ht = null;
        public static MainForm mainForm;

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
            mainForm = new MainForm();
            Application.Run(mainForm);
        }

        public static void ensureHypertable()
        {
            if (ht == null)
            {
                ht = new Hypertable(mainForm.getDbUri(), mainForm.getDbNamespace());
            }
        }
    }
}
