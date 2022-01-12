using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditLineRequest.Utils
{
    public class CreditLineUtils
    {
        public static bool creditRequestSME(double monthlyRevenue, int requestedCreditLine)
        {
            if (monthlyRevenueRule(monthlyRevenue) > requestedCreditLine)
                return true;
            else
                return false;
        }

        public static bool creditRequestStartup(double monthlyRevenue, double cashBalance, int requestedCreditLine)
        {
            double cashB = cashBalanceRule(cashBalance);
            double monthlyR = monthlyRevenueRule(monthlyRevenue);
            double maxValue = (cashB > monthlyR) ? cashB : monthlyR;

            if (maxValue > requestedCreditLine)
                return true;
            else
                return false;
        }

        private static double cashBalanceRule(double cashBalance)
        {
            return cashBalance / 3;
        } 

        private static double monthlyRevenueRule(double monthlyRevenue)
        {
            return monthlyRevenue / 5;
        }
    }
}
