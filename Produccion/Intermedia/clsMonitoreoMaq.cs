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

        string Midmaquina;
        DateTime Mfecha;
        string Midturno;
        Boolean Mestado;
        string Mcampo = "ID_CARGO";
        string Mtabla = "CARGO";
        DateTime Mhorai;
        DateTime Mhoraf;

        public string Idmaquina
        {
            get { return Midmaquina; }
            set { Midmaquina = value; }
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

        //public string RegistrarCargo()
        //{
        //    string mensaje = "";
        //    List <clsParametros> lst= new List<clsParametros>();
        //    lst.Add(new clsParametros("@idcargo", Midcargo));
        //    lst.Add(new clsParametros("@descripcion", Mdescripcion));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("registrar_cargo", ref lst);
        //    mensaje = lst[2].Valor.ToString();
        //    return mensaje;
        //}

        //public string ActualizarCargo ()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@idcargo", Midcargo));
        //    lst.Add(new clsParametros("@descripcion",Mdescripcion));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("actualizar_cargo", ref lst);
        //    mensaje = lst[2].Valor.ToString();
        //    return mensaje;
        //}
    }
}
