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
    public class DentistaCrud : BaseForm
    {
        ListView listView;
        ButtonForm btnIncluir;
        ButtonForm btnAlterar;
        ButtonForm btnExcluir;
        ButtonForm btnVoltar;
        public DentistaCrud() : base("Dentista", SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(580,350);
			listView.View = View.Details;
            ListViewItem dentistas = new ListViewItem("Sebastião");
            dentistas.SubItems.Add("123.456.789-00");
            dentistas.SubItems.Add("99999-5555");
            dentistas.SubItems.Add("sebastião@dentista.com");
            dentistas.SubItems.Add("123456");
            dentistas.SubItems.Add("8895");
            dentistas.SubItems.Add("12.000");
            dentistas.SubItems.Add("ortodontia");
            listView.Items.AddRange(new ListViewItem[]{dentistas});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Fone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salário", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
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
            (new IncluirDentista()).Show();
            this.Hide();
        }
        private void handleAlterar(object sender, EventArgs e)
        {
            (new AlterarDentista()).Show();
            this.Hide();
        }
        private void handleExcluir(object sender, EventArgs e)
        {
            (new ExcluirDentista()).Show();
            this.Hide();
        }
        private void handleVoltar(object sender, EventArgs e)
        {
            (new BeginDentista()).Show();
            this.Hide(); 
        }
    }
}