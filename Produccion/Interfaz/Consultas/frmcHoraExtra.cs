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
namespace Interfaz.Consultas
{
    public partial class frmcHoraExtra : MetroForm
    {
        public frmcHoraExtra()
        {
            InitializeComponent();
        }
        clsTurno T = new clsTurno();
        clsEmpleado E = new clsEmpleado();
        clsDepartamento D = new clsDepartamento();
        clsEmpresa Em = new clsEmpresa();
        

        private void ComboEm()
        {
            try
            {
                cmbEmpresa.DataSource = Em.Listar(true);
                cmbEmpresa.DisplayMember = "DESCRIPCION";
                cmbEmpresa.ValueMember = "ID_EMPRESA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGrid()
        {
            if (dtpFechaDesde.Value.Date <= dtpFechaHasta.Value.Date)
            {
                E.Desde = dtpFechaDesde.Value;
                E.Hasta = dtpFechaHasta.Value;
                E.Iddpto = cmbDpto2.SelectedValue.ToString();
                E.Empresa = cmbEmpresa.SelectedValue.ToString();
                DataTable dt = E.ObtRegistrosHorasExtras();
                dtgvHorasExtra.DataSource = null;
                dtgvHorasExtra.DataSource = dt;
                dtgvHorasExtra.ClearSelection();
                dtgvHorasExtra.Columns[0].Visible = false;
                dtgvHorasExtra.Columns[8].Visible = false;
                dtgvHorasExtra.Columns[9].Visible = false;
                dtgvHorasExtra.Columns[10].Visible = false;
                dtgvHorasExtra.Columns[11].Visible = false;
                dtgvHorasExtra.Columns[12].Visible = false;
                dtgvHorasExtra.Columns[13].Visible = false;
                dtgvHorasExtra.Columns[14].Visible = false;
                dtgvHorasExtra.Columns[15].Visible = false;
                dtgvHorasExtra.Columns[16].Visible = false;
                dtgvHorasExtra.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvHorasExtra.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold);
            }
            else
            {
                MessageBoxEx.Show("Fecha inicial no puede ser mayor que fecha final.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ComboD()
        {
            try
            {
                cmbDpto2.DataSource = D.Listar2(true);
                cmbDpto2.DisplayMember = "DEPARTAMENTO";
                cmbDpto2.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmHoraExtra_Load(object sender, EventArgs e)
        {
            ComboD();
            ComboEm();
            cmbEmpresa.SelectedValue = "ACERO";           
            //LlenarGrid();
        }


       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid();
            }
            catch (Exception ex)
            {

            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            int diferencia = (int)(dtpFechaHasta.Value - dtpFechaDesde.Value).TotalDays;
            if (diferencia <= 17)
            {
                if (dtpFechaDesde.Value.Date <= dtpFechaHasta.Value.Date)
                {
                    frmReporte obj = new frmReporte();
                    obj.Valor = 23;
                    obj.Nombre = "horas_extra.rdlc";
                    obj.Fechai = dtpFechaDesde.Value;
                    obj.Fechaf = dtpFechaHasta.Value;
                    obj.Empresa = cmbEmpresa.Text;
                    obj.Dpto = cmbDpto2.Text;
                    obj.Iddpto = cmbDpto2.SelectedValue.ToString();
                    obj.Idempresa = cmbEmpresa.SelectedValue.ToString();
                    obj.Show();
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvHorasExtra.SelectedRows.Count > 0)
            {
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    string msj = "";
                    E.Idhora = Convert.ToInt16(dtgvHorasExtra.CurrentRow.Cells[0].Value);
                    msj = E.EliminarRegHoraExtra();
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Registro eliminado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGrid();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
