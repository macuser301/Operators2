using System;

namespace Operators2
{
    class Program
    {
        public static void identityChecker()
        {
            Console.WriteLine("Hello world!");
            string userName = "Rob Davis";
            Console.WriteLine("What is your full name?");
            string userName2 = Console.ReadLine();                                       // Sorry for the excessive coding I wanted to practice.
            if (userName2 == userName)
            {
                Console.WriteLine("Access Granted! Welcome back Rob!");
            }
            else
            {
                Console.WriteLine("Access Denied! I'm sorry your not Rob!");
            }





        }
        static void Main(string[] args)
        {








            int x = 9 + 1;
            int y = x++;                        // <-      operators example
            Console.WriteLine($"x: {x}");
            Console.WriteLine($"y: {y}");






            Max2();
            SocialSecurity2();
            SocialSecurity();
            identityChecker();
            Console.WriteLine("Give me a number to subtract.");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to subtract.");
            int num6 = int.Parse(Console.ReadLine());
            int minus = num5 - num6;
            Console.WriteLine($"with the subtraction of your two numbers the numerical value is {minus}.");


            Console.WriteLine(Multiply(25, 2));
            Console.WriteLine(divide(10, 5));
            Console.WriteLine(Multiply(11, 8));

            int a = 10;
            int b = a;
            int c;
            int d;
            d = 40;
            c = 21;
            a = 20;
            b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);



        }
        public static int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;


        }
        public static void SocialSecurity()
        {
            int userSocialNum = 123456789;
            Console.WriteLine("Please enter your social security number for account verification.");
            int userSocial1 = int.Parse(Console.ReadLine());
            if (userSocial1 == userSocialNum)
            {
                Console.WriteLine("Access Granted! You have accessed the Social Security network.");
            }
            else
            {
                Console.WriteLine("Access Denied to Social Security network.");
            }
        }
        public static bool SocialSecurity2()
        {
            int userSocialNum2 = 123456789;
            Console.WriteLine("Please enter your social security number for account verification.");
            int userSocial2 = int.Parse(Console.ReadLine());
            if (userSocial2 == userSocialNum2)
            {
                Console.WriteLine("Access Granted! You have accessed the Social Security network.");
                return true;
            }
            else
            {
                Console.WriteLine("Access Denied to Social Security network.");
                return false;

            }
        }
        public static int Multiply2(int x, int y)
        {

            return x * y;



        }
        public static void Max2()
        {     

            int a = 17;                            // <- Operators Exercise 1
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {

                Console.WriteLine(" is {quotient} remainder {remainder}");


            }

            double radius, area;                                            // Area of a circle
            Console.WriteLine("Enter the radius of the circle");
            radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("Area of the Circle with radius {0} is {1}", radius, area);

            
            var i = 3;
            var j = 4;                                                                        //Value of K
            var k = ++i * j++;
            Console.WriteLine($"{k}");  


        }
    }     
           
}   
