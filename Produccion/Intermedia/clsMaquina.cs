using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Intermedia
{
   public class clsMaquina
    {
        private clsManejador M = new clsManejador();

        string Midmaquina;
        string Mdescripcion;
        string Midproducto;
        string Middpto;
        Boolean Mestado;
        string Mcampo = "ID_MAQUINA";
        string Mtabla = "MAQUINA";

        public string Idmaquina
        {
            get { return Midmaquina; }
            set { Midmaquina = value; }
        }
        public string Idproducto
        {
            get { return Midproducto; }
            set { Midproducto = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
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
            return dt = M.Listado("listado_maquina", lst);

        }
        public DataTable Listado_Maquinas_Tref()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_maquinas_trefilado", lst);

        }
        public DataTable Listado_Maquinas_Galv()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_maquinas_galv", lst);

        }
        public DataTable Listado_Maquinas_IndMenor()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_maquinas_indmenor", lst);

        }
        public string ActivarMaquina()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midmaquina));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }


        public string RegistrarProductoMaquina()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_productovsmaquina", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
        public string RegistrarMaquina()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_maquina", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string ActualizarMaquina()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_maquina", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string EliminarProductoMaquina()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("eliminar_productovsmaquina", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public DataTable ListadoProductoMaquina()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_productovsmaquina", lst);

        }

        public DataTable ObtenerProductoMaquina()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproducto", Midproducto));
            return dt = M.Listado("obtener_productovsmaquina", lst);

        }
    }
}

