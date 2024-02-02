using System;
namespace Uppgift_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> talLista = new List<int>()
            {
                14,
                25,
                100107,
                49,
            };

            Console.WriteLine($"Det största talet i listan är {Max(talLista)}");
        }
        /// <summary>
        /// Returnerar det största talet i en lista med int
        /// </summary>
        /// <param name="lista">Listan som ska sökas igenom</param>
        /// <returns>int</returns>
        static int Max(List<int> lista)
        {
            int maxTal = int.MinValue;

            foreach (int i in lista)
            {
                if (i > maxTal)
                {
                    maxTal = i;
                }
            }

            return maxTal;
        }
    }
}