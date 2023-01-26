using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        public static List<int> list;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            list = new List<int>();
            list.Add(1);
            //list.Add(2);
            list.Add(3);
            list.Add(4);

            int resp = GetMedian();
            Console.WriteLine(resp);
        }

        public static int GetMedian()
        {
            double i = list.Count / 2;
            int pos = 0;
            if (list.Count % 2 == 0)
            {
                pos = (int)System.Math.Round(i - 1, MidpointRounding.AwayFromZero);
            }
            else
            {
                pos = (int)System.Math.Round(i, MidpointRounding.AwayFromZero);
            }
            return list[pos];
        }

        public static int solution(int n)
        {
            String numeros = n.ToString();
            char[] arrayNumeros = numeros.ToCharArray();

            int suma = 0;
            foreach (char numero in arrayNumeros)
            {
                Console.WriteLine("numero:  " + numero);
                suma += int.Parse(numero.ToString());
            }

            Console.WriteLine("suma:  " + suma);
            return suma;
        }
    }
}
