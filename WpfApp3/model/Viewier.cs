using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public abstract class Viewier
    {

        public int Visits { get; set; }

        protected Viewier(int visits)
        {
            Visits = Visits;
        }

        public void Visit() 
        {
            Visits++;
        }
        public abstract double Cost(double price);
   

    }
}
