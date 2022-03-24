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
    public class IncluirPaciente : BaseForm
    {
        FieldForm fieldNome;
        FieldForm fieldCpf;
        FieldForm fieldFone;
        FieldForm fieldEmail;
        FieldForm fieldSenha;
        FieldForm fieldDataNasc;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public IncluirPaciente() : base("Incluir Paciente", SizeScreen.Medium)
        {
            fieldNome = new FieldForm("Nome",20,20,500,20);
            fieldCpf = new FieldForm("CPF",20,80,120,20);
            fieldFone = new FieldForm("Fone",20,140,120,20);
            fieldEmail = new FieldForm("Email",20,200,500,20);
            fieldSenha = new FieldForm("Senha",20,260,120,20);
            fieldDataNasc = new FieldForm("Data de Nascimento",20,320,120,20);
            btnConf = new ButtonForm("Confirmar",200,520, this.handleConfi);
            btnCanc = new ButtonForm("Cancelar",300,520, this.handleCance);

            this.Controls.Add(fieldNome.lblField);
            this.Controls.Add(fieldNome.txtField);
            this.Controls.Add(fieldCpf.lblField);
            this.Controls.Add(fieldCpf.txtField);
            this.Controls.Add(fieldFone.lblField);
            this.Controls.Add(fieldFone.txtField);
            this.Controls.Add(fieldEmail.lblField);
            this.Controls.Add(fieldEmail.txtField);
            this.Controls.Add(fieldSenha.lblField);
            this.Controls.Add(fieldSenha.txtField);
            this.Controls.Add(fieldDataNasc.lblField);
            this.Controls.Add(fieldDataNasc.txtField);
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