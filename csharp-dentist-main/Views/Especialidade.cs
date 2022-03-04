using System;
using Controllers;
using Models;
namespace Views
{
    public class EspecialidadeView
    {
        public static void InserirEspecialidade()
        {
            Console.WriteLine("Digite a descricão da especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o detalhamento da especialidade: ");
            string Detalhamento = Console.ReadLine();

            SalaController.IncluirSala(
                Descricao,
                Detalhamento
            );

        }

        public static void AlterarEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            Console.WriteLine("Digite a descricão da especialidade: ");
            string Descricao = Console.ReadLine();
            Console.WriteLine("Digite o detalhamento da especialidade: ");
            string Detalhamento = Console.ReadLine();

            SalaController.AlterarSala(
                Id,
                Descricao,
                Detalhamento
            );

        }

        public static void ExcluirEspecialidade()
        {
            int Id = 0;
            Console.WriteLine("Digite o ID da Especialidade: ");
            try
            {
                Id = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                throw new Exception("ID inválido.");
            }
            
            EspecialidadeControllers.ExcluirEspecialidade(
                Id
            );

        }

        public static void ListarEspecialidade()
        {
            foreach (Especialidade item in EspecialidadeControllers.VisualizarEspecialidades())
            {
                Console.WriteLine(item);
            }
        }
    }
}