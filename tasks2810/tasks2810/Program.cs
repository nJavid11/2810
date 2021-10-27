using System;

namespace tasks2810
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s= task1();       //task1
            //Console.WriteLine(s);

            //Console.WriteLine("enter the 1st number");      //task2
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the 2nd number");
            //int b = Convert.ToInt32(Console.ReadLine());
            //String s = task2(a,b);
            //Console.WriteLine(s);

            //Console.Write("Please enter the number: ");       task3
            //int num = Convert.ToInt32(Console.ReadLine());
            //int res = task3(num);
            //Console.Write("The result is: ");
            //Console.WriteLine(res);

            //console.write("please enter the number: ");       //task4
            //int num = convert.toint32(console.readline());
            //int res = task4(num);
            //console.write("the result is: ");
            //console.writeline(res);

            //Console.Write("Please enter the number: ");     //task5
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter the index: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //int res = task5(num, index);
            //Console.Write("the digit is: ");
            //Console.WriteLine(res);

            //Console.Write("Please enter the number: ");       //task6
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("binary is " + task6(num));

            //Console.Write("Please enter the number: ");     //task7
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Cube of the number is "+cube(num));

            //Console.Write("Please enter the number: ");     //task8
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Number has {task8(num)} digit(s)");

            //Console.Write("Please enter the range of series: ");     //task9
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Sum = "+task9(num));

            //Console.Write("Please enter the size: ");     //task10
            //int num = Convert.ToInt32(Console.ReadLine());
            //pattern(num);



        }

        #region task1
        public static string task1()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                return "The 1st number is the greatest among three";
            }

            if (b > a && b > c)
            {
                return "The 2nd number is the greatest among three";
            }

            if (c > a && c > b)
            {
                return "The 3nd number is the greatest among three";
            }
            return "";
        }
        #endregion

        #region task2
        public static string task2(int a, int b)
        {
            if (a > b)
            {
                return $"the bigger one is {a}, smaller is {b}";
            }
            else
            {
                return $"the bigger one is {b}, smaller is {a}";
            }
        }
        #endregion

        #region task3
        public static int task3(int num)
        {
            int mod;
            int sum = 0;

            while (num != 0)
            {
                mod = num % 10;
                sum = sum + mod;
                num = num / 10;
            }
            return sum;
        }
        #endregion

        #region task4
        public static int task4(int num)
        {
            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
        #endregion

        #region Task5       
        public static int task5(int num, int index)
        {

            int mod;
            int i = 0;

            while (num != 0)
            {
                mod = num % 10;
                i++;
                if (i == index)
                {
                    return mod;
                }
                num = num / 10;
            }
            return 0;
        }
        #endregion

        #region task6
        public static string task6(int num)
        {
            int mod;
            string res = "";
            while (num > 0)
            {
                mod = num % 2;
                num /= 2;
                res = mod.ToString() + res;
            }

            return res;
        }
        #endregion

        #region Task7
        public static int cube(int a)
        {
            return a * a * a;
        }
        #endregion

        #region task8
        public static int task8(int num)
        {
            int mod;
            int count = 0;

            while (num != 0)
            {
                mod = num % 10;
                count++;
                num = num / 10;
            }
            return count;
        }
        #endregion

        #region Task9
        public static int task9(int n)
        {
            int res = 2;
            int sum = 2;
            for (int i = 2; i <= n; i++)
            {
                res = (res * 10) + 2;
                sum = sum + res;
            }
            if (n == 0)
            {
                return 0;
            }
            return sum;
        }
        #endregion

        #region Task10
        public static void pattern(int n)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j < n && j <= i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
        #endregion
    }
}
