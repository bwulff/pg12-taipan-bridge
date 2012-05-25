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

        public Wertpapier[] titelSuchen(String suchBegriff, int wpArt, Handelsplatz börse)
        {
            ISuchListe zwergs = (ISuchListe)tpdb.Suchen( 
                TPRSuchKriterien.TPRSucheWertpapiername,
                suchBegriff, (ushort)börse.tpID, (ushort)wpArt);
            Wertpapier[] ergs = new Wertpapier[zwergs.Count];
            int i = 0;
            foreach (IStammInfo info in zwergs)
            {
                ergs[i++] = new Wertpapier(info.Name, info.SymbolNr, börse);
            }
            return ergs;
        }

        public TagesDaten holeTagesDaten(Wertpapier wp, DateTime tag)
        {
            IIntradayChart erg = tpdb.IntradayChart(wp.tpID, 1, tag);
            return new TagesDaten(wp, erg);
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

    public class Handelsplatz
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
        public Handelsplatz handelsplatz;

        public Wertpapier(String name, int taiPanNummer, Handelsplatz handelsplatz)
        {
            this.name = name;
            this.tpID = taiPanNummer;
            this.handelsplatz = handelsplatz;
        }

        public String toString()
        {
            return name + " (" + handelsplatz.name + ")";
        }
    }

    public class TagesDaten
    {
        public readonly Wertpapier titel;
        public readonly int Count;
        private IIntradayChart data;
        private int i;

        public TagesDaten(Wertpapier titel, IIntradayChart data)
        {
            this.titel = titel;
            this.data = data;
            this.Count = data.Count;
            reset();
        }

        public void reset()
        {
            i = 1;
        }

        public bool hasNext()
        {
            return i <= Count;
        }

        public Datensatz next()
        {
            IIntradayChartEintrag eintrag = (IIntradayChartEintrag)data[i++];
            return new Datensatz(titel, eintrag.Zeit, eintrag.Kurs, eintrag.Volume);
        }
    }

    public class Datensatz
    {
        public readonly Wertpapier titel;
        public DateTime timestamp;
        public float kurs, volumen;

        public Datensatz(Wertpapier titel, DateTime ts, float kurs, float volumen)
        {
            this.titel = titel;
            this.timestamp = ts;
            this.kurs = kurs;
            this.volumen = volumen;
        }
    }

    // TODO Implement ISO6166 functionality
    public class ISIN
    {
        String id;

        public ISIN(String id)
        {
            this.id = id;
        }
    }
}
