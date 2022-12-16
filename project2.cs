using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("enter ur 1st num:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ur last num: ");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i <= n2; i++)
            {
                if (isperfect(i)) Console.WriteLine(i);
            }


            







        }
        static bool isperfect (int num)
        {

            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0) sum += i;
            }if (sum == num) return true ;
            return false;

        }
    }
}
