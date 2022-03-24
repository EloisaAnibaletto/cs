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
    public class PacienteCrud : BaseForm
    {
        ListView listView;
        ButtonForm btnIncluir;
        ButtonForm btnAlterar;
        ButtonForm btnExcluir;
        ButtonForm btnVoltar;
        public PacienteCrud() : base("Paciente", SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(580,350);
			listView.View = View.Details;
            ListViewItem pacientes = new ListViewItem("Maria");
            pacientes.SubItems.Add("789.456.123.-00");
            pacientes.SubItems.Add("98877-2233");
            pacientes.SubItems.Add("maria@paciente.com");
            pacientes.SubItems.Add("123456");
            pacientes.SubItems.Add("15/02/1978");
            listView.Items.AddRange(new ListViewItem[]{pacientes});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Fone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data Nascimento", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
            btnIncluir = new ButtonForm("Incluir",100,450, this.handleIncluir);
            btnAlterar = new ButtonForm("Alterar",200,450, this.handleAlterar);
            btnExcluir = new ButtonForm("Excluir",300,450, this.handleExcluir);
            btnVoltar = new ButtonForm("Voltar",400,450, this.handleVoltar);

            this.Controls.Add(listView);
            this.Controls.Add(btnIncluir);
            this.Controls.Add(btnAlterar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnVoltar);
        }
        private void handleIncluir(object sender, EventArgs e)
        {
            (new IncluirPaciente()).Show();
            this.Hide();
        }
        private void handleAlterar(object sender, EventArgs e)
        {
            (new AlterarPaciente()).Show();
            this.Hide();
        }
        private void handleExcluir(object sender, EventArgs e)
        {
            (new ExcluirPaciente()).Show();
            this.Hide();
        }
        private void handleVoltar(object sender, EventArgs e)
        {
            (new BeginDentista()).Show();
            this.Hide(); 
        }
    }
}