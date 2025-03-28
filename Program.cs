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
            //Loops
            ///1. while loop
            ///2. for loop
            ///3. do while loop
            ///4. foreach loop
            ///When to use:
            ///Loops are used when we need to execute same condition multiple time;
            ///Syntax:
            ///1.while loop
            ///Initializers
            ///while(codnition)
            ///{
            ///  Program line1
            ///  Program line2
            ///  Increment/Decrement
            ///} 
            ///1.WAP to print numbers from 1 to 10
            int num1 = 1;
            while(num1<=10)
            {
                Console.WriteLine(num1);
                num1++;
            }
            Console.WriteLine("------------------------------------------");
            ///2.WAP to print table of user defined number
            int tablenumber,i=1;
            Console.WriteLine("Please Enter Any Number");
            tablenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("For You");
            while (i<=10)
            {
                Console.WriteLine(tablenumber*i);
                i++;
            }
            Console.WriteLine("---------------User Entered Table---------------------------");
            ///3.WAP to print table of user defined number
            int table;
            i = 1;
            Console.WriteLine("Please Enter Any Number");
            table = Convert.ToInt32(Console.ReadLine());
            
            while (i <= 10)
            {
                if (i == 1)
                {
                    Console.WriteLine("For You");
                }
                Console.WriteLine(table * i);
                i++;
            }
            Console.WriteLine("-----------------Reverse Number-------------------------");
            ///4.WAP to print table of user defined number
            int reverse;
            Console.WriteLine("Please Enter Any Number");
            reverse = Convert.ToInt32(Console.ReadLine());

            while (reverse>0)
            {
                Console.WriteLine(reverse);
                reverse--;
            }
            Console.WriteLine("------------------For Loop------------------------");
            ///25.For Loop
            ///Syntax:
            ///for(initialization;condition;updation)
            ///{
            ///  statement1;
            ///  statement2
            ///}
            ///WAP to print even number upto 20
            int uservalue;
            Console.WriteLine("Please Enter Any Number");
            uservalue = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=uservalue;i++)
            {
                if(i%2==0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("------------------For Loop------------------------");

            ///WAP to print even number upto 20
            uservalue=0;
            Console.WriteLine("Please Enter Any Number");
            uservalue = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= uservalue; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }

            Console.WriteLine("------------------Power of Number Loop------------------------");
            ///2 penta=2x2x2x2x2
            ///WAP to print even number upto 20
            int basevalue, power, result=1;
            Console.WriteLine("Please Enter Base Number");
            basevalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Power Number");
            power = Convert.ToInt32(Console.ReadLine());
            //basevalue=3
            //power=4
            for (i = 1; i <= power; i++)
            {
                result=result* basevalue;
                
            }
            Console.WriteLine(power+" Power of "+basevalue+" is = "+result);
        }
    }
}
