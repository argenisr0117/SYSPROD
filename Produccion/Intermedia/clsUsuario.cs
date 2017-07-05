using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Intermedia
{
   public class clsUsuario
    {
        private clsManejador M = new clsManejador();

        int Midusuario;
        string Middpto;
        string Musuario;
        string Mterminal;
        string Mlogin;
        string Mclave;
        Boolean Mestado;
        Boolean Mproddiaria;
        Boolean Mprodtref;
        Boolean Mprodindm;
        Boolean Mprodgalv;
        Boolean Mreggen;
        Boolean Mcongen;
        Boolean Mediindm;
        Boolean Meliindm;
        Boolean Mmosindm;
        Boolean Mexpindm;
        Boolean Mfdesindm;
        Boolean Mfhasindm;
        Boolean Meditref;
        Boolean Melitref;
        Boolean Mmostref;
        Boolean Mfiltref;
        Boolean Mexptref;
        Boolean Mfdestref;
        Boolean Mfhastref;
        Boolean Mreimtref;
        Boolean Macucong;
        Boolean Minccong;
        Boolean Mempcong;
        Boolean Mciecong;
        Boolean Mcieacong;
        Boolean Mfilcong;


        public int Idusuario
        {
            get { return Midusuario; }
            set { Midusuario = value; }
        }
        public string Iddpto
        {
            get { return Middpto; }
            set { Middpto = value; }
        }

        public string Usuario
        {
            get { return Musuario; }
            set { Musuario = value; }
        }
        public string Terminal
        {
            get { return Mterminal; }
            set { Mterminal = value; }
        }
        public string Clave
        {
            get { return Mclave; }
            set { Mclave = value; }
        }
        public string Login
        {
            get { return Mlogin; }
            set { Mlogin = value; }
        }

        public Boolean Estado
        {
            get { return Mestado; }
            set { Mestado = value; }
        }
        public Boolean Fhasindm
        {
            get { return Mfhasindm; }
            set { Mfhasindm = value; }
        }
        public Boolean Fdesindm
        {
            get { return Mfdesindm; }
            set { Mfdesindm = value; }
        }
        public Boolean Congen
        {
            get { return Mcongen; }
            set { Mcongen = value; }
        }
        public Boolean Reggen
        {
            get { return Mreggen; }
            set { Mreggen = value; }
        }
        public Boolean Proddiaria
        {
            get { return Mproddiaria; }
            set { Mproddiaria = value; }
        }
        public Boolean Prodindm
        {
            get { return Mprodindm; }
            set { Mprodindm = value; }
        }
        public Boolean Prodtref
        {
            get { return Mprodtref; }
            set { Mprodtref = value; }
        }
        public Boolean Prodgalv
        {
            get { return Mprodgalv; }
            set { Mprodgalv = value; }
        }
        public Boolean Eliindm
        {
            get { return Meliindm; }
            set { Meliindm = value; }
        }
        public Boolean Ediindm
        {
            get { return Mediindm; }
            set { Mediindm = value; }
        }
        public Boolean Mosindm
        {
            get { return Mmosindm; }
            set { Mmosindm = value; }
        }
        public Boolean Expindm
        {
            get { return Mexpindm; }
            set { Mexpindm = value; }
        }
        public Boolean Editref
        {
            get { return Meditref; }
            set { Meditref = value; }
        }
        public Boolean Elitref
        {
            get { return Melitref; }
            set { Melitref = value; }
        }
        public Boolean Mostref
        {
            get { return Mmostref; }
            set { Mmostref = value; }
        }
        public Boolean Exptref
        {
            get { return Mexptref; }
            set { Mexptref = value; }
        }
        public Boolean Filtref
        {
            get { return Mfiltref; }
            set { Mfiltref = value; }
        }
        public Boolean Fhastref
        {
            get { return Mfhastref; }
            set { Mfhastref = value; }
        }
        public Boolean Fdestref
        {
            get { return Mfdestref; }
            set { Mfdestref = value; }
        }

        public Boolean Reimtref
        {
            get { return Mreimtref; }
            set { Mreimtref = value; }
        }
        public Boolean Acucong
        {
            get { return Macucong; }
            set { Macucong = value; }
        }
        public Boolean Inccong
        {
            get { return Minccong; }
            set { Minccong = value; }
        }
        public Boolean Empcong
        {
            get { return Mempcong; }
            set { Mempcong = value; }
        }
        public Boolean Ciecong
        {
            get { return Mciecong; }
            set { Mciecong = value; }
        }
        public Boolean Cieacong
        {
            get { return Mcieacong; }
            set { Mcieacong = value; }
        }
        public Boolean Filcong
        {
            get { return Mfilcong; }
            set { Mfilcong = value; }
        }


        public string RegistrarUsuario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@iddpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("registrar_usuario", ref lst);
            mensaje = lst[3].Valor.ToString();
            return mensaje;
        }
        public int RegistrarActPermisos()
        {
            int mensaje = 2;
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@proddiaria", Mproddiaria));
            lst.Add(new clsParametros("@reggen", Mreggen));
            lst.Add(new clsParametros("@congen", Mcongen));
            lst.Add(new clsParametros("@prodtref", Mprodtref));
            lst.Add(new clsParametros("@prodgalv", Mprodgalv));
            lst.Add(new clsParametros("@prodindm", Mprodindm));
            lst.Add(new clsParametros("@ediindm", Mediindm));
            lst.Add(new clsParametros("@eliindm", Meliindm));
            lst.Add(new clsParametros("@mosindm", Mmosindm));
            lst.Add(new clsParametros("@expindm", Mexpindm));
            lst.Add(new clsParametros("@fdesindm", Mfdesindm));
            lst.Add(new clsParametros("@fhasindm", Mfhasindm));
            lst.Add(new clsParametros("@editref", Meditref));
            lst.Add(new clsParametros("@elitref", Melitref));
            lst.Add(new clsParametros("@mostref", Mmostref));
            lst.Add(new clsParametros("@filtref", Mfiltref));
            lst.Add(new clsParametros("@exptref", Mexptref));
            lst.Add(new clsParametros("@fdestref", Mfdestref));
            lst.Add(new clsParametros("@fhastref", Mfhastref));
            lst.Add(new clsParametros("@reimtref", Mreimtref));
            lst.Add(new clsParametros("@acucong", Macucong));
            lst.Add(new clsParametros("@inccong", Minccong));
            lst.Add(new clsParametros("@empcong", Mempcong));
            lst.Add(new clsParametros("@ciecong", Mciecong));
            lst.Add(new clsParametros("@cieacong", Mcieacong));
            lst.Add(new clsParametros("@filcong",Mfilcong));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.Int, ParameterDirection.Output, 8));
            M.EjecutarSP("registrar_act_permisos", ref lst);
            mensaje =Convert.ToInt32(lst[27].Valor);
            return mensaje;
        }
        public string VerificarLogin()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("verificar_login", ref lst);
            mensaje = lst[2].Valor.ToString();
            return mensaje;
        }

        public string ActualizarUsuario()
        {
            string mensaje = "";
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@usuario", Musuario));
            lst.Add(new clsParametros("@clave", Mclave));
            lst.Add(new clsParametros("@dpto", Middpto));
            lst.Add(new clsParametros("@mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
            M.EjecutarSP("actualizar_usuario", ref lst);
            mensaje = lst[4].Valor.ToString();
            return mensaje;
        }
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            return dt = M.Listado("listado_usuario", lst);

        }

        public DataTable ObtenerPermisos()
        {
            DataTable dt = new DataTable();
            List<clsParametros> lst = new List<clsParametros>();
            lst.Add(new clsParametros("@idusuario", Midusuario));
            lst.Add(new clsParametros("@usuario", Musuario));
            return dt = M.Listado("obtener_permisos", lst);

        }
    }
}
