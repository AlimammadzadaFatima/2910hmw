using System;

namespace _2910hmw
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("Kitablarin sayini daxil edin!");
            string countstr = Console.ReadLine();
            int say = Convert.ToInt32(countstr);
            library.books = new Book[0];
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine($"{i+1}-ci kitabin melumatlari;");
                Console.WriteLine("------------------");
                string name = MetodStr("adini", 0, 50);
                string genre = MetodStr("janrini", 3, 20);
                int no = Metodint("no", 0);
                int price = Metodint("qiymetini", 0);
                int count = Metodint("sayini", 0);
                Book book = new Book(name, count, no, price, genre);
                library.AddBook(book,no);
            }
            string cavab;
            do
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Filterlemek isteyirsinizmi? yes/no");
                cavab = Console.ReadLine();
            } while (cavab != "yes" && cavab != "no");
            if (cavab == "yes")
            {
                string secim;
                do
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Janr adina gore 1; Qiymet intervalina gore 2 basin;");
                    secim = Console.ReadLine();
                } while (secim!="1" && secim !="2");
                if (secim == "1")
                {
                    string janr;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Janr adini daxil edin");
                    janr = Console.ReadLine();
                    var filter = library.GetFilteredBooks(janr);
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"{janr} janrindaki kitablarin siyahisi:");
                    foreach (var item in filter)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine(item.GetInput());
                    }
                }
                else
                {
                    string minstr;
                    int min;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Min qiymet daxil edin");
                    minstr = Console.ReadLine();
                    min = Convert.ToInt32(minstr);
                    string maxstr;
                    int max;
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Max qiymet daxil edin");
                    maxstr = Console.ReadLine();
                    max = Convert.ToInt32(maxstr);
                    var minmax = library.GetFilteredBooks(min, max);
                    Console.WriteLine("----------------------");
                    Console.WriteLine("Daxil etdiyiniz qiymet intervalindaki kitablarin siyahisi:");
                    foreach ( var item in minmax)
                    {
                        Console.WriteLine("----------------------");
                        Console.WriteLine(item.GetInput());
                    }
                }
            }
            else
            {
                foreach (var item in library.books)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine(item.GetInput());
                }
            }
        }
        static string MetodStr (string inputname, int min = 0, int max = int.MaxValue)
        { string name;
            do
            {
                Console.WriteLine($"Kitabin {inputname} daxil edin");
                name = Console.ReadLine();
            } while (name.Length<min || name.Length>max);
            return name;
        }
        static int Metodint(string inputname, int min = 0, int max = int.MaxValue)
        {
            string input;
            int inputint;
            do
            {
                Console.WriteLine($"Kitabin {inputname} daxil edin");
                input = Console.ReadLine();
                inputint = Convert.ToInt32(input);
            } while (inputint < min || inputint > max);
            return inputint;
        }
    }
}
