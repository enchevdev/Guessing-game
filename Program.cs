namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gok = 0;
            int gokTeller = 0;

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

    

