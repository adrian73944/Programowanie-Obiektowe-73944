using ConsoleApp1.Klasy;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Samochod samochod1 = new Samochod("Toyota", "Corolla", 2020, Typ_Paliwa.Benzyna);
            //Samochod samochod2 = new Samochod("Audi", "A6", 2011, Typ_Paliwa.Diesel);
            //Samochod samochod3 = new Samochod("Mercesed", "EQA", 2025, "benzyna");

            //samochod1.WyswietlInformacje();
            //samochod2.WyswietlInformacje();
            //samochod3.WyswietlInformacje();

            Konto_Bankowe konto_Bankowe1 = new Konto_Bankowe("Jan Kowalski", 1000);
            Konto_Bankowe konto_Bankowe2 = new Konto_Bankowe("Anna Nowak", 200);

            konto_Bankowe1.Wplac(500);
            konto_Bankowe2.Wyplac(100);
            konto_Bankowe1.WyswietlInformacje();
            konto_Bankowe2.WyswietlInformacje();        


        }

    }
}
