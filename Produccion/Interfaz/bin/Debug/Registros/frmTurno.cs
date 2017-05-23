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
    public partial class frmTurno : MetroForm
    {
        clsTurno T = new clsTurno();
        public frmTurno()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
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
                    T.Idturno = txtabreviacion.Text;
                    T.Descripcion = txtturno.Text;
                    mensaje = T.RegistrarTurno();
                    if (mensaje == "Turno ya existe!")
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
                    T.Idturno = txtabreviacion.Text;
                    T.Descripcion = txtturno.Text;
                    DevComponents.DotNetBar.MessageBoxEx.Show(T.ActualizarTurno(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dt = T.Listar(valor);
            try
            {
                dtgvTurno.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvTurno.Rows.Add(dt.Rows[x][0]);
                    dtgvTurno.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvTurno.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvTurno.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvTurno.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtturno.Clear();
            txtabreviacion.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvTurno.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvTurno.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtturno.Text = dtgvTurno.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtabreviacion.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvTurno.SelectedRows.Count > 0)
                {
                    T.Idturno = "'" + dtgvTurno.CurrentRow.Cells[0].Value.ToString() + "'";
                    T.Estado = Convert.ToBoolean(dtgvTurno.CurrentRow.Cells[2].Value);
                    mensaje = T.ActivarTurno();
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

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
