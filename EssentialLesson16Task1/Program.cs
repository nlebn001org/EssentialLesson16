using System;

namespace EssentialLesson16Task1
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте структуру описывающую точку в трехмерной системе координат.Организуйте возможность сложения двух точек, через использование перегрузки оператора +.

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 4, 8);
            Point p2 = new Point(2, 4, 2);

            Console.WriteLine((p1 + p2).ToString());
        }
    }
}
