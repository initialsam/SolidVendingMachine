using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    public class PriceTagMaker
    {
        public virtual string MakePriceTagForProduct(Product product)
        {
            return $"${product.Price:0.##}";
        }
    }

    public class DrinkTypePriceTagMaker : PriceTagMaker
    {
        public override string MakePriceTagForProduct(Product product)
        {
            var basePrice = base.MakePriceTagForProduct(product);
            return $"{basePrice} + ${product.Price * 0.1m:0.##} deposit fee";
        }
    }


    public class FruitTypePriceTagMaker : PriceTagMaker
    {
        public override string MakePriceTagForProduct(Product product)
        {
            var basePrice = base.MakePriceTagForProduct(product);
            return $"{basePrice} + ${product.Price * 0.05m:0.##} wrapping fee";
        }
    }
}
