using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._1
{
    internal class Product
    {
        string name;
        double cost;
        int onhand;

        public Product(string n, double c, int o)
        {
            this.name = n;
            this.cost = c;
            this.onhand = o;
        }
        public override string ToString()
        {
            return String.Format("{0,10} Cost: {1,6:C} On hand: {2}",name,cost,onhand);
        }

    }
}
