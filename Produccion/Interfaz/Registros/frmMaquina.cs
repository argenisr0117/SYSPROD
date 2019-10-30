using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Intermedia;
using DevComponents.DotNetBar.Metro;
namespace Interfaz.Registros
{
    public partial class frmMaquina : MetroForm
    {
        private clsMaquina M = new clsMaquina();
        private clsDepartamento D = new clsDepartamento();
        public frmMaquina()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }
        private void LlenarGrid()
        {
            bool valor = true;
            if (cbestado.SelectedIndex == 0)
            {
                valor = true;
            }
            else if (cbestado.SelectedIndex == 1)
            {
                valor = false;
            }
            DataTable dt = new DataTable();
            dt = M.Listar(valor);
            try
            {
                dtgvMaquina.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvMaquina.Rows.Add(dt.Rows[x][0]);
                    dtgvMaquina.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvMaquina.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvMaquina.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvMaquina.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                }
                dtgvMaquina.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtmaquina.Clear();
            txtabreviacion.Focus();
            cbdpto.SelectedText = null;
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
                    M.Idmaquina = txtabreviacion.Text;
                    M.Descripcion = txtmaquina.Text;
                    M.Iddpto = cbdpto.SelectedValue.ToString();
                    mensaje = M.RegistrarMaquina();
                    if (mensaje == "Máquina ya existe!")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    M.Idmaquina = txtabreviacion.Text;
                    M.Descripcion = txtmaquina.Text;
                    M.Iddpto = cbdpto.SelectedValue.ToString();
                    DevComponents.DotNetBar.MessageBoxEx.Show(M.ActualizarMaquina(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtabreviacion.Enabled = true;
                txtabreviacion.Focus();
            }

            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvMaquina.SelectedRows.Count > 0)
                {
                    M.Idmaquina = "'" + dtgvMaquina.CurrentRow.Cells[0].Value.ToString() + "'";
                    M.Estado = Convert.ToBoolean(dtgvMaquina.CurrentRow.Cells[3].Value);
                    mensaje = M.ActivarMaquina();
                    if (mensaje == "Desactivado!")
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DevComponents.DotNetBar.MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error:" + ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvMaquina.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvMaquina.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtmaquina.Text = dtgvMaquina.CurrentRow.Cells[1].Value.ToString();
                cbdpto.SelectedValue = dtgvMaquina.CurrentRow.Cells[2].Value.ToString();
                txtmaquina.Focus();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmMaquina_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            cbestado.SelectedIndex = 0;
            txtabreviacion.Focus();
            LlenarGrid();
            LlenarCombo();
           
        }

        private void LlenarCombo()
        {
            cbdpto.DataSource = D.Listar(true);
            cbdpto.DisplayMember = "DEPARTAMENTO";
            cbdpto.ValueMember = "ID_DPTO";
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.ShowDialog();
        }

        private void cbdpto_DropDown(object sender, EventArgs e)
        {
            LlenarCombo();
        }
    }
}
