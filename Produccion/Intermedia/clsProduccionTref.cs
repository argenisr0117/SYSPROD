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
    public class clsProduccionTref
    {
        private clsManejador M = new clsManejador();

        DateTime Mfecha;
        DateTime Mfecha1;
        DateTime Mfechaft;
        DateTime Mfechaf;
        TimeSpan Mhora;
        string Msupervisor;
        string Moperador;
        string Mdpto;
        string Mayudante;
        string Mturno;
        string Mreporte;
        int Mtarjeta;
        string Mpuerto;
        int Mbaud;
        int Mid;
        string Mmaquina;
        string Mproducto;
        string Mdestino;
        decimal Mcantidad;
        int Mcliente;
        int Mcolada;
        int Mvalor;
        double Mpesoneto;
        byte[] Mbarcode;
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Fecha1
        {
            get { return Mfecha1; }
            set { Mfecha1 = value; }
        }
        public DateTime Fechaft
        {
            get { return Mfechaft; }
            set { Mfechaft = value; }
        }
        public DateTime Fechaf
        {
            get { return Mfechaf; }
            set { Mfechaf = value; }
        }
        public TimeSpan Hora
        {
            get { return Mhora; }
            set { Mhora = value; }
        }
        public string Supervisor
        {
            get { return Msupervisor; }
            set { Msupervisor = value; }
        }
        public string Dpto
        {
            get { return Mdpto; }
            set { Mdpto = value; }
        }
        public byte[] Barcode
        {
            get { return Mbarcode; }
            set { Mbarcode = value; }
        }

        public string Operador
        {
            get { return Moperador; }
            set { Moperador = value; }
        }
        public string Ayudante
        {
            get { return Mayudante; }
            set { Mayudante = value; }
        }

        public string Turno
        {
            get { return Mturno; }
            set { Mturno = value; }
        }
        public string Reporte
        {
            get { return Mreporte; }
            set { Mreporte = value; }
        }
        public string Puerto
        {
            get { return Mpuerto; }
            set { Mpuerto = value; }
        }
        public int Baud
        {
            get { return Mbaud; }
            set { Mbaud = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Tarjeta
        {
            get { return Mtarjeta; }
            set { Mtarjeta = value; }
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
        public string Destino
        {
            get { return Mdestino; }
            set { Mdestino = value; }
        }
        public Decimal Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
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
        public double PesoNeto
        {
            get { return Mpesoneto; }
            set { Mpesoneto = value; }
        }
        public DataTable Diametro_Producto(string objCodigo)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", objCodigo));
            return dt = M.Listado("diametro_producto", lst);
        }
        public DataTable Reimprimir(int Id)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Id));
            return dt = M.Listado("reimprimir_ticket", lst);
        }
        public DataTable Total_Produccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@maquina", Mmaquina));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@valor", Mvalor));
            return dt = M.Listado("total_prod_trefilado", lst);
        }
        public DataTable Produccion_Diaria()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@maquina", Mmaquina));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@valor", Mvalor));
            return dt = M.Listado("produccion_diaria_trefilado", lst);
        }
        public DataTable Configuracion_Puerto()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("configuracion_puerto", lst);
        }
        public int SecuenciaTarjeta()
        {
            List<clsParametros> lst = new List<clsParametros>();
            int tarjeta;
            lst.Add(new clsParametros("@valor", "", SqlDbType.Int, ParameterDirection.Output, 32));
            M.EjecutarSP("secuencia_tarjeta_trefilado", ref lst);
            tarjeta = Convert.ToInt32(lst[0].Valor);
            return tarjeta;
        }
        public string RegistrarProduccion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@hora", Mhora));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@turno", Mturno));
            lst.Add(new clsParametros("@maquina", Mmaquina));
            lst.Add(new clsParametros("@pesoneto", Mpesoneto));
            lst.Add(new clsParametros("@codigoprod", Mproducto));           
            lst.Add(new clsParametros("@idcolada", Mcolada));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@barcode", Mbarcode));
            M.EjecutarSP("registrar_produccion_trefilado", ref lst);
            mensaje = lst[12].Valor.ToString();
            return mensaje;
        }

        public string ActualizarPuerto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@puerto", Mpuerto));
            lst.Add(new clsParametros("@baudrate", Mbaud));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_puerto", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public string ActualizarRegistroDpto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@maquina", Mmaquina));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@cliente", Mcliente));
            lst.Add(new clsParametros("@peso", Mpesoneto));
            lst.Add(new clsParametros("@dpto", Mdpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_registro_dpto", ref lst);
            mensaje = lst[8].Valor.ToString();
            return mensaje;
        }
        public string  ExportarRegistroDpto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@reporte", Mreporte));
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("exportar_registros_dpto", ref lst);
            mensaje = lst[5].Valor.ToString();
            return mensaje;
        }

        public string EliminarRegistro()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@dpto", Mdpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("eliminar_registro_dpto", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
