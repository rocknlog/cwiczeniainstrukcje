using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 10; 

        Console.WriteLine("Wersja 1 - Losowanie z sprawdzaniem:");
        LosowanieZeSprawdzaniem(n);

        Console.WriteLine("\nWersja 2 - Losowanie bez sprawdzania:");
        LosowanieBezSprawdzania(n);

        Console.ReadLine();
    }

    static void LosowanieZeSprawdzaniem(int n)
    {
        Random random = new Random();
        int licznik = 0;
        string wyniki = "";

        while (licznik < n)
        {
            int liczba = random.Next(-8, 9);

            if (liczba % 2 == 0)
            {
                wyniki += liczba + ", ";
                licznik++;
            }
        }

        wyniki = wyniki.TrimEnd(',', ' ');
        Console.WriteLine(wyniki);
        Console.WriteLine("Ilość faktycznych losowań: " + licznik);
    }

    static void LosowanieBezSprawdzania(int n)
    {
        Random random = new Random();
        int licznik = 0; 
        string wyniki = "";

        while (licznik < n)
        {
            int liczba = random.Next(-4, 5) * 2;

            wyniki += liczba + ", ";
            licznik++;
        }

        wyniki = wyniki.TrimEnd(',', ' ');
        Console.WriteLine(wyniki);
        Console.WriteLine("Ilość faktycznych losowań: " + licznik);
    }
}
