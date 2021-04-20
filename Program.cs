using System;

namespace pattern {
    class Program {
        static void Main(string[] args) {
            for (int row = 1; row <= 10; row++) {
                for (int col = 1; col <= 10; col++) {
                    int mlply = row * col;
                    if ((row == 1) || (col == 1) || ((mlply > 20) && (mlply < 60))) {
                        Console.Write($"{mlply,4}" );
                    } else {
                        Console.Write("....");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
