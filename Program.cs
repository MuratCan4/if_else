using System;

namespace if_else
{
    class Program
    {
        static void Main (string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >= 6 && time < 11)
            Console.WriteLine("Günaydın");
            else if (time <= 18)
            Console.WriteLine("İyi Akşamlar");
            else
            Console.WriteLine("İyi Gceler");

            int kilo = 88;
            string oneri = kilo <= 70 ? "Kilon Gayet iyi" : "Kilo Vermelisin";
            Console.WriteLine(oneri);
        }
    }
}