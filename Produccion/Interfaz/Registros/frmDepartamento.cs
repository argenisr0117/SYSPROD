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
using System.Data.SqlClient;

namespace Interfaz.Registros
{
    public partial class frmDepartamento : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsDepartamento D = new clsDepartamento();
        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            cbestado.SelectedIndex = 0;
            Program.Evento = 0;
            txtabreviacion.Focus();
            LlenarGrid();
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
            dt = D.Listar(valor);
            try
            {
                dtgvDepartamento.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvDepartamento.Rows.Add(dt.Rows[x][0]);
                    dtgvDepartamento.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvDepartamento.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvDepartamento.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvDepartamento.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtdpto.Clear();
            txtabreviacion.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvDepartamento.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvDepartamento.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtdpto.Text = dtgvDepartamento.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                    D.Iddpto = txtabreviacion.Text;
                    D.Departamento = txtdpto.Text;
                    mensaje = D.RegistrarDepartamento();
                    if (mensaje == "Departamento ya existe!")
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
                    D.Iddpto = txtabreviacion.Text;
                    D.Departamento = txtdpto.Text;
                    DevComponents.DotNetBar.MessageBoxEx.Show(D.ActualizarDepartamento(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvDepartamento.SelectedRows.Count > 0)
                {
                    D.Iddpto = "'"+dtgvDepartamento.CurrentRow.Cells[0].Value.ToString()+"'";
                    D.Estado = Convert.ToBoolean(dtgvDepartamento.CurrentRow.Cells[2].Value);
                    mensaje = D.ActivarDepartamento();
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
            catch(Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Error:"+ ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid();
        }
    }
}
