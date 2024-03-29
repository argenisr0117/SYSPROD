﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace Intermedia
{
    public class clsEmpleado
    {
        private clsManejador M = new clsManejador();

        string Midempleado;
        string Mempresa;
        string Mnombre;
        string Middpto;
        string Midturno;
        string Mcargo;
        Boolean Mestado;
        Boolean Mayudante;
        Boolean Moperador;
        Boolean Mcorrido;
        Boolean Mferiado;
        Boolean Mvacaciones;
        Boolean Mincapacidad;
        bool Minasistencia;
        bool? Mpermiso;
        Boolean Msupervisor;
        string Mcampo = "ID_EMPLEADO";
        string Mtabla = "EMPLEADO";
        DateTime Mhoraent;
        DateTime Mhorasal;
        DateTime Mdesde;
        DateTime Mhasta;
        DateTime Mfecha;
        int Midhora;
        int Mpin;
        int Mid;

        public DateTime Fecha
        {
            get { return Mfecha; }
            set { Mfecha = value; }
        }
        public DateTime HoraEnt
        {
            get { return Mhoraent; }
            set { Mhoraent = value; }
        }
        public DateTime HoraSal
        {
            get { return Mhorasal; }
            set { Mhorasal = value; }
        }
        public DateTime Desde
        {
            get { return Mdesde; }
            set { Mdesde = value; }
        }
        public DateTime Hasta
        {
            get { return Mhasta; }
            set { Mhasta = value; }
        }
        public string Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
        }
        public string Idturno
        {
            get { return Midturno; }
            set { Midturno = value; }
        }
        public int Idhora
        {
            get { return Midhora; }
            set { Midhora = value; }
        }
        public int Id
        {
            get { return Mid; }
            set { Mid = value; }
        }
        public int Pin
        {
            get { return Mpin; }
            set { Mpin = value; }
        }
        public string Empresa
        {
            get { return Mempresa; }
            set { Mempresa = value; }
        }

        public string Cargo
        {
            get { return Mcargo; }
            set { Mcargo = value; }
        }
        public string Nombre
        {
            get { return Mnombre; }
            set { Mnombre = value; }
        }

        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
        }
        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        public Boolean Corrido
        {
            get { return Mcorrido; }
            set { Mcorrido = value; }
        }
        public Boolean Feriado
        {
            get { return Mferiado; }
            set { Mferiado = value; }
        }
        public bool? Permiso
        {
            get { return Mpermiso; }
            set { Mpermiso = value; }
        }
        public Boolean Vacaciones
        {
            get { return Mvacaciones; }
            set { Mvacaciones = value; }
        }
        public Boolean Incapacidad
        {
            get { return Mincapacidad; }
            set { Mincapacidad = value; }
        }
        public Boolean Inasistencia
        {
            get { return Minasistencia; }
            set { Minasistencia = value; }
        }
        public Boolean Ayudante
        {
            get { return Mayudante; }
            set { Mayudante = value; }
        }
        public Boolean Operador
        {
            get { return Moperador; }
            set { Moperador = value; }
        }
        public Boolean Supervisor
        {
            get { return Msupervisor; }
            set { Msupervisor = value; }
        }

        public DataTable Listar(Boolean objEstado)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@iddpto", Middpto));
            return dt = M.Listado("listado_empleado", lst);

        }
        public DataTable ObtHistorialAsistencia()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            lst.Add(new clsParametros("@idempleado",Midempleado));
            lst.Add(new clsParametros("@iddpto", Middpto));
            return dt = M.Listado("obt_historial_asistencia", lst);

        }
        public DataTable ObtRegistrosHorasExtras()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@desde", Mdesde));
            lst.Add(new clsParametros("@hasta", Mhasta));
            lst.Add(new clsParametros("@idempresa", Mempresa));
            lst.Add(new clsParametros("@iddpto", Middpto));
            return dt = M.Listado("obt_registros_horas_extras", lst);

        }
        public DataTable Listado_Operadores_Tref()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_operadores_trefilado", lst);

        }
        public DataTable Listado_Supervisores_Tref()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_supervisores_trefilado", lst);

        }
        public DataTable Listado_Supervisores_Galv()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_supervisores_galv", lst);

        }
        public DataTable Listado_Operadores_Galv()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_operadores_galv", lst);

        }
        public DataTable Listado_Ayudantes_Galv()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_ayudantes_galv", lst);

        }
        public DataTable ListarS(Boolean objEstado,Boolean objSupervisor)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@supervisor", objSupervisor));
            return dt = M.Listado("listado_supervisor", lst);

        }
        public DataTable ListarO(Boolean objEstado, Boolean objOperador)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@operador", objOperador));
            return dt = M.Listado("listado_operador", lst);

        }
        public DataTable ListarA(Boolean objEstado, Boolean objAyudante)
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", objEstado));
            lst.Add(new clsParametros("@ayudante", objAyudante));
            return dt = M.Listado("listado_ayudante", lst);

        }
        public DataTable ListarOA()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@estado", 1));
            lst.Add(new clsParametros("@operador", 1));
            lst.Add(new clsParametros("@ayudante", 1));
            return dt = M.Listado("listado_operador_ayu", lst);

        }
        public string RegistrarDailyAtt()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            //lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@fecha", Mfecha));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@idempleado", Midempleado));
            M.EjecutarSP("reg_daily_att", ref lst);
            //mensaje = lst[4].Valor.ToString();

            return mensaje;
        }
        public string ActivarEmpleado()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midempleado));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();

            return mensaje;
        }
        public string EliminarRegHoraExtra()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@idreghora", Midhora));
            M.EjecutarSP("eliminar_reg_hora_extra", ref lst);
            mensaje = lst[0].Valor.ToString();

            return mensaje;
        }

        public string EliminarRegAttControl()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Mid));
            M.EjecutarSP("eliminar_reg_attcontrol", ref lst);
            mensaje = lst[0].Valor.ToString();

            return mensaje;
        }
        public string RegistrarActHorasExtras()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Midhora));
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@idturno", Midturno));
            lst.Add(new clsParametros("@hora_ent", Mhoraent));
            lst.Add(new clsParametros("@hora_sal", Mhorasal));
            lst.Add(new clsParametros("@feriado", Mferiado));
            lst.Add(new clsParametros("@corrido", Mcorrido));
            lst.Add(new clsParametros("@vacaciones", Mvacaciones));
            lst.Add(new clsParametros("@incapacidad", Mincapacidad));
            lst.Add(new clsParametros("@inasistencia", Minasistencia));
            lst.Add(new clsParametros("@permiso", Mpermiso));
            M.EjecutarSP("reg_act_horas_extras", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string RegistrarEmpleado()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@empresa", Mempresa));
            lst.Add(new clsParametros("@cargo", Mcargo));
            lst.Add(new clsParametros("@pin", Mpin));
            M.EjecutarSP("registrar_empleado", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }

        public string ActualizarEmpleado()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idempleado", Midempleado));
            lst.Add(new clsParametros("@nombre", Mnombre));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@ayudante", Mayudante));
            lst.Add(new clsParametros("@operador", Moperador));
            lst.Add(new clsParametros("@supervisor", Msupervisor));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@empresa", Mempresa));
            lst.Add(new clsParametros("@cargo", Mcargo));
            lst.Add(new clsParametros("@pin", Mpin));
            M.EjecutarSP("actualizar_empleado", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }

    }
}
