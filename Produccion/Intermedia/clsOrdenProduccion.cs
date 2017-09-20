using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;

namespace Intermedia
{
    public class clsOrdenProduccion
    {
        private clsManejador M = new clsManejador();

        DateTime Mfecha;
        string Mnumorden;
        string Mdpto;
        int Mid;
        string Mproducto;
        double Mcantidad;
        int Mcliente;
        int Midusuario;
        int Mvalor;
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public string Numorden
        {
            get { return Mnumorden; }
            set { Mnumorden = value; }
        }
        public string Dpto
        {
            get { return Mdpto; }
            set { Mdpto = value; }
        }
        
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public string Producto
        {
            get { return Mproducto; }
            set { Mproducto = value; }
        }
        public double Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
        }
        public int Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }

        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }

        public bool RegistrarOrdenProduccion()
        {
            bool mensaje = false;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@numorden", Mnumorden));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@iddpto", Mdpto));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            M.EjecutarSP("registrar_orden_produccion", ref lst);
            mensaje =Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        public bool ActualizarOrdenProduccion()
        {
            bool mensaje = false;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@numorden", Mnumorden));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            M.EjecutarSP("actualizar_orden", ref lst);
            mensaje = Convert.ToBoolean(lst[0].Valor);
            return mensaje;
        }
        public DataTable ListadoOrdenes(bool estado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", estado));
            return dt = M.Listado("buscar_ordenes", lst);
        }

    }
}
