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
using System.Collections;

namespace Interfaz.Registros
{
    public partial class frmPackingList : MetroForm
    {
        public frmPackingList()
        {
            InitializeComponent();
        }
        clsOrdenProduccion O = new clsOrdenProduccion();
        clsPruebasCald PC = new clsPruebasCald();
        clsEmpresa E = new clsEmpresa();
        clsCliente C = new clsCliente();
        private void LlenarGridDisponibles()
        {
            try
            {
                DataTable dt = new DataTable();
                O.Numorden = Program.Orden;
                dtgDisponibles.DataSource = null;
                dt = O.ObtenerBobinasOrdenPacking();
                for(int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgDisponibles.Rows.Add(dt.Rows[x][0]);
                    dtgDisponibles.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgDisponibles.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgDisponibles.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgDisponibles.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgDisponibles.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgDisponibles.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                }
                dtgDisponibles.ClearSelection();
                
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void LlenarGridSeleccionadas()
        {
            try
            {
                DataTable dt = new DataTable();
                O.Id = Program.Idpacking;
                dtgSeleccionadas.DataSource = null;
                dt = O.ObtenerBobinasSeleccionadas();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgSeleccionadas.Rows.Add(dt.Rows[x][0]);
                    dtgSeleccionadas.Rows[x].Cells[0].Value = dt.Rows[x][0].ToString();
                    dtgSeleccionadas.Rows[x].Cells[1].Value = dt.Rows[x][1].ToString();
                    dtgSeleccionadas.Rows[x].Cells[2].Value = dt.Rows[x][2].ToString();
                    dtgSeleccionadas.Rows[x].Cells[3].Value = dt.Rows[x][3].ToString();
                    dtgSeleccionadas.Rows[x].Cells[4].Value = dt.Rows[x][4].ToString();
                    dtgSeleccionadas.Rows[x].Cells[5].Value = dt.Rows[x][5].ToString();
                }
                dtgSeleccionadas.ClearSelection();

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
                cmbCliente.DataSource = C.Listar(true);
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboU()
        {
            try
            {
                cmbUso.DataSource = O.ListadoUsoAlambre(1);
                cmbUso.DisplayMember = "DESCRIPCION";
                cmbUso.ValueMember = "ID_USO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboE()
        {
            try
            {
                cmbEmpresa.DataSource = E.Listar(true);
                cmbEmpresa.DisplayMember = "DESCRIPCION";
                cmbEmpresa.ValueMember = "ID_EMPRESA";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmPackingList_Load(object sender, EventArgs e)
        {
            ComboE();
            ComboC();
            ComboU();

            if (Program.Valor==6)
            {
                DateTime mydate = DateTime.ParseExact(Program.FechaS,"dd-MM-yyyy",null);
                txtContenedor.Text = Program.Contenedor;
                cmbTamano.Text = Program.Tamano.ToString();
                cmbCliente.SelectedValue = Program.Cliente;
                cmbEmpresa.SelectedValue = Program.Empresa;
                dtpFecha.Value = mydate;
                LlenarGridSeleccionadas();
                //btnGenerar.Text = "ACTUALIZAR";
            }
            LlenarGridDisponibles();
            txtProdSel.Text = "0.00";
            txtUndSel.Text = "0";
            txtProdDisp.Text = "0.00";
            txtUndDisp.Text = "0";
            CalcularTotales();
            txtContenedor.Focus();
            if (Program.Idtipoorden == 1)
            {
            SecuenciaConduce();
                cmbTamano.Enabled = false;
                txtContenedor.Enabled = false;
                txtContenedor.Text = "N/A";
                cmbTamano.SelectedIndex = 1;
            }
            else
            {
                cmbUso.Enabled = false;
            }
            cmbCliente.SelectedValue = Program.Cliente;
        }
        private void SecuenciaConduce()
        {
            try
            {
                int var;
                int var2;
                string secuencia;
                DataTable dtt = new DataTable();
                dtt = O.SecuenciaConduce();
                if (string.IsNullOrEmpty(dtt.Rows[0]["Conduce"].ToString().Trim()))
                {
                    txtConduce.Text = "1";
                    secuencia = txtConduce.Text;
                    txtConduce.Text = secuencia.PadLeft(8, '0');
                    SendKeys.Send("{TAB}");
                }
                else
                {
                    var = Convert.ToInt32(dtt.Rows[0]["Conduce"]);
                    var2 = var + 1;
                    txtConduce.Text = var2.ToString();
                    secuencia = txtConduce.Text;
                    txtConduce.Text = secuencia.PadLeft(8, '0');
                    SendKeys.Send("{TAB}");
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void CalcularTotales()  //calcular totales de qqs y unds disponibles y seleccionadas
        {
            double qqs = 0;
            for(int x = 0; x < dtgDisponibles.Rows.Count; x++)
            {
                qqs = qqs + Convert.ToDouble(dtgDisponibles.Rows[x].Cells[2].Value);
            }
            txtProdDisp.Text = qqs.ToString("N2");
            txtUndDisp.Text = dtgDisponibles.Rows.Count.ToString("0");
            qqs = 0;
            for (int x = 0; x < dtgSeleccionadas.Rows.Count; x++)
            {
                qqs = qqs + Convert.ToDouble(dtgSeleccionadas.Rows[x].Cells[2].Value);
            }
            txtProdSel.Text = qqs.ToString("N2");
            txtUndSel.Text = dtgSeleccionadas.Rows.Count.ToString("0");
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgDisponibles.SelectedRows.Count > 0)
                {
                    dtgSeleccionadas.Rows.Add(dtgDisponibles.CurrentRow.Cells[0].Value, dtgDisponibles.CurrentRow.Cells[1].Value, dtgDisponibles.CurrentRow.Cells[2].Value, dtgDisponibles.CurrentRow.Cells[3].Value, dtgDisponibles.CurrentRow.Cells[4].Value, dtgDisponibles.CurrentRow.Cells[5].Value);
                    dtgDisponibles.Rows.RemoveAt(dtgDisponibles.CurrentRow.Index);
                    CalcularTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgSeleccionadas.SelectedRows.Count > 0)
                {
                    if(Program.Valor==6)
                    {
                        O.Tarjeta = dtgSeleccionadas.CurrentRow.Cells[1].Value.ToString();
                        O.EliminarBobinaPacking();
                    }
                    dtgDisponibles.Rows.Add(dtgSeleccionadas.CurrentRow.Cells[0].Value, dtgSeleccionadas.CurrentRow.Cells[1].Value, dtgSeleccionadas.CurrentRow.Cells[2].Value, dtgSeleccionadas.CurrentRow.Cells[3].Value, dtgSeleccionadas.CurrentRow.Cells[4].Value, dtgSeleccionadas.CurrentRow.Cells[5].Value);
                    dtgSeleccionadas.Rows.RemoveAt(dtgSeleccionadas.CurrentRow.Index);
                    CalcularTotales();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Addall_btn_Click(object sender, EventArgs e)
        {
            try
            {

                foreach(DataGridViewRow row in dtgDisponibles.Rows)
                {
                    dtgSeleccionadas.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                }
                dtgDisponibles.Rows.Clear();
                CalcularTotales();
                
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void Removeall_btn_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in dtgSeleccionadas.Rows)
                {
                    dtgDisponibles.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                }
                dtgSeleccionadas.Rows.Clear();
                CalcularTotales();

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(this, errorProvider1) == false)
                {
                    return;
                }
                double total = 0;
                int inicio = 0;
                int final = 0;
                double mitad = 0;
                string mensaje = "";
                double total_diam = 0;
                double total_recu = 0;
                double total_resis_lbs = 0;
                double diametro = 0;
                double recubrimiento = 0;
                double resistencia_lbs = 0;
                double elongacion = 0;
                double resistencia_psi = 0;
                //int muestras = 0;
                int divisor = 0;
                DataTable dt = new DataTable();
                List<double> diametros = new List<double>();
                List <double> recubrimientos = new List<double>();
                List<double> resis_lbs = new List<double>();

                if (dtgSeleccionadas.Rows.Count > 0)
                {
                    if (btnGenerar.Text == "GENERAR")
                    {
                        ////REGISTRAR PACKING LIST
                        if (Program.Valor == 6)
                        {
                            O.Id = Program.Idpacking;

                        }
                        else
                        {
                            O.Id = 0;
                        }
                        O.Producto = Program.Producto;
                        O.Cliente = Convert.ToInt16(cmbCliente.SelectedValue);
                        O.Numorden = Program.Orden;
                        O.Contenedor = txtContenedor.Text.ToUpper();
                        O.Tamano = Convert.ToInt16(cmbTamano.SelectedItem);
                        O.Idempresa = cmbEmpresa.SelectedValue.ToString();
                        O.Iduso = Convert.ToInt16(cmbUso.SelectedValue);
                        O.Fecha = dtpFecha.Value;
                        if (Program.Idtipoorden == 1)
                        {
                            O.Conduce = txtConduce.Text;

                        }
                        else
                        {
                            O.Conduce = "0";
                        }
                        mensaje = O.RegistrarPackingList(); ///registrar o actualizar packing list
                        /////////////////////////////////
                        if (mensaje == "1")
                        {
                            for (int x = 0; x < dtgSeleccionadas.Rows.Count; x++)
                            {
                                O.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                                O.Tarjeta = dtgSeleccionadas.Rows[x].Cells[1].Value.ToString();
                                O.Cantidad = Convert.ToDouble(dtgSeleccionadas.Rows[x].Cells[2].Value);
                                O.RegistrarDetallePackingList(); //REGISTRAR DETALLE DEL PACKING LIST
                            }
                            if (Program.Valor == 6)
                            {
                                O.Id = Program.Idrptcald;
                            }
                            else
                            {
                                O.Id = 0;

                            }
                            O.Desdiampulg = 0;
                            O.Desrecubri = 0;
                            O.Desresislbs = 0;
                            O.RegistrarActualiarRptCalidad(); //registrar reporte de calidad 
                            for (int x = 0; x < dtgSeleccionadas.Rows.Count; x++)
                            {
                                O.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                                O.Cliente = Convert.ToInt16(dtgSeleccionadas.Rows[x].Cells[5].Value);
                                O.Producto = dtgSeleccionadas.Rows[x].Cells[4].Value.ToString();
                                O.Maquina = dtgSeleccionadas.Rows[x].Cells[3].Value.ToString();
                                dt = O.ObtenerRegistrosCalidadBobinaPacking(); //buscar pruebas  de calidad que se hicieron en esa fecha con ese cliente maquina y producto                       
                                if (dt.Rows.Count > 0)
                                {
                                    for (int y = 0; y < dt.Rows.Count; y++)
                                    {
                                        //acumular valores en listas para luego calcular desviacion
                                        resis_lbs.Add(Convert.ToDouble(dt.Rows[y][4]));
                                        diametros.Add(Convert.ToDouble(dt.Rows[y][6]));
                                        recubrimientos.Add(Convert.ToDouble(dt.Rows[y][7]));

                                        //acumular totales generales
                                        total_resis_lbs = total_resis_lbs = Convert.ToDouble(dt.Rows[y][4]);
                                        total_diam = total_diam = Convert.ToDouble(dt.Rows[y][6]);
                                        total_recu = total_recu = Convert.ToDouble(dt.Rows[y][7]);

                                        //acumular totales subgenerales
                                        resistencia_lbs = resistencia_lbs + Convert.ToDouble(dt.Rows[y][4]);
                                        resistencia_psi = resistencia_psi + Convert.ToDouble(dt.Rows[y][5]);
                                        diametro = diametro + Convert.ToDouble(dt.Rows[y][6]);
                                        recubrimiento = recubrimiento + Convert.ToDouble(dt.Rows[y][7]);
                                        elongacion = elongacion + Convert.ToDouble(dt.Rows[y][8]);
                                        //muestras++;
                                        divisor++;

                                    }
                                    //sacar promedio de totales subgenerales
                                    resistencia_lbs = (resistencia_lbs / divisor);
                                    resistencia_psi = (resistencia_psi / divisor);
                                    recubrimiento = (recubrimiento / divisor);
                                    elongacion = (elongacion / divisor);
                                    PC.Resistencia = (int)resistencia_lbs;
                                    PC.ResistenciaPsi = (int)resistencia_psi;
                                    PC.DiametroPulg = Math.Round(diametro / divisor, 4);
                                    PC.Recubrimiento = (int)recubrimiento;
                                    PC.Elongacion = (int)elongacion;
                                    PC.Tarjeta = dtgSeleccionadas.Rows[x].Cells[1].Value.ToString();
                                    PC.Maquina = dtgSeleccionadas.Rows[x].Cells[3].Value.ToString();
                                    PC.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                                    PC.Maquina = dt.Rows[0][2].ToString();
                                    PC.Colada = Convert.ToInt16(dt.Rows[0][9]);
                                    PC.RegistrarDetalleRptCalidad(); // registrar detalle de reporte calidad si hay pruebas ese dia
                                    resistencia_lbs = 0;
                                    resistencia_psi = 0;
                                    recubrimiento = 0;
                                    elongacion = 0;
                                    diametro = 0;
                                    divisor = 0;
                                    dt = null;

                                }
                                else
                                {
                                    PC.Resistencia = 0;
                                    PC.ResistenciaPsi = 0;
                                    PC.DiametroPulg = 0;
                                    PC.Recubrimiento = 0;
                                    PC.Elongacion = 0;
                                    PC.Tarjeta = dtgSeleccionadas.Rows[x].Cells[1].Value.ToString();
                                    PC.Maquina = "";
                                    PC.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                                    PC.Maquina = "";
                                    PC.Colada = 0;
                                    PC.RegistrarDetalleRptCalidad(); // registrar detalle de reporte calidad si no hay pruebas ese dia
                                }
                            }
                            //obtener desviaciones
                            double desdiam = CalcularDesviacionEstandar(diametros);
                            double desrecu = CalcularDesviacionEstandar(recubrimientos);
                            double desresis = CalcularDesviacionEstandar(resis_lbs);
                            O.Desdiampulg = desdiam;
                            O.Desrecubri = desrecu;
                            O.Desresislbs = desresis;
                            O.Id = 1;
                            //actualizar reporte calidad
                            O.RegistrarActualiarRptCalidad();

                            //desdiam = Math.Round(desdiam, 7);
                            //desrecu = Math.Round(desrecu, 7);
                            //desresis = Math.Round(desresis, 7);

                            //registrar muestras para crear graficos
                            double promedio = 0;
                            if (diametros.Count > 0)
                            {
                                promedio = diametros.Average();
                            }
                            else
                            {
                                promedio = 0;
                            }
                            for (int x = 0; x < diametros.Count; x++)
                            {
                                PC.Propiedad = diametros[x];
                                PC.Desviacion = desdiam;
                                PC.Promedio = promedio;
                                PC.Valor = 0;
                                PC.RegistrarMuestrasCalidad();
                            }
                            if (resis_lbs.Count > 0)
                            {
                                promedio = resis_lbs.Average();
                            }
                            else
                            {
                                promedio = 0;
                            }
                            for (int x = 0; x < resis_lbs.Count; x++)
                            {
                                PC.Propiedad = resis_lbs[x];
                                PC.Desviacion = desresis;
                                PC.Promedio = promedio;
                                PC.Valor = 1;
                                PC.RegistrarMuestrasCalidad();
                            }
                            if (recubrimientos.Count > 0)
                            {
                                promedio = recubrimientos.Average();
                            }
                            else
                            {
                                promedio = 0;
                            }

                            for (int x = 0; x < recubrimientos.Count; x++)
                            {
                                PC.Propiedad = recubrimientos[x];
                                PC.Desviacion = desrecu;
                                PC.Promedio = promedio;
                                PC.Valor = 2;
                                PC.RegistrarMuestrasCalidad();
                            }
                        }

                    }
                    total = dtgSeleccionadas.Rows.Count;
                    mitad = Math.Ceiling((double)total / 2);  //primera tabla de 0 a la mitad de registros
                    final = Convert.ToInt16(mitad);
                    frmReporte obj = new frmReporte();
                    if (Program.Idtipoorden == 2)
                    {
                        obj.Inicio = inicio;
                        obj.Final = final;
                        obj.Inicio1 = final;
                        obj.Final1 = Convert.ToInt16(total);
                        obj.Valor = 14;
                        obj.Nombre = "packing_list.rdlc";
                        if (Program.Valor == 6)
                        {
                            obj.Idpacking = Program.Idpacking;
                        }
                        else
                        {
                            obj.Idpacking = 0;

                        }
                        obj.Show();
                        frmReporte obj2 = new frmReporte();
                        if (Program.Valor == 6)
                        {
                            obj2.Idrepcalidad = Program.Idrptcald;
                        }
                        else
                        {
                            obj2.Idrepcalidad = 0;

                        }

                        obj2.Nombre = "certificado_calidad.rdlc";
                        obj2.Valor = 15;
                        obj2.Show();
                        frmReporte obj3 = new frmReporte();
                        if (Program.Valor == 6)
                        {
                            obj3.Idrepcalidad = Program.Idrptcald;
                        }
                        else
                        {
                            obj3.Idrepcalidad = 0;

                        }
                        obj3.Nombre = "graficos_certificado_cald.rdlc";
                        obj3.Valor = 16;
                        obj3.Show();
                    }
                    else if (Program.Idtipoorden == 1)
                    {
                        obj.Inicio = inicio;
                        obj.Final = final;
                        obj.Inicio1 = final;
                        obj.Final1 = Convert.ToInt16(total);
                        obj.Valor = 14;
                        if (Program.Dpto == "INDUSTRIA MENOR" || Program.Dpto == "IndM")
                        {
                            obj.Nombre = "packing_list_kinnox.rdlc";
                        }
                        else
                        {
                            obj.Nombre = "packing_list_local.rdlc";
                        }
                    
                        if (Program.Valor == 6)
                        {
                            obj.Idpacking = Program.Idpacking;
                        }
                        else
                        {
                            obj.Idpacking = 0;

                        }
                        obj.Show();
                    }
                        
                    dtgSeleccionadas.Rows.Clear();
                    txtProdSel.Text = "";
                    txtUndSel.Text = "";
                    txtContenedor.Clear();
                    cmbEmpresa.SelectedValue = "";
                    cmbTamano.SelectedIndex=-1;
                    cmbCliente.SelectedIndex = -1;
                    cmbUso.SelectedIndex = -1;
                    SecuenciaConduce();
                        
                        //if(Program.Valor==6)
                        //{
                        //    this.Close();
                        //}
                    Program.Valor = 0;
                    Program.Idtipoorden = 0;
                    //this.Close();
                    

                }
                else
                {
                    MessageBoxEx.Show("No hay bobinas seleccionadas", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private double CalcularDesviacionEstandar(List<double> lista)
        {
            double promedio = 0;
            double valor = 0;
            if(lista.Count>0)
            {
               promedio=lista.Average();
               valor= Math.Sqrt(lista.Sum(x => ((x - promedio) * (x - promedio)) / lista.Count));
            }
            else
            {
                valor = 0;
            }

            return valor;
        }
    }
}
