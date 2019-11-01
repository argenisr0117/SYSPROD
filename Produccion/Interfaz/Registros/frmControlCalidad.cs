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
    public partial class frmControlCalidad : MetroForm
    {
        clsProducto P = new clsProducto();
        clsMaquina M = new clsMaquina();
        clsProduccionGalv PG = new clsProduccionGalv();
        clsColada Co = new clsColada();
        clsCliente C = new clsCliente();
        clsPruebasCald PC = new clsPruebasCald();
        private double diametro=0.00;
        public frmControlCalidad()
        {
            InitializeComponent();
        }
        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(5);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void ComboC()
        {
            try
            {
                cmbCliente.DataSource = C.Listado_Cliente_Combo(true, "Galv");
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
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
                cmbMaquina.DataSource = M.Listado_Maquinas_Galv();
                cmbMaquina.DisplayMember = "ID_MAQUINA";
                cmbMaquina.ValueMember = "ID_MAQUINA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboCo()
        {
            try
            {
                cmbColada.DataSource = Co.Listar(true);
                cmbColada.DisplayMember = "COLADA";
                cmbColada.ValueMember = "ID_COLADA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmControlCalidad_Load(object sender, EventArgs e)
        {
            lbFecha.Visible = Program.vccfecha;
            dtpFecha.Visible = Program.vccfecha;
            ComboC();
            ComboCo();
            ComboP();
            ComboM();
            Limpiar();
            if (Program.Valor == 5)
            {
                btnImprimir.Text = "ACTUALIZAR";
                cmbCliente.Text = Program.Cliente1;
                cmbProducto.Text = Program.Producto;
                cmbColada.Text = Program.Colada;
                txtPesoSinZinc.Text = Program.Pesoszinc;
                txtPesoZinc.Text = Program.Pesozinc;
                txtResistencia.Text = Program.Resistenia;
                txtMuestra2.Text = Program.Muestra2;
                txtSae.Text = Program.Sae;
                cmbMaquina.Text = Program.Maquina;
                btnBorrar.Enabled = false;
            }
        }

        private void Limpiar()
        {
            cmbProducto.SelectedValue = "";
            cmbMaquina.SelectedValue = "";
            cmbCliente.SelectedValue = 0;
            cmbColada.SelectedValue = 0;
            txtMuestra2.Clear();
            txtPesoSinZinc.Clear();
            txtPesoZinc.Clear();
            txtSae.Clear();
            txtResistencia.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Consultas.frmcProductosDpto obj = new Consultas.frmcProductosDpto();
            Program.Valor3 = 5;
            Program.Valor2 = 2;
            obj.ShowDialog();
            if (string.IsNullOrEmpty(Program.CodigoP))
            {
                return;
            }
            else
            {
                cmbProducto.SelectedValue = Program.CodigoP;
            }
            Program.Evento = 0;
            Program.Valor3 = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm(this, errorProvider1) == false)
            {
                return;
            }
            try
            {
                if(Convert.ToDouble(txtMuestra2.Text)>Convert.ToDouble(txtMuestra1.Text))
                {
                    DataTable dt = new DataTable();
                    double diametro_pulg = 0;
                    double diametro_mm = 0;
                    double recubrimiento = 0;
                    double resistenciapsi = 0;
                    int elongacion = 0;
                    double area = 0;
                    string mensaje = "";
                    if (Program.vccfecha) // saber si se obtiene la fecha actual o una fecha modificada
                    {
                        PC.Valor = 0;
                    }
                    else
                    {
                        PC.Valor = 1;
                    }
                    PC.Fecha = dtpFecha.Value;
                    PC.Producto = cmbProducto.SelectedValue.ToString();
                    PC.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                    PC.Colada = Convert.ToInt16(cmbColada.SelectedValue);
                    PC.Maquina = cmbMaquina.SelectedValue.ToString();
                    PC.Muestra1 = Convert.ToDouble(txtMuestra1.Text);
                    PC.Muestra2 = Convert.ToDouble(txtMuestra2.Text);
                    PC.Resistencia = Convert.ToDouble(txtResistencia.Text);
                    PC.Sae = Convert.ToDouble(txtSae.Text);
                    PC.Pesoczinc = Convert.ToDouble(txtPesoZinc.Text);
                    PC.Pesoszinc = Convert.ToDouble(txtPesoSinZinc.Text);
                    diametro_pulg = Math.Round(Math.Pow(Convert.ToDouble(txtPesoZinc.Text) / 1211, 0.5),4); //obtener diametro en pulg segun peso con zinc
                    diametro_mm = Math.Round(diametro_pulg * 25.4, 2); //convertir diametro en pulg a mm
                    area = Math.Round(Math.Pow(diametro_pulg, 2) * 0.785, 4); //calcular area
                    resistenciapsi =Math.Round(Convert.ToDouble(txtResistencia.Text) / area,4);
                    recubrimiento =Math.Round(((163 * diametro_pulg * (Convert.ToDouble(txtPesoZinc.Text) - Convert.ToDouble(txtPesoSinZinc.Text))) / Convert.ToDouble(txtPesoSinZinc.Text)) * 305,4);
                    elongacion = (int)(((Convert.ToDouble(txtMuestra2.Text) - Convert.ToDouble(txtMuestra1.Text)) / Convert.ToDouble(txtMuestra1.Text)) * 100);
                    dt = PC.ObtenerCalibrePorDiametro(diametro_pulg);
                    if (dt.Rows.Count > 0)
                    {
                        PC.Calibre = Convert.ToDouble(dt.Rows[0][0]);
                        PC.ResistenciaPsi = resistenciapsi;
                        PC.Recubrimiento = recubrimiento;
                        PC.Elongacion = elongacion;
                        PC.DiametroPulg = diametro_pulg;
                        if (btnImprimir.Text == "ACTUALIZAR")
                        {
                            PC.Idprueba = Program.Idprueba;
                        }
                        else
                        {
                            PC.Idprueba = 0;
                        }
                        mensaje = PC.RegistrarPruebaCalidad();
                        if (mensaje == "1")
                        {
                            if (btnImprimir.Text == "ACTUALIZAR")
                            {
                                MessageBoxEx.Show("Prueba actualizada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
<<<<<<< HEAD
                                Close();
=======
                                this.Close();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058

                            }
                            else
                            {
                                MessageBoxEx.Show("Prueba registrada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();
                            }
                            

                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("No existe calibre para este diametro", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBoxEx.Show("Muestra 2 no puede ser menor que muestra 1", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
