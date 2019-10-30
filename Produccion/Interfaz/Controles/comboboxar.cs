using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Controles
{
    public partial class comboboxar : ComboBox
    {
        
        public comboboxar()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            if (m.HWnd != Handle)
            {
                return;
            }

            if (m.Msg == 0x020A) // WM_MOUSEWHEEL
            {
                return;
            }

            base.WndProc(ref m);
        }
        public bool Validar
        {
            set;
            get;
        }

        public comboboxar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
