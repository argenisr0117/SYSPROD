using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
namespace Interfaz.Registros
{
    public partial class frmResolverMaqParada : MetroForm
    {
        public frmResolverMaqParada()
        {
            InitializeComponent();
        }
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        public DateTime Fechap;
        public string Maquina;
        public int Idparada;
        public string Motivo;
        public string Dpto;

        private void frmResolverMaqParada_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            dtpFechaParada.Value = Fechap;
            txtMaquina.Text = Maquina;
            txtMotivo.Text = Motivo;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string msj = "";
                DateTime fechainicial;
                DateTime fechafinal = dtpFechaSolucion.Value;
                int cont = 0;
                if (dtpFechaSolucion.Value > dtpFechaParada.Value)
                {
                    Mo.Fecha = dtpFechaSolucion.Value;
                    Mo.Idparada = Idparada;
                    Mo.Valor = 1;
                    Mo.Idmaquina = "";
                    Mo.Idmotivo = 0;
                    Mo.Comentario = txtComentario.Text;
                    double duracion =(int) (dtpFechaSolucion.Value - dtpFechaParada.Value).TotalMinutes;
                    if (Dpto == "Galv")
                    {
                        Mo.Duracion =Convert.ToInt16(duracion);
                    }
                    else if(Dpto=="Puas" || Dpto == "Tref" || Dpto == "IndM")
                    {
                        double diferencia =(int)(dtpFechaSolucion.Value-dtpFechaParada.Value).TotalDays;
                        double minutos = 0;
                        for(DateTime date = dtpFechaParada.Value; date <= dtpFechaSolucion.Value; date=date.AddDays(1))
                        {
                            if (diferencia == 0) //si la maquina se paro y se arreglo en el mismo dia.
                            {
                                minutos =minutos+(int) (dtpFechaSolucion.Value-date).TotalMinutes;
                                Mo.Duracion =Convert.ToInt16(minutos);
                                break;
                            }
                            else
                            {
                                if (cont == 0)//asignar el valor de la fecha de parada igual
                                {
                                    fechainicial = date;
                                }
                                else
                                {
                                    fechainicial = Convert.ToDateTime(date.Date.ToShortDateString() + " 06:00 AM");
                                }
                                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    fechafinal = Convert.ToDateTime(date.Date.ToShortDateString() + " 02:00 PM");
                                }
                                else
                                {
                                    fechafinal = Convert.ToDateTime(date.Date.ToShortDateString() + " 10:00 PM");

                                }
                                if (fechafinal > dtpFechaSolucion.Value)//cuando las fechas sean iguales, restar la inicial menos la de solucion
                                {
                                    minutos = minutos + (int)(dtpFechaSolucion.Value - fechainicial).TotalMinutes;
                                }
                                else
                                {
                                    minutos = minutos + (int)(fechafinal - fechainicial).TotalMinutes;
                                }
                                cont++;
                            }
                        }
                        Mo.Duracion = Convert.ToInt16(minutos);
                    }

                    msj = Mo.Registrar_ResolverMaqParada();
                    if (msj == "1")
                    {
                        MessageBoxEx.Show("Parada de máquina actualizada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error..", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBoxEx.Show("Fecha de solución no puede ser menor que fecha de parada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
