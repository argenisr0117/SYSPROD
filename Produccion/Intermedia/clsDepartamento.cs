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
   public class clsDepartamento
    {
        private clsManejador M = new clsManejador();

        string Middpto;
        string Mdepartamento;
        Boolean Mestado;
        string Mcampo = "ID_DPTO";
        string Mtabla = "Departamento";
        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
        }

        public string Departamento
        {
            get { return Mdepartamento; }
            set { Mdepartamento= value; }
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
            return dt = M.Listado("listado_dpto", lst);
        }

        public string ActivarDepartamento()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Middpto));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
        return mensaje;
        }

        public string RegistrarDepartamento()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@departamento", Mdepartamento));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_dpto", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string ActualizarDepartamento()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@departamento", Mdepartamento));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_dpto", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
 
