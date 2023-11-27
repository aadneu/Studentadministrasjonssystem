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
        private Student _student;
        private Fag _fagnavn;
        private int _karakterverdi;

        public Karakter(Student student, Fag fagnavn, int karakterverdi)
        {
            _student = student;
            _fagnavn = fagnavn;
            _karakterverdi = karakterverdi;
        }
        public void SkrivUtInfo()
        {
            Console.WriteLine($"Student: {_student.Name} \n" +
                              $"Fag: {_fagnavn.Fagnavn} \n" +
                              $"Karakter: {_karakterverdi} \n");
        }
    }
}
