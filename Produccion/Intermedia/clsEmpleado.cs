using System;
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
        string Mcargo;
        Boolean Mestado;
        Boolean Mayudante;
        Boolean Moperador;
        Boolean Msupervisor;
        string Mcampo = "ID_EMPLEADO";
        string Mtabla = "EMPLEADO";

        public string Idempleado
        {
            get { return Midempleado; }
            set { Midempleado = value; }
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
            return dt = M.Listado("listado_empleado", lst);

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
            M.EjecutarSP("actualizar_empleado", ref lst);
            mensaje = lst[6].Valor.ToString();
            return mensaje;
        }

    }
}
