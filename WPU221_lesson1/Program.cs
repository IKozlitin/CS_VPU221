﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WPU221_lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //******1*****
            double x = 3.3;
            double y = 7.7;

            int z = (int)x;
            WriteLine(z);
            //*************

            //*********2***************
            Write("Введите ваше имя: ");
            WriteLine("Введите ваше имя: ");
            string name;
            name = ReadLine();
            if (name == "")
            {
                WriteLine("Привет, мир!");
            }
            else
            {
                WriteLine("Привет, " + name);
            }
            //***************************

            //**************3***************
            Write("Введите целое число: ");
            string numberString = ReadLine();
            int number = Convert.ToInt32(numberString);
            int number1 = Int32.Parse(numberString);
            WriteLine("Число = " + number);
            WriteLine("Число = " + number1);
            //******************************
        }
    }
}
