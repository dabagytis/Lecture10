using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_2.Core.Models
{
    public class AutomobiliuParkas
    {
        private List<Automobilis> automobiliai = new List<Automobilis>();

        public void PridetiAutomobili(Automobilis automobilis)
        {
            automobiliai.Add(automobilis);
        }

        public void TrintiAutomobili(string numerisSalinimui)
        {
            Automobilis x = new Automobilis();
            foreach(Automobilis a in automobiliai)
            {
                if (numerisSalinimui == a.Numeris)
                {
                    x = a;
                }
            }
            automobiliai.Remove(x);
        }

        public void RodytiVisusAutomobilius()
        {
            foreach(Automobilis a in automobiliai)
            {
                Console.WriteLine($"Pavadinimas: {a.Marke} {a.Modelis}, Metai: {a.Metai}, Registracijos Numeris: {a.Numeris}");
            }
        }

        public void IeskotiPagalMarke(string markePaieskai)
        {
            foreach(Automobilis a in automobiliai)
            {
                if (markePaieskai == a.Marke)
                {
                    Console.WriteLine($"Pavadinimas: {a.Marke} {a.Modelis}, Metai: {a.Metai}, Registracijos Numeris: {a.Numeris}");
                }
            }
        }

        public void NaujausiasAutomobilis()
        {
            int newestYear = int.MinValue;
            foreach (Automobilis a in automobiliai)
            {
                if (a.Metai > newestYear)
                {
                    newestYear = a.Metai;
                }
            }

            foreach (Automobilis a in automobiliai)
            {
                if (newestYear == a.Metai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Marke} {a.Modelis}, Metai: {a.Metai}, Registracijos Numeris: {a.Numeris}");
                }
            }
        }

        public void SeniausiasAutomobilis()
        {
            int oldestYear = int.MaxValue;
            foreach (Automobilis a in automobiliai)
            {
                if (a.Metai < oldestYear)
                {
                    oldestYear = a.Metai;
                }
            }

            foreach (Automobilis a in automobiliai)
            {
                if (a.Metai == oldestYear)
                {
                    Console.WriteLine($"Pavadinimas: {a.Marke} {a.Modelis}, Metai: {a.Metai}, Registracijos Numeris: {a.Numeris}");
                }
            }
        }

        public void FiltravimasPagalMetus(int nuoMetai, int ikiMetai)
        {
            foreach (Automobilis a in automobiliai)
            {
                if (a.Metai >= nuoMetai && a.Metai <= ikiMetai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Marke} {a.Modelis}, Metai: {a.Metai}, Registracijos Numeris: {a.Numeris}");
                }
            }
        }

        public int AutomobiliuKiekis()
        {
            int kiekis = automobiliai.Count;
            return kiekis;
        }

        public void ArEgzistuoja(string numerisEgz)
        {
            bool arEgzistuoja = false;
            foreach (Automobilis a in automobiliai)
            {
                if (numerisEgz == a.Numeris)
                {
                    arEgzistuoja = true;
                }
            }

            if (arEgzistuoja == true)
            {
                Console.WriteLine($"Taip, automobilis su numeriu {numerisEgz} egzistuoja.");
            }
            else
            {
                Console.WriteLine($"Ne, automobilis su numeriu {numerisEgz} neegzistuoja.");
            }
        }

        public void AtnaujintiAutomobili(string numerisNaujinimui)
        {
            
            foreach (Automobilis a in automobiliai)
            {
                if (numerisNaujinimui == a.Numeris)
                {
                    Console.WriteLine("Iveskite automobilio marke:");
                    a.Marke = Console.ReadLine();
                    Console.WriteLine("Iveskite automobilio modeli:");
                    a.Modelis = Console.ReadLine();
                    Console.WriteLine("Iveskite automobilio gamybos metus:");
                    a.Metai = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Automobilio informacija atnaujinta");
        }
    }
}
