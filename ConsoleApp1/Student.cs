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
