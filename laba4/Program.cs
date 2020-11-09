using System;
using System.Buffers;
using System.Data;
using System.IO;
namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {

            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int[] mas = new int[N];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-100000, 100000);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            //Среднее арифм отрицательных чисел
            double sp = 0;
            int k = 0, s=0;
            for (int i = 0; i < mas.Length; i++) {
                
                if (mas[i] < 0)
                {
                    sp += mas[i];
                    k += 1;
                }
                
            }
            
            if (sp/k < 0) Console.WriteLine($"Среднее значение отрицательных чисел: {sp/k}");
            else Console.WriteLine("0");


            //минимальное положительное число
            int min = 100001;
            for (int i = 0; i < mas.Length; i++) {
                if (mas[i] > 0) { 
                    if (mas[i] < min) min = mas[i]; 
                }
                
            }
            Console.WriteLine($"минимальное положительное число: {min}");



            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
