using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsTest
{
    public class Class1
    {
        static int GetRandom()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 10);
            return value;
        }
        public static void Main()
        {
            Console.Write("N = ");
            string nVar = Console.ReadLine();
            int nVarConverted = Convert.ToInt32(nVar);
            int iter = 1;
            while (iter <= nVarConverted)
            {
                Console.WriteLine(GenerateString(iter));
                iter++;
            }
        }
        static string GenerateString(int iter)
        {
            var chars = "ABCDEFGHIKJKLMNOPQRSTUVWXYZ1";
            Random rnd = new Random(iter);
            int i = 0;
            int charQuan = rnd.Next(1, 10);
            string myString = "";
            while (i <= charQuan)
            {
                if (i < charQuan)
                {
                    myString = myString + chars[rnd.Next(chars.Length)] + "+";
                }
                else
                {
                    myString = myString + chars[rnd.Next(chars.Length)];
                }
                i++;
            }
            return myString;
        }
    }
}
