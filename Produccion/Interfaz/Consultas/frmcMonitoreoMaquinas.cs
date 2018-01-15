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

namespace Interfaz.Consultas
{
    public partial class frmcMonitoreoMaquinas : MetroForm
    {

        int index = 0;
        int changeRow = 1;
        int changeColumn = 1;
        Label[] lbl;
        PictureBox[] pic;
        clsMonitoreoMaq M = new clsMonitoreoMaq();
        string Maquina;
        string Produccion;
        string Horae;
        string Tiempo;
        string Turno="";
        bool estado;
        public frmcMonitoreoMaquinas()
        {
            InitializeComponent();
        }

        private void MonitoreoMaquinas()
        {
            try
            {
                lbTitulo.Text = "";
                lbTitulo.Text = "MONITOREO DE MÁQUINAS";
                index = 0;
                changeRow = 1;
                changeColumn = 1;
                BorrarControlesDinamicos();
                DataTable dt = new DataTable();
                dt = M.ObtenerMaquinasActivas();
                if (dt.Rows.Count > 0)
                {
                    lbl = new Label[dt.Rows.Count * 4];
                    pic = new PictureBox[dt.Rows.Count];
                    for(int y = 0; y < dt.Rows.Count * 4; y++)
                    {
                        lbl[y] = new Label();
                    }
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        //lbl[i] = new Label();
                        pic[i] = new PictureBox();
                        Maquina=dt.Rows[i][0].ToString(); //nombre maquina
                        Horae= dt.Rows[i][1].ToString(); //hora encendido
                        Tiempo= dt.Rows[i][2].ToString(); // tiempo trabajo
                        Produccion= dt.Rows[i][3].ToString(); //produccion
                        //Turno= dt.Rows[i][5].ToString(); //turno
                        estado = Convert.ToBoolean(dt.Rows[i][4]); //estado de la maquina
                        GenerarLabelsEstadoModulos(i, lbl, pic);
                    }
                }
            }
            catch(Exception ex)
            {

            }
          
        }
        public void GenerarLabelsEstadoModulos(int i, Label[] lbl, PictureBox[] pic)
        {
            try { 
            if (estado)
            {
                pic[i].Image = Properties.Resources.circle_ok;
                toolTip1.SetToolTip(pic[i], "ENCENDIDA");
            }
            else
            {
                pic[i].Image = Properties.Resources.circle_error;
                toolTip1.SetToolTip(pic[i], "APAGADA");

            }

            pic[i].Tag = "dyn";


            ////ASIGNAR  UBICACION A LAS FILAS ***FOTO****////
            if (changeRow == 1)
            {
                pic[i].Top = changeRow * 50;
            }
            else if (changeRow == 2)
            {
                pic[i].Top = (changeRow * 60) + 35;
            }

            else if (changeRow == 3)
            {
                pic[i].Top = (changeRow * 60) + 80;
            }

            else if (changeRow == 4)
            {
                pic[i].Top = (changeRow * 60) + 125;
            }

            else if (changeRow == 5)
            {
                pic[i].Top = (changeRow * 60) + 170;
            }
            else
            {
                pic[i].Top = (changeRow * 60) + 210;
            }
            //// FIN ASIGNAR UBICACION A LAS FILAS  ***FOTO****////


            //// FIN ASIGNAR UBICACION A LAS COLUMNAS  ***FOTO****////
            if (changeColumn == 1)
            {
                pic[i].Left = changeColumn * 60;
            }
            else if (changeColumn == 2)
            {
                pic[i].Left = (changeColumn * 80) + 105;
            }

            else if (changeColumn == 3)
            {
                pic[i].Left = (changeColumn * 105) + 135;
            }

            else if (changeColumn == 4)
            {
                pic[i].Left = (changeColumn * 125) + 135;
            }

            else
            {
                pic[i].Left = (changeColumn * 140) + 135;
            }
            //// FIN ASIGNAR UBICACION A LAS COLUMNA  ***FOTO****////

            this.Controls.Add(pic[i]);

            for (int x = 0; x < 4; x++)
            {

                if (x == 0)
                {

                    lbl[index].Text =  Maquina;
                    if (changeRow == 1)
                    {
                        lbl[index].Top = changeRow * 100;
                    }
                    else if (changeRow == 2)
                    {
                        lbl[index].Top = (changeRow * 100) + 5;
                    }
                    else if (changeRow == 3)
                    {
                        lbl[index].Top = (changeRow * 100) + 10;
                    }

                    else if (changeRow == 4)
                    {
                        lbl[index].Top = (changeRow * 100) + 15;
                    }
                    else
                    {
                        lbl[index].Top = (changeRow * 100) + 20;
                    }

                }
                if (x == 1)
                {
                    lbl[index].Text = "HORA ENCENDIDO: " + Horae;

                    if (changeRow == 1)
                    {
                        lbl[index].Top = changeRow * 110;
                    }
                    else if (changeRow == 2)
                    {
                        lbl[index].Top = (changeRow * 100) + 15;
                    }

                    else if (changeRow == 3)
                    {
                        lbl[index].Top = (changeRow * 100) + 20;
                    }

                    else if (changeRow == 4)
                    {
                        lbl[index].Top = (changeRow * 100) + 25;
                    }
                    else
                    {
                        lbl[index].Top = (changeRow * 100) + 30;
                    }


                }
                if (x == 2)
                {
                    lbl[index].Text = "TIEMPO TRABAJADO: " + Tiempo + " MINS";
                    lbl[index].Top = changeRow * 120;
                    if (changeRow == 1)
                    {
                        lbl[index].Top = changeRow * 120;
                    }
                    else if (changeRow == 2)
                    {
                        lbl[index].Top = (changeRow * 100) + 25;
                    }
                    else if (changeRow == 3)
                    {
                        lbl[index].Top = (changeRow * 100) + 30;
                    }

                    else if (changeRow == 4)
                    {
                        lbl[index].Top = (changeRow * 100) + 35;
                    }
                    else
                    {
                        lbl[index].Top = (changeRow * 100) + 40;
                    }

                }
                if (x == 3)
                {
                    lbl[index].Text = "PRODUCCIÓN: " + Produccion + " ROLLOS";
                    if (changeRow == 1)
                    {
                        lbl[index].Top = changeRow * 130;
                    }
                    else if (changeRow == 2)
                    {
                        lbl[index].Top = (changeRow * 100) + 35;
                    }
                    else if (changeRow == 3)
                    {
                        lbl[index].Top = (changeRow * 100) + 40;
                    }

                    else if (changeRow == 4)
                    {
                        lbl[index].Top = (changeRow * 100) + 45;
                    }
                    else
                    {
                        lbl[index].Top = (changeRow * 100) + 50;
                    }

                }
                lbl[index].AutoSize = true;
                lbl[index].Font = new Font("Arial", 7, FontStyle.Bold);
                lbl[index].Tag = "dyn";
                if (changeColumn == 1)
                {
                    lbl[index].Left = changeColumn * 10;
                }
                else if (changeColumn == 2)
                {
                    lbl[index].Left = (changeColumn * 80) + 45;
                }

                else if (changeColumn == 3)
                {
                    lbl[index].Left = (changeColumn * 105) + 75;
                }

                else if (changeColumn == 4)
                {
                    lbl[index].Left = (changeColumn * 125) + 75;
                }

                else
                {
                    lbl[index].Left = (changeColumn * 140) + 75;
                }

                this.Controls.Add(lbl[index]);
                index++;
            }




            changeColumn++;
            if (changeColumn == 6)
            {
                changeRow++;
                changeColumn = 1;

            }
        }
             catch (Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }
        }

        private void frmcMonitoreoMaquinas_Load(object sender, EventArgs e)
        {
            EstadoMaqTimer.Start();
        }

        private void EstadoMaqTimer_Tick(object sender, EventArgs e)
        {
            EstadoMaqTimer.Stop();
            MonitoreoMaquinas();
            EstadoMaqTimer.Start();
        }
        public void BorrarControlesDinamicos()
        {
            foreach (Label label in Controls.OfType<Label>())
            {
                if (label.Tag != null && label.Tag.ToString() == "dyn")
                {
                    label.Dispose();
                }
            }

            foreach (PictureBox picbox in Controls.OfType<PictureBox>())
            {
                if (picbox.Tag != null && picbox.Tag.ToString() == "dyn")
                {
                    picbox.Dispose();
                }
            }
        }
    }
}
