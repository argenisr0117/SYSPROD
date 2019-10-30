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
        FlowLayoutPanel[] flp;
        FlowLayoutPanel fl = new FlowLayoutPanel();
        List<string> Maq = new List<string>();
        clsMonitoreoMaq M = new clsMonitoreoMaq();
        string Maquina;
        string Produccion;
        string Horae;
        string Tiempo;
        bool create = false;
        bool estado;
        frmcInfoMaquinaParada form = new frmcInfoMaquinaParada();
        public frmcMonitoreoMaquinas()
        {
            InitializeComponent();
        }

        private void MonitoreoMaquinas()
        {
            try
            {
                //lbTitulo.Text = "";
                //lbTitulo.Text = "MONITOREO DE MÁQUINAS";
                if (!create)
                {
                    index = 0;
                    changeRow = 1;
                    changeColumn = 1;
                    //BorrarControlesDinamicos();

                    DataTable dt = new DataTable();
                    dt = M.ObtenerMaquinasActivas();
                    if (dt.Rows.Count > 0)
                    {
                        lbl = new Label[dt.Rows.Count * 4];
                        pic = new PictureBox[dt.Rows.Count];
                        flp = new FlowLayoutPanel[dt.Rows.Count];
                        for (int y = 0; y < dt.Rows.Count * 4; y++)
                        {
                            Label lb = new Label();
                            lbl[y] = lb;
                        }
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {

                            //lbl[i] = new Label();
                            pic[i] = new PictureBox();
                            flp[i] = new FlowLayoutPanel();
                            Maquina = dt.Rows[i][0].ToString(); //nombre maquina
                            Horae = dt.Rows[i][1].ToString(); //hora encendido
                            Tiempo = dt.Rows[i][2].ToString(); // tiempo trabajo
                            Produccion = dt.Rows[i][3].ToString(); //produccion
                                                                   //Turno= dt.Rows[i][5].ToString(); //turno
                            estado = Convert.ToBoolean(dt.Rows[i][4]); //estado de la maquina
                            flp[i].FlowDirection = FlowDirection.TopDown;
                            flp[i].Size = new Size(200, 150);
                            flp[i].AutoScroll = true;
                            pic[i].Tag = dt.Rows[i][5].ToString();
                            flp[i].Tag = dt.Rows[i][5].ToString();
                            Maq.Add(dt.Rows[i][5].ToString());
                            GenerarLabelsEstadoModulos(i, lbl, pic, flp);
                        }
                    }
                }
                else
                {
                    updateMachineValues();
                }
            }
            catch (Exception ex)
            {

            }

        }
        public void GenerarLabelsEstadoModulos(int i, Label[] lbl, PictureBox[] pic, FlowLayoutPanel[] flp)
        {
            try
            {
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
                pic[i].Cursor = Cursors.Hand;
                pic[i].Click += (s, e) =>
                {
                    EstadoMaqTimer.Stop();
                    form.Idmaquina = pic[i].Tag.ToString();
                    form.ShowDialog();
                    EstadoMaqTimer.Start();
                };
                //flp[i].Tag = "dyn";

                ////ASIGNAR  UBICACION A LAS FILAS ***FOTO****////
                //if (changeRow == 1)
                //{
                //    pic[i].Top = changeRow * 50;
                //}
                //else if (changeRow == 2)
                //{
                //    pic[i].Top = (changeRow * 60) + 35;
                //}

                //else if (changeRow == 3)
                //{
                //    pic[i].Top = (changeRow * 60) + 80;
                //}

                //else if (changeRow == 4)
                //{
                //    pic[i].Top = (changeRow * 60) + 125;
                //}

                //else if (changeRow == 5)
                //{
                //    pic[i].Top = (changeRow * 60) + 170;
                //}
                //else
                //{
                //    pic[i].Top = (changeRow * 60) + 210;
                //}
                //// FIN ASIGNAR UBICACION A LAS FILAS  ***FOTO****////


                //// FIN ASIGNAR UBICACION A LAS COLUMNAS  ***FOTO****////
                //if (changeColumn == 1)
                //{
                //    pic[i].Left = changeColumn * 60;
                //}
                //else if (changeColumn == 2)
                //{
                //    pic[i].Left = (changeColumn * 80) + 105;
                //}

                //else if (changeColumn == 3)
                //{
                //    pic[i].Left = (changeColumn * 105) + 135;
                //}

                //else if (changeColumn == 4)
                //{
                //    pic[i].Left = (changeColumn * 125) + 135;
                //}

                //else
                //{
                //    pic[i].Left = (changeColumn * 140) + 135;
                //}
                //// FIN ASIGNAR UBICACION A LAS COLUMNA  ***FOTO****////
                pic[i].Size = new Size(170, 40);
                pic[i].SizeMode = PictureBoxSizeMode.CenterImage;
                flp[i].Controls.Add(pic[i]);
                //flp[i].Controls.Add(lbl[0]);

                for (int x = 0; x < 4; x++)
                {
                    if (x == 0)
                    {
                        lbl[index].Text = Maquina;
                        lbl[index].Tag = "Maq";
                        //    lbl[index].Text = Maquina;
                        //    if (changeRow == 1)
                        //    {
                        //        lbl[index].Top = changeRow * 100;
                        //    }
                        //    else if (changeRow == 2)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 5;
                        //    }
                        //    else if (changeRow == 3)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 10;
                        //    }

                        //    else if (changeRow == 4)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 15;
                        //    }
                        //    else
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 20;
                        //    }
                    }
                    if (x == 1)
                    {
                        lbl[index].Text = "HORA ENCENDIDO: " + Horae;
                        lbl[index].Tag = "Henc";

                        //    lbl[index].Text = "HORA ENCENDIDO: " + Horae;

                        //    if (changeRow == 1)
                        //    {
                        //        lbl[index].Top = changeRow * 110;
                        //    }
                        //    else if (changeRow == 2)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 15;
                        //    }

                        //    else if (changeRow == 3)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 20;
                        //    }

                        //    else if (changeRow == 4)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 25;
                        //    }
                        //    else
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 30;
                        //    }

                    }
                    if (x == 2)
                    {
                        lbl[index].Text = "TIEMPO TRABAJADO: " + Tiempo + " MINS";
                        lbl[index].Tag = "Tiempo";

                        //    lbl[index].Text = "TIEMPO TRABAJADO: " + Tiempo + " MINS";
                        //    lbl[index].Top = changeRow * 120;
                        //    if (changeRow == 1)
                        //    {
                        //        lbl[index].Top = changeRow * 120;
                        //    }
                        //    else if (changeRow == 2)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 25;
                        //    }
                        //    else if (changeRow == 3)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 30;
                        //    }

                        //    else if (changeRow == 4)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 35;
                        //    }
                        //    else
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 40;
                        //    }
                    }
                    if (x == 3)
                    {
                        lbl[index].Text = "PRODUCCIÓN: " + Produccion + " ROLLOS";
                        lbl[index].Tag = "Prod";

                        //    lbl[index].Text = "PRODUCCIÓN: " + Produccion + " ROLLOS";
                        //    if (changeRow == 1)
                        //    {
                        //        lbl[index].Top = changeRow * 130;
                        //    }
                        //    else if (changeRow == 2)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 35;
                        //    }
                        //    else if (changeRow == 3)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 40;
                        //    }

                        //    else if (changeRow == 4)
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 45;
                        //    }
                        //    else
                        //    {
                        //        lbl[index].Top = (changeRow * 100) + 50;
                        //    }

                    }
                    lbl[index].AutoSize = true;
                    lbl[index].Font = new Font("Arial", 7, FontStyle.Bold);
                    //lbl[index].Tag = "dyn";
                    //if (changeColumn == 1)
                    //{
                    //    lbl[index].Left = changeColumn * 10;
                    //}
                    //else if (changeColumn == 2)
                    //{
                    //    lbl[index].Left = (changeColumn * 80) + 45;
                    //}

                    //else if (changeColumn == 3)
                    //{
                    //    lbl[index].Left = (changeColumn * 105) + 75;
                    //}

                    //else if (changeColumn == 4)
                    //{
                    //    lbl[index].Left = (changeColumn * 125) + 75;
                    //}

                    //else
                    //{
                    //    lbl[index].Left = (changeColumn * 140) + 75;
                    //}
                    flp[i].Controls.Add(lbl[index]);
                    index++;
                }
                flowLayoutPanel1.Controls.Add(flp[i]);

                create = true;


                //changeColumn++;
                //if (changeColumn == 6)
                //{
                //    changeRow++;
                //    changeColumn = 1;

                //}
            }
            catch (Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }
        }

        private void updateMachineValues()
        {
            try
            {

                DataTable dt = new DataTable();
                bool estado = false;
                dt = M.ObtenerMaquinasActivas();
               
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    foreach (DataRow o in dt.Select("ID_MAQUINA='"+ flowLayoutPanel1.Controls[x].Tag.ToString()+"'"))
                    {
                        fl =(FlowLayoutPanel) flowLayoutPanel1.Controls[x];

                        foreach(Label l in fl.Controls.OfType<Label>())
                        {
                            if (l.Tag.ToString() == "Tiempo")
                            {
                                l.Text= "TIEMPO TRABAJADO: " + o[2] + " MINS";
                            }
                            if (l.Tag.ToString() == "Prod")
                            {
                                l.Text = "PRODUCCIÓN: " + o[3]+ " ROLLOS";
                            }
                            if (l.Tag.ToString() == "Henc")
                            {
                                l.Text = "HORA ENCENDIDO: " + o[1];
                            }
                        }
                        estado = Convert.ToBoolean(o[4]);
                        foreach (PictureBox picBox in fl.Controls.OfType<PictureBox>())
                        {
                            if (estado)
                            {
                                picBox.Image = Properties.Resources.circle_ok;
                                toolTip1.SetToolTip(picBox, "ENCENDIDA");
                            }
                            else
                            {
                                picBox.Image = Properties.Resources.circle_error;
                                toolTip1.SetToolTip(picBox, "APAGADA");

                            }
                        }
                       
                        //picBox.Cursor = Cursors.Hand;
                        //picBox.Click += (s, e) =>
                        //{
                        //    EstadoMaqTimer.Stop();
                        //    form.Idmaquina = pic[i].Tag.ToString();
                        //    form.ShowDialog();
                        //    EstadoMaqTimer.Start();
                        //};
                        //flp[i].Tag = "dyn";
                    }
                }


            }
            catch (Exception ex)
            {
                //MessageBoxEx.Show(ex.Message);
            }
        }
        private void frmcMonitoreoMaquinas_Load(object sender, EventArgs e)
        {
            EstadoMaqTimer_Tick(e, e);
            panel1.Location = new Point(ClientSize.Width / 2 - panel1.Size.Width / 2, ClientSize.Height / 2 - panel1.ClientSize.Height / 2);
            lbTitulo.Location = new Point(ClientSize.Width / 2 - lbTitulo.Size.Width / 2, 18);
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
            try
            {
                //for (int m = 0; m < flowLayoutPanel1.Controls.Count; m++)
                //{
                //    if (flowLayoutPanel1.Controls[m].Tag.ToString() == "dyn")
                //    {
                //        flowLayoutPanel1.Controls[m].Dispose();
                //    }
                //}
                while (flowLayoutPanel1.Controls.Count > 0)
                {
                    if (flowLayoutPanel1.Controls[0].Tag.ToString() == "dyn")
                    {
                        flowLayoutPanel1.Controls[0].Controls.Remove(this);
                        flowLayoutPanel1.Controls[0].Dispose();
                        //flowLayoutPanel1.Controls.RemoveAt(0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
            //foreach (PictureBox picbox in flowLayoutPanel1.Controls.OfType<PictureBox>())
            //{
            //    if (picbox.Tag != null && picbox.Tag.ToString() == "dyn")
            //    {
            //        picbox.Dispose();
            //    }
            //}
            //foreach (Label lbl in flowLayoutPanel1.Controls.OfType<Label>())
            //{
            //    if (lbl.Tag != null && lbl.Tag.ToString() == "dyn")
            //    {
            //        lbl.Dispose();
            //    }
            //}
            //foreach (FlowLayoutPanel flowp in flowLayoutPanel1.Controls.OfType<FlowLayoutPanel>())
            //{
            //    if (flowp.Tag != null && flowp.Tag.ToString() == "dyn")
            //    {
            //        flowp.Dispose();
            //    }
            //}



        }
    }
}
