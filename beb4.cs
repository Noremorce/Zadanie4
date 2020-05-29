using System;
using System.Collections;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj = new ArrayList() { 16, 22.8, 1, "a", 6.6, "b", "C", "D",666, 2, "f", "G", 66, 15.5, 0 };
            ArrayList objUpper = new ArrayList(100);

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
            Console.WriteLine();

            for (int i = 0; i < obj.Count; i++)
            {
                if (obj[i] is string)
                {
                    obj.RemoveAt(i);
                    if (obj[i] is string) i--;
                }
            }

            for (int i = 0; i < obj.Count; i++)
            {
                Console.Write(obj[i] + " | ");
            }
        }
    }
}