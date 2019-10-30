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
    public partial class frmIncentivos : MetroForm
    {
        clsDepartamento D = new clsDepartamento();
        clsProducto P = new clsProducto();
        clsIncentivos I = new clsIncentivos();
        clsMaquina M = new clsMaquina();
        clsCargo C = new clsCargo();
        public frmIncentivos()
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
        private void LlenarComboD()
        {
            try
            {
                cbdpto.DataSource = D.Listar(true);
                cbdpto.DisplayMember = "DEPARTAMENTO";
                cbdpto.ValueMember = "ID_DPTO";
                cbdpto2.DataSource = D.Listar(true);
                cbdpto2.DisplayMember = "DEPARTAMENTO";
                cbdpto2.ValueMember = "ID_DPTO";
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
                cbproducto.DataSource = P.Listar2(true);
                cbproducto.DisplayMember = "DESCRIPCION";
                cbproducto.ValueMember = "CODIGO";
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
                cbcargo.DataSource = C.Listar(true);
                cbcargo.DisplayMember = "DESCRIPCION";
                cbcargo.ValueMember = "ID_CARGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void LlenarComboM()
        {
            try
            {
                cbmaquina.DataSource = M.Listar(true);
                cbmaquina.DisplayMember = "DESCRIPCION";
                cbmaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void frmIncentivos_Load(object sender, EventArgs e)
        {
            cbtipo2.SelectedIndex = 0;
            LlenarComboD();
            LlenarComboP();
            LlenarComboM();
            LlenarComboC();
            cbdpto.SelectedValue = "";
            //cbdpto2.SelectedValue = "";
            cbproducto.SelectedValue = "";
            cbcargo.SelectedValue = "";
            cbestado.SelectedIndex = 0;
            cbestado1.SelectedIndex = 0;

            LlenarGrid();
            LlenarGrid2();
            cbtipo.SelectedIndex = 0;
            cbmaquina.Enabled = false;
            Program.Evento = 0;

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
            //cbdpto2.SelectedValue = "Ar";
            //cbtipo2.SelectedIndex = 0;
            dt = I.Listar(valor, cbdpto2.SelectedValue.ToString(), cbtipo2.SelectedItem.ToString());
            try
            {
                dtgvIncentivo.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvIncentivo.Rows.Add(dt.Rows[x][0]);
                    dtgvIncentivo.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvIncentivo.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvIncentivo.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvIncentivo.ClearSelection();
            }
            catch (Exception ex)
            {
               MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarGrid2()
        {
            bool valor = true;
            if (cbestado1.SelectedIndex == 0)
            {
                valor = true;
            }
            else if (cbestado1.SelectedIndex == 1)
            {
                valor = false;
            }
            DataTable dt = new DataTable();
            dt = I.ListarLG(valor);
            try
            {
                dtgvincentivolg.Rows.Clear();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgvincentivolg.Rows.Add(dt.Rows[x][0]);
                    dtgvincentivolg.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgvincentivolg.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgvincentivolg.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                }
                dtgvincentivolg.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabPage1, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    I.Dpto = cbdpto.SelectedValue.ToString();
                    if (cbtipo.SelectedItem.ToString() == "Producto")
                    {
                        I.Producto = cbproducto.SelectedValue.ToString();
                    }
                    else if (cbtipo.SelectedItem.ToString() == "Maquina")
                    {
                        I.Producto = cbmaquina.SelectedValue.ToString();
                    }
                    else if (cbtipo.SelectedItem.ToString() == "Cargo")
                    {
                        I.Producto = cbcargo.SelectedValue.ToString();
                    }
                    I.Tarifa =Convert.ToDecimal(txttarifa.Text);
                    I.Tipo = cbtipo.SelectedItem.ToString();
                    mensaje = I.RegistrarIncentivo();
                    if (mensaje == "Incentivo ya existe!")
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
                    I.Dpto = cbdpto.SelectedValue.ToString();        
                    I.Tarifa = Convert.ToDecimal(txttarifa.Text);
                    if(cbtipo.SelectedItem.ToString()=="Producto")
                    {
                        I.Producto = cbproducto.SelectedValue.ToString();
                    }
                    else if(cbtipo.SelectedItem.ToString() == "Maquina")
                    {
                        I.Producto = cbmaquina.SelectedValue.ToString();
                    }
                    else if (cbtipo.SelectedItem.ToString() == "Cargo")
                    {
                        I.Producto = cbcargo.SelectedValue.ToString();
                    }
                    I.Tipo = cbtipo.SelectedItem.ToString();
                    MessageBoxEx.Show(I.ActualizarIncentivo(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid();
                btnregistrar.Text = "Registrar";
                Program.Evento = 0;
            }

            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txttarifa.Clear();
            cbproducto.SelectedValue = "";
            cbdpto.SelectedValue = "";
            cbcargo.SelectedValue = "";
            txttarifa1.Clear();
            txtdescripcion.Clear();
            txtcodigo.Clear();
            //cbtipo.SelectedIndex = -1;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Text = "Doble click para seleccinar";
            obj.lbinf.Visible = true;
            obj.ShowDialog();
            if (string.IsNullOrEmpty(Program.CodigoP))
            {
                return;
            }
            else
            {
                cbproducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
        }

        private void cbdpto2_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvIncentivo.SelectedRows.Count > 0)
            {
                DataTable cod = new DataTable();
                btnregistrar.Text = "Guardar";
                cbdpto.SelectedValue = cbdpto2.SelectedValue;
                cbtipo.SelectedItem = dtgvIncentivo.CurrentRow.Cells[2].Value.ToString();
                cod = I.CodigoProducto(dtgvIncentivo.CurrentRow.Cells[0].Value.ToString(),cbtipo2.SelectedItem.ToString());
                if(cbtipo2.SelectedItem.ToString()=="Producto")
                {
                    cbproducto.SelectedValue = cod.Rows[0][0].ToString();
                    cbmaquina.Enabled = false;
                    cbcargo.Enabled = false;
                }
                else if(cbtipo2.SelectedItem.ToString()=="Maquina")
                {
                    cbmaquina.SelectedValue = cod.Rows[0][0].ToString();
                    cbproducto.Enabled = false;
                    cbcargo.Enabled = false;
                }
                else if (cbtipo2.SelectedItem.ToString() == "Cargo")
                {
                    cbmaquina.SelectedValue = cod.Rows[0][0].ToString();
                    cbproducto.Enabled = false;
                    cbmaquina.Enabled = false;
                }

                txttarifa.Text = dtgvIncentivo.CurrentRow.Cells[1].Value.ToString();
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
                if (dtgvIncentivo.SelectedRows.Count > 0)
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
                    I.Valor = valor;
                    I.Dpto = cbdpto2.SelectedValue.ToString();
                    DataTable cod = new DataTable();
                    cod = I.CodigoProducto(dtgvIncentivo.CurrentRow.Cells[0].Value.ToString(),cbtipo2.SelectedItem.ToString());
                    I.Producto = cod.Rows[0][0].ToString();
                    mensaje = I.ActivarIncentivo();
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

        private void cbestado_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void cbtipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbtipo.SelectedItem.ToString()=="Producto")
            {
                cbmaquina.Enabled = false;
                cbproducto.Enabled = true;
                cbcargo.Enabled = false;
            }
            if (cbtipo.SelectedItem.ToString() == "Maquina")
            {
                cbproducto.Enabled = false;
                cbmaquina.Enabled = true;
                cbcargo.Enabled = false;
            }
            if (cbtipo.SelectedItem.ToString() == "Cargo")
            {
                cbproducto.Enabled = false;
                cbmaquina.Enabled = false;
                cbcargo.Enabled = true;
            }
        }

        private void cbtipo2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbtipo2.SelectedItem.ToString()=="Maquina")
            {
                LlenarGrid();
            }
            if (cbtipo2.SelectedItem.ToString() =="Cargo")
            {
                LlenarGrid();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCargo obj = new frmCargo();
            obj.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMaquina obj = new frmMaquina();
            obj.ShowDialog();
        }

        private void btnsalir1_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Close();
            }
        }

        private void btnregistrar1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(tabPage2, errorProvider1) == false)
            {
                return;
            }
            string mensaje = "";
            try
            {
                if (Program.Evento == 0)
                {
                    I.Codigo = txtcodigo.Text;
                    I.Descripcion = txtdescripcion.Text;
                    I.Tarifa = Convert.ToDecimal(txttarifa1.Text);       
                    mensaje = I.RegistrarIncentivoLG();
                    if (mensaje == "Incentivo ya existe!")
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
                    I.Codigo = txtcodigo.Text;
                    I.Descripcion = txtdescripcion.Text;
                    I.Tarifa = Convert.ToDecimal(txttarifa1.Text);
                    MessageBoxEx.Show(I.ActualizarIncentivoLG(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                LlenarGrid2();
                btnregistrar1.Text = "Registrar";
                Program.Evento = 0;
                txtcodigo.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnact1_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvincentivolg.SelectedRows.Count > 0)
                {
                    bool valor = true;
                    if (cbestado1.SelectedIndex == 0)
                    {
                        valor = true;
                    }
                    else if (cbestado1.SelectedIndex == 1)
                    {
                        valor = false;
                    }
                    I.Codigo = dtgvincentivolg.CurrentRow.Cells[0].Value.ToString();
                    I.Descripcion = dtgvincentivolg.CurrentRow.Cells[1].Value.ToString();
                    I.Valor = valor;
                    mensaje = I.ActivarIncentivoLG();
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
            LlenarGrid2();
        }

        private void cbestado1_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGrid2();
        }

        private void btneditar1_Click(object sender, EventArgs e)
        {
            if (dtgvincentivolg.SelectedRows.Count > 0)
            {
                txtcodigo.Enabled = false;
                DataTable cod = new DataTable();
                btnregistrar1.Text = "Guardar";
                txtcodigo.Text = dtgvincentivolg.CurrentRow.Cells[0].Value.ToString();
                txtdescripcion.Text= dtgvincentivolg.CurrentRow.Cells[1].Value.ToString();
                txttarifa1.Text = dtgvincentivolg.CurrentRow.Cells[2].Value.ToString();
                Program.Evento = 1;
            }
            else
            {
                MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
