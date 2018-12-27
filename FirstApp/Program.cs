using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 1&2
            //Har barname ba click Ctrl+F5 Ejra mishavad
            //baraye namayesh

            //Console.WriteLine("Hello World!!!");
            #endregion

            #region 3
            //int,string,double,decimal

            //int num1;
            //num1 = 10000;

            //decimal mynum = 12.123434;

            //string name = "ali aalipour";

            //Console.WriteLine(num1);
            //Console.WriteLine(name);

            #endregion

            #region 4

            //int num1, num2;
            //num1 = 10;
            //num2 = 2;

            //int sum = num1 + num2;
            //int min = num1 - num2;
            //int div = num1 / num2;
            //int mul = num1 * num2;

            //Console.WriteLine("The Sum is: " + sum);
            //Console.WriteLine("The minus is: " + min);
            //Console.WriteLine("The Divided is: " + div);
            //Console.WriteLine("The mul is: " + mul);



            #endregion

            #region 5


            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int min = num1 - num2;
            int div = num1 / num2;
            int mul = num1 * num2;

            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The minus is: " + min);
            Console.WriteLine("The Divided is: " + div);
            Console.WriteLine("The mul is: " + mul);

            #endregion



            #region جلسه چهارم

            int i = 5;

            #region if



            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }

            #endregion


            #region if-else

            if (i == 10)
            {
                Console.WriteLine("i is 10");
            }
            else
            {
                Console.WriteLine("i is not 10");
            }

            #endregion


            #region switch
            switch (i)
            {
                case 1:
                    Console.WriteLine("i is 1");
                    break;
                case 2:
                    Console.WriteLine("i is 2");
                    break;
                case 3:
                    Console.WriteLine("i is 3");
                    break;
                case 5:
                    Console.WriteLine("i is 5");
                    break;
                default:
                    Console.WriteLine("Default number apear");
                    break;
            }
            #endregion


            #region Ternary operator

            int x = 10;
            int y = 5;

            var result = x > y ? "x is greater than y" : 
                "x is less than or equal to y";



            #endregion

            Console.ReadLine();

            #endregion
        }
    }
}
