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
            txtUsuario.Focus();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        //Program.Usuario = txtUsuario.Text;
                        Splash obj = new Splash();
                        this.Hide();
                        obj.ShowDialog();
                        this.Close();
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
