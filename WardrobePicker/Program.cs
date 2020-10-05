using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "blue", "red", "green", "purple", "yellow" };
            string[] patterns = { "striped", "flowery", "floral", "polka dot", "checkered" };
            Random rnd = new Random();
            int index = rnd.Next(wardrobe.Length);
            int index2 = rnd.Next(colors.Length);
            int index3 = rnd.Next(patterns.Length);

            Console.WriteLine("Would you like help picking out an outfit?");
            string UserInput = Console.ReadLine();
            string Input = UserInput.ToLower();
            if (Input == "yes")
            {
                Console.WriteLine($"Today you should wear a {patterns[index3]} {colors[index2]} {wardrobe[index]}");
            }
            else if (Input == "no")
            {
                Console.WriteLine("Farewell!");
            }
            else
            {
                Console.WriteLine("You did not respond correctly");
            }
        }
    }
}
