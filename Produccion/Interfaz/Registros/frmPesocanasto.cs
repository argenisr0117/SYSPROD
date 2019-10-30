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
    public partial class frmPesocanasto : MetroForm
    {
        clsPeso_Canasto P = new clsPeso_Canasto();
        public frmPesocanasto()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    P.Peso =Convert.ToDouble(txtpeso.Text);
                    mensaje = P.RegistrarPeso();
                    if (mensaje == "Peso ya existe!")
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
                    P.Idpeso = Convert.ToInt32(dtgvPeso.CurrentRow.Cells[0].Value);
                    P.Peso =Convert.ToDouble(txtpeso.Text);
                       MessageBoxEx.Show(P.ActualizarPeso(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "REGISTRAR";
                Program.Evento = 0;
                txtpeso.Focus();
            }

            catch (Exception ex)
            {
               MessageBoxEx.Show(ex.Message);
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
            dt = P.Listar(valor);
            try
            {
                dtgvPeso.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvPeso.Rows.Add(dt.Rows[x][0]);
                    dtgvPeso.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvPeso.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvPeso.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvPeso.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtpeso.Clear();
            txtpeso.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvPeso.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "GUARDAR";
                txtpeso.Text = dtgvPeso.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmPesocanasto_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtpeso.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvPeso.SelectedRows.Count > 0)
                {
                    P.Idpeso = Convert.ToInt32(dtgvPeso.CurrentRow.Cells[0].Value.ToString());
                    P.Estado = Convert.ToBoolean(dtgvPeso.CurrentRow.Cells[2].Value);
                    mensaje = P.ActivarPeso();
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
