using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wysokość trójkąta: ");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        RysujTrojkat(wysokosc);

        Console.ReadLine();
    }

    static void RysujTrojkat(int wysokosc)
    {
        int szerokosc = wysokosc * 2 - 1;

        for (int i = 0; i < wysokosc; i++)
        {
            int iloscZnakow = i * 2 + 1;
            int iloscSpacji = (szerokosc - iloscZnakow) / 2;

            string wiersz = new string(' ', iloscSpacji) + new string('+', iloscZnakow);

            Console.WriteLine(wiersz);
        }
    }
}
