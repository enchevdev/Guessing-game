using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int gok = 0;



            Random number = new Random();

            int geheimGetal =

            number.Next(1, 101);
            Console.WriteLine("Raad het geheime getal tussen 1 en 100");
            gok = int.Parse(Console.ReadLine());
        }
    }
}
