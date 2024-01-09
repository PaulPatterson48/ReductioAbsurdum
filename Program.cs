using ReductioAbsurdum;
using Linq;
using System;



List<Product> products = new List<Product>()
{
   new Product()
   {
       Name = "Apparel",
       Price = 15.00M,
       Sold = false,
       DateStocked = new DateTime(2022, 10, 20),
       ManufactureYear = 2010,
       Condition = 4.2
   },
   new Product()
   {
       Name = "Potioins",
       Price = 12.00M,
       Sold = false,
       DateStocked = new DateTime(2023, 4, 7),
       ManufactureYear = 2022,
       Condition = 4
   },
   new Product()
   {
       Name = "Enchanged Objects",
       Price = 25.00M,
       Sold = false,
       DateStocked = new DateTime(2023, 4, 20),
       ManufactureYear = 2021,
       Condition = 3
   },
   new Product()
   {
       Name = "Wands",
       Price = 35.00M,
       Sold = false,
       DateStocked = new DateTime(2021, 10, 11),
       ManufactureYear = 2020,
       Condition = 5
   }
};
Console.WriteLine("Products:");
decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}");

Console.WriteLine("Please enter a product number: ");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");

}
List<Product> unsoldProducts = products.Where(p => !p.Sold).ToList();
