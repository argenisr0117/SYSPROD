using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Intermedia
{
    public class clsMonitoreoMaq
    {
        private clsManejador M = new clsManejador();

        
        string Midturno;
        string Middpto;
        DateTime Mhorai;
        DateTime Mhoraf;
        string Midmaquina;
        DateTime Mfecha;
        int Midmotivo;
        int Midparada;
        string Mcomentario;
        int Mduracion;
        int Mvalor;


        public string Idmaquina
        {
            get { return Midmaquina; }
            set { Midmaquina = value; }
        }
        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
        }
        public string Comentario
        {
            get { return Mcomentario; }
            set { Mcomentario = value; }
        }
        public int Duracion
        {
            get { return Mduracion; }
            set { Mduracion = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public int Idmotivo
        {
            get { return Midmotivo; }
            set { Midmotivo = value; }
        }
        public int Idparada
        {
            get { return Midparada; }
            set { Midparada = value; }
        }
        public string Idturno
        {
            get { return Midturno; }
            set { Midturno = value; }
        }

        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Horai
        {
            get { return Mhorai; }
            set { Mhorai = value; }
        }
        public DateTime Horaf
        {
            get { return Mhoraf; }
            set { Mhoraf = value; }
        }
        public DataTable ObtenerMaquinasActivas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt= M.Listado("monitoreo_maquinas",lst);           
        }
        public DataTable ObtenerDetalleMaqParada()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            return dt = M.Listado("obt_detalle_maq_parada", lst);
        }
        public DataTable ListadoMotivos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_motivos", lst);
        }
        public DataTable ObtenerMaqParadas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Middpto));
            return dt = M.Listado("obt_maquinas_paradas", lst);
        }
        public DataTable ObtenerDetalleProduccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@horai", Mhorai));
            lst.Add(new clsParametros("@horaf", Mhoraf));
            return dt = M.Listado("detalle_produccion_tiempo_maquina", lst);

        }
        public DataTable ObtenerTotalDetalleProduccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@fecha", Mfecha));
            return dt = M.Listado("total_produccion_tiempo_maquina", lst);

        }

        public string Registrar_ResolverMaqParada()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idmotivo", Midmotivo));
            lst.Add(new clsParametros("@idparada", Midparada));
            lst.Add(new clsParametros("@comentario", Mcomentario));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@duracion", Mduracion));
            lst.Add(new clsParametros("@valor", Mvalor));
            M.EjecutarSP("reg_resolver_maquina_parada", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarMaqParada()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idparada", Midparada));
            M.EjecutarSP("eliminar_maquina_parada", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
    }
}
