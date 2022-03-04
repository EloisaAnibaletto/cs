using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class AgendamentoProcedimento
    {
        public int Id { set; get; } 

        [Required]
        public int ProcedimentoId{ set; get; }
        public Procedimento Procedimento { set; get; }

        [Required]
        public int AgendamentoId{ set; get; }
        public Agendamento Agendamento { set; get; }


        public AgendamentoProcedimento() { }

        public AgendamentoProcedimento(
            int ProcedimentoId,
            int AgendamentoId
        )
        {
            this.ProcedimentoId = ProcedimentoId;
            this.Procedimento = Procedimento.GetProcedimentos().Find(Procedimento => Procedimento.Id == ProcedimentoId);
            this.AgendamentoId = AgendamentoId;
            this.Agendamento = Agendamento.GetAgendamentos().Find(Agendamento => Agendamento.Id == AgendamentoId);

            Context db = new Context();
            db.AgendamentoProcedimentos.Add(this);
            db.SaveChanges();
        }

        public static List<AgendamentoProcedimento> GetAgendamentoProcedimentos()
        {
            Context db = new Context();
            return (from AgendamentoProcedimento in db.AgendamentoProcedimentos select AgendamentoProcedimento).ToList();
        }

        public static IEnumerable<AgendamentoProcedimento> GetProcedimentosPorAgendamento(int AgendamentoId)
        {
            Context db = new Context();
            return (
                from AgendamentoProcedimento in db.AgendamentoProcedimentos 
                where AgendamentoProcedimento.AgendamentoId == AgendamentoId
                select AgendamentoProcedimento
            );
        }

        public static double GetTotalPorAgendamento(int AgendamentoId)
        {
            Context db = new Context();
            return (
                from AgendamentoProcedimento in db.AgendamentoProcedimentos 
                where AgendamentoProcedimento.AgendamentoId == AgendamentoId 
                select AgendamentoProcedimento.Procedimento.Preco
            ).Sum();
        }

        public static string ImprimirPorAgendamento(int AgendamentoId)
        {
            Context db = new Context();
            IEnumerable<AgendamentoProcedimento> procedimentos = from AgendamentoProcedimento in db.AgendamentoProcedimentos 
                where AgendamentoProcedimento.AgendamentoId == AgendamentoId
                select AgendamentoProcedimento;

            
            string ret = "Procedimentos: ";
            if (procedimentos.Count() > 0) {
                foreach(AgendamentoProcedimento procedimento in procedimentos) {
                    ret += $"\n    Procedimento: {procedimento.Procedimento.Descricao}";
                    ret += $"\n    Preco: {procedimento.Procedimento.Preco}";
                }
            }
            else 
            {
                ret += "\n    Não há procedimentos.";
            }           

            return ret;
        }

        
        public static void RemoverAgendamentoProcedimento(
            AgendamentoProcedimento agendamentoProcedimento
        )
        {
            Context db = new Context();
            db.AgendamentoProcedimentos.Remove(agendamentoProcedimento);
        }

    }
}