using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace edzoterem
{
    public class Membership
    {
        private Member _owner {  get; set; }
        private int _monthlyPrice { get; set; }
        private int _months {  get; set; }
        public Member Owner { get { return _owner; } set { _owner = value; } }
        public int MonthlyPrice { get { return _monthlyPrice; } set { _monthlyPrice = value; } }
        public int Months { get { return _months; } set { _months = value; } }

        public Membership(Member Owner, int MonthlyPrice, int Months)
        {
            Owner = _owner;
            MonthlyPrice = _monthlyPrice;
            Months = _months;
        }
            
        public int TotalCost()
        {
            if (_owner.IsStudent == true)
            {
                return MonthlyPrice * Months * 100 / 80;
            }
            else
            {
                return MonthlyPrice * Months;
            }
        }
        public int Extend(int monthsplusz)
        {
            return _months += monthsplusz;
        }

    }
}
