using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaiPanRTLib;

namespace TainPan_StockDataLoader
{
    class TPDatabase
    {
        private static TaiPanRealtime tprt = null;
        private static DataBase tpdb = null;

        public TPDatabase()
        {
            if (tprt == null || tpdb == null)
            {
                tprt = new TaiPanRealtime();
                tpdb = (DataBase)tprt.DataBase;
            }
        }

        public WertpapierArt[] ladeWertpapierArten()
        {
            WertpapierArt[] erg;
            IWertpapierArten arten; 
            IWertpapierArt art;
            IWertpapierArten2 arten2;

            arten = (IWertpapierArten)tpdb.WertpapierArten;
            arten2 = (IWertpapierArten2)arten;
            arten2.SetAlternativeItem(1);

            erg = new WertpapierArt[arten.Count];
            for (int i = 1; i <= arten.Count; i++)
            { 
                art = (IWertpapierArt)arten[i];
                WertpapierArt item = new WertpapierArt(art.Name, art.Nr);
                erg[i-1] = item;
            }
            return erg;
        }

        public Handelsplatz[] ladeHandelsplätze()
        {
            IBoersen plätze = (IBoersen)tpdb.Boersen;
            Handelsplatz[] erg = new Handelsplatz[plätze.Count];
            int i = 0; 
            foreach (IBoerse platz in plätze)
            {
                erg[i++] = new Handelsplatz(platz.Nr, platz.Name);
            }
            return erg;
        }

        public Wertpapier[] titelSuchen(String suchBegriff, int wpArt, int börse)
        {
            ISuchListe zwergs = (ISuchListe)tpdb.Suchen(
                TPRSuchKriterien.TPRSucheWertpapiername,
                suchBegriff, (ushort)börse, (ushort)wpArt);
            Wertpapier[] ergs = new Wertpapier[zwergs.Count];
            int i = 0;
            foreach (IStammInfo info in zwergs)
            {
                ergs[i++] = new Wertpapier(info.Name, info.SymbolNr);
            }
            return ergs;
        }

        public TagesDaten holeTagesDaten(Wertpapier wp, DateTime tag)
        {
            IIntradayChart erg = tpdb.IntradayChart(wp.tpID, 1, tag);
            return new TagesDaten(erg);
        }
    }

    class WertpapierArt {

        public String name;
        public int tpID;

        public WertpapierArt(String name, int id)
        {
            this.name = name;
            this.tpID = id;
        }
    }

    class Handelsplatz
    {
        public int tpID;
        public String name;

        public Handelsplatz(int id, String name)
        {
            this.tpID = id;
            this.name = name;
        }
    }

    public class Wertpapier
    {
        public readonly String name;
        public readonly int tpID;

        public Wertpapier(String name, int taiPanNummer)
        {
            this.name = name;
            this.tpID = taiPanNummer;
        }

        public String toString()
        {
            return name;
        }
    }

    public class TagesDaten
    {
        public readonly long Count;
        public DateTime[] zeit;
        public float[] kurs;
        public float[] volumen;
       
        public TagesDaten(IIntradayChart daten)
        {
            this.Count = daten.Count;
            zeit = new DateTime[daten.Count];
            kurs = new float[daten.Count];
            volumen = new float[daten.Count];

            for (int i = 1; i <= daten.Count; i++)
            {
                IIntradayChartEintrag eintrag = daten[i];
                zeit[i - 1] = eintrag.Zeit;
                kurs[i - 1] = eintrag.Kurs;
                volumen[i - 1] = eintrag.Volume;
            }
        }
    }
}
