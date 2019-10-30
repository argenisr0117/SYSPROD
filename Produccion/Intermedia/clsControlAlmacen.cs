using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Data.SqlClient;

namespace Intermedia
{
    public class clsControlAlmacen
    {
        private clsManejador M = new clsManejador();

        int Midentrada;
        int Midalmacen;
        DateTime Mfecha;
        DateTime Mfechai;
        DateTime Mfechaf;
        string Mreporte;
        Boolean Mestado;
        int Midsalida;
        string Mtarjeta;
        string Mnota;
        int Miduso;

        public int Idalmacen
        {
            get { return Midalmacen; }
            set { Midalmacen = value; }
        }
        public int Iduso
        {
            get { return Miduso; }
            set { Miduso= value; }
        }
        public int Idsalida
        {
            get { return Midsalida; }
            set { Midsalida = value; }
        }
        public int Identrada
        {
            get { return Midentrada; }
            set { Midentrada = value; }
        }

        public string Reporte
        {
            get { return Mreporte; }
            set { Mreporte = value; }
        }
        public string Nota
        {
            get { return Mnota; }
            set { Mnota = value; }
        }
        public string Tarjeta
        {
            get { return Mtarjeta; }
            set { Mtarjeta = value; }
        }
        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime Fechai
        {
            get { return Mfechai; }
            set { Mfechai = value; }
        }
        public DateTime Fechaf
        {
            get { return Mfechaf; }
            set { Mfechaf = value; }
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
            return dt = M.Listado("listado_almacen", lst);
        }
        public int RegistrarEntradaAlmacen()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@id", Midentrada));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@reporte", Mreporte));
            M.EjecutarSP("reg_act_ent_alm", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public int VerificarBobinaSalida()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            M.EjecutarSP("verificar_bobina_salida", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public int VerificarRolloSalida()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            M.EjecutarSP("verificar_rollo_salida", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public void EliminarBobinaSalidaAlmacen()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            M.EjecutarSP("eli_bob_sal_inv", ref lst);
        }

        public void EliminarBobinaSalidaAlmacenAlambron()
        {
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            M.EjecutarSP("eli_bob_sal_inv_alambron", ref lst);
        }


        public DataTable ObtenerEntradasAlmacen()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfechai));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@reporte", Mreporte));
            return dt = M.Listado("obt_ent_alm", lst);
        }
        public int RegistrarSalidaInventario()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", "", SqlDbType.Int, ParameterDirection.Output, 8));
            lst.Add(new clsParametros("@iduso", Miduso));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@nota", Mnota));
            M.EjecutarSP("reg_sal_inv", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public int ActualizarSalidaInventario()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", Midsalida));
            lst.Add(new clsParametros("@iduso", Miduso));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@nota", Mnota));
            M.EjecutarSP("act_sal_inv", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public int RegistrarDetalleSalidaInventario()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", Midsalida));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            M.EjecutarSP("reg_det_sal_inv", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }

        public int RegistrarDetalleSalidaInventarioAlambron()
        {
            int mensaje = 0;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", Midsalida));
            lst.Add(new clsParametros("@tarjeta", Mtarjeta));
            M.EjecutarSP("reg_det_sal_inv_alambron", ref lst);
            mensaje = Convert.ToInt16(lst[0].Valor);
            return mensaje;
        }
        public DataTable ObtenerHistorialSalidaAlmacen()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfechai));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            return dt = M.Listado("obt_hist_sal_alm", lst);
        }

        public DataTable ObtenerHistorialSalidaAlmacenAlambron()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@fechai", Mfechai));
            lst.Add(new clsParametros("@fechaf", Mfechaf));
            lst.Add(new clsParametros("@idalmacen", Midalmacen));
            return dt = M.Listado("obt_hist_sal_alm_alambron", lst);
        }
        public DataTable ObtenerDetalleSalidaAlmacen()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", Midsalida));
            return dt = M.Listado("obt_det_sal_alm", lst);
        }
        public DataTable ObtenerDetalleSalidaAlmacenAlambron()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idsalida", Midsalida));
            return dt = M.Listado("obt_det_sal_alm_alambron", lst);
        }
        //public string ActivarCargo()
        //{
        //    string mensaje = "";
        //    List<clsParametros> lst = new List<clsParametros>();
        //    lst.Add(new clsParametros("@id", Midcargo));
        //    lst.Add(new clsParametros("@valor", Mestado));
        //    lst.Add(new clsParametros("@table", Mtabla));
        //    lst.Add(new clsParametros("@campo", Mcampo));
        //    lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //    M.EjecutarSP("actdes_entidades", ref lst);
        //    mensaje = lst[4].Valor.ToString();
        //    return mensaje;
        //}



        //    public string ActualizarCargo ()
        //    {
        //        string mensaje = "";
        //        List<clsParametros> lst = new List<clsParametros>();
        //        lst.Add(new clsParametros("@idcargo", Midcargo));
        //        lst.Add(new clsParametros("@descripcion",Mdescripcion));
        //        lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
        //        M.EjecutarSP("actualizar_cargo", ref lst);
        //        mensaje = lst[2].Valor.ToString();
        //        return mensaje;
        //    }
        //
    }
}
