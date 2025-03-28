using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace loopprograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any no.");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
