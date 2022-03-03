using System;
public class Tres
{
    public static void Main()
    {
        double[] doubleArray = new double[10];
        for (int i = 0; i < doubleArray.Length; i++)
        {
            Console.WriteLine("Informe o valor {0}", i + 1);
            doubleArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        foreach (double item in doubleArray)
        {
            Console.Write(item);
        }
    }
}