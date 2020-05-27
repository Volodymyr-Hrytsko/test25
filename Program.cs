
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program 
    {
        static 
            int suma (string s)
        {
            Char[] c = s.ToCharArray();
            int[] n = new int[s.Length];
            int sum = 0;
            for (int i = 0; i<s.Length; i++)
            {
                n[i] = Convert.ToInt32(c[i]);
                sum += n[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine("{0}", suma(s));
        }
    }
}
