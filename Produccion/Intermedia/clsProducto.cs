using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Windows.Input;

namespace Intermedia
{
    public class clsProducto
    {
        private clsManejador M = new clsManejador();

        string Mcodigo;
        string Mdescripcion;
        string Midunidad;
        Double Mcalibre;
        decimal Mdiam_pulg;
        decimal Mdiam_mm;
        string Mgrosor;
        Int32 Midcategoria;
        Boolean Mestado;
        Double Mpesolbs;
        double Mfactorqqs;
        string Mcampo = "CODIGO";
        string Mtabla = "PRODUCTO";

        public string Codigo
        {
            get { return Mcodigo; }
            set { Mcodigo = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        public string Idunidad
        {
            get { return Midunidad; }
            set { Midunidad = value; }
        }

        public Double Calibre
        {
            get { return Mcalibre; }
            set { Mcalibre = value; }
        }
        public decimal Diam_pulg
        {
            get { return Mdiam_pulg; }
            set { Mdiam_pulg = value; }
        }
        
        public decimal Diam_mm
        {
            get { return Mdiam_mm; }
            set {Mdiam_mm = value; }
        }
        public string Grosor
        {
            get { return Mgrosor; }
            set { Mgrosor = value; }
        }
        public Int32 Idcategoria
        {
            get { return Midcategoria; }
            set { Midcategoria = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        public Double PesoLBS
        {
            get { return Mpesolbs; }
            set { Mpesolbs = value; }
        }
        public Double FactorQQS
        {
            get { return Mfactorqqs; }
            set { Mfactorqqs = value; }
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_producto", lst);

        }
        public DataTable Listado_Productos_Dpto(int objValor)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", objValor));
            return dt = M.Listado("listado_productos_dpto", lst);

        }
        public DataTable Listar2(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_producto2", lst);

        }
        public DataTable BuscarC(Boolean objEstado, string objValor)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", objValor));
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("buscar_productoc", lst);

        }
        public DataTable BuscarD(Boolean objEstado, string objValor, int objValor1)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@valor", objValor));
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@valor1", objValor1));
            return dt = M.Listado("buscar_productod", lst);

        }
        public DataTable Consulta(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("consulta_producto", lst);
        }

        public DataTable GetCalibre(double calibre)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@calibre", calibre));
            return dt = M.Listado("calibre", lst);
        }
        public string ActivarProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Mcodigo));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }


        public string RegistrarProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@calibre", Mcalibre));
            lst.Add(new clsParametros("@diametropulg", Mdiam_pulg));
            lst.Add(new clsParametros("@diametromm", Mdiam_mm));
            lst.Add(new clsParametros("@grosor", Mgrosor));
            lst.Add(new clsParametros("@idcategoria", Midcategoria));
            lst.Add(new clsParametros("@pesolbs", Mpesolbs));
            lst.Add(new clsParametros("@factorqqs", Mfactorqqs));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_producto", ref lst);
            mensaje = lst[10].Valor.ToString();
            return mensaje;
        }

        public string ActualizarProducto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@codigo", Mcodigo));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@idunidad", Midunidad));
            lst.Add(new clsParametros("@calibre", Mcalibre));
            lst.Add(new clsParametros("@diametropulg", Mdiam_pulg));
            lst.Add(new clsParametros("@diametromm", Mdiam_mm));
            lst.Add(new clsParametros("@grosor", Mgrosor));
            lst.Add(new clsParametros("@idcategoria", Midcategoria));
            lst.Add(new clsParametros("@pesolbs", Mpesolbs));
            lst.Add(new clsParametros("@factorqqs", Mfactorqqs));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_producto", ref lst);
            mensaje = lst[10].Valor.ToString();
            return mensaje;
        }

    }
}
