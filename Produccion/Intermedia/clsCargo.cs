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
    public class clsCargo
    {
        private clsManejador M = new clsManejador();

        string Midcargo;
        string Mdescripcion;
        Boolean Mestado;
        string Mcampo = "ID_CARGO";
        string Mtabla = "CARGO";

        public string Idcargo
        {
            get { return Midcargo; }
            set { Midcargo = value; }
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
            return dt= M.Listado("listado_cargo",lst);

            
        }
        public string ActivarCargo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midcargo));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public string RegistrarCargo()
        {
            string mensaje = "";
            List <clsParametros> lst= new List<clsParametros>();
            lst.Add(new clsParametros("@idcargo", Midcargo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_cargo", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string ActualizarCargo ()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcargo", Midcargo));
            lst.Add(new clsParametros("@descripcion",Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_cargo", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
