using System;

namespace EssentialLesson16Task4
{

    //    Задание 4
    //Создайте класс, который будет содержать информацию о дате(день, месяц, год). С помощью механизма перегрузки операторов, определите операцию разности двух 
    //        дат(результат в виде количества дней между датами), а также операцию увеличения даты на определенное количество дней.

    class Program
    {
        static void Main(string[] args)
        {
            MyDateClass dt1 = new MyDateClass(2000, 01, 30);
            MyDateClass dt2 = new MyDateClass(2000, 01, 10);
            MyDateClass dtRes = dt1 - dt2;
            Console.WriteLine(dtRes.ToString());
            MyDateClass dtRes2 = dt2 + 40;
            Console.WriteLine(dtRes2.ToStringFull());
        }
    }
}
