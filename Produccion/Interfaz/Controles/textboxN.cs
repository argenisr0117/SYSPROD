using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Interfaz.Controles
{
    public partial class textboxN : textbox
    {
        public enum Tipo
        {
            Números,
            Letras,
            NúmerosA //Para usarlo en la salida de rollos de alambron
        }

        public Tipo Valor
        {
            set;
            get;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            NumberFormatInfo j = NumberFormatInfo.CurrentInfo;
            if (Valor == Tipo.Números)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
                else if ((char.IsDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)) || ((e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Valor == Tipo.Letras)
            {
                if ((char.IsLetter(e.KeyChar)) || (char.IsControl(e.KeyChar)) || ((e.KeyChar == '.' || e.KeyChar == (char)Keys.Space)))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Valor == Tipo.NúmerosA)
            {
                if ((char.IsDigit(e.KeyChar)) || (char.IsControl(e.KeyChar)) || ((e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == '-')))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        public textboxN()
        {
            InitializeComponent();
        }

        public textboxN(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
