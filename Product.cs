using System;

namespace ReductioAbsurdum //Here is the code
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public DateTime DateStocked { get; set; }
        public string ProductTypeId { get; set; }
        public int ManufactureYear { get; set; }
        public double Condition { get; set; }
        public int DaysOnShelf
        {
            get
            {
                TimeSpan timeOnShelf = DateTime.Now - DateStocked;
                return timeOnShelf.Days;
            }
        }
    }

   
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}

