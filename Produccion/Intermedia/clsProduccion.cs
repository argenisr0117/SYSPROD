using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Windows.Input;

namespace Intermedia
{
    public class clsProduccion
    {
        private clsManejador M = new clsManejador();

        DateTime Mfecha;
        DateTime Mfecha1;
        DateTime Mfechaft;
        DateTime Mfechaf;
        TimeSpan Mhora;
        string Msupervisor;
        string Moperador;
        string Mayudante;
        string Mturno;
        string Mtarjeta;
        string Mmaquina;
        string Mproducto;
        string Mdestino;
        decimal Mcantidad;
        string Mreporte;

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
        public string Tarjeta
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
        public string Reporte
        {
            get { return Mreporte; }
            set { Mreporte = value; }
        }

        public int[] SecuenciaTarjeta()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            int[] valores= new int[3];
            lst.Add(new clsParametros("@valor", "", SqlDbType.Int, ParameterDirection.Output,32));
            lst.Add(new clsParametros("@valor1", "", SqlDbType.Int, ParameterDirection.Output,32));
            lst.Add(new clsParametros("@valor2", "", SqlDbType.Int, ParameterDirection.Output,32));
            M.EjecutarSP("secuencia_tarjeta",ref lst);
            valores[0] =Convert.ToInt32(lst[0].Valor);
            valores[1] = Convert.ToInt32(lst[1].Valor);
            valores[2] = Convert.ToInt32(lst[2].Valor);
            return valores;
        }
        public DataTable TotalProduccion(string categoria)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@categoria", categoria));
            return dt = M.Listado("total_produccion", lst);
        }

        public DataTable AnualTotalProduccion(string categoria)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@categoria", categoria));
            return dt = M.Listado("total_anual_produccion", lst);
        }
        public DataTable SecuenciaReporte()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("secuencia_reporte", lst);
        }
        public DataTable FechaCierre()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("fecha_cierre", lst);
        }

        public void EliminarRegistros(string objReporte, int Valor)
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@reporte",objReporte));
            lst.Add(new clsParametros("@valor", Valor));
            M.EjecutarSP("eliminar_registros", ref lst);
        }
        public void EliminarRegistro(string objTarjeta)
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tarjeta", objTarjeta));
            M.EjecutarSP("eliminar_registro", ref lst);
        }
        public string RegistrarProduccion(string Procedimiento)
        {
            string mensaje = "";
            Mhora = TimeSpan.Parse(Mhora.ToString("hh\\:mm"));
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@hora", Mhora));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@idturno", Mturno));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@codigoprod", Mproducto));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@reporte", Mreporte));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP(Procedimiento, ref lst);
            mensaje = lst[12].Valor.ToString();
            return mensaje;
        }
        public string CerrarMes()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 100));
            M.EjecutarSP("cerrar_mes", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public DataTable MostrarRegistros()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@reporte", objReporte));
            return dt = M.Listado("todos_registros", lst);
        }
        public string ActualizaRegistros()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@hora", Mhora));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@idturno", Mturno));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@codigoprod", Mproducto));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            M.EjecutarSP("actualizar_registros", ref lst);
            return mensaje;
        }

        public string Actualizar1()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@hora", Mhora));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@idturno", Mturno));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@codigoprod", Mproducto));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@reporte", Mreporte));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_registros1", ref lst);
            mensaje = lst[12].Valor.ToString();
            return mensaje;
        }

        public DataTable BuscarRegistro()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@idturno", Mturno));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@codigoprod", Mproducto));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@reporte", Mreporte));
            return dt=M.Listado("buscar_registros", lst);
        }

        public DataTable Listado(string Destino)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@destino", Destino));
            return dt = M.Listado("listado", lst);
        }

        public DataTable BuscarProduccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            return dt = M.Listado("buscar_produccion", lst);
        }
    }
}
