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
    public class SalaCrud : BaseForm
    {
        ListView listView;
        ButtonForm btnIncluir;
        ButtonForm btnAlterar;
        ButtonForm btnExcluir;
        ButtonForm btnVoltar;
        public SalaCrud() : base("Sala", SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(580,350);
			listView.View = View.Details;
            ListViewItem especialidades = new ListViewItem("Sala 01");
            especialidades.SubItems.Add("Maca");
            listView.Items.AddRange(new ListViewItem[]{especialidades});
			listView.Columns.Add("Número", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Equipamentos", -2, HorizontalAlignment.Left);
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