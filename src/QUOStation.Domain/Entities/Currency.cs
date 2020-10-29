using System;
using System.Collections.Generic;
using System.Text;

namespace QUOStation.Domain.Entities
{
    public class Currency
    {
        public string Code { get; set; }
        public string CodeIn { get; set; }
        public string Name { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public float Variation { get; set; }
        public double PercentageChange { get; set; }
        public decimal Bid { get; set; }
        public decimal Ask { get; set; }
        public string TimeStamp { get; set; }
        public string CreateDate { get; set; }
    }
}
