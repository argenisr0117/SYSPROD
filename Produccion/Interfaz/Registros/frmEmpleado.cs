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
using DevComponents.DotNetBar;

namespace Interfaz.Registros
{
    public partial class frmEmpleado : MetroForm
    {
        private clsDepartamento D = new clsDepartamento();
        private clsEmpleado E = new clsEmpleado();
        private clsCargo C = new clsCargo();
        private clsEmpresa P = new clsEmpresa();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
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
            E.Iddpto = "";
            dt = E.Listar(valor);
            try
            {
                dtgvEmpleado.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvEmpleado.Rows.Add(dt.Rows[x][0]);
                    dtgvEmpleado.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvEmpleado.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvEmpleado.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgvEmpleado.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgvEmpleado.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgvEmpleado.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                    dtgvEmpleado.Rows[x].Cells[6].Value = dt.Rows[x][6].ToString();
                    dtgvEmpleado.Rows[x].Cells[7].Value = dt.Rows[x][7].ToString();
                    dtgvEmpleado.Rows[x].Cells[8].Value = dt.Rows[x][8].ToString();
                }
                dtgvEmpleado.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtcodigo.Clear();
            txtnombre.Clear();
            txtcodigo.Focus();
            cbdpto.SelectedText = null;
            for(int i=0; i<clbCargo.Items.Count;i++)
            {
                clbCargo.SetItemChecked(i, false);
            }
            cbdpto.SelectedValue = "";
            cbempresa.SelectedValue = "";
            cbcargoi.SelectedIndex = -1;
        }
        private void ValoresCheck()
        {
            if (clbCargo.GetItemChecked(0))
            {
                Boolean ayudante = true;
                E.Ayudante = ayudante;
            }
            else
            {
                Boolean ayudante = false;
                E.Ayudante = ayudante;
            }
            if (clbCargo.GetItemChecked(1))
            {
                Boolean operador = true;
                E.Operador = operador;
            }
            else
            {
                Boolean operador = false;
                E.Operador = operador;
            }
            if (clbCargo.GetItemChecked(2))
            {
                Boolean supervisor = true;
                E.Supervisor = supervisor;
            }
            else
            {
                Boolean supervisor = false;
                E.Supervisor = supervisor;
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
                    E.Idempleado = txtcodigo.Text;
                    E.Nombre = txtnombre.Text;
                    E.Iddpto = cbdpto.SelectedValue.ToString();
                    E.Empresa = cbempresa.SelectedValue.ToString();
                    E.Cargo = cbcargoi.SelectedValue.ToString();
                    ValoresCheck();
                    mensaje = E.RegistrarEmpleado();
                    if (mensaje == "Empleado ya existe!")
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
                    E.Idempleado = txtcodigo.Text;
                    E.Nombre = txtnombre.Text;
                    E.Iddpto = cbdpto.SelectedValue.ToString();
                    E.Empresa = cbempresa.SelectedValue.ToString();
                    E.Cargo = cbcargoi.SelectedValue.ToString();
                    ValoresCheck();
                    MessageBoxEx.Show(E.ActualizarEmpleado(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
                txtcodigo.Enabled = true;
                txtcodigo.Focus();
            }

            catch (Exception ex)
            {
              MessageBoxEx.Show(ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvEmpleado.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtcodigo.Text = dtgvEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtcodigo.Enabled = false;
                txtnombre.Text = dtgvEmpleado.CurrentRow.Cells[1].Value.ToString();
                cbdpto.SelectedValue = dtgvEmpleado.CurrentRow.Cells[2].Value.ToString();
                clbCargo.SetItemChecked(0,Convert.ToBoolean(dtgvEmpleado.CurrentRow.Cells[3].Value));
                clbCargo.SetItemChecked(1, Convert.ToBoolean(dtgvEmpleado.CurrentRow.Cells[4].Value));
                clbCargo.SetItemChecked(2, Convert.ToBoolean(dtgvEmpleado.CurrentRow.Cells[5].Value));
                txtnombre.Focus();
                cbempresa.SelectedValue= dtgvEmpleado.CurrentRow.Cells[7].Value.ToString();
                cbcargoi.SelectedValue = dtgvEmpleado.CurrentRow.Cells[8].Value.ToString();
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
                if (dtgvEmpleado.SelectedRows.Count > 0)
                {
                    E.Idempleado = "'" + dtgvEmpleado.CurrentRow.Cells[0].Value.ToString() + "'";
                    E.Estado = Convert.ToBoolean(dtgvEmpleado.CurrentRow.Cells[6].Value);
                    mensaje = E.ActivarEmpleado();
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

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            cbestado.SelectedIndex = 0;
            txtcodigo.Focus();
            LlenarGrid();
            LlenarCombo();
            cbdpto.SelectedValue = "";
            cbcargoi.SelectedValue = "";
            cbempresa.SelectedValue = "";
            LlenarComboC();
            LlenarComboP();
        }
        private void LlenarCombo()
        {
            try
            {
                cbdpto.DataSource = D.Listar(true);
                cbdpto.DisplayMember = "DEPARTAMENTO";
                cbdpto.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void LlenarComboP()
        {
            try
            {
                cbempresa.DataSource = P.Listar(true);
                cbempresa.DisplayMember = "DESCRIPCION";
                cbempresa.ValueMember = "ID_EMPRESA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void LlenarComboC()
        {
            try
            {
                //clbCargo.DataSource = C.Listar(true);
                //clbCargo.DisplayMember = "DESCRIPCION";
                //clbCargo.ValueMember = "DESCRIPCION";

                cbcargoi.DataSource = C.Listar(true);
                cbcargoi.DisplayMember = "DESCRIPCION";
                cbcargoi.ValueMember = "ID_CARGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.ShowDialog();
        }

        private void cbdpto_DropDown(object sender, EventArgs e)
        {
            try
            {
                LlenarCombo();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }
    }
}
