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
    public partial class frmMaquinasParadas : MetroForm
    {
        public frmMaquinasParadas()
        {
            InitializeComponent();
        }
        clsDepartamento D = new clsDepartamento();
        clsMaquina M = new clsMaquina();
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        
        private void ComboD()
        {
            try
            {
                cmbDpto.DataSource = D.Listar2(true);
                cmbDpto.DisplayMember = "DEPARTAMENTO";
                cmbDpto.ValueMember = "ID_DPTO";
                cmbDpto2.DataSource = D.Listar2(true);
                cmbDpto2.DisplayMember = "DEPARTAMENTO";
                cmbDpto2.ValueMember = "ID_DPTO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboM()
        {
            try
            {
                cmbMotivos.DataSource = Mo.ListadoMotivos();
                cmbMotivos.DisplayMember = "DESCRIPCION";
                cmbMotivos.ValueMember = "ID_MOTIVO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void frmMaquinasParadas_Load(object sender, EventArgs e)
        {
            ComboD();
            cmbDpto.SelectedValue = "Galv";
            cmbDpto2.SelectedValue = "Galv";
            ComboM();
            LlenarGridMaqParadas();
        }

        private void LlenarCheckBoxList()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                M.Iddpto = cmbDpto.SelectedValue.ToString();
                DataTable dt = M.Listado_Maquinas_Dpto();
                foreach (DataRow row in dt.Rows)
                {
                    CheckBox c = new CheckBox();
                    c.Tag = row[0].ToString();
                    c.Text = row[1].ToString();
                    c.AutoSize = true;
                    flowLayoutPanel1.Controls.Add(c);
                }
               
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbDpto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDpto.SelectedIndex > -1)
            {
                LlenarCheckBoxList();
            }
        }

        private void chbSelTodas_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = new CheckBox();
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                if (chbSelTodas.Checked)
                {
                    for(int x = 0; x < flowLayoutPanel1.Controls.Count; x++)
                    {
                        c = (CheckBox)flowLayoutPanel1.Controls[x];
                        c.Checked = true;
                    }
                }
                else
                {
                    for (int x = 0; x < flowLayoutPanel1.Controls.Count; x++)
                    {
                        c = (CheckBox)flowLayoutPanel1.Controls[x];
                        c.Checked = false;
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            CheckBox c = new CheckBox();
            string msj = "";
            bool seleccion = false;
            try
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    for (int x = 0; x < flowLayoutPanel1.Controls.Count; x++)
                    {
                        c = (CheckBox)flowLayoutPanel1.Controls[x];
                        if (c.Checked)
                        {
                            seleccion = true;
                            if(dtpFecha.Value>DateTime.Now)
                            {

                            }
                            else
                            {
                                Mo.Idparada = 0;
                                Mo.Valor = 0;
                                Mo.Idmaquina = c.Tag.ToString();
                                Mo.Duracion = 0;
                                Mo.Fecha = dtpFecha.Value;
                                Mo.Idmotivo = Convert.ToInt16(cmbMotivos.SelectedValue);
                                if(txtComentario.Text=="")
                                {
                                    Mo.Comentario = "Maq. parada debido a " + cmbMotivos.Text;
                                }
                                else
                                {
                                    Mo.Comentario = txtComentario.Text;
                                }
                                msj = Mo.Registrar_ResolverMaqParada();
                              
                            }
                        
                        }
                       
                    }
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Parada de máquina registrada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGridMaqParadas();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error..", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!seleccion)
                    {
                        MessageBoxEx.Show("No hay máquinas seleccionadas.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void LlenarGridMaqParadas()
        {
            try
            {
                Mo.Iddpto = cmbDpto2.SelectedValue.ToString();
                DataTable dt = Mo.ObtenerMaqParadas();
                dtgMaquinaParada.DataSource = null;
                dtgMaquinaParada.DataSource = dt;
            }
            catch(Exception ex)
            {

            }
        }

        private void cmbDpto2_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarGridMaqParadas();
        }
    }
}
