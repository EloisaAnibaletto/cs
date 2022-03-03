using System;
public class Um
{
    public static void Main()
    {
        Console.WriteLine("Quantas notas?");
        int qtdNotas = Convert.ToInt32(Console.ReadLine());
        double soma = 0;
        for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine("Informe a nota {0}", i + 1);
                soma += Convert.ToDouble(Console.ReadLine());
            }

        Console.WriteLine("A média final é {0}", soma / qtdNotas);
    }
}