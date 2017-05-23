using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Controles
{
    public partial class textboxceros : textboxN
    {
        public textboxceros()
        {
            InitializeComponent();
        }
        public int longitud = 0;
        public int Longitud
        {
            set { longitud = value; }
            get { return longitud; }
        }

        public int valorint = 0;
        public int Valorint
        {
            get
            {
                return Convert.ToInt32(Text);
            }
        }


        public textboxceros(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        private void textboxceros_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Text) == false)
            {
                string secuencia = Text.ToString();
                Text = secuencia.PadLeft(2, '1');
                string sec = Text.ToString();
                Text = sec.PadRight(longitud, '0');
            }
        }
    }
}
