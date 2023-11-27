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
        private string Fagkode;
        public string Fagnavn;
        private int AntallStudiepoeng;

        public Fag(string fagkode, string fagnavn, int antallStudiepoeng)
        {
            Fagkode = fagkode;
            Fagnavn = fagnavn;
            AntallStudiepoeng = antallStudiepoeng;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Fagkode: {Fagkode} \n" +
                              $"Fagnavn: {Fagnavn} \n" +
                              $"Antall studiepoeng: {AntallStudiepoeng} \n");
        }
    }
}
