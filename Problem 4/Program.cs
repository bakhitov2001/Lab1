﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                for(int r = 1; r <= i; r++) {
                    Console.Write("[*]");
                }

                Console.WriteLine();
            }
        }
    }
}
