using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Fag
    {
        private String Fagkode;
        private string Fagnavn;
        private int AntallStudiepoeng;

        public Fag(string fagkode, string fagnavn, int antallStudiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {Fagkode}" +
                              $"Fagnavn: {Fagnavn}" +
                              $"Antall studiepoeng: {AntallStudiepoeng}");
        }
    }
}
