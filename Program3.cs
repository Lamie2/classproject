using System;

namespace task22_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("kitablarin sayini daxil et");
            string sizestr = Console.ReadLine();
            int size = Convert.ToInt32(sizestr);

            Library library1 = new Library
            {
                Books = new Book[size]
            };


            for (int i = 0; i < size; i++)
            {
                int no;
                string name;
                string genre;
                double price;
                int count;               
                {
                    Console.WriteLine($"kitabin nomresini daxil edin:");
                    price = Convert.ToInt32(Console.ReadLine());
                    no = Convert.ToInt32(Console.ReadLine());
                    count = Convert.ToInt32(Console.ReadLine());
                    if (price<0 && no < 0 && count<0)
                    {
                        Console.WriteLine("price, no, count deyerleri menfi ola bilmez");
                    }
                    for (int j = 0; j < i; j++)
                    {
                        if (i != j && no == library1.Books[j].No)
                        {
                            Console.WriteLine("eyni no deyerinde 2. kitab elave edile bilmez");
                        }
                    }
            }

                Console.WriteLine($" kitabin adini daxil edin:");
                name = Console.ReadLine();
                while (name.Length < 0 || name.Length > 50)
                {
                    Console.WriteLine($"Kitabin adinin uzunluguı 1-den kicik ve 50-den boyuk ola bilmez");
                  
                }

                Console.WriteLine($" kitabin janrini daxil edin:");
                genre = Console.ReadLine();
                while (genre.Length < 3 || genre.Length > 30)
                {
                    Console.WriteLine("kitabin janr adi 3-den kicik 20-den boyuk ola bilmez");
                    
                }

                char answer1;
                char answer2;
                int minPrice;
                int maxPrice;
                Console.WriteLine("filterlemek isteyirsinizmi? y/n");
                answer1 = Convert.ToChar(Console.ReadLine());
                if (answer1 == 'n')
                {
                    foreach (var item in library1.Books)
                    {
                        Console.WriteLine($" name of book: {item.Name}, genre of book: {item.Genre}, price of book: {item.Price}, number of book: {item.No}, count of book: {item.Count}.");
                    }
                }
                else if (answer1 == 'y')
                {
                    
                        Console.WriteLine("1 - Genre adina gore , 2 - Qiymet intervalina gore");
                        answer2 = Convert.ToChar(Console.ReadLine());
                        if (answer2 == '1')
                        {
                            Console.WriteLine("axtardiginiz janri daxil edin");
                        }
                    library1.GetFilteredBooks(library1.Books, genreForFilter);
                }
                else if (answer2 == '2')
                        {
                            Console.WriteLine("minimum qiymeti daxil edin: ");
                            minPrice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("maksimum qiymeti daxil edin: ");
                            maxPrice = Convert.ToInt32(Console.ReadLine());
                            library1.GetFiltererdBooks( minPrice, maxPrice);
                        }

                
            };

           
            
        }
    
    }
}
