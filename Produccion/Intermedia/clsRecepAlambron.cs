using Datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Intermedia
{
    public class clsRecepAlambron
    {
        private clsManejador M = new clsManejador();

        #region Chofer
        int _IdChofer;

        public int IdChofer
        {
            get { return _IdChofer; }
            set { _IdChofer = value; }
        }
        public DataTable ListadoChofer()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_chofer", lst);
        }

        #endregion

        #region Pedido
        int _IdPedido;
        int _Valor;
        string _Pedido;
        bool _EstadoP;

        public int IdPedido
        {
            get { return _IdPedido; }
            set { _IdPedido = value; }
        }
        public int Valor
        {
            get { return _Valor; }
            set { _Valor = value; }
        }
        public string Pedido
        {
            get { return _Pedido; }
            set { _Pedido = value; }
        }

        public bool EstadoP
        {
            get { return _EstadoP; }
            set { _EstadoP = value; }
        }

        public DataTable ListadoPedidos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_pedidos", lst);
        }

        public string RegistrarActPedido()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@idpedido", _IdPedido));
            lst.Add(new clsParametros("@pedido", _Pedido));
            lst.Add(new clsParametros("@valor", _Valor));
            lst.Add(new clsParametros("@estado", _EstadoP));
            M.EjecutarSP("reg_act_pedidos", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string EliminarPedido()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@idpedido", _IdPedido));
            M.EjecutarSP("Eliminar_pedido", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable BuscarPedido()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@Pedido", _Pedido));
            return dt = M.Listado("Buscar_Pedido", lst);
        }

        #endregion

        #region Recepcion
        string _IdRecepcion;
        DateTime _Fecha;
        string _Conduce;
        int _Idrecep;
        int _Top;
        string _Busqueda;


        public string IdRecepcion
        {
            get { return _IdRecepcion; }
            set { _IdRecepcion = value; }
        }
        public int IdRecep

        {
            get { return _Idrecep; }
            set { _Idrecep = value; }
        }
        public string Conduce
        {
            get { return _Conduce; }
            set { _Conduce = value; }
        }

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        public string GenerarNumRecepion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@NumRecepcion", "", SqlDbType.VarChar, ParameterDirection.Output, 10));
            M.EjecutarSP("Generar_NumRecepcion", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarActRecepcion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@IdPedido", _IdPedido));
            lst.Add(new clsParametros("@Pedido", _Pedido));
            lst.Add(new clsParametros("@valor", _Valor));
            lst.Add(new clsParametros("@Conduce", _Conduce));
            lst.Add(new clsParametros("@IdRecepcion", _IdRecepcion));
            lst.Add(new clsParametros("@Fecha", _Fecha));
            lst.Add(new clsParametros("@IdChofer", _IdChofer));
            M.EjecutarSP("Reg_act_recepcion", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ListadoRecepcion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("Listado_recepcion", lst);
        }
        public string EliminarRecepcion()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@idrecepcion", _Idrecep));
            M.EjecutarSP("Eliminar_Recepcion_Alambron", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public DataTable ObtenerUltimaRecepcion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("Obtener_ult_recepcion", lst);
        }

        public DataTable VerificarRecepcionAlambron()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@Idrecepcion", _IdRecepcion));
            return dt = M.Listado("Verificar_Recepcion_Alambron", lst);
        }
        #endregion

        #region Almacen
        int _IdAlmacen;

        public int IdAlmacen
        {
            get { return _IdAlmacen; }
            set { _IdAlmacen = value; }
        }
        public DataTable ListadoAlmacen()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", 1));
            return dt = M.Listado("listado_almacen", lst);
        }
        #endregion

        #region Cliente
        int _IdCliente;

        public int IdCliente
        {
            get { return _IdCliente; }
            set { _IdCliente = value; }
        }
        public DataTable ListadoCliente()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", 1));
            return dt = M.Listado("Listado_Clientes_Alambron", lst);
        }
        #endregion

        #region Rollos
        string _Colada;
        string _NumRollo;
        string _Sae;
        string _Diametro;
        decimal _Peso;
        int _IdFabricante;
        int _Id;
        bool _Impreso;
        bool _Eliminado;
        byte[] _Barcode;

        public string Colada
        {
            get { return _Colada; }
            set { _Colada = value; }
        }
        public string NumRollo

        {
            get { return _NumRollo; }
            set { _NumRollo = value; }
        }
        public string Sae
        {
            get { return _Sae; }
            set { _Sae = value; }
        }
        public string Diametro
        {
            get { return _Diametro; }
            set { _Diametro = value; }
        }

        public decimal Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }

        public int IdFabricante
        {
            get { return _IdFabricante; }
            set { _IdFabricante = value; }
        }

        public int Top
        {
            get
            {
                return _Top;
            }

            set
            {
                _Top = value;
            }
        }

        public string Busqueda
        {
            get
            {
                return _Busqueda;
            }

            set
            {
                _Busqueda = value;
            }
        }

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public bool Impreso
        {
            get
            {
                return _Impreso;
            }

            set
            {
                _Impreso = value;
            }
        }

        public bool Eliminado
        {
            get
            {
                return _Eliminado;
            }

            set
            {
                _Eliminado = value;
            }
        }

        public byte[] Barcode
        {
            get
            {
                return _Barcode;
            }

            set
            {
                _Barcode = value;
            }
        }

        public string RegistrarRollo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@IdRecep", _Idrecep));
            lst.Add(new clsParametros("@Colada", _Colada));
            lst.Add(new clsParametros("@NumRollo", _NumRollo));
            lst.Add(new clsParametros("@Diametro", _Diametro));
            lst.Add(new clsParametros("@Sae", _Sae));
            lst.Add(new clsParametros("@IdAlmacen", _IdAlmacen));
            lst.Add(new clsParametros("@IdCliente", _IdCliente));
            lst.Add(new clsParametros("@Peso", _Peso));
            lst.Add(new clsParametros("@IdFabrIcante", _IdFabricante));
            lst.Add(new clsParametros("@Barcode", _Barcode));
            M.EjecutarSP("Reg_rollo_alambron", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public string EliminarRollo()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@Colada", _Colada));
            lst.Add(new clsParametros("@NumRollo", _NumRollo));
            lst.Add(new clsParametros("@Id", _Id));
            M.EjecutarSP("Eliminar_rolloAlambron", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ListadoRollosAlambron()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@Top", _Top));
            lst.Add(new clsParametros("@Busqueda", _Busqueda));
            lst.Add(new clsParametros("@Impreso", _Impreso));
            lst.Add(new clsParametros("@Eliminado", _Eliminado));
            return dt = M.Listado("Listado_Rollos", lst);
        }


        public int ObtenerUltimoIdRollo()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.Int, ParameterDirection.Output, 8));
            M.EjecutarSP("Obtener_ult_IdRolloAlambron", ref lst);
            mensaje = Convert.ToInt32(lst[0].Valor);
            return mensaje;
        }

        public string ObtenerPesoRolloAlambron()
        {
            string mensaje ="";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@_Rollo", "", SqlDbType.VarChar, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@Rollo", _NumRollo));
            M.EjecutarSP("Obtener_Peso_Rollo_Alambron", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        #endregion

        #region Fabricante
        public DataTable ListadoFabricante()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_fabricantes", lst);
        }
        #endregion


    }
}
