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
    public class AlterarDentista : BaseForm
    {
        FieldForm fieldId;
        FieldForm fieldNome;
        FieldForm fieldCpf;
        FieldForm fieldFone;
        FieldForm fieldEmail;
        FieldForm fieldSenha;
        FieldForm fieldRegistro;
        FieldForm fieldSalario;
        FieldForm fieldEspecialidade;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public AlterarDentista() : base("Alterar Dentista", SizeScreen.Medium)
        {
            fieldId = new FieldForm("ID de alteração",20,20,500,20);
            fieldNome = new FieldForm("Nome",20,20,500,20);
            fieldCpf = new FieldForm("CPF",20,80,120,20);
            fieldFone = new FieldForm("Fone",20,140,120,20);
            fieldEmail = new FieldForm("Email",20,200,500,20);
            fieldSenha = new FieldForm("Senha",20,260,120,20);
            fieldRegistro = new FieldForm("Registro",20,320,120,20);
            fieldSalario = new FieldForm("Salario",20,380,120,20);
            fieldEspecialidade = new FieldForm("Especialidade",20,440,180,20);
            btnConf = new ButtonForm("Confirmar",200,520, this.handleConfi);
            btnCanc = new ButtonForm("Cancelar",300,520, this.handleCance);

            this.Controls.Add(fieldId.lblField);
            this.Controls.Add(fieldId.txtField);
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
            this.Controls.Add(fieldRegistro.lblField);
            this.Controls.Add(fieldRegistro.txtField);
            this.Controls.Add(fieldSalario.lblField);
            this.Controls.Add(fieldSalario.txtField);
            this.Controls.Add(fieldEspecialidade.lblField);
            this.Controls.Add(fieldEspecialidade.txtField);
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