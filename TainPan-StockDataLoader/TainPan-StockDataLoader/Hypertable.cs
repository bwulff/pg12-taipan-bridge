using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hypertable;

namespace TainPan_StockDataLoader
{
    public class Hypertable
    {
        private String host, ns;
        private IContext htContext;
        private IClient htClient;
        private INamespace htNs;
        private ITable table = null;
        private ITableMutator mutator = null;
        private IDBInserter inserter = null;

        public Hypertable(String host, String ns) 
        {
            this.host = host;
            this.ns = ns;
            String conn = "Provider=Hyper;Uri=net.tcp://" + host;
            htContext = Context.Create(conn);
            htClient = htContext.CreateClient();
            htNs = htClient.OpenNamespace(ns, OpenDispositions.OpenAlways | OpenDispositions.CreateIntermediate);
        }

        public void openTable(String tableName)
        {
            table = htNs.OpenTable(tableName);
            mutator = table.CreateMutator();
        }

        public void setInserter(IDBInserter inserter)
        {
            this.inserter = inserter;
        }

        public void schreibe(Candlestick daten)
        {
            if (this.table != null && this.inserter != null)
            {
                inserter.schreibe(daten, mutator);
                mutator.Flush();
            }
            else
            {
                throw new System.ArgumentException("Tabelle öffnen und/oder DBInserter setzen!");
            }
        }

        public void shutdown()
        {
            htClient.Dispose();
            htContext.Dispose();
        }
    }

    public interface IDBInserter
    {
        void schreibe(Candlestick data, ITableMutator mutator);
    }

    // DBInserter der die Werte kurs und volumen als Strings in die Db schreibt
    public class TestDBInserter : IDBInserter
    {
        public void schreibe(Candlestick data, ITableMutator mutator)
        {
            //DateTime ts = data.timestamp;
            //String rowKey = data.titel.name + " " + Util.getAmiDatum();

            //// schreibe kurs
            //Key key = new Key(rowKey, "quote");
            //mutator.Set(key, Encoding.UTF8.GetBytes(data.kurs.ToString()));

            //// schreibe volumen
            //key.ColumnFamily = "volume";
            //mutator.Set(key, Encoding.UTF8.GetBytes(data.volumen.ToString()));
        }
    }
}
