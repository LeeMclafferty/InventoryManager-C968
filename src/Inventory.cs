using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_I___C____C968.src
{
    public class Inventory
    {

        public BindingList<Product> products;
        public BindingList<Part> allParts;

        public Inventory() 
        {
            allParts = new BindingList<Part>(); 
            products = new BindingList<Product>();
            SetupPartsList();
            SetupProductsList();
        }

        public void addProduct(Product toAdd)
        { 
            products.Add(toAdd);
        }

        public bool removeProduct(int toRemove) 
        { 
            foreach (Product product in products) 
            { 
                if (product.productID == toRemove)
                {
                    return products.Remove(product);
                }
            }
            return false;
        }

        public Product lookupProduct(int id) 
        {
            foreach (Product item in products)
            {
                if (item.productID == id)
                {
                    return item;
                }
            }
            return new Product(); 
        }

        public void updateProduct(int id, Product product)
        {
            foreach (Product item in products)
            {
                if (product.productID == id)
                {
                    item.name = product.name;
                    item.inStock = product.inStock;
                    item.price = product.price;
                    item.min = product.min;
                    item.max = product.max;
                    item.associatedParts = product.associatedParts;
                }
            }
        }

        public void addPart(Part toAdd) 
        { 
            allParts.Add(toAdd);
        }

        public bool deletePart(Part toRemove) 
        { 
            return allParts.Remove(toRemove);
        }

        public Part lookupPart(int part) 
        {
            foreach (Part item in allParts)
            {
                if (item.partID == part)
                {
                    return item;
                }
            }
            return new Part(); 
        }

        public void updatePart(int id, Part part) 
        {
            foreach (Part item in allParts)
            {
                if (item.partID == id)
                {
                    item.partID = part.partID;
                    item.name = part.name;
                    item.inStock = part.inStock;
                    item.price = part.price;
                    item.min = part.min;
                    item.max = part.max;
                }
            }
        }

        private void SetupPartsList()
        {
            allParts.Add(
                new Inhouse()
                {
                    partID = 0,
                    name = "Wheel",
                    inStock = 15,
                    price = 12.11,
                    min = 5,
                    max = 25,
                    machineID = 1220
                });
            allParts.Add(
                new Inhouse()
                {
                    partID = 1,
                    name = "Pedal",
                    inStock = 11,
                    price = 8.22,
                    min = 5,
                    max = 25,
                    machineID = 128,
                });
            allParts.Add(
                new Outsourced()
                {
                    partID = 2,
                    name = "Chain",
                    inStock = 12,
                    price = 8.33,
                    min = 5,
                    max = 25,
                    companyName = "Chain Hangin'"
                });
            allParts.Add(
                new Outsourced()
                {
                    partID = 3,
                    name = "Seat",
                    inStock = 8,
                    price = 4.55,
                    min = 2,
                    max = 15,
                    companyName = "Seat City"
                });
        }

        private void SetupProductsList() 
        {
            products.Add(
                new Product()
                {
                    productID = 0,
                    name = "Red Bicycle",
                    inStock = 15,
                    price = 11.44,
                    min = 1,
                    max = 25
                });
            products.Add(
                new Product()
                {
                    productID = 1,
                    name = "Yellow Bicycle",
                    inStock = 19,
                    price = 9.66,
                    min = 1,
                    max = 20
                });
            products.Add(
                new Product()
                {
                    productID = 2,
                    name = "Blue Bicycle",
                    inStock = 5,
                    price = 12.77,
                    min = 1,
                    max = 25
                });
        }
    }
}
