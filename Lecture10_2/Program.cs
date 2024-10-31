using Lecture10_2.Core.Models;
using System;
using System.ComponentModel.Design;

namespace Lecture10_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AutomobiliuParkas automobiliuParkas = new AutomobiliuParkas();

            automobiliuParkas.PridetiAutomobili(new Automobilis("Honda","Civic",2006,"AAA111"));
            automobiliuParkas.PridetiAutomobili(new Automobilis("Toyota","Yaris",2010,"BBB222"));
            automobiliuParkas.PridetiAutomobili(new Automobilis("Subaru","Impreza",1992,"CCC333"));
            automobiliuParkas.PridetiAutomobili(new Automobilis("Fiat","Topolino",2023,"DDD444"));
            automobiliuParkas.PridetiAutomobili(new Automobilis("Mazda","Miata",1998,"EEE555"));

            while (true)
            {
                Console.WriteLine("Meniu");
                Console.WriteLine("1. Rodyti visus automobilius parke");
                Console.WriteLine("2. Prideti automobili i parka");
                Console.WriteLine("3. Pasalinti automobili is parko");
                Console.WriteLine("4. Ieskoti automobiliu pagal marke");
                Console.WriteLine("5. Rasti naujausia automobili");
                Console.WriteLine("6. Rasti seniausia automobili");
                Console.WriteLine("7. Filtruoti automobilius pagal gamybos metus");
                Console.WriteLine("8. Rodyti visu automobiliu parke kieki");
                Console.WriteLine("9. Tikrinti, ar automobilis egzistuoja pagal registracijos numeri");
                Console.WriteLine("10. Atnaujinti automobilio informacija pagal registracijos numeri");
                Console.WriteLine();
                Console.WriteLine("Pasirinkite norima numeri:");
                int parinktis = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (parinktis)
                {
                    case 1:
                        automobiliuParkas.RodytiVisusAutomobilius();
                        Console.WriteLine();
                        continue;

                    case 2:
                        Console.WriteLine("Iveskite automobilio marke:");
                        string marke = Console.ReadLine();
                        Console.WriteLine("Iveskite automobilio modeli:");
                        string modelis = Console.ReadLine();
                        Console.WriteLine("Iveskite automobilio gamybos metus:");
                        int metai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite automobilio registracijos numeri:");
                        string numeris = Console.ReadLine();
                        Console.WriteLine();

                        automobiliuParkas.PridetiAutomobili(new Automobilis(marke,modelis,metai,numeris));
                        Console.WriteLine("Automobilis pridetas i parka");
                        Console.WriteLine();
                        continue;

                    case 3:
                        Console.WriteLine("Iveskite automobilio registracijos numeri:");
                        string numerisSalinimui = Console.ReadLine();
                        Console.WriteLine();

                        automobiliuParkas.TrintiAutomobili(numerisSalinimui);
                        Console.WriteLine("Automobilis pasalintas is parko");
                        Console.WriteLine();
                        continue;

                    case 4:
                        Console.WriteLine("Iveskite automobilio marke:");
                        string markePaieskai = Console.ReadLine();

                        Console.WriteLine();
                        automobiliuParkas.IeskotiPagalMarke(markePaieskai);
                        Console.WriteLine();
                        continue;

                    case 5:
                        Console.WriteLine("Naujausias automobilis parke:");
                        automobiliuParkas.NaujausiasAutomobilis();
                        Console.WriteLine();
                        continue;

                    case 6:
                        Console.WriteLine("Seniausias automobilis parke:");
                        automobiliuParkas.SeniausiasAutomobilis();
                        Console.WriteLine();
                        continue;

                    case 7:
                        Console.WriteLine("Nuo kuriu gamybos metu norite matyti automobilius?");
                        int nuoMetai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iki kuriu gamybos metu norite matyti automobilius?");
                        int ikiMetai = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine($"Automobiliai {nuoMetai}-{ikiMetai}:");
                        automobiliuParkas.FiltravimasPagalMetus(nuoMetai,ikiMetai);
                        Console.WriteLine();
                        continue;

                    case 8:
                        Console.WriteLine($"Parke yra {automobiliuParkas.AutomobiliuKiekis()} automobiliai");
                        Console.WriteLine();
                        continue;

                    case 9:
                        Console.WriteLine("Iveskite automobilio registracijos numeri:");
                        string numerisEgz = Console.ReadLine();
                        Console.WriteLine();

                        automobiliuParkas.ArEgzistuoja(numerisEgz);
                        Console.WriteLine();
                        continue;

                    case 10:
                        Console.WriteLine("Iveskite automobilio registracijos numeri:");
                        string numerisNaujinimui = Console.ReadLine();
                        Console.WriteLine();

                        automobiliuParkas.AtnaujintiAutomobili(numerisNaujinimui);
                        Console.WriteLine();
                        continue;
                }
            }
        }
    }
}