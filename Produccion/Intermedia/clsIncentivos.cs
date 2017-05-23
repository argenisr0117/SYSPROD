using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Intermedia
{
    public class clsIncentivos
    {
        private clsManejador M = new clsManejador();

        string Mdpto;
        string Mtipo;
        string Mproducto;
        decimal Mtarifa;
        Boolean Mvalor;
        string Mdescripcion;
        string Mcodigo;

        public string Dpto
        {
            get { return Mdpto; }
            set { Mdpto = value; }
        }
        public string Tipo
        {
            get { return Mtipo; }
            set { Mtipo = value; }
        }
        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public string Codigo
        {
            get { return Mcodigo; }
            set { Mcodigo = value; }
        }
        public string Producto
        {
            get { return Mproducto; }
            set { Mproducto = value; }
        }
        public decimal Tarifa
        {
            get { return Mtarifa; }
            set { Mtarifa = value; }
        }
        public Boolean Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }

        public DataTable Listar(Boolean objEstado, string objDpto, string objTipo)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@departamento", objDpto));
            lst.Add(new clsParametros("@tipo", objTipo));
            return dt = M.Listado("listado_incentivos", lst);

        }
        public DataTable ListarLG(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_incentivolg", lst);

        }
        public DataTable CodigoProducto(string objProducto, string objTipo)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@descripcion", objProducto));
            lst.Add(new clsParametros("@tipo", objTipo));
            return dt = M.Listado("producto_codigo", lst);

        }
        public string RegistrarIncentivo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@departamento", Mdpto));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@tarifa", Mtarifa));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipo", Mtipo));
            M.EjecutarSP("registrar_incentivo", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string RegistrarIncentivoLG()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@tarifa", Mtarifa));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_incentivolg", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public string ActualizarIncentivoLG()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@tarifa", Mtarifa));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_incentivolg", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public string ActivarIncentivoLG()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("activar_incentivolg", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string ActivarIncentivo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@departamento", Mdpto));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("activar_incentivo", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }

        public string ActualizarIncentivo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@departamento", Mdpto));
            lst.Add(new clsParametros("@producto", Mproducto));
            lst.Add(new clsParametros("@tarifa", Mtarifa));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipo", Mtipo));
            M.EjecutarSP("actualizar_incentivo", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
    }
}
