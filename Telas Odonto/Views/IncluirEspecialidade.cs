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
    public class IncluirEspecialidade : BaseForm
    {
        FieldForm fieldDescricao;
        FieldForm fieldDetalhamento;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public IncluirEspecialidade() : base("Incluir Especialidade", SizeScreen.Small)
        {
            fieldDescricao = new FieldForm("Descrição",20,20,150,20);
            fieldDetalhamento = new FieldForm("Detalhamento",20,80,120,20);
            btnConf = new ButtonForm("Confirmar",30,200, this.handleConfi);
            btnCanc = new ButtonForm("Cancelar",150,200, this.handleCance);

            this.Controls.Add(fieldDescricao.lblField);
            this.Controls.Add(fieldDescricao.txtField);
            this.Controls.Add(fieldDetalhamento.lblField);
            this.Controls.Add(fieldDetalhamento.txtField);
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