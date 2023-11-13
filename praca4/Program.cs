using System;
using System.Collections.Generic;

// Klasa reprezentująca produkt spożywczy
public class Produkt
{
    public string NazwaProducenta { get; set; }
    public string NazwaProduktu { get; set; }
    public string Kategoria { get; set; }
    public string KodProduktu { get; set; }
    public decimal Cena { get; set; }
    public string Opis { get; set; }
}

// Klasa reprezentująca adres
public class Adres
{
    public string Ulica { get; set; }
    public string KodPocztowy { get; set; }
    public string Miejscowosc { get; set; }
    public string NumerPosesji { get; set; }
    public string NumerLokalu { get; set; }
}

// Klasa reprezentująca magazyn
public class Magazyn
{
    public List<Produkt> Produkty { get; set; }
    public Adres AdresMagazynu { get; set; }

    public Magazyn()
    {
        Produkty = new List<Produkt>();
        AdresMagazynu = new Adres();
    }
}

class Program
{
    static void Main()
    {
        List<Magazyn> magazyny = new List<Magazyn>();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Dodaj nowy magazyn");
            Console.WriteLine("2. Edytuj istniejący magazyn");
            Console.WriteLine("3. Usuń magazyn");
            Console.WriteLine("4. Dodaj produkt do magazynu");
            Console.WriteLine("5. Usuń produkt z magazynu");
            Console.WriteLine("6. Wyjście");

            string opcja = Console.ReadLine();

            switch (opcja)
            {
                case "1":
                    // Dodawanie nowego magazynu
                    Magazyn nowyMagazyn = new Magazyn();
                    Console.Write("Podaj ulicę: ");
                    nowyMagazyn.AdresMagazynu.Ulica = Console.ReadLine();
                    // Pozostałe pola adresu analogicznie
                    magazyny.Add(nowyMagazyn);
                    Console.WriteLine("Dodano nowy magazyn.");
                    break;

                case "2":
                    // Edycja magazynu
                    Console.Write("Podaj indeks magazynu do edycji: ");
                    int indeks = int.Parse(Console.ReadLine());
                    if (indeks >= 0 && indeks < magazyny.Count)
                    {
                        // Analogicznie, edytuj dane magazynu
                        Console.WriteLine("Zaktualizowano dane magazynu.");
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy indeks magazynu.");
                    }
                    break;

                case "3":
                    // Usuwanie magazynu
                    Console.Write("Podaj indeks magazynu do usunięcia: ");
                    indeks = int.Parse(Console.ReadLine());
                    if (indeks >= 0 && indeks < magazyny.Count)
                    {
                        magazyny.RemoveAt(indeks);
                        Console.WriteLine("Usunięto magazyn.");
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy indeks magazynu.");
                    }
                    break;

                case "4":
                    // Dodawanie produktu do magazynu
                    Console.Write("Podaj indeks magazynu: ");
                    indeks = int.Parse(Console.ReadLine());
                    if (indeks >= 0 && indeks < magazyny.Count)
                    {
                        Produkt nowyProdukt = new Produkt();
                        Console.Write("Podaj nazwę producenta: ");
                        nowyProdukt.NazwaProducenta = Console.ReadLine();
                        // Analogicznie, edytuj pozostałe dane produktu
                        magazyny[indeks].Produkty.Add(nowyProdukt);
                        Console.WriteLine("Dodano produkt do magazynu.");
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy indeks magazynu.");
                    }
                    break;

                case "5":
                    // Usuwanie produktu z magazynu
                    Console.Write("Podaj indeks magazynu: ");
                    indeks = int.Parse(Console.ReadLine());
                    if (indeks >= 0 && indeks < magazyny.Count)
                    {
                        Console.Write("Podaj indeks produktu do usunięcia: ");
                        int indeksProduktu = int.Parse(Console.ReadLine());
                        if (indeksProduktu >= 0 && indeksProduktu < magazyny[indeks].Produkty.Count)
                        {
                            magazyny[indeks].Produkty.RemoveAt(indeksProduktu);
                            Console.WriteLine("Usunięto produkt z magazynu.");
                        }
                        else
                        {
                            Console.WriteLine("Nieprawidłowy indeks produktu.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nieprawidłowy indeks magazynu.");
                    }
                    break;

                case "6":
                    // Wyjście z programu
                    return;

                default:
                    Console.WriteLine("Nieprawidłowa opcja.");
                    break;
            }
        }
    }
}