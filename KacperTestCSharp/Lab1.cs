using System;

namespace KacperTestCSharp
{
    //Zadanie 1
    public class Samochod
    {
        private string marka, model;
        private int iloscDrzwi;
        private double pojemnoscSilnika, srednieSpalanie;
        private static int iloscSamochodow = 0;


        public string Marka
        {
            get { return Marka; }
            set { marka = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public double PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0.0;
            srednieSpalanie = 0.0;
        }


        public Samochod(string marka_, string model_, int iloscDrzwi_, double pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
            iloscSamochodow = iloscSamochodow + 1;
        }


        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy) / 100.0;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double x = ObliczSpalanie(dlugoscTrasy);
            return x * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość Drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemnosc Silnika: " + pojemnoscSilnika);
            Console.WriteLine("Srednie Spalanie: " + srednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość Samochodów: " + iloscSamochodow);
        }
    }




//Zadanie 2
public class Garaz
    {
        private string _adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;



        public string Addres { get; set; }

        public int Pojemnosc
        {
            get  => pojemnosc; 
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public Garaz()
        {
            Addres = "nieznany";
            pojemnosc = 0;
            samochody = null;
        }

        public Garaz(string adres, int pojemnosc)
        {
            this.Addres = adres;
            this.Pojemnosc = pojemnosc;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {

            if (pojemnosc == liczbaSamochodow)
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
            Console.WriteLine("Adres Garażu:" + Addres);
            Console.WriteLine("Pojemność Garażu:" + pojemnosc);
            Console.WriteLine("Liczba Samochodów w garażu:" + liczbaSamochodow);

            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody[i].WypiszInfo();
            }
        }
    }
}
