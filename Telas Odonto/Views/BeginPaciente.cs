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
    public class BeginPaciente : BaseForm
    {
        ListView listView; 
        ButtonForm btnConfirmar;
        ButtonForm btnClose;
        public BeginPaciente() : base("Bem-vindo Paciente", SizeScreen.Small)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(280,150);
			listView.View = View.Details;
            ListViewItem agendamentos = new ListViewItem("Sebastião");
            agendamentos.SubItems.Add("Sala 01");
            agendamentos.SubItems.Add("25/19/2022");
            agendamentos.SubItems.Add("Sim");		
			listView.Items.AddRange(new ListViewItem[]{agendamentos});
			listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Ano", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Confirmado", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
            btnConfirmar = new ButtonForm("Confirmar",20,200, this.handleConfirmar);
            btnClose = new ButtonForm("Sair",180,200, this.handleClose);

            this.Controls.Add(listView);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnClose);
        }
        private void handleConfirmar(object sender, EventArgs e)
        {
           MessageBox.Show(
				"Confirmado com susseco!"
			    );
        }
        private void handleClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}