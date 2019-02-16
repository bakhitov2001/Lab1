using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());                                      // Создал переменную хранящую количество элементов
            for(int i = 1; i <= n; i++) {                                              // Прохожу по элементам от 1 до n
                for(int r = 1; r <= i; r++) {                                         // прохожусь по элементам от 1 до i
                    Console.Write("[*]");
                }

                Console.WriteLine();
            }
        }
    }
}
