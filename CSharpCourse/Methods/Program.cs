﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            //var result = Add2(1,2);

            //int number1 = 20;
            //int number2 = 30;
            //var result2 = Add3(number1,number2);
            //Console.WriteLine(Multiply(2, 4));
            //Console.WriteLine(result2);
            //Console.WriteLine(result);
            Console.WriteLine(Add4(1,2,3,4,5,6,7,8,9));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Eklendi!");
        }

        static int Add2(int sayi1,int sayi2)
        {
            var result =  sayi1 + sayi2;
            return result;
        }
        static int Add3(int number1, int number2)
        {
            
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Add4(int number,params int[] numbers) 
        {
            return numbers.Sum();
        }
    }
}
