using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter ur 1st name: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ur last name: ");
            int n2 = int.Parse(Console.ReadLine());
            int num, count, prime, temp;
            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }
            for (num = n1; num <= n2; num++)
            {
                if (num == 1||num==0)
                {
                    if (num == 0) num += 2;
                    else num += 1;
                }
                   

                prime = 1;
                for (count = 2; count < num; count++)
                {
                    if(num%count == 0)
                    {
                        prime = 0;
                        break;
                    }
                   
                }
                if (prime == 1)
                {
                    Console.WriteLine(num);
                   
                }
            }






        }
    }
}
