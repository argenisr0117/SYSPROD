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
    public partial class frmCargo : MetroForm
    {
        private clsCargo C = new clsCargo();
        public frmCargo()
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
            if(Utilidades.ValidarForm(this,errorProvider1)==false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    C.Idcargo = txtabreviacion.Text;
                    C.Descripcion = txtcargo.Text;
                    mensaje = C.RegistrarCargo();
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
                    C.Idcargo = txtabreviacion.Text;
                    C.Descripcion = txtcargo.Text;
                    MessageBoxEx.Show(C.ActualizarCargo(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtabreviacion.Enabled = true;
                txtabreviacion.Focus();
            }
            
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            bool valor=true;
            if(cbestado.SelectedIndex==0)
            {
                valor = true;
            }
            else if(cbestado.SelectedIndex==1)
            {
                valor = false;
            }
            DataTable dt = new DataTable();
            dt = C.Listar(valor);
            try
            {
                dtgvCargo.Rows.Clear();
                for(int x=0; x<dt.Rows.Count;x++)
                {
                    dtgvCargo.Rows.Add(dt.Rows[x][0]);
                    dtgvCargo.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvCargo.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvCargo.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvCargo.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message,"Sistema de Producción",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtabreviacion.Clear();
            txtcargo.Clear();
            txtabreviacion.Focus();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if(dtgvCargo.SelectedRows.Count>0)
            {
                btnregistrar.Text = "Guardar";
                txtabreviacion.Text = dtgvCargo.CurrentRow.Cells[0].Value.ToString();
                txtabreviacion.Enabled = false;
                txtcargo.Text = dtgvCargo.CurrentRow.Cells[1].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!","Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmCargo_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            LlenarGrid();
            txtabreviacion.Focus();
            cbestado.SelectedIndex = 0;
        }

        private void cbestado_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvCargo.SelectedRows.Count > 0)
                {
                    C.Idcargo = "'" + dtgvCargo.CurrentRow.Cells[0].Value.ToString() + "'";
                    C.Estado = Convert.ToBoolean(dtgvCargo.CurrentRow.Cells[2].Value);
                    mensaje = C.ActivarCargo();
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
    }
}
