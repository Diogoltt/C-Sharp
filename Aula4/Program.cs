using System;
namespace Aula4 {
    class Program {
        static void teste() {
            /*
            for (int i = 0; i < 10; i++) {
                System.Console.WriteLine($"Hello, World {i}");
            }
            */

            /*
            int i = 0;
            while (i < 10) {
                System.Console.WriteLine($"Hello, World {i}");
                i++;
            }
            */

            int x = 0;
            do {
                System.Console.WriteLine($"Hello, World {x}");
                x++;
            } while (x < 10);
        }
    }
}