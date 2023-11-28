using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name;
        private int Alder;
        private string Studieprogram;
        private int StudentID;
        public List<Fag> Fagliste = new List<Fag>();

        public void LeggTilFag(Fag fag)
        {
            Fagliste.Add(fag);
        }
        public void LeggTilKarakter(Fag fag, int karakterverdi)
        {
            Karakter karakter = new Karakter(this, fag, karakterverdi);
            fag.LeggTilKarakter(karakter);
        }
        public int BeregnStudiePoeng()
        {
            int StudiePoeng = 0;
            foreach (Fag fag in Fagliste)
            {
                StudiePoeng += fag.AntallStudiepoeng;
            }
            return StudiePoeng;
        }
        public double BeregnKarakterSnitt()
        {
            double KarakterSum = 0;
            foreach (Fag fag in Fagliste)
            {
                foreach (Karakter karakter in fag.Karakterliste)
                {
                    KarakterSum += karakter.Karakterverdi;
                }
            }
            double KarakterSnitt= KarakterSum/Fagliste.Count;
            return KarakterSnitt;
        }

        public void SkrivUtKarakterInfo()
        {
            foreach (Fag fag in Fagliste)
            {
                foreach (Karakter karakter in fag.Karakterliste)
                {
                    karakter.SkrivUtInfo();
                }
            }
        }

        public Student(string name, int alder, string studieprogram, int studentId)
        {
            Name = name;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentId;
        }

        public void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Name} \n" +
                              $"Alder: {Alder} \n" +
                              $"Studieprogram: {Studieprogram} \n" +
                              $"StudentID: {StudentID} \n");
        }

        
    }
}
