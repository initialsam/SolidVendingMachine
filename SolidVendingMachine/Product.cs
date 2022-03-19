using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} - {Name} - {this.GetPriceTagMaker().MakePriceTagForProduct(this)} ";
        }
    }
}
