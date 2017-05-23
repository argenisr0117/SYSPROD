using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Intermedia
{
    public class clsCliente
    {
        clsManejador M = new clsManejador();
        int Midcliente;
        string Mnombre;
        string Middpto;
        string Mdestino;
        Boolean Mestado;
        string Mcampo = "ID_CLIENTE";
        string Mtabla = "CLIENTE";

        public int Idcliente
        {
            get { return Midcliente; }
            set { Midcliente = value; }
        }

        public string Destino
        {
            get { return Mdestino; }
            set { Mdestino = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
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
            return dt = M.Listado("listado_cliente", lst);

        }
        public DataTable Listado_Cliente_Combo(Boolean objEstado, string objDpto)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@dpto", objDpto));
            return dt = M.Listado("listado_cliente_combo", lst);

        }
      
        public string ActivarCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midcliente));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();

            return mensaje;
        }


        public string RegistrarCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mnombre));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@dpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_cliente", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string ActualizarCliente()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcliente", Midcliente));
            lst.Add(new clsParametros("@descripcion", Mnombre));
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@dpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_cliente", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
    }
}
