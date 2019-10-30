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
    public partial class frmCliente : MetroForm
    {
        clsDepartamento D = new clsDepartamento();
        clsDestino De = new clsDestino();
        clsCliente C = new clsCliente();
        public frmCliente()
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
        private void ComboDe()
        {
            try
            {
                cmbDestino.DataSource = De.Listar(true);
                cmbDestino.DisplayMember = "DESTINO";
                cmbDestino.ValueMember = "DESTINO";
                cmbDestino.DisplayMember.ToLower();
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
                Dispose();
                Close();
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ComboD();
            ComboDe();
            txtNombre.Focus();
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
                    C.Nombre = txtNombre.Text;
                    C.Destino = cmbDestino.SelectedValue.ToString();
                    C.Iddpto = cmbDpto.SelectedValue.ToString();
                    mensaje = C.RegistrarCliente();
                    if (mensaje == "Cliente ya existe!")
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
                    C.Idcliente = Convert.ToInt32(dtgvCliente.CurrentRow.Cells[0].Value);
                    C.Nombre = txtNombre.Text;
                    C.Destino = cmbDestino.SelectedValue.ToString();
                    C.Iddpto = cmbDpto.SelectedValue.ToString();
                    MessageBoxEx.Show(C.ActualizarCliente(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtNombre.Focus();
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
            dt = C.Listar(valor);
            try
            {
                dtgvCliente.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvCliente.Rows.Add(dt.Rows[x][0]);
                    dtgvCliente.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvCliente.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvCliente.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvCliente.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvCliente.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgvCliente.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                }
                dtgvCliente.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtNombre.Focus();
            cmbDpto.SelectedValue = "";
            cmbDestino.SelectedValue = "";
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvCliente.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtNombre.Text = dtgvCliente.CurrentRow.Cells[1].Value.ToString();
                cmbDestino.SelectedValue = dtgvCliente.CurrentRow.Cells[2].Value.ToString();
                cmbDpto.SelectedValue = dtgvCliente.CurrentRow.Cells[4].Value.ToString();
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
                if (dtgvCliente.SelectedRows.Count > 0)
                {
                    C.Idcliente = Convert.ToInt32(dtgvCliente.CurrentRow.Cells[0].Value.ToString());
                    C.Estado = Convert.ToBoolean(dtgvCliente.CurrentRow.Cells[5].Value);
                    mensaje = C.ActivarCliente();
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
