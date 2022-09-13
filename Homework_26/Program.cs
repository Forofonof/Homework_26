using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Массив чисел:");

        foreach (var numbers in numbersArray)
        {
            Console.Write($"{numbers} ");
        }

        Console.WriteLine("\nНасколько значений хотите сдвинуть массив?");
        int numbersShift = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbersShift; i++)
        {
            for (int j = numbersArray.Length - 2; j > -1; j--)
            {
                int tempArray = numbersArray[j + 1];
                numbersArray[j + 1] = numbersArray[j];
                numbersArray[j] = tempArray;
            }
        }

        Console.WriteLine("Новый массив: ");

        foreach (var numbers in numbersArray)
        {
            Console.Write($"{numbers} ");
        }
    }
}