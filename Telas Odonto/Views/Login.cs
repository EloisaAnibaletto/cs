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
    public class Login : BaseForm
    {
        FieldForm fieldUsuario;
        FieldForm fieldSenha;
		ButtonForm btnConfirmar;
        ButtonForm btnCancelar;

        public Login() : base("Login",SizeScreen.Small)
        {
            fieldUsuario = new FieldForm("Usuário",20,20,180,20);
            fieldSenha = new FieldForm("Senha",20,100,180,60);

			btnConfirmar = new ButtonForm("Confirmar", 20, 180, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 180, 180, this.handleCancel);

            this.Controls.Add(fieldUsuario.lblField);
            this.Controls.Add(fieldUsuario.txtField);
            this.Controls.Add(fieldSenha.lblField);
            this.Controls.Add(fieldSenha.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            (new BeginDentista()).Show();
            (new BeginPaciente()).Show();
            this.Hide();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}