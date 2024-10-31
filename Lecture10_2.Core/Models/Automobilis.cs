using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture10_2.Core.Models
{
    public class Automobilis
    {
        public string Marke { get; set; }
        public string Modelis { get; set; }
        public int Metai { get; set; }
        public string Numeris { get; set; }

        public Automobilis()
        {

        }

        public Automobilis(string marke, string modelis, int metai, string numeris)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Numeris = numeris;
        }
    }
}
