using System;

namespace ConsoleApp2
{
    class Program
    {
    public static double results;
        static void Main(string[] args)
        {
            
            Console.WriteLine("please Enter First num: ");
            string a = Console.ReadLine();
            Console.WriteLine("What do you want?: ");
            string b = Console.ReadLine();
            Console.WriteLine("please Enter Secound num: ");
            string c = Console.ReadLine();
            //Console.WriteLine("Your result {0}", Convert.ToDouble(a) + Convert.ToDouble (c));
            //double results;
            double firstnumber = Convert.ToDouble(a);
            //Console.WriteLine(firstnumber);
            double secondnumber = Convert.ToDouble(c);

            if (b == "+")
            {
                results = firstnumber + secondnumber;

            }
            else if (b == "-")
            {
                results = firstnumber - secondnumber;


            }
            else if (b == "x")
            {
                results = firstnumber * secondnumber;


            }
            else if (b == "/")
            {
                results = firstnumber / secondnumber;
            }
                
            else
            {
                Console.WriteLine("please check again");
            }
                Console.WriteLine(results);

        }
    }
}
