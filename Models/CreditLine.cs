using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditLineRequest.Models
{
    public class CreditLine
    {
        public string foundingType { set; get; }
        public double cashBalance { set; get; }
        public double monthlyRevenue { set; get; }
        public int requestedCreditLine { set; get; }
        public DateTime requestedDate { set; get; }
    }
}

