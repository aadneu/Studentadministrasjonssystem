using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Karakter
    {
        public Student Student;
        public Fag Fag;
        public double Karakterverdi;

        public Karakter(Student student, Fag fagnavn, double karakterverdi)
        {
            Student = student;
            Fag = fagnavn;
            Karakterverdi = karakterverdi;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {Student.Name} \n" +
                              $"Fag: {Fag.Fagnavn} \n" +
                              $"Karakter: {Karakterverdi} \n");
        }
    }
}
