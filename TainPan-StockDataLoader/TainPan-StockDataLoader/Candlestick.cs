using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TainPan_StockDataLoader
{
    public class Candlestick
    {
        public Wertpapier titel;
        public DateTime timestamp;
        public float mean, min, max, open, close; 

        public Candlestick(DateTime ts, float mean, float min, float max, float open, float close)
        {
            this.timestamp = ts;
            this.mean = mean;
            this.min = min;
            this.max = max;
            this.open = open;
            this.close = close;
        }
    }

    class CandlestickProducer
    {
        private int resolution;
        private DateTime beginTime;
        private long beginTimeTS;
        private Candlestick last = null;
        private Candlestick current;
        private long count;

        public CandlestickProducer(int resolution)
        {
            this.resolution = resolution * 1000;
        }

        public void reset(DateTime time)
        {
            beginTime = time;
            beginTimeTS = Util.dateTimeToUnixTS(time);
            current = new Candlestick(beginTime, 0.0f, float.MaxValue, 0.0f, 0.0f, 0.0f);
            count = 0;
        }

        public void update(DateTime time, float value)
        {
            long ts = Util.dateTimeToUnixTS(time);
            if (ts - beginTimeTS < resolution)
            {
                if (count == 0)
                {
                    current.open = value;
                }
                current.mean += value;
                current.min = Math.Min(current.min, value);
                current.max = Math.Max(current.max, value);
                current.close = value;
                count++;
            }
            else
            {
                finalizeCurrent();
                reset(time);
                update(time, value);    
            }
        }

        public void finalizeCurrent()
        {
            current.mean /= count;
            last = current;
        }

        public bool hasNextCandlestick()
        {
            return last != null;
        }

        public Candlestick getNextCandlestick()
        {
            Candlestick cs = last;
            last = null;
            return cs;
        }
    }
}
