using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    public enum Typ_Paliwa
    {
        Benzyna,
        Diesel,
        Elektryczny
    }
    internal class Samochod
    {
        private string Marka { get; set; }
        private string Model { get; set; }
        private int RokProdukcji { get; set; }
        private Typ_Paliwa Paliwo { get; set; }

        public Samochod()
        {
            Marka = "Nieznana";
            Model = "Nieznany";
            RokProdukcji = 0;
            Paliwo = Typ_Paliwa.Benzyna;

        }
        public Samochod(string marka, string model, int rokProdukcji, Typ_Paliwa paliwo)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
            Paliwo = paliwo;
        }

        public Samochod(string marka, string model, int rokProdukcji, string PaliwoString)
        {
            Marka = marka;
            Model = model;
            RokProdukcji = rokProdukcji;
            if (Enum.TryParse(PaliwoString, true, out Typ_Paliwa paliwo))
            {
                Paliwo = paliwo;
            }
            else
            {
                throw new ArgumentException("Nieprawidłowy typ paliwa");
            }
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Samochód: {Marka} {Model}, Rok produkcji: {RokProdukcji}, Typ paliwa: {Paliwo}");
        }
    }
}
