using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Intermedia
{
    public class clsTurno
    {
        private clsManejador M = new clsManejador();

        #region Parameters
        int Mid;
        int Mtypeid;
        string Middpto;
        string Midturno;
        string Mdescripcion;
        Boolean Mestado;
        string Mcampo = "ID_TURNO";
        string Mtabla = "TURNO";
        DateTime MHorainicio;
        DateTime MHorafin;
        DateTime MInicioHent;
        DateTime MFinHent;
        DateTime MInicioHsal;
        DateTime MFinHsal;
        bool MHoracomida;
        int MDuracion;
        string Midempleado;
        bool Msemana;
        bool MfinSemana;
        #endregion

        #region Properties
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Typeid
        {
            get { return Mtypeid; }
            set { Mtypeid = value; }
        }
        public string Idturno
        {
            get { return Midturno; }
            set { Midturno = value; }
        }
        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
        }
        public string IdEmpleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }

        public bool Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        public bool Semana
        {
            get { return Msemana; }
            set { Msemana = value; }
        }
        public bool FinSemana
        {
            get { return MfinSemana; }
            set { MfinSemana = value; }
        }

        public Boolean HoraComida
        {
            get { return MHoracomida; }
            set { MHoracomida = value; }
        }

        public int Duracion
        {
            get { return MDuracion; }
            set { MDuracion = value; }
        }
        public DateTime HoraInicio
        {
            get { return MHorainicio; }
            set { MHorainicio = value; }
        }
        public DateTime HoraFin
        {
            get { return MHorafin; }
            set { MHorafin = value; }
        }
        public DateTime InicioHent
        {
            get { return MInicioHent; }
            set { MInicioHent = value; }
        }
        public DateTime FinHent
        {
            get { return MFinHent; }
            set { MFinHent = value; }
        }
        public DateTime InicioHsal
        {
            get { return MInicioHsal; }
            set { MInicioHsal = value; }
        }
        public DateTime FinHsal
        {
            get { return MFinHsal; }
            set { MFinHsal = value; }
        }


        #endregion


        #region AttControl

        public DataTable ObtAttControlTypes()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("obt_attcontrol_type", lst);
        }

        public string RegistrarActAttControl()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@idate", MHorainicio));
            lst.Add(new clsParametros("@fdate", MHorafin));
            lst.Add(new clsParametros("@typeid", Mtypeid));
            lst.Add(new clsParametros("@idempleado", Midempleado));
            M.EjecutarSP("reg_act_attcontrol", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public DataTable ObtRegAttControl()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@typeid", Mtypeid));
            return dt = M.Listado("obt_reg_attcontrol", lst);
        }
        #endregion


        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            return dt = M.Listado("listado_turno", lst);
        }
        public DataTable ObtenerInicioFinTurno()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idturno", Midturno));
            return dt = M.Listado("obt_inicio_fin_turno", lst);
        }

        public DataTable ObtenerAsignacionTurno()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@iddpto", Middpto));
            return dt = M.Listado("obt_asignacion_turno", lst);
        }
        public string EliminarAsignacionTurno()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            M.EjecutarSP("eliminar_asignacion_turno", ref lst);
            mensaje = lst[0].Valor.ToString();

            return mensaje;
        }
        public string ActivarTurno()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midturno));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }

        public string RegistrarTurno()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@horainicio", MHorainicio));
            lst.Add(new clsParametros("@horafin", MHorafin));
            lst.Add(new clsParametros("@iniciohent", MInicioHent));
            lst.Add(new clsParametros("@finhent", MFinHent));
            lst.Add(new clsParametros("@iniciohsal", MInicioHsal));
            lst.Add(new clsParametros("@finhsal", MFinHsal));
            lst.Add(new clsParametros("@horacomida", MHoracomida));
            lst.Add(new clsParametros("@duracion", MDuracion));
            M.EjecutarSP("registrar_turno", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarAsignacionTurno()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@semana", Msemana));
            lst.Add(new clsParametros("@finsemana", MfinSemana));
            M.EjecutarSP("reg_act_asignacion_turno", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarTurno()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            lst.Add(new clsParametros("@horainicio", MHorainicio));
            lst.Add(new clsParametros("@horafin", MHorafin));
            lst.Add(new clsParametros("@iniciohent", MInicioHent));
            lst.Add(new clsParametros("@finhent", MFinHent));
            lst.Add(new clsParametros("@iniciohsal", MInicioHsal));
            lst.Add(new clsParametros("@finhsal", MFinHsal));
            lst.Add(new clsParametros("@horacomida", MHoracomida));
            lst.Add(new clsParametros("@duracion", MDuracion));
            M.EjecutarSP("actualizar_turno", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }
    }
}

