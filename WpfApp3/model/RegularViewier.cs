using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WpfApp3
{
    public class RegularViewier:Viewier
    {
        public RegularViewier(int visits) : base(visits)
        {
        }
        public override double Cost(double price)
        {
            Random random = new Random();
             int discont=0;
            if (Visits % 10 == 0)
            {
                discont = random.Next(1, 21);
            }
            return price - (price * discont) / 100;
        }

    }
}
