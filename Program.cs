namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gok = 0;
            int gokTeller = 0;
            string j = "";

            Random random = new Random();

            int geheimGetal = random.Next(1, 101);

            while (gok != geheimGetal)
            {
                Console.WriteLine("Raad het geheime getal tussen 1 en 100");

                try
                {
                    gok = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }
                if (gok > 100 || gok < 1)
                {
                    Console.WriteLine("Gok mag niet hoger dan 100 worden of lager dan 1.");
                }
                else
                {
                    gokTeller++;

                    if (gok == geheimGetal)
                    {
                        Console.WriteLine("Gefeliciteerd je hebt het geheime getal geraden.");

                        Console.WriteLine($"Je hebt {gokTeller} keer geraden.");

                        Console.WriteLine("Wil je nog een keer spelen? (j/n)");

                        j = Console.ReadLine().ToLower();

                        if (j == "j")
                        {
                            gok = 0;
                            gokTeller = 0;
                            geheimGetal = random.Next(1, 101);
                            Console.WriteLine("Jouw nieuwe spel begint opnieuw succes!");
                        }
                        else if (j == "n")
                        {
                            Console.WriteLine("Bedankt voor het spelen!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Ongeldige invoer. Voer 'j' of 'n' in.");
                        }
                    }
                    else if (gok > geheimGetal)
                    {
                        Console.WriteLine("Het geheime getal is lager dan je gok.");
                    }
                    else
                    {
                        Console.WriteLine("Het geheime getal is hoger dan je gok.");
                    }
                }
            }
        }
    }  
}