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
    public partial class SearchForm : Form
    {
        private MainForm master;
        private WertpapierArt[] wpArten;
        private Handelsplatz[] börsen;
        private Wertpapier[] aktuelleSuche;

        public SearchForm(MainForm master)
        {
            this.master = master;
            InitializeComponent();
            Hide();

            // Handelsplätze laden
            börsen = Program.db.ladeHandelsplätze();
            for (int i = 0; i < börsen.Length; i++)
            {
                handelsplatzSelect.Items.Insert(i, börsen[i].name);
            }
            handelsplatzSelect.SelectedIndex = 11;
            
            // Wertpapierarten laden
            wpArten = Program.db.ladeWertpapierArten();
            for (int i = 0; i < wpArten.Length; i++)
            {
                wpArtSelect.Items.Insert(i, wpArten[i].name);
            }
            wpArtSelect.SelectedIndex = 11;
        }

        private void suchenButton_Click(object sender, EventArgs e)
        {
            aktuelleSuche = Program.db.titelSuchen(
                sucheText.Text, wpArten[wpArtSelect.SelectedIndex].tpID, 
                börsen[handelsplatzSelect.SelectedIndex].tpID);
            ergList.Items.Clear();
            foreach (Wertpapier wp in aktuelleSuche)
            {
                ergList.Items.Add(wp.toString());
            }
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ergList_SelectedIndexChanged(object sender, EventArgs e)
        {
            master.titelAusgewählt(aktuelleSuche[ergList.SelectedIndex]);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
