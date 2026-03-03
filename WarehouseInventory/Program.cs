namespace WarehouseInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HEADER
            Console.WriteLine("Competency Project - Warehouse Inventory - by Colton Gurr\n");

            // INSTANTIATE WAREHOUSE COLLECTION
            Warehouse<Product> warehouse = new Warehouse<Product>();

            // INSTANTIATE PRODUCTS AND ADD TO WAREHOUSE
            warehouse.Add(new Product(123, "pen", 3.50, 300));
            warehouse.Add(new Product(456, "pencil", 2.00, 375));
            warehouse.Add(new Product(789, "eraser", 2.5, 200));
            warehouse.Add(new Product(579, "staples", 2.75, 150));
            warehouse.Add(new Product(432, "paper", 6.25, 100));
            warehouse.Add(new Product(807, "clips", 1.50, 225));
            warehouse.Add(new Product(612, "magnets", 1.69, 125));
            warehouse.Add(new Product(206, "pushpins", 1.99, 175));

            // VARIABLE FOR TOTAL VALUE
            double totalValue = 0;

            // DISPLAY PRODUCTS & ADD TO TOTAL VALUE
            foreach (Product product in warehouse)
            {
                Console.WriteLine(product.ToString());
                totalValue += product.CalcValue();
            }
            Console.WriteLine("\n");

            // OUTPUT TOTAL VALUE
            Console.WriteLine($"Total Value in Warehouse: {totalValue:C}");

            // FIND ITEM WITH LARGEST VALUE
            Product largest = warehouse.First<Product>();
            foreach (Product product in warehouse)
            {
                if (product.CompareTo(largest) > 0)
                {
                    largest = product;
                }
            }
            // DISPLAY LARGEST
            Console.WriteLine($"\nItem with largest value: {largest.ToString()}");

            // FIND ITEM WITH SMALLEST VALUE
            Product smallest = warehouse.First<Product>();
            foreach (Product product in warehouse)
            {
                if (product.CompareTo(smallest) < 0)
                {
                    smallest = product;
                }
            }
            // DISPLAY SMALLEST
            Console.WriteLine($"\nItem with smallest value: {smallest.ToString()}");

            // PAUSE
            Console.Write("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
