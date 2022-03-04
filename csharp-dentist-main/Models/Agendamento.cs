using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Agendamento
    {
        public int Id { set; get; }

        [Required]
        public int PacienteId { set; get; }
        public Paciente Pacientes { get; }

        [Required]
        public int DentistaId { set; get; }
        public Dentista Dentistas { get; }

        [Required]
        public int SalaId { set; get; }
        public Sala Sala { get; }

        [Required]
        public DateTime Datas { set; get; }
        public bool Confirmado { set; get; }

        
        public Agendamento() { }

        public Agendamento(
            int PacienteId,
            int DentistaId,
            int SalaId,
            DateTime Data
        )
        {
            this.PacienteId = PacienteId;
            this.Pacientes = Paciente.GetPacientes().Find(Paciente => Paciente.Id == PacienteId);
            this.DentistaId = DentistaId;
            this.Dentistas = Dentista.GetDentistas().Find(Dentista => Dentista.Id == DentistaId);
            this.SalaId = SalaId;
            this.Sala = Sala.GetSalas().Find(Sala => Sala.Id == SalaId);
            this.Datas = Data;

            Context db = new Context();
            db.Agendamentos.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nPaciente: {this.Pacientes.Nome}"
                + $"\nDentista: {this.Dentistas.Nome}"
                + $"\nSala: {this.Sala.Numero}"
                + $"\nData: {this.Datas}"
                + $"\nConfirmado: {(this.Confirmado ? "Sim" : "Não")}"
                + $"\nTotal: R$ {AgendamentoProcedimento.GetTotalPorAgendamento(this.Id)}"
                + $"\n{AgendamentoProcedimento.ImprimirPorAgendamento(this.Id)}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Agendamento.ReferenceEquals(obj, this))
            {
                return false;
            }
            Agendamento it = (Agendamento)obj;
            return it.Id == this.Id;
        }


        public static List<Agendamento> GetAgendamentos()
        {
            Context db = new Context();
            return (from Agendamento in db.Agendamentos select Agendamento).ToList();
        }
   
        public static void RemoverAgendamento(
            Agendamento agendamento
        )
        {
            Context db = new Context();
            db.Agendamentos.Remove(agendamento);
        }
    }
}