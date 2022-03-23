using System;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook1 = new Notebook
            {
                Name = "A101",
                BrandName = "Toshiba",
                Price = 400
            };
            Notebook notebook2 = new Notebook
            {
                Name = "XPS 13",
                BrandName = "DELL",
                Price = 700
            };
            Notebook notebook3 = new Notebook
            {
                Name = "Apple mac prp",
                BrandName = "Apple",
                Price = 1500
            };
            Notebook notebook4 = new Notebook
            {
                Name = "A13",
                BrandName = "Acer",
                Price = 550
            };

            Notebook[] notebooks = {notebook1, notebook2, notebook3, notebook4};

            Notebook[] rangeNotebooks = FindRangePriceNotebooks(notebooks, 500, 800);

            for (int i = 0; i < rangeNotebooks.Length; i++) {
                Console.WriteLine(rangeNotebooks[i].BrandName);
            }
        }

        static Notebook[] FindRangePriceNotebooks(Notebook[] notebooks, double minPrice, double maxPrice)
        {
            int index = 0;
            Notebook[] rangeNotebooks = new Notebook[2];
            for (int i = 0; i < notebooks.Length; i++)
            {
                if (notebooks[i].Price > minPrice && notebooks[i].Price < maxPrice)
                {
                    
                    rangeNotebooks[index] = notebooks[i];
                    index++; 
                }
            }
            return rangeNotebooks;
        }
    }
}
