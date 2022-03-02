using Models;
using System;
using System.Linq;
using System.Collections.Generic;
namespace Controllers
{
    public class ProcedimentoController
    {
        public static Procedimento IncluirProcedimento(
            string Descricao,
            double Preco
        )
        {
            if (String.IsNullOrEmpty(Descricao)) 
            {
                throw new Exception("Descricao é obrigatório");
            }

            if (Double.IsNaN(Preco)) 
            {
                throw new Exception("Preço é obrigatório");
            }

            return new Procedimento(Descricao, Preco);
        }

        public static Procedimento AlterarProcedimento(
            int Id,
            string Descricao,
            double Preco
        )
        {
            Procedimento procedimentos = GetProcedimento(Id);

            if (!String.IsNullOrEmpty(Descricao)) {
                procedimentos.Descricao = Descricao;
            }
            procedimentos.Descricao = Descricao;

            if (!Double.IsNaN(Preco)) {
                procedimentos.Descricao = Descricao;
            }
            procedimentos.Preco = Preco;

            return procedimentos;
        }

        public static Procedimento ExcluirProcedimento(
            int Id
        )
        {
            Procedimento procedimento = GetProcedimento(Id);
            Models.Procedimento.RemoverProcedimento(procedimento);
            return procedimento;
        }

        public static List<Procedimento> VisualizarProcedimentos()
        {
            return Models.Procedimento.GetProcedimentos();  
        }

        public static Procedimento GetProcedimento(
            int Id
        )
        {
            List<Procedimento> procedimentosModels = Models.Procedimento.GetProcedimentos();
            IEnumerable<Procedimento> procedimentos = from Procedimento in procedimentosModels
                            where Procedimento.Id == Id
                            select Procedimento;
            Procedimento procedimento = procedimentos.First();
            
            if (procedimento == null)
            {
                throw new Exception("Sala não encontrada");
            }

            return procedimento;
        }
    }
}