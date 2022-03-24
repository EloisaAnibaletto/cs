using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Views.Lib;

namespace Views
{
    public class IncluirAgendamentoProcedimento : BaseForm
    {
        FieldForm fieldAgendamentoId;
        FieldForm fieldProcedimentoId;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public IncluirAgendamentoProcedimento() : base("Incluir AgendamentoProcedimento", SizeScreen.Small)
        {
            fieldAgendamentoId = new FieldForm("ID do agendamento",20,20,150,20);
            fieldProcedimentoId = new FieldForm("ID do procedimento",20,80,120,20);
            btnConf = new ButtonForm("Confirmar",30,200, this.handleConfi);
            btnCanc = new ButtonForm("Cancelar",150,200, this.handleCance);

            this.Controls.Add(fieldAgendamentoId.lblField);
            this.Controls.Add(fieldAgendamentoId.txtField);
            this.Controls.Add(fieldProcedimentoId.lblField);
            this.Controls.Add(fieldProcedimentoId.txtField);
            this.Controls.Add(btnConf);
            this.Controls.Add(btnCanc);
        }
        private void handleConfi(object sender, EventArgs e)
        {
            string message = "Você deseja confirmar?";  
            string title = "Atenção!";  
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
            DialogResult result = MessageBox.Show(message, title, buttons);  
            if (result == DialogResult.Yes) { 
                (new BeginDentista()).Show();
                this.Hide();
            } else {  
                this.Close();
            }  
        }
        private void handleCance(object sender, EventArgs e)
        {
            string message = "Você deseja cancelar?";  
            string title = "Atenção!";  
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  
            DialogResult result = MessageBox.Show(message, title, buttons);  
            if (result == DialogResult.Yes) {  
                (new BeginDentista()).Show();
                this.Hide();  
            } else {  
                this.Close();  
            } 
        }
    }
}