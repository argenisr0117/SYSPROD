using Datos;
using System.Collections.Generic;
using System.Data;

namespace Intermedia
{
    public class clsRecepAlambron
    {
        private clsManejador M = new clsManejador();

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

    }
}
