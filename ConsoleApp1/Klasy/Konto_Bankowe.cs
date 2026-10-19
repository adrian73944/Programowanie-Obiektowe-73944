using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Klasy
{
    internal class Konto_Bankowe
    {
        private decimal _saldo;
        private int _liczbaOperacji;
        public string Wlasciciel { get; set; }
        public int Saldo
        {
            get { return (int)_saldo; }
            set
            {
                if(value <0)
                {
                    throw new ArgumentException("Saldo nie może być ujemne.");
                }
                else
                {
                    _saldo = value;
                }
            }
        }
        public int LiczbaOperacji
        {
            get { return _liczbaOperacji; }
        }

        public Konto_Bankowe()
        {
            Wlasciciel = "Nieznany";
            Saldo = 0;
        }

        public Konto_Bankowe(string wlasciciel, int saldo)
        {
            Wlasciciel = wlasciciel;
            Saldo = saldo;
        }

        public void Wplac(decimal kwota)
        {
            if(kwota<1)
            {
                throw new ArgumentException("Podana kwota jest nieprawidłowa");
            }
            else
            {
                _saldo += kwota;
                _liczbaOperacji++;
            }
        }
        public void Wyplac(decimal kwota)
        {
            if (kwota < 1)
            {
                throw new ArgumentException("Podana kwota jest nieprawidłowa");
            }
            else if(kwota > _saldo)
            {
                throw new ArgumentException("Brak wystarczających środków na koncie");
            }
            else
            {
                _saldo -= kwota;
                _liczbaOperacji++;
            }
            
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Właściciel: {Wlasciciel}, Saldo: {_saldo}, Liczba operacji: {_liczbaOperacji}");
        }

    }
}
