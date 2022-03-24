using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Views.Lib;
using Views;

namespace Views
{
    public class BeginDentista : BaseForm
    {
        ButtonForm btnDentista;
        ButtonForm btnPaciente;
        ButtonForm btnSala;
        ButtonForm btnProcedimento;
        ButtonForm btnAgendamento;
        ButtonForm btnEspecialidade;
        ButtonForm btnAgendamentoProcedimento;
        ButtonForm btnSair;
        public BeginDentista() : base("Bem-Vindo Dentista", SizeScreen.Small) 
        {
            btnDentista = new ButtonForm("Dentista", 20, 32, this.handleDentista);
            btnPaciente = new ButtonForm("Paciente", 20, 92, this.handlePaciente);
            btnSala = new ButtonForm("Sala", 20, 142, this.handleSala);
            btnProcedimento = new ButtonForm("Procedimento", 180, 32, this.handleProcedimento);
            btnAgendamento = new ButtonForm("Agendamento",180, 92, this.handleAgendamento);
            btnEspecialidade = new ButtonForm("Especialidade", 180, 142, this.handleEspecialidade);
            btnAgendamentoProcedimento = new ButtonForm("AgendProced", 180, 200, this.handleAgendamentoProcedimento);
            btnSair = new ButtonForm("Sair", 20, 200, this.handleSair);

            this.Controls.Add(btnDentista);
            this.Controls.Add(btnPaciente);
            this.Controls.Add(btnSala);
            this.Controls.Add(btnProcedimento);
            this.Controls.Add(btnAgendamento);
            this.Controls.Add(btnEspecialidade);
            this.Controls.Add(btnAgendamentoProcedimento);
            this.Controls.Add(btnSair);
        }
        private void handleDentista(object sender, EventArgs e)
        {
            (new DentistaCrud()).Show();
            this.Hide();

        }
        private void handlePaciente(object sender, EventArgs e)
        {
            (new PacienteCrud()).Show();
            this.Hide();

        }
        private void handleSala(object sender, EventArgs e)
        {
            (new SalaCrud()).Show();
            this.Hide();

        }
        private void handleProcedimento(object sender, EventArgs e)
        {
            (new ProcedimentoCrud()).Show();
            this.Hide();

        }
        private void handleAgendamento(object sender, EventArgs e)
        {
            (new AgendamentoCrud()).Show();
            this.Hide();

        }
        private void handleEspecialidade(object sender, EventArgs e)
        {
            (new EspecialidadeCrud()).Show();
            this.Hide();

        }
        private void handleAgendamentoProcedimento(object sender, EventArgs e)
        {
            (new AgendamentoProcedimentoCrud()).Show();
            this.Hide();

        }

        private void handleSair(object sender, EventArgs e) {
			this.Close();
		}
    }
}