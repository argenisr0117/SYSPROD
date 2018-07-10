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

namespace Interfaz.Consultas
{
    public partial class frmcInfoMaquinaParada : MetroForm
    {
        public frmcInfoMaquinaParada()
        {
            InitializeComponent();
        }
        clsMonitoreoMaq Mo = new clsMonitoreoMaq();
        public string Idmaquina = "";
        private void frmcInfoMaquinaParada_Load(object sender, EventArgs e)
        {
            LlenarCampos();
        }

        private void LlenarCampos()
        {
            try
            {
                Mo.Idmaquina = Idmaquina;
                DataTable dt = Mo.ObtenerDetalleMaqParada();
                if (dt.Rows.Count > 0)
                {
                    panel1.Visible = true;
                    lblEstado.Visible = false;
                    string Dpto = dt.Rows[0]["Dpto"].ToString();
                    txtMaquina.Text = dt.Rows[0]["Maquina"].ToString();
                    txtMotivo.Text = dt.Rows[0]["Motivo"].ToString();
                    dtpFecha.Value = Convert.ToDateTime(dt.Rows[0]["Fecha"]);
                    txtComentario.Text = dt.Rows[0]["Comentario"].ToString();
                    double promedio = Convert.ToDouble(dt.Rows[0]["Promedio"]);
                    DateTime fechainicial = dtpFecha.Value;
                    DateTime fechafinal = DateTime.Now;
                    DateTime fechaf2 = DateTime.Now;
                    fechaf2 = Convert.ToDateTime(fechaf2.Date.ToShortDateString() + " 10:00 PM");
                    double rollosp = 0;
                    //int cont = 0;
                    double duracion = (int)(fechaf2 - fechainicial).TotalMinutes;
                    double seg = 0;
                    if (Dpto == "Galv")
                    {
                        Mo.Duracion = Convert.ToInt16(duracion);
                    }
                    else if (Dpto == "Puas" || Dpto == "Tref" || Dpto == "IndM")
                    {
                        //double diferencia = (int)(fechaf2 - fechainicial).TotalDays;
                        double minutos = Convert.ToDouble(dt.Rows[0]["Duracion"]);
                        seg = (int)minutos * 60;
                        //for (DateTime date = dtpFecha.Value; date <= fechaf2; date = date.AddDays(1))
                        //{
                        //    if (diferencia == 0) //si la maquina se paro y se arreglo en el mismo dia.
                        //    {
                        //        minutos = minutos + (int)(fechafinal - date).TotalMinutes;
                        //        seg = seg + (int)(fechafinal - date).TotalSeconds;
                        //        break;
                        //    }
                        //    else
                        //    {
                        //        if (cont == 0)//asignar el valor de la fecha de parada igual
                        //        {
                        //            fechainicial = dtpFecha.Value;
                        //        }
                        //        else
                        //        {
                        //            fechainicial = Convert.ToDateTime(date.Date.ToShortDateString() + " 06:00 AM");
                        //        }
                        //        if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                        //        {
                        //            fechafinal = Convert.ToDateTime(date.Date.ToShortDateString() + " 06:00 PM");
                        //        }
                        //        else
                        //        {
                        //            fechafinal = Convert.ToDateTime(date.Date.ToShortDateString() + " 10:00 PM");
                        //        }
                        //        if (fechafinal >= fechaf2)//cuando las fechas sean iguales, restar la inicial menos la de solucion
                        //        {
                        //            fechaf2 = DateTime.Now;

                        //            seg = seg + (int)(fechaf2 - fechainicial).TotalSeconds;
                        //        }
                        //        else
                        //        {
                        //            minutos = minutos + (int)(fechafinal - fechainicial).TotalMinutes;
                        //            seg = seg + (int)(fechafinal - fechainicial).TotalSeconds;
                        //        }
                        //        cont++;
                        //    }
                        //}
                        rollosp = minutos / promedio;
                        txtTiempoparada.Text = (seg / 3600).ToString("#") + " Hrs " + ((seg % 3600) / 60).ToString("#") + " Mins";
                        rollosp = Math.Ceiling(rollosp);
                        if (promedio == 0)
                        {
                            rollosp = 0.00;
                        }
                        txtRollos.Text = rollosp.ToString() + " Rollos";

                    }
                }
                else
                {
                    panel1.Visible = false;
                    lblEstado.Visible = true;
                    lblEstado.BringToFront();
                    lblEstado.Text = "LA MÁQUINA ESTA TRABAJANDO, SI SE MUESTRA APAGADA PUEDE QUE SE DEBA A \nQUE ESTAN SACANDO UN ROLLO O EL SUPERVISOR NO LA HA REGISTRADO COMO PARADA";
                }
            }


            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

