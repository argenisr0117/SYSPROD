using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Intermedia
{
    public class clsDestino
    {
        private clsManejador M = new clsManejador();

        string Mdestino;
        Boolean Mestado;
        string Mcampo = "DESTINO";
        string Mtabla = "DESTINO";

        public string Destino
        {
            get { return Mdestino; }
            set { Mdestino = value; }
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
            return dt = M.Listado("listado_destino", lst);
        }

        public string RegistrarDestino()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@destino", Mdestino));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_destino", ref lst);
            mensaje = lst[1].Valor.ToString();
            return mensaje;
        }
        public string ActivarDestino()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mdestino));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        //public string ActualizarCargo()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    try
        //    {
        //        lst.Add(new clsParametros("@idcargo", Midcargo));
        //        lst.Add(new clsParametros("@descripcion", Mdescripcion));
        //        lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //        M.EjecutarSP("actualizar_cargo", ref lst);
        //        mensaje = lst[2].Valor.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return mensaje;
        //}
    }
}

