using Lecture10_1.Core.Models;
using System;
using System.ComponentModel.Design;

namespace Lecture10_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Biblioteka biblioteka = new Biblioteka();

            biblioteka.PridetiKnyga(new Knyga("Haris Poteris ir Išminties Akmuo","J.K. Rowling",1997,"11111"));
            biblioteka.PridetiKnyga(new Knyga("Karas ir taika","Leo Tolstoy",1869,"22222"));
            biblioteka.PridetiKnyga(new Knyga("1984","George Orwell",1949,"33333"));
            biblioteka.PridetiKnyga(new Knyga("Didysis Getsbis","F. Scott Fitzgerald",1925,"44444"));

            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Prideti knyga prie saraso");
                Console.WriteLine("2. Rodyti visas knygas");
                Console.WriteLine("3. Istrinti knyga pagal koda");
                Console.WriteLine("4. Rasti naujausia knyga");
                Console.WriteLine("5. Rasti seniausia knyga");
                Console.WriteLine("6. Filtruoti knygas pagal isleidimo metus (nuo/iki)");
                Console.WriteLine("7. Knygos paieska pagal koda");
                Console.WriteLine("8. Baigti programa");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        Console.WriteLine("Iveskite knygos pavadinima:");
                        string pavadinimas = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos autoriu:");
                        string autorius = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos isleidimo metus:");
                        int metai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite knygos koda:");
                        string kodas = Console.ReadLine();

                        biblioteka.PridetiKnyga(new Knyga(pavadinimas,autorius,metai,kodas));
                        Console.WriteLine("Nauja knyga prideta prie bibliotekos");
                        Console.WriteLine();
                        continue;

                    case 2:
                        biblioteka.RodytiKnygas();
                        Console.WriteLine();
                        continue;

                    case 3:
                        Console.WriteLine("Iveskite knygos koda:");
                        string kodasTrinimui = Console.ReadLine();

                        biblioteka.TrintiKnyga(kodasTrinimui);
                        Console.WriteLine("Nurodyta knyga pasalinta is bibliotekos");
                        Console.WriteLine();
                        continue;

                    case 4:
                        biblioteka.NaujausiaKnyga();
                        Console.WriteLine();
                        continue;

                    case 5:
                        biblioteka.SeniausiaKnyga();
                        Console.WriteLine();
                        continue;

                    case 6:
                        Console.WriteLine("Nuo kuriu metu norite matyti knygas?");
                        int nuoMetai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iki kuriu metu norite matyti knygas?");
                        int ikiMetai = int.Parse(Console.ReadLine());

                        biblioteka.FiltravimasPagalMetus(nuoMetai, ikiMetai);
                        Console.WriteLine();
                        continue;

                    case 7:
                        Console.WriteLine("Iveskite knygos koda:");
                        string kodasPaieskai = Console.ReadLine();

                        biblioteka.PaieskaPagalKoda(kodasPaieskai);
                        Console.WriteLine();
                        continue;

                    case 8:
                        return;
                }
            }
        }
    }
}