using System;
class Klasa
{
    static void Main()
    {
        Console.WriteLine("test praktyczny 2025 czerwiec zad 2");

        Console.WriteLine("Podaj cyfrę, o ile miejsc słowo ma być zaszyfrowane: ");
        int przesuniecie = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj słowo do zaszyfrowania: ");
        string slowo = Console.ReadLine();

        string wynik = Szyfruj(przesuniecie, slowo);

        Console.WriteLine("\nZaszyfrowany tekst: ");
        Console.WriteLine(wynik);

        Console.ReadKey();
    }

    static string Szyfruj(int przesuniecie, string slowo)
    {
        przesuniecie = przesuniecie % 26;
        char[] wynik = new char[slowo.Length];

        for (int i = 0 ; i < slowo.Length; i++)
        {
            char znak = slowo[i];

            if (znak == ' ')
            {
                wynik[i] = ' ';
                continue;
            }

            int pozycja = znak - 'a';
            int nowaPozycja = (pozycja + przesuniecie + 26) % 26;

            wynik[i] = (char)('a' + nowaPozycja);
        }

        return new string(wynik);
    }
}