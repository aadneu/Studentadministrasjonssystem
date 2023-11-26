using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        private string Name;
        private int Alder;
        private string Studieprogram;
        private int StudentID;

        public Student(string name, int alder, string studieprogram, int studentId)
        {
            Name = name;
            Alder = alder;
            Studieprogram = studieprogram;
            StudentID = studentId;
        }

        void SkrivUtInfo()
        {
            Console.WriteLine($"Navn: {Name}" +
                              $"Alder: {Alder}" +
                              $"Studieprogram: {Studieprogram}" +
                              $"StudentID: {StudentID}");
        }
    }
}
