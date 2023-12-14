using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Orderbook
{
    public class OrderbookSpread
    {
        public OrderbookSpread(long? bid, long? ask)
        {
            Bid = bid;
            Ask = ask;
        }

        public long? Bid {  get; private set; }
        public long? Ask { get; private set; }
        public long? Spread
        {
            get 
            {
                if (Bid.HasValue && Ask.HasValue)
                    return (Ask.Value - Bid.Value);
                else return null;
            }
        }
    }
}
