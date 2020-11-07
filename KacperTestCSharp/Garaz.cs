using System;

namespace KacperTestCSharp
{
    public class Garaz
    {
        private int _pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;


        public string Adres { get; set; }

        public int Pojemnosc
        {
            get => _pojemnosc;
            set
            {
                _pojemnosc = value;
                samochody = new Samochod[_pojemnosc];
            }
        }

        public Garaz()
        {
            this.Adres = "nieznany";
            this.Pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres, int pojemnosc)
        {
            this.Adres = adres;
            this.Pojemnosc = pojemnosc;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (_pojemnosc == liczbaSamochodow)
            {
                Console.WriteLine("Garaż jest pełny");
            }
            else
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }

        }

        public Samochod WyprowadzSamochod()
        {

            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaz jest pusty");
            }
            else
            {
                liczbaSamochodow--;
                samochody[liczbaSamochodow] = null;
            }
            return samochody[liczbaSamochodow];
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Adres garażu:" + this.Adres);
            Console.WriteLine("Pojemność garażu: " + _pojemnosc);
            Console.WriteLine("Liczba samochodów w garażu: " + liczbaSamochodow);

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
