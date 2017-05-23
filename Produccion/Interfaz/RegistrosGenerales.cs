using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;

namespace Interfaz
{
    public partial class RegistrosGenerales : MetroForm
    {
        public RegistrosGenerales()
        {
            InitializeComponent();
        }

        private void ObtenerHora()
        {
            lbfecha.Text = DateTime.Now.ToLongDateString();
            lbhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ObtenerHora();
        }

        private void RegistrosGenerales_Load(object sender, EventArgs e)
        {
            ObtenerHora();
            timer1.Start();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            Registros.frmCargo obj = new Registros.frmCargo();
            obj.ShowDialog();
        }

        private void btndestino_Click(object sender, EventArgs e)
        {
            Registros.frmDestino obj = new Registros.frmDestino();
            obj.ShowDialog();
        }

        private void btndepartamento_Click(object sender, EventArgs e)
        {
            Registros.frmDepartamento obj = new Registros.frmDepartamento();
            obj.ShowDialog();
        }

        private void btnunidad_Click(object sender, EventArgs e)
        {
            Registros.frmUnidad obj = new Registros.frmUnidad();
            obj.ShowDialog();
        }

        private void btnmaquina_Click(object sender, EventArgs e)
        {
            Registros.frmMaquina obj = new Registros.frmMaquina();
            obj.ShowDialog();
        }

        private void btnturno_Click(object sender, EventArgs e)
        {
            Registros.frmTurno obj = new Registros.frmTurno();
            obj.ShowDialog();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            Registros.frmEmpleado obj = new Registros.frmEmpleado();
            obj.ShowDialog();
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            Registros.frmCategoria obj = new Registros.frmCategoria();
            obj.ShowDialog();
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            Registros.frmProducto obj = new Registros.frmProducto();
            obj.ShowDialog();
        }

        private void btnincentivos_Click(object sender, EventArgs e)
        {
            Registros.frmIncentivos obj = new Registros.frmIncentivos();
            obj.ShowDialog();
        }

        private void btnempresas_Click(object sender, EventArgs e)
        {
            Registros.frmEmpresa obj = new Registros.frmEmpresa();
            obj.ShowDialog();
        }

        private void btnColadas_Click(object sender, EventArgs e)
        {
            Registros.frmColada obj = new Registros.frmColada();
            obj.ShowDialog();
        }

        private void btnpesocanastos_Click(object sender, EventArgs e)
        {
            Registros.frmPesocanasto obj = new Registros.frmPesocanasto();
            obj.ShowDialog();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Registros.frmCliente obj = new Registros.frmCliente();
            obj.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Registros.frmUsuario obj = new Registros.frmUsuario();
            obj.ShowDialog();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Registros.frmMaquinaPuas obj = new Registros.frmMaquinaPuas();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registros.frmEditarInvPuas obj = new Registros.frmEditarInvPuas();
            obj.ShowDialog();
        }
    }
}
