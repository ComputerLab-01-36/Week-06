using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Your are number:"); //   รับค่าจากคีย์บอร์ด
            
            a = int.Parse(Console.ReadLine());
            pass(a);
            Console.ReadLine();

        }
        static void pass(int A)
        {

            if ((A % 2) == 0)
            {

                Console.WriteLine("{0} is even", A);
            }
            else
            {
                Console.WriteLine("{0} is odd", A);
            }
        }

        
                
            
        
    }
}
