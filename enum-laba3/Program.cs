﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите день недели");
        Day day = (Day)Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите час");
        byte hour = Convert.ToByte(Console.ReadLine());
        
        if(hour>=0&& hour <= 6)
        {
            Console.WriteLine($"Сейчас {day}, Ночь");
        }
        else if(hour>=7&& hour <= 12) {
            Console.WriteLine($"Сейчас {day}, Утро");
        }
        else if(hour>= 13&& hour <= 18)
        {
            Console.WriteLine($"Сейчас {day}, День");
        }
        else if(hour>= 19&& hour <= 23) {
            Console.WriteLine($"Сейчас {day}, Вечер");
        }
        else
        {
            Console.WriteLine("Время введено неправильно");
        }
        
    }
}
enum Day
{
    Понедельник = 1, Вторник, Среда, Четверг, Пятница, Суббота, Воскресенье
}
enum Time
{
    zero, one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fiveteen, sixteen, seventeen, eighteen, nineteen, twenty, twentyone, twentytwo, twentythree    
}
