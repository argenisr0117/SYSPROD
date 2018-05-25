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
using System.Globalization;

namespace Interfaz.Registros
{
    public partial class frmProducto : MetroForm
    {
        clsProducto P = new clsProducto();
        clsCategoria C = new clsCategoria();
        clsUnidad U = new clsUnidad();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void txtcalibre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcalibre.Text.Trim()))

            {
                LLenarCalibre();
            }
            else
            {
                label10.Text = "";
                txtdiampulg.Clear();
                txtdiammm.Clear();
                txtgrosor.Clear();
            }
        }

        private void LLenarCalibre()
        {
            DataTable dt = new DataTable();
            dt = P.GetCalibre(Convert.ToDouble(txtcalibre.Text.Trim()));
            try
            {
                if (dt.Rows.Count > 0)
                {
                    if(Convert.ToDouble(dt.Rows[0]["CALIBRE"])>14)
                    {
                        txtgrosor.Text = "Fino";
                    }
                    else
                    {
                        txtgrosor.Text = "Grueso";
                    }
                    txtdiampulg.Text = dt.Rows[0]["DIAM_PULG"].ToString().Trim();
                    txtdiammm.Text = dt.Rows[0]["DIAM_MM"].ToString().Trim();
                    label10.Text = "";
                }
                else
                {
                    label10.Text = "Calibre no existe!";
                    txtdiampulg.Clear();
                    txtdiammm.Clear();
                    txtgrosor.Clear();
                }
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
      
        private void btnsalir_Click(object sender, EventArgs e)
        {
            if (DevComponents.DotNetBar.MessageBoxEx.Show("¿Desea Salir?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            dt = P.Listar(valor);
            try
            {
                //dtgvProducto.Rows.Clear();
                dtgvProducto.DataSource = null;
                dtgvProducto.DataSource = dt;
                //for (int x = 0; x < dt.Rows.Count; x++)
                //{
                //    dtgvProducto.Rows.Add(dt.Rows[x][0]);
                //    dtgvProducto.Rows[x].Cells[0].Value = dt.Rows[x][1].ToString();
                //    dtgvProducto.Rows[x].Cells[1].Value = dt.Rows[x][2].ToString();
                //    dtgvProducto.Rows[x].Cells[2].Value = dt.Rows[x][3].ToString();
                //    dtgvProducto.Rows[x].Cells[3].Value = dt.Rows[x][10].ToString();
                //    dtgvProducto.Rows[x].Cells[4].Value = dt.Rows[x][8].ToString();
                //    dtgvProducto.Rows[x].Cells[5].Value = dt.Rows[x][4].ToString();
                //    dtgvProducto.Rows[x].Cells[6].Value = dt.Rows[x][7].ToString();
                //    dtgvProducto.Rows[x].Cells[7].Value = dt.Rows[x][9].ToString();
                //}
                //dtgvProducto.ClearSelection();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpiar()
        {
            txtcodigo.Clear();
            txtdescripcion.Clear();
            txtcalibre.Clear();
            txtcodigo.Focus();
            cbcategoria.SelectedValue = -1;
            cbunidad.SelectedValue = "";
            txtpeso.Clear();
            txtfactor.Clear();
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
                    P.Codigo = txtcodigo.Text.Trim();
                    P.Descripcion = txtdescripcion.Text.Trim();
                    P.Idunidad = cbunidad.SelectedValue.ToString();
                    P.Idcategoria =Convert.ToInt32(cbcategoria.SelectedValue);
                    P.Calibre = Convert.ToDouble(txtcalibre.Text);
                    P.Grosor = txtgrosor.Text;
                    P.Diam_mm = Convert.ToDecimal(txtdiammm.Text.Trim());
                    P.Diam_pulg = Convert.ToDecimal(txtdiampulg.Text.Trim());
                    P.PesoLBS = Convert.ToDouble(txtpeso.Text);
                    P.FactorQQS = Convert.ToDouble(txtfactor.Text);
                    mensaje = P.RegistrarProducto();
                    if (mensaje == "Producto ya existe!")
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
                    P.Codigo = txtcodigo.Text;
                    P.Descripcion = txtdescripcion.Text;
                    P.Idunidad = cbunidad.SelectedValue.ToString();
                    P.Idcategoria =Convert.ToInt32(cbcategoria.SelectedValue);
                    P.Calibre = Convert.ToDouble(txtcalibre.Text);
                    P.Diam_pulg =Convert.ToDecimal(txtdiampulg.Text);
                    P.Diam_mm = Convert.ToDecimal(txtdiammm.Text);
                    P.Grosor = txtgrosor.Text;
                    P.PesoLBS = Convert.ToDouble(txtpeso.Text);
                    P.FactorQQS = Convert.ToDouble(txtfactor.Text);
                    DevComponents.DotNetBar.MessageBoxEx.Show(P.ActualizarProducto(), "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dtgvProducto.SelectedRows.Count > 0)
            {
                btnregistrar.Text = "Guardar";
                txtcodigo.Text = dtgvProducto.CurrentRow.Cells[0].Value.ToString();
                txtcodigo.Enabled = false;
                txtdescripcion.Text = dtgvProducto.CurrentRow.Cells[1].Value.ToString();
                cbunidad.SelectedValue = dtgvProducto.CurrentRow.Cells[2].Value.ToString();
                cbcategoria.SelectedValue = dtgvProducto.CurrentRow.Cells[4].Value.ToString();
                txtcalibre.Text = dtgvProducto.CurrentRow.Cells[5].Value.ToString();
                txtpeso.Text = dtgvProducto.CurrentRow.Cells[3].Value.ToString();
                txtdescripcion.Focus();
                Program.Evento = 1;
            }
            else
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Seleccione un registro!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                if (dtgvProducto.SelectedRows.Count > 0)
                {
                    P.Codigo = "'" + dtgvProducto.CurrentRow.Cells[0].Value.ToString() + "'";
                    P.Estado = Convert.ToBoolean(dtgvProducto.CurrentRow.Cells[7].Value);
                    mensaje = P.ActivarProducto();
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

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Program.Evento = 0;
            cbestado.SelectedIndex = 0;
            txtcodigo.Focus();
            LlenarGrid();
            LlenarComboU();
            LlenarComboC();
            cbunidad.SelectedValue = "";
            cbcategoria.SelectedValue = -1;
        }
        private void LlenarComboU()
        {
            cbunidad.DataSource = U.Listar(true);
            cbunidad.DisplayMember = "DESCRIPCION";
            cbunidad.ValueMember = "ID_UNIDAD";
        }
        private void LlenarComboC()
        {
            cbcategoria.DataSource = C.Listar(true);
            cbcategoria.DisplayMember = "DESCRIPCION";
            cbcategoria.ValueMember = "ID_CATEGORIA";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUnidad obj = new frmUnidad();
            obj.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCategoria obj = new frmCategoria();
            obj.ShowDialog();
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        private void cbunidad_DropDown(object sender, EventArgs e)
        {
            LlenarComboU();
        }

        private void cbcategoria_DropDown(object sender, EventArgs e)
        {
            LlenarComboC();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProducto obj = new Consultas.frmcProducto();
            obj.lbinf.Visible = true;
            obj.ShowDialog();
            if(Program.Evento==1)
            {
                txtcodigo.Enabled = false;
                btnregistrar.Text = "Guardar";
                txtcodigo.Text = Program.CodigoP;
                txtdescripcion.Text = Program.DescripcionP;
                cbunidad.SelectedValue = Program.UnidadP;
                LlenarComboC();
                cbcategoria.Text = Program.CategoriaP;
                txtcalibre.Text = Program.CalibreP.ToString();
                txtdescripcion.Focus();
            }
            else
            {
                return;
            }
           
        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpeso.Text.Trim()))

            {
                Double var =Convert.ToDouble(txtpeso.Text);
                var = var/100;
                txtfactor.Text = var.ToString("N6");
            }
            else
            {
                txtfactor.Clear();
            }
          
        }
    }
}
