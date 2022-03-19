using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    internal class PriceTagMaker
    {
        public string MakePriceTagForProduct(Product product)
        {
            return $"${product.Price:0.##}";
        }
    }
}
