using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
    public static void Main() {
        int z = int.Parse (Console.ReadLine());                                                   //Количество элементов
        int[] m = Array.ConvertAll<string, int> (Console.ReadLine().Split(), int.Parse);         // Создал массив
        int[] Prime = new int[z];                                                               // Создал массив для простых чисел
        int cnt = 0;                                                                           // Создал счетчик для простых чисел
        for(int i = 0; i < z; i++){                                                           // Пробегаюсь в цикле по всем элементам массива чисе
            bool tf = true;                                                                  // Создал флаг, отвечающий за добавление в Prime
            for(int j = 2; j < m[i]; j++) {                                                 // Проверка числа на простое или сложное
                if(m[i] % j == 0) {
                    tf = false;
                    break;
                }
            }
            if(tf == true && m[i] != 1) {                                             // Если флаг tf == true и не равняется одному, то оно добавляется Prime числа
                Prime[cnt] = m[i];
                cnt++;
            }
        }
        
        Console.WriteLine(cnt);
        for(int i = 0; i < cnt; i++) {
            Console.Write(Prime[i] + " ");
        }
    }
}




