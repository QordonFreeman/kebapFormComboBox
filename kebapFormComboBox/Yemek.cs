using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kebapFormComboBox
{
   public class Yemek
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
