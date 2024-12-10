using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Масив чисел
        int[] numbers = { 2, 12, 14, 18, 25, 15 };

        // Вибір трьох чисел, починаючи з другого
        var selectedNumbers = numbers.Skip(1).Take(3);

        // Виведення результатів
        Console.WriteLine("Вибрані числа:");
        foreach (var number in selectedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
