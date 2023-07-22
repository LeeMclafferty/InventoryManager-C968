using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    public class Product
    {
        public Product() 
        {
            associatedParts = new BindingList<Part>();
            productID = 0;
            name = "None";
            inStock = 0;
            price = 0;
            min = 0; 
            max = 0;
        }
        public BindingList<Part> associatedParts { get; set; }
        public int productID { get; set; }
        public string name { get; set; }
        public int inStock { get; set; }
        public double price { get; set; }
        public int min { get; set; }
        public int max { get; set; }

        public void addAssociatedPart(Part part) { }
        public bool removeAssociatedPart(int n) { return true; } 
        public Part lookupAssociatedPart(int n) { return new Part(); }
    }
}
