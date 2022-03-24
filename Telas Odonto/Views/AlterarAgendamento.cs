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
    public class AlterarAgendamento : BaseForm
    {
        FieldForm fieldAgendamentoId;
        FieldForm fieldPacienteId;
        FieldForm fieldDentistaId;
        FieldForm fieldSalaId;
        FieldForm fieldData;
        FieldForm fieldProcedimentoId;
        CheckedListBox checkedList;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public AlterarAgendamento() : base("Alterar Agendamento", SizeScreen.Medium)
        {
            fieldAgendamentoId = new FieldForm("ID do Agendamento de alteração",20,20,100,20);
            fieldPacienteId = new FieldForm("ID do Paciente",20,20,100,20);
            fieldDentistaId = new FieldForm("ID do dentista",20,80,100,20);
            fieldSalaId = new FieldForm("ID da Sala",20,140,100,20);
            fieldData = new FieldForm("Data",20,200,50,100);
            fieldProcedimentoId = new FieldForm("Id do procedimento",20,260,100,20);
            btnConf = new ButtonForm("Confirmar",200,520, this.handleConf);
            btnCanc = new ButtonForm("Cancelar",300,520, this.handleCanc);
            checkedList = new CheckedListBox();
			checkedList.Location = new Point(100, 350);
			checkedList.Size = new Size(400,180);
            string[] procedimentos = { "Extrair", "Limpeza", "Obturação" };
			checkedList.Items.AddRange(procedimentos);
            checkedList.SelectionMode = SelectionMode.One;
			checkedList.CheckOnClick = true;

            this.Controls.Add(fieldAgendamentoId.lblField);
            this.Controls.Add(fieldAgendamentoId.txtField);
            this.Controls.Add(fieldPacienteId.lblField);
            this.Controls.Add(fieldPacienteId.txtField);
            this.Controls.Add(fieldDentistaId.lblField);
            this.Controls.Add(fieldDentistaId.txtField);
            this.Controls.Add(fieldSalaId.lblField);
            this.Controls.Add(fieldSalaId.txtField);
            this.Controls.Add(fieldData.lblField);
            this.Controls.Add(fieldData.txtField);
            this.Controls.Add(fieldProcedimentoId.lblField);
            this.Controls.Add(fieldProcedimentoId.txtField);
            this.Controls.Add(btnConf);
            this.Controls.Add(btnCanc);
            this.Controls.Add(checkedList);
            
        }
        private void handleConf(object sender, EventArgs e)
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
        private void handleCanc(object sender, EventArgs e)
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