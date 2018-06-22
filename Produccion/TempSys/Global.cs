using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempSys
{
    
    public class Global
    {
        private clsManejador M = new clsManejador();

        int Midentrada;
        string Mdescripcion;
        string Mtipohorno;
        string Mtipohorno2;
        int Mnumentrada;
        int Mmin;
        int Mmax;


        public int Max
        {
            get { return Mmax; }
            set { Mmax = value; }
        }
        public int Min
        {
            get { return Mmin; }
            set { Mmin = value; }
        }
        public int Identrada
        {
            get { return Midentrada; }
            set { Midentrada = value; }
        }
        public int Numentrada
        {
            get { return Mnumentrada; }
            set { Mnumentrada = value; }
        }

        public string Descripcion
        {
            get { return Mdescripcion; }
            set { Mdescripcion = value; }
        }
        public string TipoHorno
        {
            get { return Mtipohorno; }
            set { Mtipohorno = value; }
        }

        public string TipoHorno2
        {
            get { return Mtipohorno2; }
            set { Mtipohorno2 = value; }
        }

        int Me0;
        public int E0
        {
            get { return Me0; }
            set {Me0 = value; }
        }

        int Me1;
        public int E1
        {
            get { return Me1; }
            set { Me1 = value; }
        }
        int Me2;
        public int E2
        {
            get { return Me2; }
            set { Me2 = value; }
        }
        int Me3;
        public int E3
        {
            get { return Me3; }
            set { Me3 = value; }
        }
        int Me4;
        public int E4
        {
            get { return Me4; }
            set { Me4 = value; }
        }
        int Me5;
        public int E5
        {
            get { return Me5; }
            set { Me5 = value; }
        }
        int Me6;
        public int E6
        {
            get { return Me6; }
            set { Me6 = value; }
        }

        int Me7;
        public int E7
        {
            get { return Me7; }
            set { Me7 = value; }
        }

        

        public DataTable ObtenerEntradas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("obt_entradas_mod_temp", lst);
        }

        public DataTable ObtenerNombreEntradas()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@numeroEntrada", Mnumentrada));
            return dt = M.Listado("obt_nombre_entrada_mod_temp", lst);
        }

        public DataTable ObtenerMinMaxTipoHorno()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipoHorno", Mtipohorno));
            return dt = M.Listado("obt_valores_tipo_horno_mod_temp", lst);
        }

        public DataTable ObtenerMinMaxTipoHorno2()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@tipoHorno", Mtipohorno2));
            return dt = M.Listado("obt_valores_tipo_horno_mod_temp", lst);
        }

        public DataTable ObtenerRegistrosTemperatura()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            
            return dt = M.Listado2("obt_registros_temp_modo_temp", lst);
        }
        public DataTable ObtenerRegistrosTemperaturaGrafico()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();

            return dt = M.Listado("obt_registros_temp_modo_temp_grafico", lst);
        }

        public string Reg_Act_Entradas()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@msj", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@id", Midentrada));
            lst.Add(new clsParametros("@entrada", Mnumentrada));
            lst.Add(new clsParametros("@horno", Mtipohorno));
            lst.Add(new clsParametros("@descripcion", Mdescripcion));
            M.EjecutarSP("reg_entradas_mod_temp", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string ActualizarMinMaxTemp()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            lst.Add(new clsParametros("@tipoHorno", Mtipohorno2));
            lst.Add(new clsParametros("@min", Mmin));
            lst.Add(new clsParametros("@max", Mmax));
            
            M.EjecutarSP("actualizar_min_max_mod_temp", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

        public string Reg_Temperatura()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();

            lst.Add(new clsParametros("@e0", Me0));
            lst.Add(new clsParametros("@e1", Me1));
            lst.Add(new clsParametros("@e2", Me2));
            lst.Add(new clsParametros("@e3", Me3));
            lst.Add(new clsParametros("@e4", Me4));
            lst.Add(new clsParametros("@e5", Me5));
            lst.Add(new clsParametros("@e6", Me6));
            lst.Add(new clsParametros("@e7", Me7));
           
            M.EjecutarSP("reg_temperatura_mod_temp", ref lst);
            mensaje = lst[0].Valor.ToString();
            return mensaje;
        }

    }
}
