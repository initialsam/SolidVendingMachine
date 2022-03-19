using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    public interface IMenuLoader
    {
        List<Product> LoadMenu();
    }
}
