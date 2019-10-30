using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Intermedia;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Interfaz.Registros
{
    public partial class frmRecepcionAlambron : MetroForm
    {
        public frmRecepcionAlambron()
        {
            InitializeComponent();
        }
        clsRecepAlambron R = new clsRecepAlambron();
        clsOrdenProduccion O = new clsOrdenProduccion();
        clsControlAlmacen Ca = new clsControlAlmacen();
        clsProduccionGalv PG = new clsProduccionGalv();
        DataTable dt = new DataTable();
        int IdPedido = 0;
        int TipoReporte = 0;
        int IdRollo = 0;
        int idSalida = 0;
        int idRecepcion = 0;

        #region MethodsCombos
        private void ComboChofer()
        {
            try
            {
                cmbChofer.DataSource = R.ListadoChofer();
                cmbChofer.DisplayMember = "NOMBRE";
                cmbChofer.ValueMember = "ID_CHOFER";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboAlmacen()
        {
            try
            {
                cmbAlmacen.DataSource = R.ListadoAlmacen();
                cmbAlmacen.DisplayMember = "DESCRIPCION";
                cmbAlmacen.ValueMember = "ID_ALMACEN";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboCliente()
        {
            try
            {
                cmbCliente.DataSource = R.ListadoCliente();
                cmbCliente.DisplayMember = "DESCRIPCION";
                cmbCliente.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboCliente2()
        {
            try
            {
                cmbCliente2.DataSource = R.ListadoCliente();
                cmbCliente2.DisplayMember = "DESCRIPCION";
                cmbCliente2.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboClienteSalida()
        {
            try
            {
                cmbClienteSalida.DataSource = R.ListadoCliente();
                cmbClienteSalida.DisplayMember = "DESCRIPCION";
                cmbClienteSalida.ValueMember = "ID_CLIENTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void ComboFabricante()
        {
            try
            {
                cmbFabricante.DataSource = R.ListadoFabricante();
                cmbFabricante.DisplayMember = "NOMBRE";
                cmbFabricante.ValueMember = "ID_FABRICANTE";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }
        private void ComboU()
        {
            try
            {
                cb_Uso.DataSource = O.ListadoUsoAlambre(3);
                cb_Uso.DisplayMember = "DESCRIPCION";
                cb_Uso.ValueMember = "ID_USO";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
        #endregion

        #region Methods
        private void GenerarNumRecepcion()
        {
            try
            {
                txtRecepcion.Text = string.Empty;
                txtRecepcion.Text = R.GenerarNumRecepion();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }

        }

        private void LlenarGridRecepcion()
        {
            DataTable dt = R.ListadoRecepcion();
            dtgvRecepcion.DataSource = null;
            dtgvRecepcion.DataSource = dt;
            dtgvRecepcion.ClearSelection();
            dtgvRecepcion.Columns[0].Visible = false;
            dtgvRecepcion.Columns[3].Visible = false;

        }
        private void LlenarGridRollos()
        {
            R.Impreso = chImpreso.Checked;
            R.Eliminado = chEliminados.Checked;
            R.Top = Convert.ToInt16(cmbTop.SelectedItem);
            R.Busqueda = txtBusqueda.Text.Trim();
            DataTable dt = R.ListadoRollosAlambron();
            dtgvRollosAlambron.DataSource = null;
            dtgvRollosAlambron.DataSource = dt;
            dtgvRollosAlambron.ClearSelection();
            //dtgvRecepcion.Columns[0].Visible = false;
            //dtgvRecepcion.Columns[3].Visible = false;

        }
        private void ObtenerUltimaRecepcion()
        {
            DataTable dt = R.ObtenerUltimaRecepcion();
            txtRecepcion2.Text = string.Empty;
            txtRecepcion2.Text = dt.Rows[0][1].ToString();
            idRecepcion = Convert.ToInt32(dt.Rows[0][0]);
        }
        #endregion

        private void frmRecepcionAlambron_Load(object sender, EventArgs e)
        {
            try
            {
                chImpreso.Checked = false;
                chEliminados.Checked = false;
                ComboChofer();
                ComboAlmacen();
                ComboCliente();
                ComboCliente2();
                ComboClienteSalida();
                ComboFabricante();
                cmbChofer.SelectedIndex = 0;
                cmbUnidadMedida.SelectedIndex = 0;
                Program.Evento = 0;
                Program.Valor3 = 0;
                Program.IdPedido = 0;
                GenerarNumRecepcion();
                LlenarGridRecepcion();
                ObtenerUltimaRecepcion();
                cmbAlmacen.Text = "ALAMBRON";
                cmbCliente.Text = "ACERO DEL CIBAO, SRL";
                cmbClienteSalida.Text = "ACERO DEL CIBAO, SRL";
                cmbFabricante.SelectedIndex = 1;
                cmbTop.SelectedIndex = 1;
                LlenarGridRollos();
                rdPedido_CheckedChanged(e, e);
                ComboU();
                IdRollo = R.ObtenerUltimoIdRollo();
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtLeerRollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)13)
                {
                    e.Handled = true;
                    string[] datos = txtLeerRollo.Text.Split(';');

                    switch (cmbFabricante.Text)
                    {

                        case "MINMETALS":
                            txtRollo.Text = datos[0].Substring(8, 5);
                            txtColada.Text = datos[0].Substring(0, 8) + "E";
                            txtSae.Text = datos[1].Substring(3, 4);
                            txtDiametro.Text = datos[2];
                            txtPeso.Text = datos[3];
                            txtLeerRollo.Text = string.Empty;
                            break;
                        case "BENXI":
                            txtRollo.Text = datos[7].Substring(1, 3);
                            txtColada.Text = datos[3].Substring(1, 9);
                            txtSae.Text = datos[6].Substring(4, 4);
                            txtDiametro.Text = datos[5];
                            txtPeso.Text = datos[8].Substring(1, 4);
                            txtLeerRollo.Text = string.Empty;
                            break;
                        case "ACINDAR":
                            datos = txtLeerRollo.Text.Split(';');
                            //txtRollo.Text = datos[7].Substring(1, 3);
                            txtColada.Text = datos[0].Substring(17, 5);
                            //txtSae.Text = datos[6].Substring(4, 4);
                            //txtDiametro.Text = datos[5];
                            txtPeso.Text = datos[0].Substring(10, 4);
                            txtLeerRollo.Text = string.Empty;
                            break;
                        default:
                            break;
                    }
                    datos = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            cmbUnidadMedida_SelectedIndexChanged(e, e);
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            frmPedido obj = new frmPedido();
            Program.VerLabel = true;
            obj.ShowDialog();
            if (string.IsNullOrEmpty(Program.Pedido))
            {
                return;
            }
            else
            {
                txtPedido.Text = Program.Pedido;
                IdPedido = Program.IdPedido;
            }
            Program.Evento = 0;
            Program.Pedido = "";
        }

        private void txtPedido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPedido.Text.Length > 4 && !string.IsNullOrWhiteSpace(txtPedido.Text))
                {
                    R.Pedido = txtPedido.Text;
                    dt = R.BuscarPedido();

                    if (dt.Rows.Count > 0)
                    {
                        txtPedido.Text = dt.Rows[0][2].ToString();
                        IdPedido = Convert.ToInt32(dt.Rows[0][0]);
                        lbinf.Visible = false;
                    }
                    else
                    {
                        lbinf.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarRecepcion_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtPedido.Text) && !string.IsNullOrEmpty(txtConduce.Text) && IdPedido!=0)
                {
                    string Msj = "";
                    R.IdRecepcion = txtRecepcion.Text;
                    R.IdPedido = IdPedido;
                    R.Pedido = txtPedido.Text;
                    R.Fecha = dtpFecha.Value;
                    R.Conduce = txtConduce.Text;
                    R.IdChofer = Convert.ToInt32(cmbChofer.SelectedValue);
                    if (Program.Valor3 == 1)
                    {
                        R.Valor = 2;
                    }
                    else
                    {
                        R.Valor = 1;
                    }
                    Msj = R.RegistrarActRecepcion();
                    if (Msj == "1")
                    {
                        LlenarGridRecepcion();
                        GenerarNumRecepcion();
                        txtPedido.Text = string.Empty;
                        txtConduce.Text = string.Empty;
                        Program.Valor3 = 0;
                        IdPedido = 0;
                        MessageBoxEx.Show("Recepción guardada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ObtenerUltimaRecepcion();
                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardarRollo_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Utilidades.ValidarForm2(panel4, errorProvider1) == false)
            {
                return;
            }
            try
            {
                string Msj = "";
                R.IdRecepcion = txtRecepcion2.Text;
                DataTable dt = R.VerificarRecepcionAlambron();
                if (dt.Rows.Count > 0)
                {
                    idRecepcion = Convert.ToInt16(dt.Rows[0][0]);
                    //R.IdRecepcion = txtRecepcion2.Text;
                    R.Colada = txtColada.Text;
                    R.Sae = txtSae.Text;
                    R.Diametro = txtDiametro.Text;
                    R.IdAlmacen = Convert.ToInt32(cmbAlmacen.SelectedValue);
                    R.IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                    R.IdFabricante = Convert.ToInt32(cmbFabricante.SelectedValue);
                    R.NumRollo = txtRollo.Text;
                    R.IdRecep = idRecepcion;
                    R.Peso = Convert.ToDecimal(txtPeso.Text);
                    Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox1.Image = barcode.Draw(txtRollo.Text + IdRollo.ToString() + "P" + txtPeso.Text, 25);
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] Pic = ms.ToArray();
                    R.Barcode = Pic;
                    Msj = R.RegistrarRollo();
                    if (Msj == "1")
                    {
                        MessageBoxEx.Show("Rollo registrado", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LlenarGridRollos();
                        txtLeerRollo.Focus();
                        IdRollo = R.ObtenerUltimoIdRollo();
                    }
                    else
                    {
                        MessageBoxEx.Show("Rollo ya existe", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBoxEx.Show("Número de recepción no existe", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dt = null; 
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void txtPedido3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPedido3.Text.Length > 4 && !string.IsNullOrWhiteSpace(txtPedido3.Text))
                {
                    R.Pedido = txtPedido3.Text;
                    dt = R.BuscarPedido();

                    if (dt.Rows.Count > 0)
                    {
                        txtPedido3.Text = dt.Rows[0][2].ToString();
                        IdPedido = Convert.ToInt32(dt.Rows[0][0]);
                        lbinf.Visible = false;
                    }
                    else
                    {
                        lbinf.Visible = true;
                    }
                    dt = null;
                }

            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmReporte obj = new frmReporte();
            if (TipoReporte == 1)
            {
                errorProvider1.Clear();
                if (Utilidades.ValidarForm2(panel9, errorProvider1) == false)
                {
                    return;
                }

                obj.Pedido = txtPedido3.Text;
                obj.Nombre = "recepcion_alambron.rdlc";
                obj.Valor = 25;

            }
            else if (TipoReporte == 2)
            {
                obj.Fechai = dtpDesde.Value;
                obj.Fechaf = dtpHasta.Value;
                obj.Nombre = "rollos_alambrondet.rdlc";
                obj.Valor = 26;
            }
            obj.Idcliente = Convert.ToInt32(cmbCliente2.SelectedValue);
            obj.Show();
        }

        private void rdPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdPedido.Checked)
            {
                txtPedido3.Enabled = false;
                txtPedido3.Validar = false;
            }
            else
            {
                TipoReporte = 1;
                txtPedido3.Enabled = true;
                txtPedido3.Validar = true;
            }
        }

        private void rbFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFechas.Checked)
            {
                TipoReporte = 2;
            }
        }

        private void cmbTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarGridRollos();
        }

        private void btnEliminarRollo_Click(object sender, EventArgs e)
        {
            try
            {
                string Msj = "";
                if (dtgvRollosAlambron.SelectedRows.Count > 0)
                {
                    DialogResult var = MessageBoxEx.Show("¿Desea eliminar el registro?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (var == DialogResult.Yes)
                    {
                        PG.Id = Convert.ToInt32(dtgvRollosAlambron.CurrentRow.Cells[0].Value);
                        PG.Dpto = "Alambron";
                        PG.Idusuario = Program.Idusuario;
                        PG.Pcname = Environment.MachineName;
                        Msj = PG.EliminarRegistro();
                        //R.Id = Convert.ToInt32(dtgvRollosAlambron.CurrentRow.Cells[0].Value);
                        //R.Colada = dtgvRollosAlambron.CurrentRow.Cells[2].Value.ToString();
                        //R.NumRollo = dtgvRollosAlambron.CurrentRow.Cells[1].Value.ToString();
                        //Msj = R.EliminarRollo();
                        if (Msj == "1")
                        {
                            MessageBoxEx.Show("Eliminado correctamente", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LlenarGridRollos();

                        }
                        else
                        {
                            MessageBoxEx.Show("El rollo no existe o ya tiene salida.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void dtgvRollosAlambron_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dtgvRollosAlambron.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToBoolean(Myrow.Cells[6].Value))// Or your condition 
                {
                    Myrow.DefaultCellStyle.ForeColor = System.Drawing.Color.Green;
                }
                //else if (Convert.ToBoolean(Myrow.Cells[10].Value))
                //{
                //    Myrow.DefaultCellStyle.ForeColor = System.Drawing.Color.Red;
                //}
                //else
                {
                    Myrow.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

                }

            }
        }

        private void chImpreso_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridRollos();
        }

        private void chEliminados_CheckedChanged(object sender, EventArgs e)
        {
            LlenarGridRollos();
        }

        private void btn_InventarioRes_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 27;
                obj.Reporte = "INVENTARIO RESUMIDO";
                obj.Nombre = "inventario_res_alambron.rdlc";
                obj.Idcliente = Convert.ToInt16(cmbClienteSalida.SelectedValue);
                //obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                //obj.Almacen = cmbAlmacen.Text;
                obj.Show();
            }
            catch (Exception)
            {

            }
        }

        private void btn_InventarioDet_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 28;
                obj.Reporte = "INVENTARIO DETALLADO";
                obj.Nombre = "inventario_det_alambron.rdlc";
                obj.Idcliente = Convert.ToInt16(cmbClienteSalida.SelectedValue);
                //obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                //obj.Almacen = cmbAlmacen.Text;
                obj.Show();
            }
            catch (Exception)
            {

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvRollosAlambron.SelectedRows.Count > 0)
                {
                    frmReporte obj = new frmReporte();
                    obj.Valor = 29;
                    obj.Reporte = "TICKET ALAMBRON";
                    obj.Nombre = "ticket_alambron.rdlc";
                    obj._IdRollo = Convert.ToInt32(dtgvRollosAlambron.CurrentRow.Cells[0].Value);
                    obj.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                MessageBoxEx.Show(ex.Message, "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnEditarRecepcion_Click(object sender, EventArgs e)
        {
            if (dtgvRecepcion.SelectedRows.Count > 0)
            {

                txtRecepcion.ReadOnly = true;
                Program.Valor3 = 1;
                txtRecepcion.Text = dtgvRecepcion.CurrentRow.Cells[1].Value.ToString();
                IdPedido = Convert.ToInt32(dtgvRecepcion.CurrentRow.Cells[3].Value.ToString());
                txtPedido.Text = dtgvRecepcion.CurrentRow.Cells[4].Value.ToString();
                txtConduce.Text = dtgvRecepcion.CurrentRow.Cells[6].Value.ToString();
                cmbChofer.Text = dtgvRecepcion.CurrentRow.Cells[5].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(dtgvRecepcion.CurrentRow.Cells[2].Value);

            }
        }

        private void btnEliminarRecepcion_Click(object sender, EventArgs e)
        {
            if (dtgvRecepcion.SelectedRows.Count > 0)
            {
                string msj = "";
                DialogResult var = MessageBoxEx.Show("¿Desea eliminar la recepción?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (var == DialogResult.Yes)
                {
                    R.IdRecep = Convert.ToInt32(dtgvRecepcion.CurrentRow.Cells[0].Value);

                    msj = R.EliminarRecepcion();
                    if (msj == "1")
                    {
                        LlenarGridRecepcion();
                        GenerarNumRecepcion();
                        MessageBoxEx.Show("Recepción eliminada", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBoxEx.Show("No puede eliminar una recepción que ya tiene rollos", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    ObtenerUltimaRecepcion();
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            LlenarGridRollos();
        }

        private void txt_Rollo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)80)
            {
                e.Handled = true;
                txt_Peso.Focus();

            }
        }

        private void txt_Peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool agregado = false;
            if (e.KeyChar == (char)Keys.Enter)
            {
                R.NumRollo = txt_Rollo.Text;
                txt_Peso.Text = R.ObtenerPesoRolloAlambron();
                Ca.Tarjeta = txt_Rollo.Text.Trim();
                Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                int msj = Ca.VerificarRolloSalida();
                if (msj == 0)
                {
                    for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
                    {
                        if (txt_Rollo.Text == dtgv_Salida.Rows[x].Cells[0].Value.ToString())
                        {
                            agregado = true;
                        }
                    }
                    if (agregado)
                    {
                        agregado = false;
                        MessageBoxEx.Show("Está rollo ya ha sido agregado.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Rollo.Clear();
                        txt_Peso.Clear();
                        txt_Rollo.Focus();
                    }
                    else
                    {
                        dtgv_Salida.Rows.Add(txt_Rollo.Text, txt_Peso.Text);
                        CalcularTotal();
                    }

                }
                else if (msj == 1)
                {
                    MessageBoxEx.Show("Rollo ya tiene salida", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (msj == 2)
                {
                    MessageBoxEx.Show("Rollo no tiene existe en inventario.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txt_Peso.Clear();
                txt_Rollo.Clear();
                txt_Rollo.Focus();
            }
        }

        private void CalcularTotal()
        {
            double total = 0;
            for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
            {
                total = total + Convert.ToDouble(dtgv_Salida.Rows[x].Cells[1].Value);

            }
            //total = total;
            lb_Total.Text = total.ToString() + " " + "QQS.";
            lb_Totalc.Text = dtgv_Salida.Rows.Count.ToString();
        }

        private void cmbUnidadMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                var Peso = txtPeso.Text;
                switch (cmbUnidadMedida.Text)
                {
                    case "KG":
                        txtPesoKG.Text = txtPeso.Text;
                        break;
                    case "LBS":
                        txtPesoKG.Text =Math.Round((Convert.ToDouble(Peso) / 2.205),2).ToString();
                        break;
                    case "TM":
                        txtPesoKG.Text = (Convert.ToDouble(Peso) * 1000).ToString();
                        break;
                }
                txtPesoKG.Text = txtPesoKG.Text + " KG";
            }
            else
            {
                txtPesoKG.Text = string.Empty;
            }
            
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            if (Program.Editar == 0)
            {
                 idSalida = 0;
            }

            try
            {
                if (dtgv_Salida.Rows.Count > 0)
                {
                    Ca.Fecha = dtp_FechaSalida.Value;
                    Ca.Nota = txt_Nota.Text;
                    Ca.Iduso = Convert.ToInt16(cb_Uso.SelectedValue);
                    Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                    if (Program.Editar == 1)
                    {
                        Ca.ActualizarSalidaInventario();
                    }
                    else
                    {
                        idSalida = Ca.RegistrarSalidaInventario();
                    }
                    if (idSalida > 0)
                    {
                        for (int x = 0; x < dtgv_Salida.Rows.Count; x++)
                        {
                            Ca.Tarjeta = dtgv_Salida.Rows[x].Cells[0].Value.ToString();
                            Ca.Idsalida = idSalida;
                            Ca.RegistrarDetalleSalidaInventarioAlambron();
                        }
                        if (Program.Editar == 1)
                        {
                            MessageBoxEx.Show("Salida actualizada.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Registrar.Text = "REGISTRAR";
                        }
                        else
                        {
                            MessageBoxEx.Show("Salida registrada.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        Limpiar();

                    }
                    else
                    {
                        MessageBoxEx.Show("Ha ocurrido un error.", "Sistema de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                Program.Editar = 0;
            }
            catch (Exception ex)
            {

            }
        }
        private void Limpiar()
        {
            txt_Nota.Clear();
            dtgv_Salida.Rows.Clear();
            cb_Uso.SelectedIndex = -1;
            lb_Total.Text = "0.00 QQS.";
            lb_Totalc.Text = "0";
            cb_Uso.SelectedIndex = -1;
        }
        private void LlenarGridHistorialSalida()
        {
            try
            {
                DataTable dt = new DataTable();
                Ca.Fechai = dtp_FechaiSalida.Value;
                Ca.Fechaf = dtp_FechafSalida.Value;
                Ca.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                dt.Rows.Clear();
                dt = Ca.ObtenerHistorialSalidaAlmacenAlambron();

                dtgv_HistorialSalida.DataSource = null;
                dtgv_HistorialSalida.DataSource = dt;
                dtgv_HistorialSalida.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_BuscarSalida_Click(object sender, EventArgs e)
        {
            LlenarGridHistorialSalida();
        }

        private void btn_VerSalida_Click(object sender, EventArgs e)
        {
            try
            {
                frmReporte obj = new frmReporte();
                obj.Valor = 30;
                obj.Reporte = "SALIDA DE INVENTARIO";
                obj.Nombre = "salida_inventario_alambron.rdlc";
                obj.Idalmacen = Convert.ToInt16(cmbAlmacen.SelectedValue);
                obj.Idcliente= Convert.ToInt16(cmbClienteSalida.SelectedValue);
                obj.Almacen = cmbAlmacen.Text;
                obj.Fechai = dtp_FechaiSalida.Value;
                obj.Fechaf = dtp_FechafSalida.Value;
                //obj.Producto = "0";
                //obj.Iduso = 0;
                obj.Show();
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void dtgv_Salida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult var;
                var = MessageBoxEx.Show("Desea eliminar la bobina?", "Sistema de Producción", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (var == DialogResult.Yes)
                {
                    if (Program.Editar == 1)
                    {
                        Ca.Tarjeta = dtgv_Salida.CurrentRow.Cells[0].Value.ToString();
                        Ca.EliminarBobinaSalidaAlmacenAlambron();
                    }
                    dtgv_Salida.Rows.RemoveAt(dtgv_Salida.CurrentRow.Index);
                    CalcularTotal();
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void dtgv_HistorialSalida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.Editar = 1;
                DataTable dt = new DataTable();
                Ca.Idsalida = Convert.ToInt16(dtgv_HistorialSalida.CurrentRow.Cells[0].Value);
                idSalida = Convert.ToInt16(dtgv_HistorialSalida.CurrentRow.Cells[0].Value);
                dt = Ca.ObtenerDetalleSalidaAlmacenAlambron();
                Limpiar();
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dtgv_Salida.Rows.Add(dt.Rows[x][0]);
                    dtgv_Salida.Rows[x].Cells[0].Value = dt.Rows[x][4].ToString();
                    dtgv_Salida.Rows[x].Cells[1].Value = dt.Rows[x][5].ToString();
                }
                dtp_FechaSalida.Value = Convert.ToDateTime(dt.Rows[0][1]);
                cb_Uso.SelectedValue = Convert.ToInt32(dt.Rows[0][2]);
                txt_Nota.Text = dt.Rows[0][3].ToString();
                CalcularTotal();
                btn_Registrar.Text = "ACTUALIZAR";
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }
    }
}
