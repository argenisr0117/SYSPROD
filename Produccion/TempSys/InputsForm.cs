using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempSys
{
    public partial class InputsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public InputsForm()
        {
            InitializeComponent();
        }

        Global g = new Global();
        string Accion;
        int identrada;
        private void cerrar_btn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Close();
=======
            this.Close();
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
        }
        private void button1_Click(object sender, EventArgs e)
        {
            InputsForm obj = new InputsForm();
            obj.ShowDialog();
        }
       
        private void guardar_btn_Click(object sender, EventArgs e)
        {
            string msj = "";
            try
            {
                if (descripcion_txt.Text!= "")
                {
                    g.Descripcion = descripcion_txt.Text;
                    g.Numentrada = Convert.ToInt16(entrada_nud.Value);
                    g.TipoHorno = horno_cb.Text;
                    if (Accion == "REGISTRAR")
                    {
                        g.Identrada = 0;
                        msj=g.Reg_Act_Entradas();
                        if(msj=="1")
                        {
                            MessageBox.Show("Registrado con éxito","", MessageBoxButtons.OK);
                            LlenarGrid();
                            Limpiar();
                        }
                    }
                    else
                    {
                        g.Identrada = identrada;
                        msj = g.Reg_Act_Entradas();
                        if (msj == "1")
                        {
                            MessageBox.Show("Actualizado con éxito", "", MessageBoxButtons.OK);
                            LlenarGrid();
                            Limpiar();
                            Accion = "REGISTRAR";
                        }
                    }
                }
            }
<<<<<<< HEAD
            catch(Exception)
=======
            catch(Exception ex)
>>>>>>> bf1dba918529b9e8fe8f30955f8e6ec0e9182058
            {

            }
       
        }
        private void LlenarGrid()
        {
            try
            {
                DataTable dt;
                dt = g.ObtenerEntradas();
                entradas_dtgv.DataSource = null;
                entradas_dtgv.DataSource = dt;
                entradas_dtgv.Columns[0].Visible = false;
                //entradas_dtgv.Columns[4].Visible = false;
            }
            catch(Exception ex)
            {

            }
        }

        private void InputsForm_Load(object sender, EventArgs e)
        {
           
            LlenarTxtMinMax();
            Accion = "REGISTRAR";
            entrada_nud.Maximum = 7;
            entrada_nud.Minimum = 0;
            LlenarGrid();
        }

        public void LlenarTxtMinMax()
        {
            DataTable dt = new DataTable();
            g.TipoHorno2 = "ZINC";
            dt = g.ObtenerMinMaxTipoHorno2();
            if (dt.Rows.Count > 0)
            {
                Zmin_txt.Text = dt.Rows[0][0].ToString();
                Zmax_txt.Text = dt.Rows[0][1].ToString();
            }

            g.TipoHorno2 = "PLOMO";
            dt = g.ObtenerMinMaxTipoHorno2();
            if (dt.Rows.Count > 0)
            {
                Pmin_txt.Text = dt.Rows[0][0].ToString();
                Pmax_txt.Text = dt.Rows[0][1].ToString();
            }

        }

        private void barraSup_pn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void Limpiar()
        {
            descripcion_txt.Clear();
            horno_cb.SelectedIndex = -1;
            entrada_nud.Value = 0;
        }

        private void entradas_dtgv_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (entradas_dtgv.SelectedRows.Count > 0)
            {
                identrada = Convert.ToInt16(entradas_dtgv.CurrentRow.Cells[0].Value);
                descripcion_txt.Text = entradas_dtgv.CurrentRow.Cells[2].Value.ToString();
                entrada_nud.Value = Convert.ToInt16(entradas_dtgv.CurrentRow.Cells[1].Value);
                horno_cb.Text= entradas_dtgv.CurrentRow.Cells[3].Value.ToString();
                Accion = "ACTUALIZAR";

            }
        }

        private void guardarMinMax_btn_Click(object sender, EventArgs e)
        {
            if(Zmax_txt.Text != "" && Zmin_txt.Text != "" && Pmax_txt.Text != "" && Pmin_txt.Text != "")
            {
                g.TipoHorno2 = "ZINC";
                g.Max = Convert.ToInt32(Zmax_txt.Value);
                g.Min = Convert.ToInt32(Zmin_txt.Value);
                string msj = g.ActualizarMinMaxTemp();

                g.TipoHorno2 = "PLOMO";
                g.Max = Convert.ToInt32(Pmax_txt.Value);
                g.Min = Convert.ToInt32(Pmin_txt.Value);
                string msj1 = g.ActualizarMinMaxTemp();

                LlenarTxtMinMax();
                if(msj1 == "1" && msj == "1")
                {
                    MessageBox.Show("Actualizado con éxito", "", MessageBoxButtons.OK);
                }
                if(msj == "0")
                {
                    MessageBox.Show("No se pudo actualizar valores Min/Max Zinc", "", MessageBoxButtons.OK);
                }

                if (msj1 == "0")
                {
                    MessageBox.Show("No se pudo actualizar valores Min/Max Plomo", "", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("Campo de temperatura máximo y mínimo es necesario", "", MessageBoxButtons.OK);
            }
        }
    }
}
