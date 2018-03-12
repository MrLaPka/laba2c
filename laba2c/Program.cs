using System;
using System.Text;

namespace laba2c
{
    class Program
    {
    static void Main(string[] args)
        {
            sbyte one = -1;
            short two = -2;
            int three = -3;
            long four = -9999999;
            byte five = 5;
            ushort six = 6;
            uint seven = 7;
            ulong eight = 10000000;
            float nine = 9;
            double ten = 10.0;
            bool eleven = true;
            char x = 'a';
            two = one;
            three = two;
            four = three;
            ten = nine;
            four = one;
            two = (short)one;
            three = (int)two;
            four = (long)three;
            ten = (double)nine;
            four = (long)one;
            object o = three;
            o = -1;
            three = (int)o;
            var variable = 3;//variable convert to int
            variable += 3;
            Console.WriteLine(variable);
            int? nullable = 7;
            Console.WriteLine(nullable.Value);
            char a = 'a';
            char b = 'b';
            if(a<b)
                Console.WriteLine("a<b");
            else if(a==b)
                Console.WriteLine("a=b");
            else
                Console.WriteLine("a>b");
            string s1 = "str1";
            string s2 = "str2";
            string s3 = "str1 str2 str3";
            Console.WriteLine(s1+s2+s3);
            s1 = s2;
            Console.WriteLine(s1);
            Console.WriteLine(s3.IndexOf(s1));
            string[] words = s3.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            s1 = "str1";
            s2 = s2.Insert(4, s1);
            Console.WriteLine(s2);
            s2 = s2.Remove(4, 4);
            Console.WriteLine(s2);
            string empty = "";
            string nul = null;
            Console.WriteLine(empty.Length);
            Console.WriteLine(nul);
            Console.WriteLine(String.IsNullOrEmpty(empty));
            Console.WriteLine(String.IsNullOrEmpty(nul));
            StringBuilder str = new StringBuilder("abcd");
            Console.WriteLine(str);
            str.Remove(0, 1);
            str.Remove(1, 1);
            str.Insert(0, s1);
            str.Insert(str.Length, s2);
            Console.WriteLine(str);
            int [,] array_in_matrix = { { 1,2},{3,4} };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (j == 2)
                        Console.WriteLine();
                    else
                    {
                        Console.Write("  {0}", array_in_matrix[i, j]);
                    }
                }
            }
            string [] mas2 = { "abc", "xyz", "qwe", "fdm" };
            for (int i = 0; i < mas2.Length; i++)
                Console.WriteLine(mas2[i]);
            Console.WriteLine("Какой элемент массива поменять?");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите новое значение элемента: ");
            string newstr = Console.ReadLine();
            if (number > mas2.Length)
                Console.WriteLine("Элемента под таким номером не существует!");
            else
                for (int i = 0; i < mas2.Length; i++)
                {
                    if (i + 1 == number)
                        mas2[i] = newstr;
                    Console.WriteLine(mas2[i]);
                }
            Console.WriteLine("Количество элементов массива равно {0}", mas2.Length);

            double[][] nums = new double[3][];
            nums[0] = new double[2];
            nums[1] = new double[3];
            nums[2] = new double[4];
            Console.WriteLine("Вводите массив: ");
            int count=1;
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<nums[i].Length;j++)
                {
                    Console.Write($"Введите {count} элемет массива: ");
                    nums[i][j] = double.Parse(Console.ReadLine());
                    count++;
                }
            }
            Console.WriteLine("Получившийся массив: ");
            foreach (double[] row in nums)
            {
                foreach (double numbers in row)
                {
                    Console.Write($"{numbers} \t");
                }
                Console.WriteLine();
            }
            var type1 = "string";
            var type2 = new []{ 1, 2, 3, 4, 5 };
            Console.WriteLine(type1);
            for (int i = 0; i < type2.Length; i++)
            {
                Console.Write($" {type2[i]}");
            }
            Console.WriteLine();
            int frst = 5;
            string scnd = "cort1";
            char thrd = 'l';
            string frth = "cort2";
            ulong fifth = 1234445687567;
            var cort1 = new Tuple<int, string, char, string, ulong>(frst, scnd, thrd, frth, fifth);
            Console.WriteLine(cort1);
            Console.WriteLine(cort1.Item1);
            Console.WriteLine(cort1.Item3);
            Console.WriteLine(cort1.Item4);
            (frst, scnd, thrd, frth, fifth) = cort1;
            Tuple<int, int, int, char> function(int[] arr1, string strstr)
            {
                int max = arr1[0];
                int min = arr1[0];
                int sum = 0;
                string c;
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (max < arr1[i])
                        max = arr1[i];
                    if (min > arr1[i])
                        min = arr1[i];
                    sum += arr1[i];
                }
                char letter = (char)strstr[0];
                return Tuple.Create<int, int, int, char>(max, min, sum, letter);
            }
            int[] arr2 = { 1, 2, 3, 4 };
            Console.WriteLine(function(arr2, s1));
        }
    }
}