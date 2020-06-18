using System;

namespace Volume_Silinder
{
    class Program
    {
        static void Main()
        {
            double JARI, TINGGI, DIAMETER, LUASALAS, VOLUME;
            Console.WriteLine("\n Menghitung Luas Silinder \n");
            Console.Write("\n Jari - Jari       = ");
            JARI = double.Parse(Console.ReadLine());
            Console.Write(" Tinggi            = ");
            TINGGI = double.Parse(Console.ReadLine());
            DIAMETER = JARI * 2;
            LUASALAS = JARI * JARI * 22 / 7;
            VOLUME = LUASALAS * TINGGI;
            Console.Write("\n Diameter          = " + DIAMETER);
            Console.Write("\n Luas Alas         = " + LUASALAS);
            Console.Write("\n Volume Silinder   = " + VOLUME);
            Console.ReadKey();
        }
    }
}
