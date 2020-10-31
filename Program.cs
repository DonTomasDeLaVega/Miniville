using System;

namespace MiniVille
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien de cartes voulez-vous dans le paquet?");

            int input;
            while (true)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre valide!");
                }
            }
            Console.WriteLine("");
            Game game = new Game(input);
            game.DispDiffCards();
            Console.Read();
        }
    }
}
