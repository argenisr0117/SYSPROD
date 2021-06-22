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
    public partial class frmControlAlm : MetroForm
    {
        clsControlAlmacen Ca = new clsControlAlmacen();
        clsOrdenProduccion O = new clsOrdenProduccion();
        int idsalida = 0;
        public frmControlAlm()
        {
            InitializeComponent();
        }

        private void ComboU()
        {
            try
            {
                if (Program.Almacen == "LINEA GALV")
                {
                    cb_Uso.DataSource = O.ListadoUsoAlambre(1);
                }
                else
                {
                    cb_Uso.DataSource = O.ListadoUsoAlambre(2);
                }
                cb_Uso.DisplayMember = "DESCRIPCION";
                cb_Uso.ValueMember = "ID_USO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboAlmacen()
        {
            try
            {
                cmbAlmacen.DataSource = Ca.Listar(true);
                cmbAlmacen.DisplayMember = "DESCRIPCION";
                cmbAlmacen.ValueMember = "ID_ALMACEN";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmControlAlm_Load(object sender, EventArgs e)
        {
            ComboU();
            dtp_Fechai.Value = DateTime.Now.AddDays(-1);
            Text = Text + Program.Almacen;
            lb_Titulo.Text = lb_Titulo.Text + Program.Almacen;
            ComboAlmacen();
            cmbAlmacen.Text = Program.Almacen;
            LLenarGrid();
            if (Program.Almacen == "LINEA GALV")
            {
                cb_Uso.Text = "PROCESO DE GALVANIZACIÓN";
            }
            else
            {
                cb_Uso.SelectedIndex = -1;
            }
            Program.Editar = 0;
        }

        private void LLenarGrid()
        {
            try
            {
                dtgv_Entradas.DataSource = null;
                DataTable dt = new DataTable();
                Ca.Fechai = dtp_Fechai.Value;
                Ca.Fechaf = dtp_Fechaf.Value;
                Ca.Reporte = txt_NoReporte.Text.Trim();
                Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                dt = Ca.ObtenerEntradasAlmacen();
                dtgv_Entradas.DataSource = dt;
                dtgv_Entradas.ClearSelection();
                //dtgv_Entradas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgv_Entradas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgv_Entradas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgv_Entradas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //dtgv_Entradas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtp_Fechai.Value.Date <= dtp_Fechaf.Value.Date)
            {
                LLenarGrid();
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial no puede ser mayor que fecha final.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_InventarioDet_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 18;
                obj.Reporte = "INVENTARIO A LA FECHA";
                obj.Nombre = "inventario_detallado.rdlc";
                obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                obj.Almacen = cmbAlmacen.Text;
                obj.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void btn_InventarioRes_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 18;
                obj.Reporte = "INVENTARIO A LA FECHA";
                obj.Nombre = "inventario_resumido.rdlc";
                obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                obj.Almacen = cmbAlmacen.Text;
                obj.Show();
            }
            catch (Exception)
            {
            }
        }

        private void btn_VerEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 19;
                obj.Reporte = "ENTRADA A INVENTARIO";
                obj.Nombre = "entrada_inventario.rdlc";
                obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                obj.Almacen = cmbAlmacen.Text;
                obj.Fechai = dtp_Fechai.Value;
                obj.Fechaf = dtp_Fechaf.Value;
                obj.NoReporte = txt_NoReporte.Text.Trim();
                obj.Show();
            }
            catch (Exception)
            {
            }
        }

        private void txt_Rollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)80)
            {
                e.Handled = true;
                txt_Peso.Focus();
            }
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean agregado = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                Ca.Tarjeta = txt_Rollo.Text.Trim();
                Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                int msj = Ca.VerificarBobinaSalida();
                if (msj == 0)
                {
                    for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
                    {
                        if (txt_Rollo.Text == dtgv_Salida.Rows[x].Cells[0].Value.ToString())
                        {
                            agregado = true;
                        }
                    }
                    if (agregado)
                    {
                        agregado = false;
                        MessageBoxEx.Show("Está bobina ya ha sido agregada.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Rollo.Clear();
                        txt_Peso.Clear();
                        txt_Rollo.Focus();
                    }
                    else
                    {
                        dtgv_Salida.Rows.Add(txt_Rollo.Text, txt_Peso.Text);
                        CalcularTotal();
                    }
                }
                else if (msj == 1)
                {
                    MessageBoxEx.Show("Bobina ya tiene salida", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (msj == 2)
                {
                    MessageBoxEx.Show("Bobina no tiene existe en inventario.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txt_Peso.Clear();
                txt_Rollo.Clear();
                txt_Rollo.Focus();
            }
        }

        private void dtgv_Salida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult var;
                var = MessageBoxEx.Show("Desea eliminar la bobina?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (var == DialogResult.Yes)
                {
                    if (Program.Editar == 1)
                    {
                        Ca.Tarjeta = dtgv_Salida.CurrentRow.Cells[0].Value.ToString();
                        Ca.EliminarBobinaSalidaAlmacen();
                    }
                    dtgv_Salida.Rows.RemoveAt(dtgv_Salida.CurrentRow.Index);
                    CalcularTotal();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void CalcularTotal()
        {
            double total = 0;
            for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
            {
                total = total + Convert.ToDouble(dtgv_Salida.Rows[x].Cells[1].Value);
            }
            total = total / 100;
            lb_Total.Text = total.ToString() + " " + "QQS.";
            lb_Totalc.Text = dtgv_Salida.Rows.Count.ToString();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            if (Program.Editar == 0)
            {
                idsalida = 0;
            }

            try
            {
                if (dtgv_Salida.Rows.Count > 0)
                {
                    Ca.Fecha = dtp_FechaSalida.Value;
                    Ca.Nota = txt_Nota.Text;
                    Ca.Iduso = Convert.ToInt16(cb_Uso.SelectedValue);
                    Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                    if (Program.Editar == 1)
                    {
                        Ca.ActualizarSalidaInventario();
                    }
                    else
                    {
                        idsalida = Ca.RegistrarSalidaInventario();
                    }
                    if (idsalida > 0)
                    {
                        for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
                        {
                            Ca.Tarjeta = dtgv_Salida.Rows[x].Cells[0].Value.ToString();
                            Ca.Idsalida = idsalida;
                            Ca.RegistrarDetalleSalidaInventario();
                        }
                        if (Program.Editar == 1)
                        {
                            MessageBoxEx.Show("Salida actualizada.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Registrar.Text = "REGISTRAR";
                        }
                        else
                        {
                            MessageBoxEx.Show("Salida registrada.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Limpiar();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Program.Editar = 0;
            }
            catch (Exception ex)
            {
            }
        }
        private void Limpiar()
        {
            txt_Nota.Clear();
            dtgv_Salida.Rows.Clear();
            cb_Uso.SelectedIndex = -1;
            lb_Total.Text = "0.00 QQS.";
            lb_Totalc.Text = "0";
            cb_Uso.SelectedIndex = -1;
        }

        private void btn_VerSalida_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 20;
                obj.Reporte = "SALIDA DE INVENTARIO";
                obj.Nombre = "salida_inventario.rdlc";
                obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                obj.Almacen = cmbAlmacen.Text;
                obj.Fechai = dtp_FechaiSalida.Value;
                obj.Fechaf = dtp_FechafSalida.Value;
                obj.Producto = "0";
                obj.Iduso = 0;
                obj.Show();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btn_BuscarSalida_Click(object sender, EventArgs e)
        {
            LlenarGridHistorialSalida();
        }
        private void LlenarGridHistorialSalida()
        {
            try
            {
                DataTable dt = new DataTable();
                Ca.Fechai = dtp_FechaiSalida.Value;
                Ca.Fechaf = dtp_FechafSalida.Value;
                Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                dt.Rows.Clear();
                dt = Ca.ObtenerHistorialSalidaAlmacen();

                dtgv_HistorialSalida.DataSource = null;
                dtgv_HistorialSalida.DataSource = dt;
                dtgv_HistorialSalida.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
            }
        }

        private void dtgv_HistorialSalida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.Editar = 1;
                DataTable dt = new DataTable();
                Ca.Idsalida = Convert.ToInt16(dtgv_HistorialSalida.CurrentRow.Cells[0].Value);
                idsalida = Convert.ToInt16(dtgv_HistorialSalida.CurrentRow.Cells[0].Value);
                dt = Ca.ObtenerDetalleSalidaAlmacen();
                Limpiar();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgv_Salida.Rows.Add(dt.Rows[x][0]);
                    dtgv_Salida.Rows[x].Cells[0].Value = dt.Rows[x][4].ToString();
                    dtgv_Salida.Rows[x].Cells[1].Value = dt.Rows[x][5].ToString();
                }
                dtp_FechaSalida.Value = Convert.ToDateTime(dt.Rows[0][1]);
                cb_Uso.SelectedValue = Convert.ToInt32(dt.Rows[0][2]);
                txt_Nota.Text = dt.Rows[0][3].ToString();
                CalcularTotal();
                btn_Registrar.Text = "ACTUALIZAR";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}