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
    public class EspecialidadeCrud : BaseForm
    {
        ListView listView;
        ButtonForm btnIncluir;
        ButtonForm btnAlterar;
        ButtonForm btnExcluir;
        ButtonForm btnVoltar;
        public EspecialidadeCrud() : base("Especialidade", SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(580,350);
			listView.View = View.Details;
            ListViewItem especialidades = new ListViewItem("Ortodontia");
            especialidades.SubItems.Add("Especialidade odontológica cujo objeto é prevenir e corrigir estados de anormalidade no alinhamento dos dentes.");
            listView.Items.AddRange(new ListViewItem[]{especialidades});
			listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Detalhamento", -2, HorizontalAlignment.Left);
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
            (new IncluirEspecialidade()).Show();
            this.Hide();
        }
        private void handleAlterar(object sender, EventArgs e)
        {
            (new AlterarEspecialidade()).Show();
            this.Hide();
        }
        private void handleExcluir(object sender, EventArgs e)
        {
            (new ExcluirEspecialidade()).Show();
            this.Hide();
        }
        private void handleVoltar(object sender, EventArgs e)
        {
            (new BeginDentista()).Show();
            this.Hide(); 
        }
    }
}