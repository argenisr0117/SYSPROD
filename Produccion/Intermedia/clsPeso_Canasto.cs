using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;

namespace Intermedia
{
   public class clsPeso_Canasto
    {
        private clsManejador M = new clsManejador();

        Int32 Midpeso;
        double Mpeso;
        Boolean Mestado;
        string Mcampo = "ID_PESO";
        string Mtabla = "PESO_CANASTO";

        public Int32 Idpeso
        {
            get { return Midpeso; }
            set { Midpeso = value; }
        }

        public double Peso
        {
            get { return Mpeso; }
            set { Mpeso = value; }
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
            return dt = M.Listado("listado_peso_canasto", lst);

        }

        public string ActivarPeso()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@id", Midpeso));
            lst.Add(new clsParametros("@valor", Mestado));
            lst.Add(new clsParametros("@table", Mtabla));
            lst.Add(new clsParametros("@campo", Mcampo));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actdes_entidades", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public string RegistrarPeso()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@peso", Mpeso));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_peso_canasto", ref lst);
            mensaje = lst[1].Valor.ToString();
            return mensaje;
        }

        public string ActualizarPeso()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idpeso", Midpeso));
            lst.Add(new clsParametros("@peso", Mpeso));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_peso_canasto", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }
    }
}
