using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Intermedia
{
    public class clsUnidad
    {
        private clsManejador M = new clsManejador();

        string Midunidad;
        string Mdescripcion;
        Boolean Mestado;
        string Mcampo = "ID_UNIDAD";
        string Mtabla = "UNIDAD";

        public string Idunidad
        {
            get { return Midunidad; }
            set { Midunidad = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_unidad", lst);
            
        }
        public string ActivarUnidad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midunidad));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string RegistrarUnidad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_unidad", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string ActualizarUnidad()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_unidad", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
