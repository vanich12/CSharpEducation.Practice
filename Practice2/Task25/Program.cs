using System;

namespace Task25
{
    public enum Week
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class Program
    {
        static int currentDayNum;

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите число от 1 до 7");
                if (int.TryParse(Console.ReadLine(), out currentDayNum) && currentDayNum >= 1 && currentDayNum <= 7)
                {
                    Week weekDay = GetWeekDay(currentDayNum);
                    Console.WriteLine(weekDay);
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                }
            } while (true);

            Console.ReadKey();
        }

        static Week GetWeekDay(int value)
        {
            return (Week)(value - 1);
        }
    }
}