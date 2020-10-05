using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "lose your smartphone", "fall in love", "buy youtube premium", "join the darkside" };

            Random ran = new Random();

            int index = ran.Next(predictions.Length);


            Console.WriteLine($"you will {predictions[index]}");
        }
    }
}
