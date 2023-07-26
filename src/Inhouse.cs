using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    public class Inhouse : Part
    {
        public Inhouse() 
        {
            machineID = 0;
        }
        public Inhouse(Inhouse part)
        {
            partID = part.partID;
            name = part.name;
            inStock = part.inStock;
            price = part.price;
            min = part.min;
            max = part.max;
            machineID = part.machineID;
        }

        public int machineID { get; set; }
    }
}
