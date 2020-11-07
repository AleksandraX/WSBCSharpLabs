using System;

namespace KacperTestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadnie nr 1: ");
            Console.WriteLine();
            Zadanie1();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Zadanie nr 2: ");
            Console.WriteLine();
            Zadanie2();
            Console.ReadLine();
        }


        public static void Zadanie1()
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();

            s1.Marka = "Fiat";
            s1.Model = "126p";
            s1.IloscDrzwi = 2;
            s1.PojemnoscSilnika = 650;
            s1.SrednieSpalanie = 6.0;
            s1.WypiszInfo();

            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);
            s2.WypiszInfo();

            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine($"Koszt przejazdu: {kosztPrzejazdu:0.00}zł");

            Samochod.WypiszIloscSamochodow();
        }

        public static void Zadanie2()
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

            Garaz g1 = new Garaz {Adres = "ul. Garażowa 1", Pojemnosc = 1};
            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();

            g1.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();
            g2.WypiszInfo();
        }
    }
}
