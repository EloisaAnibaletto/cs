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
    public class AlterarSala : BaseForm
    {
        FieldForm fieldId;
        FieldForm fieldNumero;
        FieldForm fieldEquipamentos;
        ButtonForm btnConf;
        ButtonForm btnCanc;
        public AlterarSala() : base("Alterar Sala", SizeScreen.Small)
        {
            fieldId = new FieldForm("ID de alteração",20,20,150,20);
            fieldNumero = new FieldForm("Número",20,20,150,20);
            fieldEquipamentos = new FieldForm("Equipamentos",20,80,120,20);
            btnConf = new ButtonForm("Confirmar",30,200, this.handleConfi);
            btnCanc = new ButtonForm("Cancelar",150,200, this.handleCance);

            this.Controls.Add(fieldId.lblField);
            this.Controls.Add(fieldId.txtField);
            this.Controls.Add(fieldNumero.lblField);
            this.Controls.Add(fieldNumero.txtField);
            this.Controls.Add(fieldEquipamentos.lblField);
            this.Controls.Add(fieldEquipamentos.txtField);
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