using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    public class CsvMenuLoader : IMenuLoader
    {
        public List<Product> LoadMenu()
        {
            var list = new List<Product>();

            using (var reader = new StreamReader(@"./menu.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    list.Add(new Product { ID = int.Parse(values[0]), Name = values[1], Price = decimal.Parse(values[2]), Type = values[3] });
                }
            }

            return list;
        }
    }
}
