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
    public partial class frmPermisos : MetroForm
    {
        clsUsuario U = new clsUsuario();

        public frmPermisos()
        {
            InitializeComponent();
        }
        private void ComboU()
        {
            try
            {
                cmbUsuario.DataSource = U.Listar();
                cmbUsuario.DisplayMember = "USUARIO";
                cmbUsuario.ValueMember = "ID_USUARIO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmPermisos_Load(object sender, EventArgs e)
        {
            ComboU();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int mensaje;
                U.Idusuario = Convert.ToInt32(cmbUsuario.SelectedValue);
                U.Proddiaria = cBProddiaria.Checked;
                U.Prodtref = cBprodtref.Checked;
                U.Prodgalv = cbProdgalv.Checked;
                U.Prodindm = cBprodindm.Checked;
                U.Congen = cBcongeneral.Checked;
                U.Reggen = cBreggeneral.Checked;
                U.Ediindm = cBeditarindm.Checked;
                U.Eliindm = cbeliminarIndm.Checked;
                U.Mosindm = cbMostrarIndm.Checked;
                U.Expindm = cBExportarIndm.Checked;
                U.Fdesindm = cBFechadindm.Checked;
                U.Fhasindm = cBfechahindm.Checked;
                U.Editref = cBeditartref.Checked;
                U.Elitref = cBeliminarTref.Checked;
                U.Mostref = cbMostrartref.Checked;
                U.Exptref = cBexportartref.Checked;
                U.Filtref = cBfiltartref.Checked;
                U.Fdestref = cbFechadtref.Checked;
                U.Fhastref = cBfechahtref.Checked;
                U.Reimtref = cbReimprimirTref.Checked;
                U.Acucong = cBacumuladoM.Checked;
                U.Inccong = cBincentivos.Checked;
                U.Empcong = cBEmpresa.Checked;
                U.Ciecong = cbCierreM.Checked;
                U.Cieacong = cBcierreA.Checked;
                U.Filcong = cBFiltros.Checked;

                mensaje = U.RegistrarActPermisos();
                if (mensaje == 1)
                {
                    MessageBoxEx.Show("Guardado con éxito", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (mensaje == 0)
                {
                    MessageBoxEx.Show("Actualizado con éxito", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
           
        }

        private void cmbUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                U.Idusuario = Convert.ToInt32(cmbUsuario.SelectedValue);
                U.Usuario = "";
                dt = U.ObtenerPermisos();
                cBProddiaria.Checked = Convert.ToBoolean(dt.Rows[0][1]);
                cBreggeneral.Checked = Convert.ToBoolean(dt.Rows[0][2]);
                cBcongeneral.Checked = Convert.ToBoolean(dt.Rows[0][3]);
                cBprodtref.Checked = Convert.ToBoolean(dt.Rows[0][4]);
                cbProdgalv.Checked = Convert.ToBoolean(dt.Rows[0][5]);
                cBprodindm.Checked = Convert.ToBoolean(dt.Rows[0][6]);
                cBeditarindm.Checked = Convert.ToBoolean(dt.Rows[0][7]);
                cbeliminarIndm.Checked = Convert.ToBoolean(dt.Rows[0][8]);
                cbMostrarIndm.Checked = Convert.ToBoolean(dt.Rows[0][9]);
                cBExportarIndm.Checked = Convert.ToBoolean(dt.Rows[0][10]);
                cBFechadindm.Checked = Convert.ToBoolean(dt.Rows[0][11]);
                cBfechahindm.Checked = Convert.ToBoolean(dt.Rows[0][12]);
                cBeditartref.Checked = Convert.ToBoolean(dt.Rows[0][13]);
                cBeliminarTref.Checked = Convert.ToBoolean(dt.Rows[0][14]);
                cbMostrartref.Checked = Convert.ToBoolean(dt.Rows[0][15]);
                cBfiltartref.Checked = Convert.ToBoolean(dt.Rows[0][16]);
                cBexportartref.Checked = Convert.ToBoolean(dt.Rows[0][17]);
                cbFechadtref.Checked = Convert.ToBoolean(dt.Rows[0][18]);
                cBfechahtref.Checked = Convert.ToBoolean(dt.Rows[0][19]);
                cbReimprimirTref.Checked= Convert.ToBoolean(dt.Rows[0][20]);
                cBacumuladoM.Checked= Convert.ToBoolean(dt.Rows[0][21]);
                cBincentivos.Checked= Convert.ToBoolean(dt.Rows[0][22]);
                cBEmpresa.Checked= Convert.ToBoolean(dt.Rows[0][23]);
                cbCierreM.Checked= Convert.ToBoolean(dt.Rows[0][24]);
                cBcierreA.Checked= Convert.ToBoolean(dt.Rows[0][25]);
                cBFiltros.Checked= Convert.ToBoolean(dt.Rows[0][26]);
            }
            catch(Exception ex)
            {

            }
           
        }
    }
}
