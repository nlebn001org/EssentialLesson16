using System;

namespace EssentialLesson16Task2
{

    //    Задание 2
    //Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:
    //Equals – способный сравнивать блоки между собой,
    //ToString – возвращающий информацию о полях блока.

    class Program
    {
        static void Main(string[] args)
        {
            Block b1 = new Block(1,2,3,4);
            Block b2 = new Block(1,2,4,3);
            Block b3 = b1;

            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b2.GetHashCode());
            Console.WriteLine(b3.GetHashCode());

            Console.WriteLine(b1.Equals(b2)); 
            Console.WriteLine(b3.Equals(b2)); 
            Console.WriteLine(b3.Equals(b1)); 
        }
    }
}
