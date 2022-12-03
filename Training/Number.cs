using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Training;

public class Number
{
    public void OddNumber(int[] arrayNumbers)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            int count = 0;
            var numbersInArray = arrayNumbers[i];
            foreach (var check in arrayNumbers)
            {
                if (check == numbersInArray)
                {
                    count++;
                }
            }
            if (count % 2 != 0 && !numbers.Contains(numbersInArray))
            {
                numbers.Add(numbersInArray);
            }
        }
        Console.WriteLine();
        Console.Write("Эти числа встречаются нечётное количество раз - ");
        foreach (var check in numbers)
        {
            Console.Write($"{check} ");
        }
        Console.WriteLine();
    }
    public void EvenNumber(int[] arrayNumbers)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            int count = 0;
            var numbersInArray = arrayNumbers[i];
            foreach (var check in arrayNumbers)
            {
                if (check == numbersInArray)
                {
                    count++;
                }
            }
            if (count % 2 == 0 && !numbers.Contains(numbersInArray))
            {
                numbers.Add(numbersInArray);
            }
        }
        Console.WriteLine();
        Console.Write("Эти числа встречаются чётное количество раз - ");
        foreach (var check in numbers)
        {
            Console.Write($"{check} ");
        }
        Console.WriteLine();
    }
}
