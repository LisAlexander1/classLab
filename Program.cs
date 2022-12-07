//Чиннов 22-ИСП-2/1 Средний 19 вариант
using System;

namespace classLab
{
    internal class Program
    {
        static string VectorToString(double[] coords)
        {
            string result = "";
            for (int j = 0; j < coords.Length; j++)
            {

                switch (j)
                {
                    case 0: result = ("x1="); break;
                    case 1: result = ("y1="); break;
                    case 2: result = ("x2="); break;
                    case 3: result = ("y2="); break;
                }
                result += $"{coords[j]:F2}";
            }
            return result;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Vector[] vectors = {
                new(),
                new(r.NextDouble()*50-25,r.NextDouble()*50-25),
                new(r.NextDouble()*50-25,r.NextDouble()*50-25,r.NextDouble()*50-25,r.NextDouble()*50-25),
            };

            for (int i = 0; i < vectors.Length; i++)
            {
                Console.WriteLine(VectorToString(vectors[i].GetCoords()));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(VectorToString(vectors[i].GetDoubleLength()));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{vectors[i].GetAreaRightTriangle():F2}");
                Console.ResetColor();
                Console.WriteLine();
            }

        }
    }
}