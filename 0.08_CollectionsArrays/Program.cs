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

            favFoods[0] = "Ice Cream";
            favFoods[1] = "Creme Fraiche";
            favFoods[2] = "Deconstructed Artichoke";

            foreach (string food in favFoods)
            {
                Console.WriteLine(food);
            }

            //Silver
            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };

            int[] numbers3 = new int[5];

            //using a for loop to create the array
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
            }

            //using a foreach loop to display the array
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            //GOLD
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next(100);
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
