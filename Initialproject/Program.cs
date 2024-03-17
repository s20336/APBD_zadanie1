using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int max = FindMaxValue(numbers);
        Console.WriteLine("Max wartość: " + max);
    }

    public static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta");
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        return max;
    }
}