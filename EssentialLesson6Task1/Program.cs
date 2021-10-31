using EssentialLesson6Task1;
using System;

namespace EssentialLesson6Task1
{
    class Program
    {

        //        Задание
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется:
        //Создать статический класс Calculator, с методами для выполнения основных арифметических операций.
        //Написать программу, которая выводит на экран основные арифметические операции.

        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Plus(3, 5));
            Console.WriteLine(Calculator.Minus(3, 5));
            Console.WriteLine(Calculator.Devide(3, 5));
            Console.WriteLine(Calculator.Multiply(3, 5));

        }
    }
}
