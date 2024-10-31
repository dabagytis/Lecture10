using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_1.Core.Models
{
    public class Knyga
    {
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int Metai { get; set; }
        public string Kodas { get; set; }

        public Knyga()
        {

        }

        public Knyga(string pavadinimas, string autorius, int metai, string kodas)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Metai = metai;
            Kodas = kodas;
        }
    }
}
