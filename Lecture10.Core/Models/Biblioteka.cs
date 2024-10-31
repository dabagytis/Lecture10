using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1.Core.Models
{
    public class Biblioteka
    {
        private List<Knyga> knygos = new List<Knyga>();

        public void PridetiKnyga(Knyga knyga)
        {
            knygos.Add(knyga);
        }

        public void TrintiKnyga (string kodasTrinimui)
        {
            Knyga x = new Knyga();
            foreach (Knyga a in knygos)
            {
                if (kodasTrinimui == a.Kodas)
                {
                    x = a;
                }
            }
            knygos.Remove(x);
        }

        public void RodytiKnygas()
        {
            foreach (Knyga a in knygos)
            {
                Console.WriteLine($"Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.Metai}, Kodas: {a.Kodas}");
            }
        }

        public void NaujausiaKnyga()
        {
            int newestYear = int.MinValue;
            foreach (Knyga a in knygos)
            {
                if (a.Metai > newestYear)
                {
                    newestYear = a.Metai;
                }
            }
            foreach (Knyga a in knygos)
            {
                if (newestYear == a.Metai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.Metai}, Kodas: {a.Kodas}");
                }
            }
        }

        public void SeniausiaKnyga()
        {
            int oldestYear = int.MaxValue;
            foreach (Knyga a in knygos)
            {
                if (a.Metai < oldestYear)
                {
                    oldestYear = a.Metai;
                }
            }
            foreach (Knyga a in knygos)
            {
                if (oldestYear == a.Metai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.Metai}, Kodas: {a.Kodas}");
                }
            }
        }

        public void FiltravimasPagalMetus(int nuoMetai, int ikiMetai)
        {
            foreach (Knyga a in knygos)
            {
                if (a.Metai >= nuoMetai && a.Metai <= ikiMetai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.Metai}, Kodas: {a.Kodas}");
                }
            }
        }

        public void PaieskaPagalKoda(string kodasPaieskai)
        {
            foreach (Knyga a in knygos)
            {
                if (a.Kodas == kodasPaieskai)
                {
                    Console.WriteLine($"Pavadinimas: {a.Pavadinimas}, Autorius: {a.Autorius}, Metai: {a.Metai}, Kodas: {a.Kodas}");
                }
            }
        }
    }
}
