using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;

namespace Interfaz.Registros
{
    public partial class frmInventarioPuas : MetroForm
    {
        public frmInventarioPuas()
        {
            InitializeComponent();
        }
        clsProducto P = new clsProducto();
        clsEmpleado E = new clsEmpleado();
        clsMaquina M = new clsMaquina();
        clsProduccionIndM Pi = new clsProduccionIndM();

        private void ComboP()
        {
            try
            {
                cmbProducto.DataSource = P.Listado_Productos_Dpto(2);
                cmbProducto.DisplayMember = "DESCRIPCION";
                cmbProducto.ValueMember = "CODIGO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        private void ComboO()
        {
            try
            {
                cmbOperador.DataSource = E.Listar(true);
                cmbOperador.DisplayMember = "NOMBRE";
                cmbOperador.ValueMember = "ID_EMPLEADO";

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmInventarioPuas_Load(object sender, EventArgs e)
        {
            ComboO();
            ComboP();
            LlenarCampos();
        }
        private void LlenarCampos()
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            try
            {
              
               
                txtCantdiadR.Text = Program.Cantidad.ToString();
                cmbOperador.SelectedValue= Program.Empleado;
                cmbProducto.SelectedValue = Program.Producto;
                M.Idproducto = Program.Producto;
                dt1 = M.ObtenerProductoMaquina();
                Pi.Idempleado = cmbOperador.SelectedValue.ToString();
                Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                dt = Pi.ObtenerPuasOperador();
                if(dt1.Rows.Count==5)
                {
                    Mostrar();
                    txtDisp1.Text = dt.Rows[0][1].ToString();
                    txtDisp2.Text = dt.Rows[1][1].ToString();
                    txtDisp3.Text = dt.Rows[2][1].ToString();
                    txtDisp4.Text = dt.Rows[3][1].ToString();
                    txtDisp5.Text = dt.Rows[4][1].ToString();
                    lbMaq1.Text= dt.Rows[0][2].ToString();
                    lbMaq2.Text = dt.Rows[1][2].ToString();
                    lbMaq3.Text = dt.Rows[2][2].ToString();
                    lbMaq4.Text = dt.Rows[3][2].ToString();
                    lbMaq5.Text = dt.Rows[4][2].ToString();
                    lbMaq11.Text = dt.Rows[0][2].ToString();
                    lbMaq22.Text = dt.Rows[1][2].ToString();
                    lbMaq33.Text = dt.Rows[2][2].ToString();
                    lbMaq44.Text = dt.Rows[3][2].ToString();
                    lbMaq55.Text = dt.Rows[4][2].ToString();

                }
                else if(dt1.Rows.Count== 2)
                {
                    Mostrar2();
                    txtDisp1.Text = dt.Rows[0][1].ToString();
                    txtDisp2.Text = dt.Rows[1][1].ToString();
                    lbMaq1.Text = dt.Rows[0][2].ToString();
                    lbMaq2.Text = dt.Rows[1][2].ToString();
                    lbMaq11.Text = dt.Rows[0][2].ToString();
                    lbMaq22.Text = dt.Rows[1][2].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void Mostrar()
        {
            lbMaq1.Visible = true;
            lbMaq2.Visible = true;
            lbMaq3.Visible = true;
            lbMaq4.Visible = true;
            lbMaq5.Visible = true;
            txtCantidad1.Visible = true;
            txtCantidad2.Visible = true;
            txtCantidad3.Visible = true;
            txtCantidad4.Visible = true;
            txtCantidad5.Visible = true;
            lbMaq11.Visible = true;
            lbMaq22.Visible = true;
            lbMaq33.Visible = true;
            lbMaq44.Visible = true;
            lbMaq55.Visible = true;
            txtDisp1.Visible = true;
            txtDisp2.Visible = true;
            txtDisp3.Visible = true;
            txtDisp4.Visible = true;
            txtDisp5.Visible = true;
        }
        private void Mostrar2()
        {
            lbMaq1.Visible = true;
            lbMaq2.Visible = true;
            txtCantidad1.Visible = true;
            txtCantidad2.Visible = true;
            txtDisp1.Visible = true;
            txtDisp2.Visible = true;
            lbMaq11.Visible = true;
            lbMaq22.Visible = true;
        }

        private void btnRegistrar2_Click(object sender, EventArgs e)
        {
            int disp;
            int cant;
            int total = 0;
            string mensaje = "";
            int[] array = new int[5];
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            M.Idproducto = cmbProducto.SelectedValue.ToString();
            dt1 = M.ObtenerProductoMaquina();
            Pi.Idcliente = Program.Cliente;
            Pi.Idorden = Program.Idorden;
            try
            {
                if (dt1.Rows.Count == 5)
                {
                    if (!string.IsNullOrEmpty(txtCantidad1.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad1.Text);
                        disp = Convert.ToInt32(txtDisp1.Text);
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.1 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad1.Text = "0";
                            txtCantidad1.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad1.Text = "0";
                    }
                    if (!string.IsNullOrEmpty(txtCantidad2.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad2.Text);
                        disp = Convert.ToInt32(txtDisp2.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.2 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad2.Text = "0";
                            txtCantidad2.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad2.Text = "0";
                    }
                    if (!string.IsNullOrEmpty(txtCantidad3.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad3.Text);
                        disp = Convert.ToInt32(txtDisp3.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.3 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad3.Text = "0";
                            txtCantidad3.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad3.Text = "0";
                    }
                    if (!string.IsNullOrEmpty(txtCantidad4.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad4.Text);
                        disp = Convert.ToInt32(txtDisp4.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.4 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad4.Text = "0";
                            txtCantidad4.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad4.Text = "0";
                    }
                    if (!string.IsNullOrEmpty(txtCantidad5.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad5.Text);
                        disp = Convert.ToInt32(txtDisp5.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.5 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad5.Text = "0";
                            txtCantidad5.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }

                    }
                    else
                    {
                        txtCantidad5.Text = "0";
                    }
                    if (total > Program.Cantidad || total < Program.Cantidad)
                    {
                        MessageBoxEx.Show("Verifique las cantidades digitadas!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidad1.Focus();
                        txtCantidadD.Text = total.ToString();
                        txtCantidadF.Text = Convert.ToInt32((Program.Cantidad - total)).ToString();
                    }
                    else
                    {
                        txtCantidadD.Text = total.ToString();
                        txtCantidadF.Text = Convert.ToInt32((Program.Cantidad - total)).ToString();
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                        array[1] = Convert.ToInt32(txtCantidad2.Text);
                        array[2] = Convert.ToInt32(txtCantidad3.Text);
                        array[3] = Convert.ToInt32(txtCantidad4.Text);
                        array[4] = Convert.ToInt32(txtCantidad5.Text);

                        for (int x = 0; x < 5; x++)
                        {
                            dt = Pi.ObtenerPuasOperador();
                            Pi.Supervisor = Program.Supervisor;
                            Pi.Operador = cmbOperador.SelectedValue.ToString();
                            Pi.Ayudante = Program.Ayudante;
                            Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                            Pi.Idmaquina = dt.Rows[x][0].ToString();
                            Pi.Cantidad = Convert.ToDecimal(array[x]);
                            Pi.Cantidad1 = Convert.ToInt32(array[x]);
                            Pi.ActualizarInvPuas();
                            mensaje = Pi.RegistrarProduccionIndM();
                        }

                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.Evento = 4;
                        Close();
                    }


                }
                else if (dt1.Rows.Count == 2)
                {
                    total = 0;
                    if (!string.IsNullOrEmpty(txtCantidad1.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad1.Text);
                        disp = Convert.ToInt32(txtDisp1.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.1 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad1.Text = "0";
                            txtCantidad1.Focus();
                            //txtCantidadD.Text = total.ToString();
                            //txtCantidadF.Text = Convert.ToInt32((Program.Cantidad - total)).ToString();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad1.Text = "0";
                    }
                    if (!string.IsNullOrEmpty(txtCantidad2.Text))
                    {
                        cant = Convert.ToInt32(txtCantidad2.Text);
                        disp = Convert.ToInt32(txtDisp2.Text);
                        //total = total + cant;
                        if (cant > disp)
                        {
                            //MessageBoxEx.Show("Cantidad en MAQ.2 excede inventario!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCantidad2.Text = "0";
                            txtCantidad2.Focus();
                        }
                        else
                        {
                            total = total + cant;

                        }
                    }
                    else
                    {
                        txtCantidad2.Text = "0";
                    }

                    if (total > Program.Cantidad || total < Program.Cantidad)
                    {
                        MessageBoxEx.Show("Verifique las cantidades digitadas!", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidad1.Focus();
                    }
                    else
                    {
                        txtCantidadD.Text = total.ToString();
                        txtCantidadF.Text = Convert.ToInt32((Program.Cantidad - total)).ToString();
                        array[0] = Convert.ToInt32(txtCantidad1.Text);
                        array[1] = Convert.ToInt32(txtCantidad2.Text);

                        for (int x = 0; x < 2; x++)
                        {
                            dt = Pi.ObtenerPuasOperador();
                            Pi.Supervisor = Program.Supervisor;
                            Pi.Operador = cmbOperador.SelectedValue.ToString();
                            Pi.Ayudante = Program.Ayudante;
                            Pi.Idproducto = cmbProducto.SelectedValue.ToString();
                            Pi.Idmaquina = dt.Rows[x][0].ToString();
                            Pi.Cantidad = Convert.ToDecimal(array[x]);
                            Pi.Cantidad1 = Convert.ToInt32(array[x]);
                            Pi.ActualizarInvPuas();
                            mensaje = Pi.RegistrarProduccionIndM();
                        }

                        MessageBoxEx.Show(mensaje, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.Evento = 4;
                        Close();
                    }
                }
                dt1.Rows.Clear();
                dt.Rows.Clear();
            }
            catch(Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
