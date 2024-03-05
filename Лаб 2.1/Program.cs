using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = GenerateRandomList(20); 
        Console.WriteLine("Список чисел:");
        PrintList(numbers);

        int startIndex = -1;
        int endIndex = -1;
        int currentIndex = 0;
        int maxSequenceLength = 0;
        int currentSequenceLength = 0;
        

        foreach (int num in numbers)
        {
            if (num == 1)
            {
                currentSequenceLength++;
                if (startIndex == -1)
                {
                    startIndex = currentIndex;
                }
            }
            else
            {
                if (currentSequenceLength > maxSequenceLength)
                {
                    maxSequenceLength = currentSequenceLength;
                    endIndex = currentIndex - 1;
                }
                currentSequenceLength = 0;
                startIndex = -1;
            }
            currentIndex++;
        }

        if (currentSequenceLength > maxSequenceLength)
        {
            maxSequenceLength = currentSequenceLength;
            endIndex = currentIndex - 1;
        }

        Console.WriteLine($"Найдовша безперервна послідовність одиниць має довжину {maxSequenceLength} і знаходиться між індексами {endIndex - maxSequenceLength + 1} і {endIndex}.");
    }

    static List<int> GenerateRandomList(int length)
    {
        List<int> list = new List<int>();
        Random rnd = new Random();
        for (int i = 0; i < length; i++)
        {
            list.Add(rnd.Next(0,2));
        }
        return list;
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}


