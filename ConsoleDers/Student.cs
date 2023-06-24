using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDers
{
    internal class Student
    {

        private static int _numberCounter = 0;
        private static int NumberCounter { get { return ++_numberCounter; } }

        public int Number { get; }

        public string Name;
        public string Surname;

        private char _classRoom;
        private int _classChangeCounter = 0;
        public char ClassRoom
        {
            get { return _classRoom; }
            set
            {
                _classChangeCounter++;
                _classRoom = value;
            }
        }


        public Student(string name, string surname, char classRoom)
        {
            Number = Student.NumberCounter;
            Name = name;
            Surname = surname;
            _classRoom = classRoom;
        }

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
        public void Print()
        {
            Console.WriteLine("Öğrenci numarası: "+Number);
            Console.WriteLine("Öğrenci tam adı: " + GetFullName());
            Console.WriteLine("Öğrenci sınıfı: "+ClassRoom);
            Console.WriteLine("---------------------------");

        }

    }
}
