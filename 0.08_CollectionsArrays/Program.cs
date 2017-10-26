using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            string[] favFoods = new string[3];

            favFoods[0] = "ice cream";
            favFoods[1] = "Creme Fraiche";
            favFoods[2] = "Deconstructed Artichoke";

            //SILVER
            int[] numbers1 = new int[5] { 3, 7, 2, 5, 10 };
            int[] numbers2 = new int[5] { 1, 3, 6, 3, 4 };

            int[] numbers3 = new int[5];

            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
            }

            Console.WriteLine(numbers3[4]);

            //GOLD
            Random rnd = new Random();

            int[] randomNumbers = new int[10];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
                Console.WriteLine(randomNumbers[i]);
            }


        }
    }
}
