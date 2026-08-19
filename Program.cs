namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gok = 0;
            int gokTeller = 0;


            Random number = new Random();

            int geheimGetal =

            number.Next(1, 101);
            
            



            while (gok != geheimGetal)
            {
                Console.WriteLine("Raad het geheime getal tussen 1 en 100");
                

                try
                {
                    gok = int.Parse(Console.ReadLine());
                    gokTeller++;
                }

                catch (FormatException)
                {
                    Console.WriteLine("Ongeldige invoer. Voer een geldig getal in.");
                    continue;
                }

                if (gok == geheimGetal)
                {
                    Console.WriteLine("Gefeliciteerd je hebt het geheime getal geraden.");
                    Console.WriteLine($"Je hebt {gokTeller} keer geraden.");
                    
                }

                else if (gok > geheimGetal)
                {
                    Console.WriteLine("Het geheime getal is lager dan je gok.");
                   
                }
                else if (gok < geheimGetal)
                {
                    Console.WriteLine("Het geheime getal is hoger dan je gok.");
                    
                }
               
            }
        }
    }
}

    

