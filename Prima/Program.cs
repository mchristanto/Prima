using System;

namespace Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            var angka = 0;
            Console.Write("Masukkan angka : ");
            angka = Convert.ToInt32(Console.ReadLine());
          
                if ((angka % 2 == 1) && (angka / angka == 1))
                {
                    Console.WriteLine("Bilangan Prima");
                }
                else 
                {
                    Console.WriteLine("Bukan Bilangan Prima");
                }
        }
    }
}
