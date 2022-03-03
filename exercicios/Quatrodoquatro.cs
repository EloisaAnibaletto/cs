using System;
public class Quatro
{
    public static void Main()
    {
        int[] intArray = new int[10];
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.WriteLine("Informe o valor {0}", i + 1);
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (int item in intArray)
        {
            Console.Write(item % 2 == 0 ? "É par" : "É ímpar");
        }
    }
}