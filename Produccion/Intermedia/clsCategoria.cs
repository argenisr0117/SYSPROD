using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Intermedia
{
    public class clsCategoria
    {
        private clsManejador M = new clsManejador();

        Int32 Midcategoria;
        string Mdescripcion;
        Boolean Mestado;
        string Mcampo = "ID_CATEGORIA";
        string Mtabla = "CATEGORIA";

        public Int32 Idcategoria
        {
            get { return Midcategoria; }
            set { Midcategoria = value; }
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
            return dt = M.Listado("listado_categoria", lst);

        }

        public string ActivarCategoria()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midcategoria));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string RegistrarCategoria()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_categoria", ref lst);
            mensaje = lst[1].Valor.ToString();
            return mensaje;
        }

        public string ActualizarCategoria()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idcategoria", Midcategoria));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_categoria", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}

