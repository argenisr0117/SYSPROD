namespace Interfaz.Registros
{
    partial class frmProduccionTrefilado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduccionTrefilado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoCanastosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pUERTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabregistro = new System.Windows.Forms.TabPage();
            this.txtPesoBruto = new Interfaz.Controles.textboxN(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCalibre = new System.Windows.Forms.TextBox();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbColada = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPesocanasto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDiametro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReimprimir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnbuscar1 = new System.Windows.Forms.Button();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.lbProdT2 = new System.Windows.Forms.Label();
            this.lbTurno2 = new System.Windows.Forms.Label();
            this.lbProdT1 = new System.Windows.Forms.Label();
            this.lbTurno1 = new System.Windows.Forms.Label();
            this.lbTotalC = new System.Windows.Forms.Label();
            this.lbTotalP = new System.Windows.Forms.Label();
            this.lbTotalCanasto = new System.Windows.Forms.Label();
            this.lbTotalProd = new System.Windows.Forms.Label();
            this.dtgvProduccion = new System.Windows.Forms.DataGridView();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabregistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ForeColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.cONFIGURACIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 111;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coladasToolStripMenuItem,
            this.pesoCanastosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.registrosToolStripMenuItem.Text = "REGISTROS";
            // 
            // coladasToolStripMenuItem
            // 
            this.coladasToolStripMenuItem.Name = "coladasToolStripMenuItem";
            this.coladasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.coladasToolStripMenuItem.Text = "COLADAS";
            this.coladasToolStripMenuItem.Click += new System.EventHandler(this.coladasToolStripMenuItem_Click);
            // 
            // pesoCanastosToolStripMenuItem
            // 
            this.pesoCanastosToolStripMenuItem.Name = "pesoCanastosToolStripMenuItem";
            this.pesoCanastosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pesoCanastosToolStripMenuItem.Text = "PESO CANASTOS";
            this.pesoCanastosToolStripMenuItem.Click += new System.EventHandler(this.pesoCanastosToolStripMenuItem_Click);
            // 
            // cONFIGURACIONToolStripMenuItem
            // 
            this.cONFIGURACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pUERTOSToolStripMenuItem});
            this.cONFIGURACIONToolStripMenuItem.Name = "cONFIGURACIONToolStripMenuItem";
            this.cONFIGURACIONToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.cONFIGURACIONToolStripMenuItem.Text = "CONFIGURACION";
            // 
            // pUERTOSToolStripMenuItem
            // 
            this.pUERTOSToolStripMenuItem.Name = "pUERTOSToolStripMenuItem";
            this.pUERTOSToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pUERTOSToolStripMenuItem.Text = "PUERTOS";
            this.pUERTOSToolStripMenuItem.Click += new System.EventHandler(this.pUERTOSToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabregistro);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 621);
            this.tabControl1.TabIndex = 112;
            // 
            // tabregistro
            // 
            this.tabregistro.Controls.Add(this.txtPesoBruto);
            this.tabregistro.Controls.Add(this.label14);
            this.tabregistro.Controls.Add(this.pictureBox1);
            this.tabregistro.Controls.Add(this.txtCalibre);
            this.tabregistro.Controls.Add(this.menuStrip1);
            this.tabregistro.Controls.Add(this.txtDiametro);
            this.tabregistro.Controls.Add(this.label13);
            this.tabregistro.Controls.Add(this.btnImprimir);
            this.tabregistro.Controls.Add(this.btnBorrar);
            this.tabregistro.Controls.Add(this.btnBuscar);
            this.tabregistro.Controls.Add(this.cmbColada);
            this.tabregistro.Controls.Add(this.label10);
            this.tabregistro.Controls.Add(this.cmbPesocanasto);
            this.tabregistro.Controls.Add(this.label11);
            this.tabregistro.Controls.Add(this.cmbSupervisor);
            this.tabregistro.Controls.Add(this.label12);
            this.tabregistro.Controls.Add(this.label7);
            this.tabregistro.Controls.Add(this.cmbDiametro);
            this.tabregistro.Controls.Add(this.label8);
            this.tabregistro.Controls.Add(this.cmbProducto);
            this.tabregistro.Controls.Add(this.label9);
            this.tabregistro.Controls.Add(this.cmbCliente);
            this.tabregistro.Controls.Add(this.label6);
            this.tabregistro.Controls.Add(this.cmbOperador);
            this.tabregistro.Controls.Add(this.label5);
            this.tabregistro.Controls.Add(this.cmbMaquina);
            this.tabregistro.Controls.Add(this.label4);
            this.tabregistro.Controls.Add(this.txtDepartamento);
            this.tabregistro.Controls.Add(this.label3);
            this.tabregistro.Controls.Add(this.label1);
            this.tabregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabregistro.ForeColor = System.Drawing.Color.Black;
            this.tabregistro.Location = new System.Drawing.Point(4, 22);
            this.tabregistro.Name = "tabregistro";
            this.tabregistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabregistro.Size = new System.Drawing.Size(1012, 595);
            this.tabregistro.TabIndex = 0;
            this.tabregistro.Text = "REGISTRAR";
            this.tabregistro.UseVisualStyleBackColor = true;
            // 
            // txtPesoBruto
            // 
            this.txtPesoBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoBruto.Location = new System.Drawing.Point(319, 459);
            this.txtPesoBruto.Name = "txtPesoBruto";
            this.txtPesoBruto.ReadOnly = true;
            this.txtPesoBruto.Size = new System.Drawing.Size(407, 21);
            this.txtPesoBruto.TabIndex = 141;
            this.txtPesoBruto.Validar = false;
            this.txtPesoBruto.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(661, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 140;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(767, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // txtCalibre
            // 
            this.txtCalibre.BackColor = System.Drawing.Color.White;
            this.txtCalibre.Enabled = false;
            this.txtCalibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalibre.ForeColor = System.Drawing.Color.Black;
            this.txtCalibre.Location = new System.Drawing.Point(319, 313);
            this.txtCalibre.Name = "txtCalibre";
            this.txtCalibre.Size = new System.Drawing.Size(336, 22);
            this.txtCalibre.TabIndex = 138;
            this.txtCalibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiametro
            // 
            this.txtDiametro.BackColor = System.Drawing.Color.White;
            this.txtDiametro.Enabled = false;
            this.txtDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiametro.ForeColor = System.Drawing.Color.Black;
            this.txtDiametro.Location = new System.Drawing.Point(319, 275);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(336, 22);
            this.txtDiametro.TabIndex = 137;
            this.txtDiametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(157, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "PESO BRUTO:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnImprimir.FlatAppearance.BorderSize = 2;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = global::Interfaz.Properties.Resources.save_icon;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(598, 495);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(128, 67);
            this.btnImprimir.TabIndex = 134;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "IMPRIMIR FICHA";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Image = global::Interfaz.Properties.Resources.delete_file_icon;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(319, 495);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(128, 67);
            this.btnBorrar.TabIndex = 133;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "BORRAR CAMPOS";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Interfaz.Properties.Resources.Search_icon;
            this.btnBuscar.Location = new System.Drawing.Point(692, 236);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 24);
            this.btnBuscar.TabIndex = 132;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbColada
            // 
            this.cmbColada.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbColada.DropDownHeight = 160;
            this.cmbColada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbColada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColada.ForeColor = System.Drawing.Color.Black;
            this.cmbColada.FormattingEnabled = true;
            this.cmbColada.IntegralHeight = false;
            this.cmbColada.Location = new System.Drawing.Point(319, 425);
            this.cmbColada.MaxDropDownItems = 30;
            this.cmbColada.Name = "cmbColada";
            this.cmbColada.Size = new System.Drawing.Size(410, 26);
            this.cmbColada.TabIndex = 131;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(157, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 130;
            this.label10.Text = "COLADA:";
            // 
            // cmbPesocanasto
            // 
            this.cmbPesocanasto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbPesocanasto.DropDownHeight = 160;
            this.cmbPesocanasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesocanasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPesocanasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesocanasto.ForeColor = System.Drawing.Color.Black;
            this.cmbPesocanasto.FormattingEnabled = true;
            this.cmbPesocanasto.IntegralHeight = false;
            this.cmbPesocanasto.Location = new System.Drawing.Point(319, 386);
            this.cmbPesocanasto.MaxDropDownItems = 30;
            this.cmbPesocanasto.Name = "cmbPesocanasto";
            this.cmbPesocanasto.Size = new System.Drawing.Size(410, 26);
            this.cmbPesocanasto.TabIndex = 129;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(157, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 128;
            this.label11.Text = "PESO CANASTO(LBS):";
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSupervisor.DropDownHeight = 160;
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupervisor.ForeColor = System.Drawing.Color.Black;
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.IntegralHeight = false;
            this.cmbSupervisor.Location = new System.Drawing.Point(319, 349);
            this.cmbSupervisor.MaxDropDownItems = 30;
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(410, 26);
            this.cmbSupervisor.TabIndex = 127;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(157, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 126;
            this.label12.Text = "SUPERVISOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(157, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "CALIBRE:";
            // 
            // cmbDiametro
            // 
            this.cmbDiametro.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDiametro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiametro.ForeColor = System.Drawing.Color.Black;
            this.cmbDiametro.FormattingEnabled = true;
            this.cmbDiametro.Items.AddRange(new object[] {
            "PULG",
            "MM"});
            this.cmbDiametro.Location = new System.Drawing.Point(661, 274);
            this.cmbDiametro.Name = "cmbDiametro";
            this.cmbDiametro.Size = new System.Drawing.Size(68, 24);
            this.cmbDiametro.TabIndex = 124;
            this.cmbDiametro.SelectedIndexChanged += new System.EventHandler(this.cmbDiametro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(157, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "DIAMETRO:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbProducto.DropDownHeight = 160;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducto.ForeColor = System.Drawing.Color.Black;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IntegralHeight = false;
            this.cmbProducto.Location = new System.Drawing.Point(319, 237);
            this.cmbProducto.MaxDropDownItems = 30;
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(369, 26);
            this.cmbProducto.TabIndex = 122;
            this.cmbProducto.SelectedValueChanged += new System.EventHandler(this.cmbProducto_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(157, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 121;
            this.label9.Text = "PRODUCTO:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCliente.DropDownHeight = 160;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.Location = new System.Drawing.Point(319, 199);
            this.cmbCliente.MaxDropDownItems = 30;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(410, 26);
            this.cmbCliente.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(157, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "CLIENTE:";
            // 
            // cmbOperador
            // 
            this.cmbOperador.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbOperador.DropDownHeight = 160;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.ForeColor = System.Drawing.Color.Black;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.IntegralHeight = false;
            this.cmbOperador.Location = new System.Drawing.Point(319, 164);
            this.cmbOperador.MaxDropDownItems = 30;
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(410, 26);
            this.cmbOperador.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(157, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "OPERADOR:";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbMaquina.DropDownHeight = 160;
            this.cmbMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaquina.ForeColor = System.Drawing.Color.Black;
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.IntegralHeight = false;
            this.cmbMaquina.Location = new System.Drawing.Point(319, 130);
            this.cmbMaquina.MaxDropDownItems = 30;
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(410, 26);
            this.cmbMaquina.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(157, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "MÁQUINA #:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDepartamento.Location = new System.Drawing.Point(319, 92);
            this.txtDepartamento.Multiline = true;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.ReadOnly = true;
            this.txtDepartamento.Size = new System.Drawing.Size(410, 24);
            this.txtDepartamento.TabIndex = 114;
            this.txtDepartamento.Text = "TREFILADO";
            this.txtDepartamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(157, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "DEPARTAMENTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(315, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 20);
            this.label1.TabIndex = 111;
            this.label1.Text = "REGISTRO PRODUCCIÓN DIARIA - TREFILADO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dtgvProduccion);
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1012, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PRODUCCIÓN DEL DIA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnReimprimir);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 82);
            this.panel2.TabIndex = 2;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.BackColor = System.Drawing.Color.White;
            this.btnReimprimir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnReimprimir.FlatAppearance.BorderSize = 2;
            this.btnReimprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnReimprimir.Image = global::Interfaz.Properties.Resources.print;
            this.btnReimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReimprimir.Location = new System.Drawing.Point(526, 8);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(103, 55);
            this.btnReimprimir.TabIndex = 58;
            this.btnReimprimir.TabStop = false;
            this.btnReimprimir.Text = "REIMPRIMIR";
            this.btnReimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReimprimir.UseVisualStyleBackColor = false;
            this.btnReimprimir.Click += new System.EventHandler(this.btnReimprimir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.White;
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnFiltrar.FlatAppearance.BorderSize = 2;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Image = global::Interfaz.Properties.Resources.Search_icon1;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFiltrar.Location = new System.Drawing.Point(308, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(103, 55);
            this.btnFiltrar.TabIndex = 57;
            this.btnFiltrar.TabStop = false;
            this.btnFiltrar.Text = "FILTRAR";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = global::Interfaz.Properties.Resources.delete_file_icon;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(635, 8);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 55);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Image = global::Interfaz.Properties.Resources.save_icon;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(417, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 55);
            this.btnEditar.TabIndex = 54;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.White;
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnExportar.FlatAppearance.BorderSize = 2;
            this.btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.ForeColor = System.Drawing.Color.Black;
            this.btnExportar.Image = global::Interfaz.Properties.Resources.exportar__1_;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(199, 8);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(103, 55);
            this.btnExportar.TabIndex = 56;
            this.btnExportar.TabStop = false;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnbuscar1);
            this.panel1.Controls.Add(this.dtphasta);
            this.panel1.Controls.Add(this.dtpdesde);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lbProdT2);
            this.panel1.Controls.Add(this.lbTurno2);
            this.panel1.Controls.Add(this.lbProdT1);
            this.panel1.Controls.Add(this.lbTurno1);
            this.panel1.Controls.Add(this.lbTotalC);
            this.panel1.Controls.Add(this.lbTotalP);
            this.panel1.Controls.Add(this.lbTotalCanasto);
            this.panel1.Controls.Add(this.lbTotalProd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 85);
            this.panel1.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkRed;
            this.label18.Location = new System.Drawing.Point(654, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 67;
            this.label18.Text = "05:59 AM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(653, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 66;
            this.label16.Text = "06:00 AM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(486, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 65;
            this.label17.Text = "HASTA:";
            // 
            // btnbuscar1
            // 
            this.btnbuscar1.BackColor = System.Drawing.Color.White;
            this.btnbuscar1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnbuscar1.FlatAppearance.BorderSize = 2;
            this.btnbuscar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnbuscar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbuscar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar1.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar1.Image = global::Interfaz.Properties.Resources.Show_all_icon;
            this.btnbuscar1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar1.Location = new System.Drawing.Point(742, 17);
            this.btnbuscar1.Name = "btnbuscar1";
            this.btnbuscar1.Size = new System.Drawing.Size(103, 48);
            this.btnbuscar1.TabIndex = 57;
            this.btnbuscar1.TabStop = false;
            this.btnbuscar1.Text = "MOSTRAR";
            this.btnbuscar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar1.UseVisualStyleBackColor = false;
            this.btnbuscar1.Click += new System.EventHandler(this.btnbuscar1_Click);
            // 
            // dtphasta
            // 
            this.dtphasta.BackColor = System.Drawing.Color.White;
            this.dtphasta.CustomFormat = "dd/MM/yyyy";
            this.dtphasta.ForeColor = System.Drawing.Color.Black;
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphasta.Location = new System.Drawing.Point(544, 45);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(103, 20);
            this.dtphasta.TabIndex = 64;
            // 
            // dtpdesde
            // 
            this.dtpdesde.BackColor = System.Drawing.Color.White;
            this.dtpdesde.CustomFormat = "dd/MM/yyyy";
            this.dtpdesde.ForeColor = System.Drawing.Color.Black;
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdesde.Location = new System.Drawing.Point(544, 16);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(103, 20);
            this.dtpdesde.TabIndex = 62;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(484, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "DESDE:";
            // 
            // lbProdT2
            // 
            this.lbProdT2.AutoSize = true;
            this.lbProdT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdT2.ForeColor = System.Drawing.Color.Maroon;
            this.lbProdT2.Location = new System.Drawing.Point(317, 44);
            this.lbProdT2.Name = "lbProdT2";
            this.lbProdT2.Size = new System.Drawing.Size(32, 13);
            this.lbProdT2.TabIndex = 7;
            this.lbProdT2.Text = "0.00";
            // 
            // lbTurno2
            // 
            this.lbTurno2.AutoSize = true;
            this.lbTurno2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno2.Location = new System.Drawing.Point(257, 44);
            this.lbTurno2.Name = "lbTurno2";
            this.lbTurno2.Size = new System.Drawing.Size(11, 13);
            this.lbTurno2.TabIndex = 6;
            this.lbTurno2.Text = ".";
            // 
            // lbProdT1
            // 
            this.lbProdT1.AutoSize = true;
            this.lbProdT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdT1.ForeColor = System.Drawing.Color.Maroon;
            this.lbProdT1.Location = new System.Drawing.Point(317, 23);
            this.lbProdT1.Name = "lbProdT1";
            this.lbProdT1.Size = new System.Drawing.Size(32, 13);
            this.lbProdT1.TabIndex = 5;
            this.lbProdT1.Text = "0.00";
            // 
            // lbTurno1
            // 
            this.lbTurno1.AutoSize = true;
            this.lbTurno1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno1.Location = new System.Drawing.Point(257, 23);
            this.lbTurno1.Name = "lbTurno1";
            this.lbTurno1.Size = new System.Drawing.Size(11, 13);
            this.lbTurno1.TabIndex = 4;
            this.lbTurno1.Text = ".";
            // 
            // lbTotalC
            // 
            this.lbTotalC.AutoSize = true;
            this.lbTotalC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalC.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotalC.Location = new System.Drawing.Point(141, 44);
            this.lbTotalC.Name = "lbTotalC";
            this.lbTotalC.Size = new System.Drawing.Size(32, 13);
            this.lbTotalC.TabIndex = 3;
            this.lbTotalC.Text = "0.00";
            // 
            // lbTotalP
            // 
            this.lbTotalP.AutoSize = true;
            this.lbTotalP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalP.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotalP.Location = new System.Drawing.Point(141, 23);
            this.lbTotalP.Name = "lbTotalP";
            this.lbTotalP.Size = new System.Drawing.Size(32, 13);
            this.lbTotalP.TabIndex = 2;
            this.lbTotalP.Text = "0.00";
            // 
            // lbTotalCanasto
            // 
            this.lbTotalCanasto.AutoSize = true;
            this.lbTotalCanasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCanasto.Location = new System.Drawing.Point(3, 44);
            this.lbTotalCanasto.Name = "lbTotalCanasto";
            this.lbTotalCanasto.Size = new System.Drawing.Size(121, 13);
            this.lbTotalCanasto.TabIndex = 1;
            this.lbTotalCanasto.Text = "TOTAL CANASTOS:";
            // 
            // lbTotalProd
            // 
            this.lbTotalProd.AutoSize = true;
            this.lbTotalProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProd.Location = new System.Drawing.Point(3, 23);
            this.lbTotalProd.Name = "lbTotalProd";
            this.lbTotalProd.Size = new System.Drawing.Size(132, 13);
            this.lbTotalProd.TabIndex = 0;
            this.lbTotalProd.Text = "PROD. TOTAL (QQS):";
            // 
            // dtgvProduccion
            // 
            this.dtgvProduccion.AllowUserToAddRows = false;
            this.dtgvProduccion.AllowUserToDeleteRows = false;
            this.dtgvProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvProduccion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProduccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProduccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProduccion.Location = new System.Drawing.Point(3, 94);
            this.dtgvProduccion.MultiSelect = false;
            this.dtgvProduccion.Name = "dtgvProduccion";
            this.dtgvProduccion.ReadOnly = true;
            this.dtgvProduccion.RowHeadersWidth = 20;
            this.dtgvProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProduccion.Size = new System.Drawing.Size(1009, 419);
            this.dtgvProduccion.TabIndex = 0;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // frmProduccionTrefilado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmProduccionTrefilado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TREFILADO- IDENTIFICACION DE ALAMBRE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProduccionTrefilado_FormClosing);
            this.Load += new System.EventHandler(this.frmProduccionTrefilado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabregistro.ResumeLayout(false);
            this.tabregistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesoCanastosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pUERTOSToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabregistro;
        private System.Windows.Forms.TextBox txtCalibre;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbColada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPesocanasto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDiametro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvProduccion;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotalCanasto;
        private System.Windows.Forms.Label lbTotalProd;
        private System.Windows.Forms.Label lbProdT1;
        private System.Windows.Forms.Label lbTurno1;
        private System.Windows.Forms.Label lbTotalC;
        private System.Windows.Forms.Label lbTotalP;
        private System.Windows.Forms.Label lbProdT2;
        private System.Windows.Forms.Label lbTurno2;
        private Controles.textboxN txtPesoBruto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnbuscar1;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnReimprimir;
    }
}