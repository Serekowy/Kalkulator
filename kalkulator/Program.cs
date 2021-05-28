using System;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Wprowadź pierwszą liczbę: ");
                string pLiczba = Console.ReadLine();
                float liczba, wynik;
                bool spr = float.TryParse(pLiczba, out liczba);

            poczatek:

                while (!spr)
                {
                    WprowadzLiczbe();
                    Console.Write("Wprowadź pierwszą liczbę: ");
                    pLiczba = Console.ReadLine();
                    spr = float.TryParse(pLiczba, out liczba);
                }

                Console.Write("Wprowadź drugą liczbę: ");
                string dLiczba = Console.ReadLine();
                float liczbaD;
                spr = float.TryParse(dLiczba, out liczbaD);

                while (!spr)
                {
                    WprowadzLiczbe();
                    Console.Write("Wprowadź drugą liczbę: ");
                    dLiczba = Console.ReadLine();
                    spr = float.TryParse(dLiczba, out liczbaD);
                }

                Console.Clear();

                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Zakończ działanie");
                Console.WriteLine("-----------------------");

                char wybor = Console.ReadKey().KeyChar;

                switch (wybor)
                {
                    case '1':
                        Console.Clear();
                        wynik = liczba + liczbaD;
                        Console.WriteLine("Wynik to: {0}", Math.Round(wynik, 2));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        wynik = liczba - liczbaD;
                        Console.WriteLine("Wynik to: {0}", Math.Round(wynik, 2));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        wynik = liczba * liczbaD;
                        Console.WriteLine("Wynik to: {0}", Math.Round(wynik, 2));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        if (liczba == 0 || liczbaD == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nie można dzielić przez zero!");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            goto poczatek;
                        }
                        else
                        {
                            Console.Clear();
                            wynik = liczba / liczbaD;
                            Console.WriteLine("Wynik to: {0}", Math.Round(wynik, 2));
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case '5':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Błędny wybór");
                        Console.ReadKey();
                        break;
                }
            }
            
        }
        static void WprowadzLiczbe()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Musisz wprowadzić liczbę!");
            Console.ResetColor();
        }
    }
}
