using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TainPan_StockDataLoader
{
    public partial class MainForm : Form
    {
        private SearchForm searchF;
        private Wertpapier aktuellerTitel = null;

        public MainForm()
        {
            searchF = new SearchForm(this);
            InitializeComponent();
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            searchF.Show();
        }

        public void titelAusgewählt(Wertpapier wp)
        {
            aktuellerTitel = wp;
            titelAnzeige.Text = wp.name;
        }

        public void log(String msg)
        {
            logText.Text += msg + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (aktuellerTitel != null)
            {
                DateTime tag = vonDatum.Value;
                log("\r\nHole Tagesdaten zu " + aktuellerTitel.name + " (" + tag.ToString() + ")...");
                TagesDaten daten = Program.db.holeTagesDaten(aktuellerTitel, tag);
                for (int i = 0; i < daten.Count; i++)
                {
                    String line = daten.zeit[i].ToString() + "\t" + daten.kurs[i].ToString() + "\t" + daten.volumen[i].ToString();
                    log(line);
                }
            }
            else
            {
                MessageBox.Show("Bitte ein Wertpapier auswählen!");
            }
        }
    }
}
