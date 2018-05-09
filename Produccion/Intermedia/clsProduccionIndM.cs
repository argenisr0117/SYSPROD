using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Intermedia
{
    public class clsProduccionIndM
    {
        private clsManejador M = new clsManejador();
        DateTime Mfecha;
        DateTime Mfecha1;
        DateTime Mfechaft;
        DateTime Mfechaf;
        string Msupervisor;
        string Moperador;
        string Mayudante;
        string Mturno;
        int Mtarjeta;
        string Mdestino;
        decimal Mcantidad;
        string Mreporte;
        string Midempleado;
        string Midmaquina;
        string Midproducto;
        int Mcantidad1;
        int Mvalor;
        int Midcliente;
        int Midorden;
        int Midusuario;
        string Mpcname;
        string Mdpto;

        public string Pcname
        {
            get { return Mpcname; }
            set { Mpcname = value; }
        }
        public string Dpto
        {
            get { return Mdpto; }
            set { Mdpto = value; }
        }
        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }
        public int Idorden
        {
            get { return Midorden; }
            set { Midorden = value; }
        }
        public int Idcliente
        {
            get { return Midcliente; }
            set { Midcliente = value; }
        }
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Fecha1
        {
            get { return Mfecha1; }
            set { Mfecha1 = value; }
        }
        public DateTime Fechaft
        {
            get { return Mfechaft; }
            set { Mfechaft = value; }
        }
        public DateTime Fechaf
        {
            get { return Mfechaf; }
            set { Mfechaf = value; }
        }
        public string Supervisor
        {
            get { return Msupervisor; }
            set { Msupervisor = value; }
        }

        public string Operador
        {
            get { return Moperador; }
            set { Moperador = value; }
        }
        public string Ayudante
        {
            get { return Mayudante; }
            set { Mayudante = value; }
        }
        public string Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        }

        public string Idproducto
        {
            get { return Midproducto; }
            set { Midproducto= value; }
        }
        public string Idmaquina
        {
            get { return Midmaquina; }
            set { Midmaquina = value; }
        }

        public int Cantidad1
        {
            get { return Mcantidad1; }
            set { Mcantidad1 = value; }
        }
        public string Turno
        {
            get { return Mturno; }
            set { Mturno = value; }
        }
        public int Tarjeta
        {
            get { return Mtarjeta; }
            set { Mtarjeta = value; }
        }
        public int Valor
        {
            get { return Mvalor; }
            set { Mvalor = value; }
        }

        public string Destino
        {
            get { return Mdestino; }
            set { Mdestino = value; }
        }
        public Decimal Cantidad
        {
            get { return Mcantidad; }
            set { Mcantidad = value; }
        }
        public string Reporte
        {
            get { return Mreporte; }
            set { Mreporte = value; }
        }
        public string RegistrarProduccionIndM()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@codigoprod", Midproducto));
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@idorden", Midorden));
            lst.Add(new clsParametros("@idcliente", Midcliente));
            M.EjecutarSP("registrar_produccion_indm", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarRegistros()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@maquina", Midmaquina));
            lst.Add(new clsParametros("@producto", Midproducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad));
            lst.Add(new clsParametros("@idcliente",Midcliente ));
            M.EjecutarSP("actualizar_registro_indm", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
        public DataTable ObtenerOrden()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Mdpto));
            lst.Add(new clsParametros("@idcliente", Midcliente));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            return dt = M.Listado("obtener_orden_canasto", lst);
        }
        public void CompletarOrdenProduccion()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idorden", Midorden));
            M.EjecutarSP("completar_orden_produccion", ref lst);
        }
        public void ActCantOrdenProduccion()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idorden", Midorden));
            lst.Add(new clsParametros("@peso", Mcantidad));
            M.EjecutarSP("act_cant_orden_produccion", ref lst);
        }
        public void EliminarRegistro(int objTarjeta)
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@pcname", Mpcname));
            lst.Add(new clsParametros("@tarjeta", objTarjeta));
            M.EjecutarSP("eliminar_registro_indm", ref lst);
        }
        public string RegistrarInvPuas()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad1));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_inv_puas", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public void ActualizarInvPuas()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Moperador));
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad1));
            M.EjecutarSP("actualizar_inv_puas", ref lst);
        }
        public int EditarInvPuas()
        {
            int mensaje;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@idmaquina", Midmaquina));
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@cantidad", Mcantidad1));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Int, ParameterDirection.Output, 8));
            M.EjecutarSP("editar_inv_puas", ref lst);
            mensaje = Convert.ToInt32(lst[4].Valor);
            return mensaje;
        }
        public string VerificarCategoria()
        {
            string valor = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idproducto", Midproducto));
            lst.Add(new clsParametros("@valor", "", SqlDbType.VarChar, ParameterDirection.Output,1));
            M.EjecutarSP("verificar_categoria", ref lst);
            valor = lst[1].Valor.ToString();
            return valor;
        }
        
        public DataTable MostrarRegistros()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            return dt = M.Listado("produccion_diaria_indm", lst);
        }
        public DataTable ListadoCliente2()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_cliente2", lst);
        }

        public DataTable ObtenerInvPuas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("obtener_inv_puas", lst);
        }
        public DataTable VerificarPuasOperador()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Idempleado));
            lst.Add(new clsParametros("@idproducto", Idproducto));
            return dt = M.Listado("verificar_puas_operador", lst);
        }
        public DataTable ObtenerPuasOperador()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Idempleado));
            lst.Add(new clsParametros("@idproducto", Idproducto));
            return dt = M.Listado("obtener_puas_operador", lst);
        }

        public DataTable BuscarProduccion()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            return dt = M.Listado("buscar_produccion", lst);
        }
        public string ExportarRegistroDpto()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@reporte", Mreporte));
            lst.Add(new clsParametros("@fechai", Mfecha1));
            lst.Add(new clsParametros("@fechaft", Mfechaft));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@valor", Mvalor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("exportar_registros_dpto", ref lst);
            mensaje = lst[5].Valor.ToString();
            return mensaje;
        }
        public DataTable SecuenciaReporte()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("secuencia_reporte", lst);
        }
    }
}
