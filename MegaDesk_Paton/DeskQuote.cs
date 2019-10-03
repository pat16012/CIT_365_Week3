using System;

namespace MegaDesk_Paton
{
    public class DeskQuote
    {
        public string CustomerName { get; set; }
        public string RushDays { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk desk { get; set; }
        public DateTime QuoteDate { get; set; }

        
    }
}