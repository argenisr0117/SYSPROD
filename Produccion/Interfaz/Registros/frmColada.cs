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
using DevComponents.DotNetBar;
using Intermedia;

namespace Interfaz.Registros
{
    public partial class frmColada : MetroForm
    {
        clsColada C = new clsColada();
        public frmColada()
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
                    C.Colada = txtcolada.Text;
                    mensaje = C.RegistrarColada();
                    if (mensaje == "Colada ya existe!")
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
                    C.Idcolada = Convert.ToInt32(dtgvColada.CurrentRow.Cells[0].Value);
                    C.Colada = txtcolada.Text;
                    DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarColada(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "REGISTRAR";
                Program.Evento = 0;
                txtcolada.Focus();
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
            dt = C.Listar(valor);
            try
            {
                dtgvColada.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvColada.Rows.Add(dt.Rows[x][0]);
                    dtgvColada.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvColada.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvColada.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvColada.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtcolada.Clear();
            txtcolada.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvColada.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "GUARDAR";
                txtcolada.Text = dtgvColada.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmColada_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtcolada.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvColada.SelectedRows.Count > 0)
                {
                    C.Idcolada = Convert.ToInt32(dtgvColada.CurrentRow.Cells[0].Value.ToString());
                    C.Estado = Convert.ToBoolean(dtgvColada.CurrentRow.Cells[2].Value);
                    mensaje = C.ActivarColada();
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

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
