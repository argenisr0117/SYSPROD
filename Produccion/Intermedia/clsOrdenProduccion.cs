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
        DateTime Mfechaf;
        string Mnumorden;
        string Mdpto;
        int Mid;
        Boolean Mticket;
        Boolean Mlongitud;
        int Midtipo;
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
        string Mcontenedor;
        string Midempresa;
        int Mtamano;
        int Miduso;
        string Mconduce;
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Fechaf
        {
            get { return Mfechaf; }
            set { Mfechaf = value; }
        }
        public string Numorden
        {
            get { return Mnumorden; }
            set { Mnumorden = value; }
        }
        public string Conduce
        {
            get { return Mconduce; }
            set { Mconduce = value; }
        }
        public string Contenedor
        {
            get { return Mcontenedor; }
            set { Mcontenedor = value; }
        }
        public string Idempresa
        {
            get { return Midempresa; }
            set { Midempresa = value; }
        }
        public int Tamano
        {
            get { return Mtamano; }
            set { Mtamano = value; }
        }
        public int Iduso
        {
            get { return Miduso; }
            set { Miduso = value; }
        }
        public Boolean Ticket
        {
            get { return Mticket; }
            set { Mticket = value; }
        }
        public Boolean Longitud
        {
            get { return Mlongitud; }
            set { Mlongitud = value; }
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
        public int Idtipo
        {
            get { return Midtipo; }
            set { Midtipo = value; }
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

        public DataTable SecuenciaConduce()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("secuencia_conduce", lst);
        }
        public DataTable ListadoUsoAlambre(int tipo)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipo", tipo));
            return dt = M.Listado("listado_uso_alambre", lst);
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
            lst.Add(new clsParametros("@idtipo", Midtipo));
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
        public bool EliminarOrdenProduccion()
        {
            bool mensaje = false;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Bit, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idorden", Mid));
            M.EjecutarSP("eliminar_orden_produccion", ref lst);
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
            lst.Add(new clsParametros("@ticket", Mticket));
            lst.Add(new clsParametros("@idempresa", Midempresa));
            lst.Add(new clsParametros("@id", Mid));
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
        public DataTable BuscarPakingList()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mfecha));
            lst.Add(new clsParametros("@hasta", Mfechaf));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            return dt = M.Listado("buscar_packing_list", lst);
        }
        public string RegistrarPackingList()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@idproducto", Mproducto));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idpacking", Mid));
            lst.Add(new clsParametros("@idcliente", Mcliente));
            lst.Add(new clsParametros("@numorden", Mnumorden));
            lst.Add(new clsParametros("@contenedor", Mcontenedor));
            lst.Add(new clsParametros("@idempresa", Midempresa));
            lst.Add(new clsParametros("@tamano", Mtamano));
            lst.Add(new clsParametros("@iduso", Miduso));
            lst.Add(new clsParametros("@conduce", Mconduce));
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
            lst.Add(new clsParametros("@idpacking", Mid));
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
        public void EliminarBobinaPacking()
        {
            //string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            // lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 1));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            M.EjecutarSP("eliminar_bobina_packing", ref lst);
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
        public DataTable ObtenerBobinasSeleccionadas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idpacking", Mid));
            return dt = M.Listado("obtener_bobinas_seleccionadas_packing", lst);
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
        public DataTable ListadoOrdenes(bool estado, int idtipo)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", estado));
            lst.Add(new clsParametros("@idtipo", idtipo));
            return dt = M.Listado("buscar_ordenes", lst);
        }
        public DataTable ListadoTipoOrden(bool estado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", estado));
            return dt = M.Listado("listado_tipo_orden", lst);
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
