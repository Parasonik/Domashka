using System;

namespace Domashka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = "String";
            //var b = new[] {"String","Sring 2" };
            //Array();
            //Array_String();
            //Array_Stair();
            //Kartej();
            (int, int, int, char) Local_Function()
            { 
                int[] b = new int[] {5, 6, 7, 7, 10, 3};
                int max = b[0], min = b[0], sum =0;
                string a = "Stroka";
                char[] c = a.ToCharArray(); 
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] > max)
                    {
                        max = b[i];
                    }
                    if (b[i] < min)
                    {
                        min = b[i];
                    }
                    sum += b[i];

                }
                (int, int, int, char) t = (min, max, sum, c[0]);
                
                return t;
            }

            
            Console.WriteLine(Local_Function());
            Console.ReadKey();
        }
        static void Array()
        {
            int[,] arr = new int[3, 3];

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {

                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {

                    Console.Write($"{arr[i,j]}   ");
                }
                Console.WriteLine();
            }

        }
        static void Array_String()
        {
            String[] stroka = new string[5];
            for (int i = 0; i < 5; i++)
            {
                stroka[i] = Console.ReadLine();
            }
            foreach(string i in stroka)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine(stroka.Length);
            Console.Write($"Для для того что бы изменить элемент массива введите его номер и новый элемент:  ");
            int a = Convert.ToInt32(Console.ReadLine()) - 1;
            stroka[a] = Console.ReadLine();
            foreach (string i in stroka)
            {
                Console.Write($"{i} ");
            }
        } 
        static void Array_Stair()
        {
            double[][] arr = new double[3][];
            arr[0] = new double[2];
            arr[1] = new double[3];
            arr[2] = new double[4];
            for(int i =0; i< arr.Length; i++)
            {
                for(int j =0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            foreach (double[] row in arr)
            {
                foreach (double number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
            
        }
        static void Kartej()
        {
            
            (int, string, char, string, ulong) t = (5, "kartej", 'K', "Kartej", 94439493);
            Console.WriteLine(t.ToString());
            switch (Convert.ToInt32(Console.ReadLine()))
                {
                case 1: Console.WriteLine(t.Item1.ToString()); break;
                case 2: Console.WriteLine(t.Item2.ToString()); break;
                case 3: Console.WriteLine(t.Item3.ToString()); break;
                case 4: Console.WriteLine(t.Item4.ToString()); break;
                case 5: Console.WriteLine(t.Item5.ToString()); break;
            }
            var population = new Tuple<int, string, char, string, ulong>(5, "kartej", 'K', "Kartej", 94439493); 
            (int, int, double, char) t1 = (5, 5, 6, 'g');
            (int, int, int, char) t2 = (5, 5, 6, 'g');
            Console.WriteLine(t1 == t2);

        }

    }
}