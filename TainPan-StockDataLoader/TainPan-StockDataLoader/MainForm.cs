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
            titelAnzeige.Text = wp.toString();
        }

        public String getDbUri()
        {
            return textDbHostname.Text;
        }

        public String getDbNamespace()
        {
            return textDbNamespace.Text;
        }

        public String getDbTable()
        {
            return textDbTable.Text;
        }

        public void log(String msg)
        {
            logText.Text += msg;
        }

        public void logln(String msg)
        {
            logText.Text += msg + "\r\n";
        }

        // TODO mehrere Tage!!
        // TODO Durchschnitte berechnen
        // TODO Prozentanzeige für's Schreiben
        private void button1_Click(object sender, EventArgs e)
        {
            if (aktuellerTitel != null)
            {
                DateTime tag = vonDatum.Value;
                log("\r\nHole Tagesdaten zu " + aktuellerTitel.name + " (" + tag.ToString() + ") von " + aktuellerTitel.handelsplatz.name + "...");
                TagesDaten daten = Program.db.holeTagesDaten(aktuellerTitel, tag);
                logln("fertig");
                if (daten.Count > 0)
                {
                    logln("Datensatzgröße: " + daten.Count);
                    
                    // Auszug der Daten Ausgeben?
                    if (checkDSAuszugAnzeigen.Checked)
                    {
                        int i = 0;
                        while (daten.hasNext() && i++ < 20)
                        {
                            Datensatz d = daten.next();
                            String line = d.timestamp.ToString() + "\t" + 
                                d.kurs.ToString() + "\t" + d.volumen.ToString();
                            logln(line);
                        }
                        logln("...");
                    }

                    // Daten in die DB schreiben
                    if (checkDatenSchreiben.Checked)
                    {
                        log("Schreibe Daten...");
                        Program.ensureHypertable();
                        Program.ht.openTable(textDbTable.Text);
                        Program.ht.setInserter(new TestDBInserter());
                        daten.reset();
                        while (daten.hasNext())
                        {
                            Datensatz d = daten.next();
                            
                            // Workaround für den 1899-Bug von TaiPan
                            DateTime oldD = d.timestamp;
                            DateTime newD = new DateTime(
                                tag.Year, tag.Month, tag.Day, oldD.Hour, oldD.Minute, oldD.Second);
                            d.timestamp = newD;
                            Program.ht.schreibe(d);
                        }
                        logln("fertig");
                    }
                }
                else
                {
                    logln("keine Daten vorhanden");
                }
            }
            else
            {
                MessageBox.Show("Bitte ein Wertpapier auswählen!");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.ht != null)
            {
                Program.ht.shutdown();
            }
        }
    }
}
