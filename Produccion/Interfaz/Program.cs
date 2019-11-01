using Interfaz.Consultas;
using Interfaz.Registros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    static class Program
    {
        public static string Almacen;
        public static string FechaS;
        public static int Filtrar; //variable para filtrar prod tref - galv
        public static int Editar; //variable para editar prod tref - galv
        public static int Idpuerto;
        public static int Idusuario;
        private static int valor3;
        public static int Evento;
        public static int Idorden;
        public static int Valor;
        public static int Valor2;
        public static int Idpacking;
        public static int Idrptcald;
        public static string CodigoP;
        public static string Contenedor;
        public static string Empresa;
        public static int Tamano;
        public static string Empleado;
        public static string DescripcionP;
        public static string UnidadP;
        public static string Pedido;
<<<<<<< HEAD
        public static int IdPedido;
        public static bool VerLabel;
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        public static string CategoriaP;
        public static double CalibreP;
        public static DateTime Fechai;
        public static DateTime Fechaf;
        public static DateTime Fechaft;
        public static string Supervisor;
        public static string Ayudante;
        public static string Maquina;
        public static string Colada;
        public static string Pesozinc;
        public static string Pesoszinc;
        public static string Muestra2;
        public static string Sae;
        public static string Resistenia;
        public static int Idprueba;
        public static int Idtipoorden;
        public static string Cliente1;
        public static string Dpto;
        public static string Orden;
        public static int Cliente;
        public static string Producto;
        public static int Cantidad;
        public static Boolean proddiaria;
        public static Boolean prodtref;
        public static Boolean prodindm;
        public static Boolean prodgalv;
        public static Boolean reggen;
        public static Boolean congen;
        public static Boolean ediindm;
        public static Boolean eliindm;
        public static Boolean mosindm;
        public static Boolean expindm;
        public static Boolean fdesindm;
        public static Boolean fhasindm;
        public static Boolean editref;
        public static Boolean elitref;
        public static Boolean mostref;
        public static Boolean filtref;
        public static Boolean exptref;
        public static Boolean fdestref;
        public static Boolean fhastref;
        public static Boolean reimtref;
        public static Boolean acucong;
        public static Boolean inccong;
        public static Boolean empcong;
        public static Boolean ciecong;
        public static Boolean cieacong;
        public static Boolean filcong;
        public static Boolean ordenprod;
        public static Boolean controlcald;
        public static Boolean vcontrolcald;
        public static Boolean vccfecha;
        public static Boolean edigalv;
        public static Boolean eligalv;
        public static Boolean mosgalv;
        public static Boolean filgalv;
        public static Boolean expgalv;
        public static Boolean fdesgalv;
        public static Boolean fhasgalv;
        public static Boolean reimgalv;
        public static Boolean almintermedios;
        public static Boolean almterminados;
        public static Boolean almlg;
        public static Boolean montemp;
        public static Boolean maqpar;
        public static Boolean monmaq;
        public static Boolean reghora;
<<<<<<< HEAD

        public static int Valor3
        {
            get
            {
                return valor3;
            }

            set
            {
                valor3 = value;
            }
        }

=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-DO");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Registros.frmPonche());
            Application.Run(new Login());
<<<<<<< HEAD
            //Application.Run(new frmRecepcionAlambron());
=======
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            //Application.Run(new Registros.frmAsignarTurno());
            //Application.Run(new Registros.frmAttControl());
        }
    }
}
