using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;

namespace Intermedia
{
    public class clsPruebasCald
    {
        private clsManejador M = new clsManejador();

        DateTime Mfecha;
        DateTime Mfechaf;
        int Midprueba;
        double Mpesoczinc;
        double Mpesoszinc;
        double Mmuestra1;
        double Mmuestra2;
        double Mresistencia;
        double Mresistenciapsi;
        double Mcalibre;
        double Mrecubrimiento;
        int Melongacion;
        double Msae;
        string Mmaquina;
        string Mtarjeta;
        string Mproducto;
        int Mcliente;
        int Mcolada;
        double Mdiametro;
        double Mpromedio;
        double Mpropiedad;
        double Mdesviacion;
        int Mvalor;
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public double Sae
        {
            get { return Msae; }
            set { Msae = value; }
        }
        public int Elongacion
        {
            get { return Melongacion; }
            set { Melongacion = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public double Recubrimiento
        {
            get { return Mrecubrimiento; }
            set { Mrecubrimiento = value; }
        }
        public double Propiedad
        {
            get { return Mpropiedad; }
            set { Mpropiedad = value; }
        }
        public double Promedio
        {
            get { return Mpromedio; }
            set { Mpromedio = value; }
        }
        public double Desviacion
        {
            get { return Mdesviacion; }
            set { Mdesviacion = value; }
        }
        public double ResistenciaPsi
        {
            get { return Mresistenciapsi; }
            set { Mresistenciapsi = value; }
        }
        public double DiametroPulg
        {
            get { return Mdiametro; }
            set { Mdiametro = value; }
        }
        public DateTime Fechaf
        {
            get { return Mfechaf; }
            set { Mfechaf = value; }
        }
        public double Calibre
        {
            get { return Mcalibre; }
            set { Mcalibre = value; }
        }
        public double Resistencia
        {
            get { return Mresistencia; }
            set { Mresistencia = value; }
        }
        public double Muestra2
        {
            get { return Mmuestra2; }
            set { Mmuestra2 = value; }
        }
        public double Muestra1
        {
            get { return Mmuestra1; }
            set { Mmuestra1 = value; }
        }

        public double Pesoczinc
        {
            get { return Mpesoczinc; }
            set { Mpesoczinc = value; }
        }
        public double Pesoszinc
        {
            get { return Mpesoszinc; }
            set { Mpesoszinc = value; }
        }        
        
        public int Idprueba
        {
            get { return Midprueba; }
            set { Midprueba = value; }
        }
        
        public string Maquina
        {
            get { return Mmaquina; }
            set { Mmaquina = value; }
        }
        public string Producto
        {
            get { return Mproducto; }
            set { Mproducto = value; }
        }
        public string Tarjeta
        {
            get { return Mtarjeta; }
            set { Mtarjeta = value; }
        }
        public int Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }

        public int Colada
        {
            get { return Mcolada; }
            set { Mcolada = value; }
        }
        public void RegistrarDetalleRptCalidad()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@idcolada", Mcolada));
            lst.Add(new clsParametros("@diampulg", Mdiametro));
            lst.Add(new clsParametros("@elongacion", Melongacion));
            lst.Add(new clsParametros("@recubrimiento", Mrecubrimiento));
            lst.Add(new clsParametros("@resislbs", Mresistencia));
            lst.Add(new clsParametros("@resispsi", Mresistenciapsi));
            M.EjecutarSP("registrar_detalle_rpt_calidad", ref lst);
            //mensaje = lst[0].Valor.ToString();
            //return mensaje;
        }

        public void RegistrarMuestrasCalidad()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@propiedad", Mpropiedad));
            lst.Add(new clsParametros("@promedio", Mpromedio));
            lst.Add(new clsParametros("@desviacion", Mdesviacion));
            lst.Add(new clsParametros("@valor", Mvalor));
            M.EjecutarSP("registrar_muestras_calidad", ref lst);
            //mensaje = lst[0].Valor.ToString();
            //return mensaje;
        }
        public DataTable ObtenerCalibrePorDiametro(double Diametro_pulg)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@diametro_pulg", Diametro_pulg));
            return dt = M.Listado("obtener_calibre_por_diametro", lst);
        }
        public DataTable BuscarPruebasCalidad()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mfecha));
            lst.Add(new clsParametros("@hasta", Mfechaf));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            return dt = M.Listado("buscar_pruebas_calidad", lst);
        }
        public string RegistrarPruebaCalidad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@idcolada", Mcolada));
            lst.Add(new clsParametros("@sae", Msae));
            lst.Add(new clsParametros("@elongacion", Melongacion));
            lst.Add(new clsParametros("@recubrimiento", Mrecubrimiento));
            lst.Add(new clsParametros("@calibre", Mcalibre));
            lst.Add(new clsParametros("@pesozinc", Mpesoczinc));
            lst.Add(new clsParametros("@pesosinzinc", Mpesoszinc));
            lst.Add(new clsParametros("@muestra1", Mmuestra1));
            lst.Add(new clsParametros("@muestra2", Mmuestra2));
            lst.Add(new clsParametros("@resistencia", Mresistencia));
            lst.Add(new clsParametros("@resistenciapsi", Mresistenciapsi));
            lst.Add(new clsParametros("@diametropulg", Mdiametro));
            lst.Add(new clsParametros("@idprueba", Midprueba));
            M.EjecutarSP("registrar_prueba_calidad", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        //public string  ExportarRegistroDpto()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@reporte", Mreporte));
        //    lst.Add(new clsParametros("@fechai", Mfecha1));
        //    lst.Add(new clsParametros("@fechaft", Mfechaft));
        //    lst.Add(new clsParametros("@fechaf", Mfechaf));
        //    lst.Add(new clsParametros("@valor", Mvalor));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("exportar_registros_dpto", ref lst);
        //    mensaje = lst[5].Valor.ToString();
        //    return mensaje;
        //}

        //public string EliminarRegistro()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@id", Mid));
        //    lst.Add(new clsParametros("@dpto", Mdpto));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("eliminar_registro_dpto", ref lst);
        //    mensaje = lst[2].Valor.ToString();
        //    return mensaje;
        //}
        public DataTable ObtenerProductoLongitudConversion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            return dt = M.Listado("obtener_producto_longitud_conversion", lst);
        }
    }
}
