using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Views;

namespace Dentista
{
    static class TelaLogin
    {
         [STAThread]
        static void Main()
        {
			Application.EnableVisualStyles();
            Application.Run(new Login());
            //Application.Run(new BeginDentista());
            //Application.Run(new ExcluirDentista());
            //Application.Run(new DentistaList());
            //Application.Run(new IncluirProcedimento());

        }
    }
}