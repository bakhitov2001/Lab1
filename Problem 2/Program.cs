using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2 {
    class Program {
        static void Main(string[] args) {
            Student stu = new Student("Bakhitov Berik", 12345678);
            stu.Pozvatb();
        }
    }

    class Student {
        string name;
        int id;
        int year;

        public Student(string name, int id) {
            this.name = name;
            this.id = id;
            year = 2019;
        }

        public void Pozvatb() {
            Console.WriteLine("Klichka: {0} Id: {1}", name, id);
            year++;
        }
    }   
}
