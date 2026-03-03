using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseInventory
{
    public class Product : IComparable
    {
        // PROPERTIES
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        // CONSTRUCTOR
        public Product(int id, string name, double price, double quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // DISPLAY METHOD
        public override string ToString()
        {
            return $"{Id} {Name}:\tprice {Price:C},\tquantity {Quantity}\tItem Value: {CalcValue():C}";
        }

        // METHOD TO CALCULATE ITEM VALUE
        public double CalcValue()
        {
            return Price * Quantity;
        }

        // COMPARE PRODUCTS USING ICOMPARABLE
        public int CompareTo(Product other)
        {
            return CalcValue().CompareTo(other.CalcValue());
        }
        // INTERFACE COMPARETO OBJECT (NOT IMPLEMENTED)
        public int CompareTo(Object other)
        {
            throw new NotImplementedException();
        }
    }
}
