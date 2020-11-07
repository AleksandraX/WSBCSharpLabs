using System;

namespace KacperTestCSharp
{
    public class Samochod
    {
        private static int _iloscSamochodow = 0;

        public string Marka { get; set; }

        public string Model { get; set; }

        public int IloscDrzwi { get; set; }
        
        public double SrednieSpalanie { get; set; }

        public double PojemnoscSilnika { get; set; }

        public Samochod()
        {
            this.Marka = "nieznana";
            this.Model = "nieznany";
            this.IloscDrzwi = 0;
            this.PojemnoscSilnika = 0.0;
            this.SrednieSpalanie = 0.0;
        }

        public Samochod(
            string marka, 
            string model, 
            int iloscDrzwi, 
            double pojemnoscSilnika, 
            double srednieSpalanie)
        {
            this.Marka = marka;
            this.Model = model;
            this.IloscDrzwi = iloscDrzwi;
            this.PojemnoscSilnika = pojemnoscSilnika;
            this.SrednieSpalanie = srednieSpalanie;
            _iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (this.SrednieSpalanie * dlugoscTrasy) / 100.0;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double x = ObliczSpalanie(dlugoscTrasy);
            return x * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + this.Marka);
            Console.WriteLine("Model: " + this.Model);
            Console.WriteLine("Ilość drzwi: " + this.IloscDrzwi);
            Console.WriteLine("Pojemnosc silnika: " + this.PojemnoscSilnika);
            Console.WriteLine("Średnie spalanie: " + this.SrednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość Samochodów: " + _iloscSamochodow);
        }
    }
}
