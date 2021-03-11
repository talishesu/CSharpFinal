using CSharpFinal.Classes;
using CSharpFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1-Mehsullar uzerinde emeliyyat aparmaq");
            Console.WriteLine("2-Satislar uzerinde emeliyyat aparmaq");
            Console.WriteLine("3-Sistemden cixmaq");
            Console.WriteLine("Reqem Daxil Edin");
            string number = Console.ReadLine();
            if (number == "1")
            {
                Console.WriteLine("Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("1-Yeni mehsul elave et");
                Console.WriteLine("2-Mehsul uzerinde duzelis et");
                Console.WriteLine("3-Mehsulu sil");
                Console.WriteLine("4-Butun mehsullari goster");
                Console.WriteLine("5-Categoriyasina gore mehsullari goster");
                Console.WriteLine("6-Qiymet araligina gore mehsullari goster");
                Console.WriteLine("7-Mehsullar arasinda ada gore axtaris et");
                Console.WriteLine("Reqem Daxil Edin");
                string number1 = Console.ReadLine();
                switch (number1)
                {
                    case "1":
                        
                        Product product = new Product();
                        product.AddProduct(product);
                        //product.ShowProducts();
                        break;
                    case "2":
                        Console.WriteLine("Mehsul uzerinde duzelis et");
                        break;
                    case "3":
                        Console.WriteLine("Mehsulu sil");
                        break;
                    case "4":
                        Console.WriteLine("Butun mehsullari goster");
                        break;
                    case "5":
                        Console.WriteLine("Categoriyasina gore mehsullari goster");
                        break;
                    case "6":
                        Console.WriteLine("Qiymet araligina gore mehsullari goster");
                        break;
                    case "7":
                        Console.WriteLine("Mehsullar arasinda ada gore axtaris et");
                        break;
                    default:
                        Console.WriteLine("Duzgun Reqem Daxil Edin (1, 2, 3, 4, 5, 6, 7)");
                        break;
                }
            }
            else if (number == "2")
            {
                Console.WriteLine("Satislar uzerinde emeliyyat aparmaq");
            }
            else if (number == "3")
            {
                Console.WriteLine("Sistemden cixmaq");
            }
            else
            {
                Console.WriteLine("Duzgun Reqem Daxil Edin (1, 2, 3)");
            }
        }
    }
}
