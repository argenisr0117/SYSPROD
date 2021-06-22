using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using Intermedia;

namespace Interfaz
{
    public partial class Login : MetroForm
    {
        clsUsuario U = new clsUsuario();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.TitleText = "SysPROD";
            txtUsuario.Text = Properties.Settings.Default.Usuario;
            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.TabIndex = 1;
                txtClave.TabIndex = 0;
                txtClave.Focus();
            }
            else
            {
                txtUsuario.Focus();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    U.Usuario = txtUsuario.Text;
                    U.Clave = txtClave.Text;
                    mensaje = U.VerificarLogin();
                    if (mensaje == "Usuario no existe!")
                    {
                        MessageBox.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Clear();
                        txtClave.Clear();
                        txtUsuario.Focus();
                    }
                    else if (mensaje == "Clave incorrecta!")
                    {
                        MessageBox.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClave.Clear();                        
                        txtClave.Focus();

                    }
                    else
                    {
                        Properties.Settings.Default.Usuario = txtUsuario.Text;
                        Properties.Settings.Default.Save();
                        DataTable dt = new DataTable();
                        U.Idusuario = 0;
                        U.Usuario = txtUsuario.Text;
                        dt = U.ObtenerPermisos();
                        Program.proddiaria = Convert.ToBoolean(dt.Rows[0][1]);
                        Program.reggen = Convert.ToBoolean(dt.Rows[0][2]);
                        Program.congen = Convert.ToBoolean(dt.Rows[0][3]);
                        Program.prodtref = Convert.ToBoolean(dt.Rows[0][4]);
                        Program.prodgalv = Convert.ToBoolean(dt.Rows[0][5]);
                        Program.prodindm = Convert.ToBoolean(dt.Rows[0][6]);
                        Program.ediindm = Convert.ToBoolean(dt.Rows[0][7]);
                        Program.eliindm = Convert.ToBoolean(dt.Rows[0][8]);
                        Program.mosindm = Convert.ToBoolean(dt.Rows[0][9]);
                        Program.expindm = Convert.ToBoolean(dt.Rows[0][10]);
                        Program.fdesindm = Convert.ToBoolean(dt.Rows[0][11]);
                        Program.fhasindm = Convert.ToBoolean(dt.Rows[0][12]);
                        Program.editref = Convert.ToBoolean(dt.Rows[0][13]);
                        Program.elitref = Convert.ToBoolean(dt.Rows[0][14]);
                        Program.mostref = Convert.ToBoolean(dt.Rows[0][15]);
                        Program.filtref = Convert.ToBoolean(dt.Rows[0][16]);
                        Program.exptref = Convert.ToBoolean(dt.Rows[0][17]);
                        Program.fdestref = Convert.ToBoolean(dt.Rows[0][18]);
                        Program.fhastref = Convert.ToBoolean(dt.Rows[0][19]);
                        Program.reimtref = Convert.ToBoolean(dt.Rows[0][20]);
                        Program.acucong = Convert.ToBoolean(dt.Rows[0][21]);
                        Program.inccong = Convert.ToBoolean(dt.Rows[0][22]);
                        Program.empcong = Convert.ToBoolean(dt.Rows[0][23]);
                        Program.ciecong = Convert.ToBoolean(dt.Rows[0][24]);
                        Program.cieacong = Convert.ToBoolean(dt.Rows[0][25]);
                        Program.filcong = Convert.ToBoolean(dt.Rows[0][26]);
                        Program.ordenprod = Convert.ToBoolean(dt.Rows[0][27]);
                        Program.controlcald = Convert.ToBoolean(dt.Rows[0][28]);
                        Program.Idusuario = Convert.ToInt16(dt.Rows[0][0]);
                        Program.vcontrolcald= Convert.ToBoolean(dt.Rows[0][29]);
                        Program.vccfecha= Convert.ToBoolean(dt.Rows[0][30]);
                        Program.edigalv= Convert.ToBoolean(dt.Rows[0][31]);
                        Program.eligalv= Convert.ToBoolean(dt.Rows[0][32]);
                        Program.mosgalv= Convert.ToBoolean(dt.Rows[0][33]);
                        Program.filgalv= Convert.ToBoolean(dt.Rows[0][34]);
                        Program.expgalv= Convert.ToBoolean(dt.Rows[0][35]);
                        Program.fdesgalv= Convert.ToBoolean(dt.Rows[0][36]);
                        Program.fhasgalv=Convert.ToBoolean(dt.Rows[0][37]);
                        Program.reimgalv= Convert.ToBoolean(dt.Rows[0][38]);
                        Program.almintermedios= Convert.ToBoolean(dt.Rows[0][39]);
                        Program.almterminados= Convert.ToBoolean(dt.Rows[0][40]);
                        Program.almlg= Convert.ToBoolean(dt.Rows[0][41]);
                        Program.montemp= Convert.ToBoolean(dt.Rows[0][42]);
                        Program.maqpar= Convert.ToBoolean(dt.Rows[0][43]);
                        Program.monmaq= Convert.ToBoolean(dt.Rows[0][44]);
                        Program.reghora= Convert.ToBoolean(dt.Rows[0][45]);
                        Program.recpalm= Convert.ToBoolean(dt.Rows[0][46]);
                        //Program.Usuario = txtUsuario.Text;
                        //Splash obj = new Splash();
                        Principal obj = new Principal();
                        Hide();
                        obj.ShowDialog();
                        Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAcceder_Click(sender, e);
            }
        }
    }
}
