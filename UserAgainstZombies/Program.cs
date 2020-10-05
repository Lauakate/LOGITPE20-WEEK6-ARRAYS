using System;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userBag = new string[5];
            int i = 0;
            while(i < userBag.Length)
            {
                Console.WriteLine("Please enter the name of five objects from your bag");
                userBag[i] = Console.ReadLine();
                i++;
            }
            Random rndTEACH = new Random();

            Console.WriteLine($"In case of a zombie apocalypse you will have to fight zombies with a {userBag[rndTEACH.Next(0, userBag.Length)]}");

            /*/
            Console.WriteLine("Please enter the name of five objects from your bag");
            Console.WriteLine("1.");
            string Input1 = Console.ReadLine();
            Console.WriteLine("2.");
            string Input2 = Console.ReadLine();
            Console.WriteLine("3.");
            string Input3 = Console.ReadLine();
            Console.WriteLine("4.");
            string Input4 = Console.ReadLine();
            Console.WriteLine("5.");
            string Input5 = Console.ReadLine();

            string[] Objects = { Input1, Input2, Input3, Input4, Input5 };

            Random rnd = new Random();
            int index = rnd.Next(Objects.Length);

            Console.WriteLine($"In case of a zombie apocalypse you will have to fight zombies with a {Objects[index]}");
            /*/
        }
    }
}
