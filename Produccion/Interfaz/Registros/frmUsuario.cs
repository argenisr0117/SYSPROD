using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;

namespace Interfaz.Registros
{
    public partial class frmUsuario : MetroForm
    {
        clsDepartamento D = new clsDepartamento();
        clsDestino De = new clsDestino();
        clsUsuario U = new clsUsuario();
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void ComboD()
        {
            try
            {
                cmbDpto.DataSource = D.Listar(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
       
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ComboD();
            txtUsuario.Focus();
            Program.Evento = 0;
            Limpiar();
            LlenarGrid();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
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
                    U.Iddpto = cmbDpto.SelectedValue.ToString();
                    mensaje = U.RegistrarUsuario();
                    if (mensaje == "Usuario ya existe!")
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    U.Idusuario = Convert.ToInt32(dtgvUsuario.CurrentRow.Cells[0].Value);
                    U.Usuario = txtUsuario.Text;
                    U.Clave = txtClave.Text;
                    U.Iddpto = cmbDpto.SelectedValue.ToString();
                    MessageBoxEx.Show(U.ActualizarUsuario(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtUsuario.Focus();
            }

            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void LlenarGrid()
        {
            DataTable dt = new DataTable();
            dt = U.Listar();
            try
            {
                dtgvUsuario.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvUsuario.Rows.Add(dt.Rows[x][0]);
                    dtgvUsuario.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvUsuario.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvUsuario.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvUsuario.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvUsuario.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                }
                dtgvUsuario.ClearSelection();
            }
            catch (Exception ex)
            {
               MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtUsuario.Clear();
            txtUsuario.Focus();
            cmbDpto.SelectedValue = "";
            txtClave.Clear();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvUsuario.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtUsuario.Text = dtgvUsuario.CurrentRow.Cells[1].Value.ToString();
                txtClave.Text = dtgvUsuario.CurrentRow.Cells[2].Value.ToString();
                cmbDpto.SelectedValue = dtgvUsuario.CurrentRow.Cells[4].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos obj = new frmPermisos();
            obj.ShowDialog();
        }
    }
}

