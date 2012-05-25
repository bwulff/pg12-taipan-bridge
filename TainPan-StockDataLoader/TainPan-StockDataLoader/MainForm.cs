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
            logText.SelectionStart = logText.Text.Length;
            logText.ScrollToCaret();
        }

        // TODO Prozentanzeige für's Schreiben
        // TODO move logic out of GUI class
        private void button1_Click(object sender, EventArgs e)
        {
            CandlestickProducer producer = null;
            DateTime beginTag = Util.tagesAnfang(vonDatum.Value);
            DateTime endTag = Util.tagesAnfang(bisDatum.Value);

            if (aktuellerTitel == null)
            {
                MessageBox.Show("Bitte ein Wertpapier auswählen!");
                return;
            }

            if (beginTag.CompareTo(endTag) >= 0)
            {
                MessageBox.Show("Startdatum muss vor dem Enddatum liegen!");
                return;
            }

            if (checkDatenSchreiben.Checked)
            {
                Program.ensureHypertable();
                Program.ht.openTable(textDbTable.Text);
                Program.ht.setInserter(new TestDBInserter());
                producer = new CandlestickProducer((int)feldAufloesung.Value);
            }
            
            DateTime tag = beginTag;
            do
            {
                log("\r\nHole Tagesdaten zu " + aktuellerTitel.name 
                    + " (" + Util.zweistellig(tag.Day) + "." + Util.zweistellig(tag.Month) + "." + tag.Year 
                    + ") von " + aktuellerTitel.handelsplatz.name + "...");
                TagesDaten daten = Program.db.holeTagesDaten(aktuellerTitel, tag);
                logln("fertig (" + daten.Count + " Datensätze)");

                if (checkDSAuszugAnzeigen.Checked)  // besser Candlesticks anzeigen, wenn das hier gecheckt ist
                {
                    druckeDatenauszug(daten);
                }

                // Candlesticks berechnen und in der DB speichern
                if (checkDatenSchreiben.Checked)
                {
                    //log("Schreibe Daten...");
                    producer.reset(tag);
                    while (daten.hasNext())
                    {
                        Datensatz ds = daten.next();
                        producer.update(korrigiereDatum(ds.timestamp, tag), ds.kurs);
                        if (producer.hasNextCandlestick())
                        {
                            Candlestick cs = producer.getNextCandlestick();
                            cs.titel = daten.titel;
                            //Program.ht.schreibe(cs);
                            logln(cs.timestamp.ToString() + "\t" + cs.mean + "\t" + cs.min + "\t" + cs.max + "\t" + cs.open + "\t" + cs.close);
                        }
                    }
                    if (!producer.hasNextCandlestick())
                    {
                        producer.finalizeCurrent();
                        Candlestick cs = producer.getNextCandlestick();
                        cs.titel = daten.titel;
                        //Program.ht.schreibe(cs);
                        logln(cs.timestamp.ToString() + "\t" + cs.mean + "\t" + cs.min + "\t" + cs.max + "\t" + cs.open + "\t" + cs.close);
                    }
                    //logln("fertig");
                }

                tag = tag.AddDays(1);
            } while (endTag.CompareTo(tag) >= 0);
        }

        private DateTime korrigiereDatum(DateTime oldD, DateTime tag)
        {
            return new DateTime(tag.Year, tag.Month, tag.Day, oldD.Hour, oldD.Minute, oldD.Second);
        }

        private void druckeDatenauszug(TagesDaten daten)
        {
            if (daten.Count == 0)
            {
                return;
            }
            int i = 0;
            while (daten.hasNext() && i++ < 20)
            {
                Datensatz d = daten.next();
                String line = d.timestamp.ToString() + "\t" +
                    d.kurs.ToString() + "\t" + d.volumen.ToString();
                logln(line);
            }
            daten.reset();
            logln("...");
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
