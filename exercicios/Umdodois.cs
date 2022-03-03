using System;
    public class Um
    {
        public static void Main()
        {
            Console.WriteLine("Digite a nota um: ");
            double notaUm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota dois: ");
            double notaDois = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota três: ");
            double notaTres = Convert.ToDouble(Console.ReadLine());
            double media = ((notaUm + notaDois + notaTres) / 3);
            Console.WriteLine(
                "A média é {0} e está {1}",
                media,
                media >= 7 ? "aprovado" : "reprovado"
            );
        }
    }