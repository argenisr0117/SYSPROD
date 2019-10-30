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
    public partial class frmCategoria : MetroForm
    {
        private clsCategoria C = new clsCategoria();
        public frmCategoria()
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
                    C.Descripcion = txtcategoria.Text;
                    mensaje = C.RegistrarCategoria();
                    if (mensaje == "Categoria ya existe!")
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
                    C.Idcategoria = Convert.ToInt32(dtgvCategoria.CurrentRow.Cells[0].Value);
                    C.Descripcion = txtcategoria.Text;
                    DevComponents.DotNetBar.MessageBoxEx.Show(C.ActualizarCategoria(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtcategoria.Focus();
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
                dtgvCategoria.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvCategoria.Rows.Add(dt.Rows[x][0]);
                    dtgvCategoria.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvCategoria.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvCategoria.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvCategoria.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtcategoria.Clear();
            txtcategoria.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvCategoria.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtcategoria.Text = dtgvCategoria.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtcategoria.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvCategoria.SelectedRows.Count > 0)
                {
                    C.Idcategoria=Convert.ToInt32(dtgvCategoria.CurrentRow.Cells[0].Value.ToString());
                    C.Estado = Convert.ToBoolean(dtgvCategoria.CurrentRow.Cells[2].Value);
                    mensaje = C.ActivarCategoria();
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
