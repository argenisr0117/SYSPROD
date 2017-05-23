using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Intermedia
{
    public class clsColada
    {
        private clsManejador M = new clsManejador();

        Int32 Midcolada;
        string Mcolada;
        Boolean Mestado;
        string Mcampo = "ID_COLADA";
        string Mtabla = "COLADA";

        public Int32 Idcolada
        {
            get { return Midcolada; }
            set { Midcolada = value; }
        }

        public string Colada
        {
            get { return Mcolada; }
            set { Mcolada = value; }
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
            return dt = M.Listado("listado_colada", lst);

        }

        public string ActivarColada()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midcolada));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string RegistrarColada()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@colada", Mcolada));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_colada", ref lst);
            mensaje = lst[1].Valor.ToString();
            return mensaje;
        }

        public string ActualizarColada()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcolada", Midcolada));
            lst.Add(new clsParametros("@colada", Mcolada));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_colada", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
