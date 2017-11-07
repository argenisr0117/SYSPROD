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
        private void frmPackingList_Load(object sender, EventArgs e)
        {
            LlenarGridDisponibles();
            txtProdSel.Text = "0.00";
            txtUndSel.Text = "0";
            txtProdDisp.Text = "0.00";
            txtUndDisp.Text = "0";
            CalcularTotales();
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
                    dtgDisponibles.Rows.Add(dtgSeleccionadas.CurrentRow.Cells[0].Value, dtgSeleccionadas.CurrentRow.Cells[1].Value, dtgSeleccionadas.CurrentRow.Cells[2].Value, dtgDisponibles.CurrentRow.Cells[3].Value, dtgDisponibles.CurrentRow.Cells[4].Value, dtgDisponibles.CurrentRow.Cells[5].Value);
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
                    O.Producto = Program.Producto;
                    O.Cliente = Program.Cliente;
                    O.Numorden = Program.Orden;
                    mensaje = O.RegistrarPackingList();
                    if (mensaje == "1")
                    {
                        for(int x = 0; x < dtgSeleccionadas.Rows.Count; x++)
                        {
                            O.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(),"dd/MM/yyyy",null);
                            O.Tarjeta = dtgSeleccionadas.Rows[x].Cells[1].Value.ToString();
                            O.Cantidad = Convert.ToDouble(dtgSeleccionadas.Rows[x].Cells[2].Value);
                            O.RegistrarDetallePackingList();
                        }
                        O.Id = 0;
                        O.Desdiampulg = 0;
                        O.Desrecubri = 0;
                        O.Desresislbs = 0;
                        O.RegistrarActualiarRptCalidad(); //registrar reporte de calidad 
                        for (int x = 0; x < dtgSeleccionadas.Rows.Count; x++)
                        {
                            O.Fecha = DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                            O.Cliente =Convert.ToInt16(dtgSeleccionadas.Rows[x].Cells[5].Value);
                            O.Producto = dtgSeleccionadas.Rows[x].Cells[4].Value.ToString();
                            O.Maquina = dtgSeleccionadas.Rows[x].Cells[3].Value.ToString();
                            dt = O.ObtenerRegistrosCalidadBobinaPacking(); //buscar pruebas  de calidad que se hicieron en esa fecha con ese cliente maquina y producto                       
                            if (dt.Rows.Count > 0) 
                            {
                                for(int y=0;y<dt.Rows.Count;y++)
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
                                resistencia_lbs =(resistencia_lbs / divisor);
                                resistencia_psi =(resistencia_psi / divisor);
                                recubrimiento =(recubrimiento / divisor);
                                elongacion =(elongacion / divisor);
                                PC.Resistencia = (int)resistencia_lbs;
                                PC.ResistenciaPsi = (int)resistencia_psi;
                                PC.DiametroPulg = Math.Round(diametro / divisor, 4);
                                PC.Recubrimiento = (int)recubrimiento;
                                PC.Elongacion = (int)elongacion;
                                PC.Tarjeta= dtgSeleccionadas.Rows[x].Cells[1].Value.ToString();
                                PC.Maquina= dtgSeleccionadas.Rows[x].Cells[3].Value.ToString();
                                PC.Fecha= DateTime.ParseExact(dtgSeleccionadas.Rows[x].Cells[0].Value.ToString(), "dd/MM/yyyy", null);
                                PC.Maquina = dt.Rows[0][2].ToString();
                                PC.Colada = Convert.ToInt16(dt.Rows[0][9]);
                                PC.RegistrarDetalleRptCalidad();
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
                                PC.RegistrarDetalleRptCalidad();
                            }
                        }
                        //obtener desviaciones
                        double desdiam= CalcularDesviacionEstandar(diametros);
                        double desrecu= CalcularDesviacionEstandar(recubrimientos);
                        double desresis= CalcularDesviacionEstandar(resis_lbs);
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
                        double promedio = diametros.Average();
                        for (int x = 0; x < diametros.Count; x++)
                        {
                            PC.Propiedad = diametros[x];
                            PC.Desviacion = desdiam;
                            PC.Promedio = promedio;
                            PC.Valor = 0;
                            PC.RegistrarMuestrasCalidad();
                        }
                        promedio = resis_lbs.Average();
                        for (int x = 0; x < resis_lbs.Count; x++)
                        {
                            PC.Propiedad = resis_lbs[x];
                            PC.Desviacion = desresis;
                            PC.Promedio = promedio;
                            PC.Valor = 1;
                            PC.RegistrarMuestrasCalidad();
                        }
                        promedio = recubrimientos.Average();
                        for (int x = 0; x < recubrimientos.Count; x++)
                        {
                            PC.Propiedad = recubrimientos[x];
                            PC.Desviacion = desrecu;
                            PC.Promedio = promedio;
                            PC.Valor = 2;
                            PC.RegistrarMuestrasCalidad();
                        }

                        total = dtgSeleccionadas.Rows.Count;
                        mitad = Math.Ceiling((double) total / 2);  //primera tabla de 0 a la mitad de registros
                        final =Convert.ToInt16(mitad);
                        frmReporte obj = new frmReporte();
                        obj.Inicio = inicio;
                        obj.Final = final;
                        obj.Inicio1 = final;
                        obj.Final1 =Convert.ToInt16(total);
                        obj.Valor = 14;
                        obj.Nombre = "packing_list.rdlc";
                        obj.Idpacking = 0;
                        obj.Show();
                        frmReporte obj2 = new frmReporte();
                        obj2.Idrepcalidad = 0;
                        obj2.Nombre = "certificado_calidad.rdlc";
                        obj2.Valor = 15;
                        obj2.Show();
                        
                    }

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
            double promedio = lista.Average();
            return Math.Sqrt(lista.Sum(x => ((x-promedio)*(x-promedio)) / lista.Count));
        }
    }
}
