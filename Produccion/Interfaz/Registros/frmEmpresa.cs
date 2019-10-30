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
using Intermedia;
using DevComponents.DotNetBar.Metro;

namespace Interfaz.Registros
{
    public partial class frmEmpresa : MetroForm
    {
        private clsEmpresa E = new clsEmpresa();
        public frmEmpresa()
        {
            InitializeComponent();
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
                    E.Idempresa = txtabreviacion.Text;
                    E.Descripcion = txtempresa.Text;
                    mensaje = E.RegistrarEmpresa();
                    if (mensaje == "Cargo ya existe!")
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
                    E.Idempresa = txtabreviacion.Text;
                    E.Descripcion = txtempresa.Text;
                    MessageBoxEx.Show(E.ActualizarEmpresa(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvEmpresa.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvEmpresa.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtempresa.Text = dtgvEmpresa.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvEmpresa.SelectedRows.Count > 0)
                {
                    E.Idempresa = "'" + dtgvEmpresa.CurrentRow.Cells[0].Value.ToString() + "'";
                    E.Estado = Convert.ToBoolean(dtgvEmpresa.CurrentRow.Cells[2].Value);
                    mensaje = E.ActivarEmpresa();
                    if (mensaje == "Desactivado!")
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show("Error:" + ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarGrid();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            dt = E.Listar(valor);
            try
            {
                dtgvEmpresa.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvEmpresa.Rows.Add(dt.Rows[x][0]);
                    dtgvEmpresa.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvEmpresa.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvEmpresa.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvEmpresa.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtempresa.Clear();
            txtabreviacion.Focus();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtabreviacion.Focus();
            cbestado.SelectedIndex = 0;
        }
    }
}
