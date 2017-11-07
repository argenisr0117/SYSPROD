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
        string Midd;
        string Mproducto;
        string Mmaquina;
        string Mtarjeta;
        double Mcantidad;
        int Mcliente;
        int Midusuario;
        int Mvalor;
        int Mcolada;
        bool Mestado;
        double Mdesdiampulg;
        double Mdesrecubri;
        double Mdesresislbs;
        string Mpedido;
        double Mdiampulg;
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
        public string Maquina
        {
            get { return Mmaquina; }
            set { Mmaquina = value; }
        }
        public string Pedido
        {
            get { return Mpedido; }
            set { Mpedido = value; }
        }
        public string Tarjeta
        {
            get { return Mtarjeta; }
            set { Mtarjeta = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }
        public int Colada
        {
            get { return Mcolada; }
            set { Mcolada = value; }
        }
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public string Idd
        {
            get { return Midd; }
            set { Midd = value; }
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
        public double Diampulg
        {
            get { return Mdiampulg; }
            set { Mdiampulg = value; }
        }
        public double Desrecubri
        {
            get { return Mdesrecubri; }
            set { Mdesrecubri = value; }
        }
        public double Desdiampulg
        {
            get { return Mdesdiampulg; }
            set { Mdesdiampulg = value; }
        }
        public double Desresislbs
        {
            get { return Mdesresislbs; }
            set { Mdesresislbs = value; }
        }
        public int Cliente
        {
            get { return Mcliente; }
            set { Mcliente = value; }
        }
        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
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
            lst.Add(new clsParametros("@pedido", Mpedido));
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
        public string RelacionProductoClienteLongitud()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            M.EjecutarSP("relacion_producto_cliente_longitud", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string ObtenerNumeroPedido()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@numero", "", SqlDbType.VarChar, ParameterDirection.Output, 10));
            M.EjecutarSP("obtener_numero_pedido", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string RegistrarPackingList()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@numorden", Mnumorden));
            M.EjecutarSP("registrar_packing_list", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public void RegistrarDetallePackingList()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
           // lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@peso", Mcantidad));
            M.EjecutarSP("registrar_detalle_packing_list", ref lst);
            //mensaje = lst[0].Valor.ToString();
            //return mensaje;
        }
        public void RegistrarActualiarRptCalidad()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            // lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idreporte", Mid));
            lst.Add(new clsParametros("@desdiampulg", Mdesdiampulg));
            lst.Add(new clsParametros("@desresislbs", Mdesresislbs));
            lst.Add(new clsParametros("@desrecubri", Mdesrecubri));
            M.EjecutarSP("registrar_actualizar_rpt_calidad", ref lst);
            //mensaje = lst[0].Valor.ToString();
            //return mensaje;
        }
        
        public DataTable ObtenerProductoClienteLongitud(bool estado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", estado));
            return dt = M.Listado("obtener_producto_cliente_longitud", lst);
        }
        public DataTable ObtenerRegistrosCalidadBobinaPacking()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@idmaquina", Mmaquina));
            return dt = M.Listado("obtener_registros_calidad_bobinas_packing", lst);
        }
        public DataTable ListadoOrdenes(bool estado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", estado));
            return dt = M.Listado("buscar_ordenes", lst);
        }
        public DataTable ObtenerBobinasOrdenPacking()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@numero", Mnumorden));
            return dt = M.Listado("obtener_bobinas_orden_packing", lst);
        }
        public string Activar()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midd));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", "PROD_CLIENTE_LONGITUD"));
            lst.Add(new clsParametros("@campo", "ID"));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }


    }
}
