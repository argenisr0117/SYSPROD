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

namespace Interfaz.Registros
{
    

    public partial class frmUnidad : DevComponents.DotNetBar.Metro.MetroForm
    {
        private clsUnidad U = new clsUnidad();
        public frmUnidad()
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

        private void frmUnidad_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtabreviacion.Focus();
            cbestado.SelectedIndex = 0;
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
            dt = U.Listar(valor);
            try
            {
                dtgvUnidad.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvUnidad.Rows.Add(dt.Rows[x][0]);
                    dtgvUnidad.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvUnidad.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvUnidad.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvUnidad.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtunidad.Clear();
            txtabreviacion.Focus();
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
                    U.Idunidad = txtabreviacion.Text;
                    U.Descripcion = txtunidad.Text;
                    mensaje = U.RegistrarUnidad();
                    if (mensaje == "Unidad ya existe!")
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
                    U.Idunidad = txtabreviacion.Text;
                    U.Descripcion = txtunidad.Text;
                    DevComponents.DotNetBar.MessageBoxEx.Show(U.ActualizarUnidad(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvUnidad.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvUnidad.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtunidad.Text = dtgvUnidad.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (dtgvUnidad.SelectedRows.Count > 0)
                {
                    U.Idunidad = "'" + dtgvUnidad.CurrentRow.Cells[0].Value.ToString() + "'";
                    U.Estado = Convert.ToBoolean(dtgvUnidad.CurrentRow.Cells[2].Value);
                    mensaje = U.ActivarUnidad();
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
    }
}
