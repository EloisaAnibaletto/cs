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
    public class AgendamentoProcedimentoCrud : BaseForm
    {
        ListView listView;
        ButtonForm btnIncluir;
        ButtonForm btnExcluir;
        ButtonForm btnVoltar;
        public AgendamentoProcedimentoCrud() : base("AgendamentoProcedimento", SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(580,350);
			listView.View = View.Details;
            ListViewItem especialidades = new ListViewItem("01");
            especialidades.SubItems.Add("01");
            listView.Items.AddRange(new ListViewItem[]{especialidades});
			listView.Columns.Add("ID do agendamento", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("ID do procedimento", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
            btnIncluir = new ButtonForm("Incluir",100,450, this.handleIncluir);
            btnExcluir = new ButtonForm("Excluir",300,450, this.handleExcluir);
            btnVoltar = new ButtonForm("Voltar",400,450, this.handleVoltar);

            this.Controls.Add(listView);
            this.Controls.Add(btnIncluir);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnVoltar);
        }
        private void handleIncluir(object sender, EventArgs e)
        {
            (new IncluirAgendamentoProcedimento()).Show();
            this.Hide();
        }
        private void handleExcluir(object sender, EventArgs e)
        {
            (new ExcluirAgendamentoProcedimento()).Show();
            this.Hide();
        }
        private void handleVoltar(object sender, EventArgs e)
        {
            (new BeginDentista()).Show();
            this.Hide(); 
        }
    }
}