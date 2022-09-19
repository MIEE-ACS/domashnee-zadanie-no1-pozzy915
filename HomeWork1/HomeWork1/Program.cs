using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, x;
            const float Pi = 3.14f;
            Console.Write("Введите значение угла в диапозоне от 0 до 360 градусов: a = ");
            a = float.Parse(Console.ReadLine());
            if (a >= 0 && a <= 360)
            {
                x = (Pi * a) / 180;
                Console.WriteLine("Угол а в радианах равен: " + x);
            }
            else
            {
                Console.Write("Введено неверное значение угла a");
            }
        }
    }
}
