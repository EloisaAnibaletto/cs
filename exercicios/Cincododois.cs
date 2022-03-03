using System;
public class Cinco
{
    public static void Main()
    {
        Console.WriteLine("Digite a palavra");
        string palavra = Console.ReadLine();

            foreach (char item in palavra)
                {
                    Console.WriteLine(item);
                } 
    }
}