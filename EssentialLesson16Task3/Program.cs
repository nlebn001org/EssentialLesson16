using System;

namespace EssentialLesson16Task3
{

    //    Задание 3
    //Создайте класс House c двумя полями и свойствами.
    //Создайте два метода Clone() и DeepClone(), которые выполняют поверхностное и глубокое копирование соответственно.Реализуйте простой способ проверки.
    class Program
    {
        static void Main(string[] args)
        {
            Door door1 = new Door("Beko", "Blue");
            House h1 = new House("Red", 1997, door1);

            House clonedHouse1 = (House)h1.Clone();
            House clonedHouse2 = (House)h1.DeepClone();



            Console.WriteLine(h1.ToString());
            Console.WriteLine(clonedHouse1.ToString());
            Console.WriteLine(clonedHouse2.ToString());

            Console.WriteLine(new string('-', 20));

            door1.Color = "Purple";
            door1.Name = "DoorMaster";

            Console.WriteLine(clonedHouse1.ToString());
            Console.WriteLine(clonedHouse2.ToString());

            clonedHouse2.houseDoor.Color = "Black";

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(clonedHouse1.ToString());
            Console.WriteLine(clonedHouse2.ToString());
        }
    }
}
