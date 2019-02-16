using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3 {
    class Program {
        static void Main(string[] args) {
            int kol = int.Parse(Console.ReadLine());                                                   // Создаю переменную хранящее количество элементов 
            int[] sbor = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);        // Создаю массив
            int[] kol2 = new int[kol*2];                                                             // Создаю массив количеством больше надвое
            int cnt = 0;                                                                            // Индекс элементов второго массива
            for(int i = 0; i < kol; i++) {                                                         // Прохожу по элементам веденного массива  
                kol2[cnt++] = sbor[i];                                                            // Дублирую каждый элемент первого массива во второй
                kol2[cnt++] = sbor[i];                                                           // Дублирую каждый элемент первого массива во второй
            }

            for(int i = 0; i < kol * 2; i++) {
                Console.Write(kol2[i] + " ");
                
            }
        }
    }
}
