using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int liczba = 2; // Zaczynamy od liczby 2
        int licznik = 0; // Licznik wypisanych liczb pierwszych

        while (licznik < n)
        {
            if (CzyLiczbaPierwsza(liczba))
            {
                Console.WriteLine(liczba);
                licznik++;
            }

            liczba++;
        }

        Console.ReadLine();
    }

    static bool CzyLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
