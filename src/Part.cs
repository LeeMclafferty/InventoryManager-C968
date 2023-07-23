using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    public class Part
    {
        public Part()
        {
            partID = 0;
            name = "None";
            inStock = 0;
            price = 0;
            min = 0; 
            max = 0;
        }
        public int partID { get; set; }
        public string name { get; set; }
        public int inStock { get; set; }
        public double price { get; set; }
        public int min { get; set; }
        public int max { get; set; }
    }
}
