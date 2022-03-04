using System;
using Controllers;
using Models;

namespace Views
{
    public class ProcedimentoView
    {
        public static void IncluirProcedimento()
        {
            string Descricao;
            double Preco;
            Console.WriteLine("Digite a descrição do procedimento: ");
            Descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do procedimento: ");
            try
            {
                Preco = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Preço inválido.");
            }

            ProcedimentoController.IncluirProcedimento(Descricao, Preco);
        }

        public static void AlterarProcedimento()
        {
            int Id = 0;
            string Descricao;
            double Preco;
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite a descrição do procedimento: ");
            Descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do procedimento: ");
            try
            {
                Preco = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                throw new Exception("Preço inválido.");
            }

            ProcedimentoController.AlterarProcedimento(Id, Descricao, Preco);
        }

        public static void ExcluirProcedimento()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID do Procedimento: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            ProcedimentoController.ExcluirProcedimento(Id);
        }

        public static void ListarProcedimentos()
        {
            foreach (Procedimento item in ProcedimentoController.VisualizarProcedimentos())
            {
                Console.WriteLine(item);
            }
        }
    }

}