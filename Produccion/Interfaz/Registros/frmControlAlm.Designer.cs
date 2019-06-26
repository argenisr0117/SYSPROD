namespace Interfaz.Registros
{
    partial class frmControlAlm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControlAlm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbAlmacen = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_InventarioDet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_InventarioRes = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_VerEntrada = new System.Windows.Forms.Button();
            this.dtp_Fechaf = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fechai = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgv_Entradas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_BuscarSalida = new System.Windows.Forms.Button();
            this.dtgv_HistorialSalida = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_VerSalida = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_FechafSalida = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaiSalida = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Nota = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgv_Salida = new System.Windows.Forms.DataGridView();
            this.rollo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Rollo = new System.Windows.Forms.TextBox();
            this.cb_Uso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.lb_Totalc = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_NoReporte = new Interfaz.Controles.textbox(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Entradas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HistorialSalida)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Salida)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.BackColor = System.Drawing.Color.DarkRed;
            this.lb_Titulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_Titulo.Location = new System.Drawing.Point(146, 13);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(332, 23);
            this.lb_Titulo.TabIndex = 46;
            this.lb_Titulo.Text = "CONTROL DE ALAMBRES - ALMACÉN ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbAlmacen);
            this.panel1.Controls.Add(this.lb_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 50);
            this.panel1.TabIndex = 47;
            // 
            // cmbAlmacen
            // 
            this.cmbAlmacen.FormattingEnabled = true;
            this.cmbAlmacen.Location = new System.Drawing.Point(4, 14);
            this.cmbAlmacen.Name = "cmbAlmacen";
            this.cmbAlmacen.Size = new System.Drawing.Size(96, 21);
            this.cmbAlmacen.TabIndex = 47;
            this.cmbAlmacen.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_InventarioDet);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_InventarioRes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(717, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(94, 485);
            this.panel2.TabIndex = 48;
            // 
            // btn_InventarioDet
            // 
            this.btn_InventarioDet.BackColor = System.Drawing.Color.White;
            this.btn_InventarioDet.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_InventarioDet.FlatAppearance.BorderSize = 2;
            this.btn_InventarioDet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_InventarioDet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_InventarioDet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InventarioDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InventarioDet.ForeColor = System.Drawing.Color.Black;
            this.btn_InventarioDet.Image = ((System.Drawing.Image)(resources.GetObject("btn_InventarioDet.Image")));
            this.btn_InventarioDet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InventarioDet.Location = new System.Drawing.Point(2, 137);
            this.btn_InventarioDet.Name = "btn_InventarioDet";
            this.btn_InventarioDet.Size = new System.Drawing.Size(88, 75);
            this.btn_InventarioDet.TabIndex = 83;
            this.btn_InventarioDet.TabStop = false;
            this.btn_InventarioDet.Text = "INV. DETALLADO";
            this.btn_InventarioDet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_InventarioDet, "INVENTARIO DETALLADO A LA FECHA");
            this.btn_InventarioDet.UseVisualStyleBackColor = false;
            this.btn_InventarioDet.Click += new System.EventHandler(this.btn_InventarioDet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(1, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 82;
            this.label6.Text = "REPORTES";
            // 
            // btn_InventarioRes
            // 
            this.btn_InventarioRes.BackColor = System.Drawing.Color.White;
            this.btn_InventarioRes.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_InventarioRes.FlatAppearance.BorderSize = 2;
            this.btn_InventarioRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_InventarioRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_InventarioRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InventarioRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InventarioRes.ForeColor = System.Drawing.Color.Black;
            this.btn_InventarioRes.Image = ((System.Drawing.Image)(resources.GetObject("btn_InventarioRes.Image")));
            this.btn_InventarioRes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_InventarioRes.Location = new System.Drawing.Point(2, 50);
            this.btn_InventarioRes.Name = "btn_InventarioRes";
            this.btn_InventarioRes.Size = new System.Drawing.Size(88, 75);
            this.btn_InventarioRes.TabIndex = 55;
            this.btn_InventarioRes.TabStop = false;
            this.btn_InventarioRes.Text = "INV. RESUMIDO";
            this.btn_InventarioRes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_InventarioRes, "INVENTARIO RESUMIDO A LA FECHA");
            this.btn_InventarioRes.UseVisualStyleBackColor = false;
            this.btn_InventarioRes.Click += new System.EventHandler(this.btn_InventarioRes_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 485);
            this.tabControl1.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btn_VerEntrada);
            this.tabPage1.Controls.Add(this.dtp_Fechaf);
            this.tabPage1.Controls.Add(this.dtp_Fechai);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.dtgv_Entradas);
            this.tabPage1.Controls.Add(this.txt_NoReporte);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "VISUALIZAR ENTRADAS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_VerEntrada
            // 
            this.btn_VerEntrada.BackColor = System.Drawing.Color.White;
            this.btn_VerEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_VerEntrada.FlatAppearance.BorderSize = 2;
            this.btn_VerEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_VerEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VerEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerEntrada.ForeColor = System.Drawing.Color.Black;
            this.btn_VerEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btn_VerEntrada.Image")));
            this.btn_VerEntrada.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VerEntrada.Location = new System.Drawing.Point(386, 25);
            this.btn_VerEntrada.Name = "btn_VerEntrada";
            this.btn_VerEntrada.Size = new System.Drawing.Size(106, 49);
            this.btn_VerEntrada.TabIndex = 82;
            this.btn_VerEntrada.TabStop = false;
            this.btn_VerEntrada.Text = "VER ENTRADA";
            this.btn_VerEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_VerEntrada, "REPORTE DE ENTRADA");
            this.btn_VerEntrada.UseVisualStyleBackColor = false;
            this.btn_VerEntrada.Click += new System.EventHandler(this.btn_VerEntrada_Click);
            // 
            // dtp_Fechaf
            // 
            this.dtp_Fechaf.BackColor = System.Drawing.Color.White;
            this.dtp_Fechaf.CustomFormat = "dd/MM/yyyy";
            this.dtp_Fechaf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fechaf.ForeColor = System.Drawing.Color.Black;
            this.dtp_Fechaf.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fechaf.Location = new System.Drawing.Point(97, 41);
            this.dtp_Fechaf.Name = "dtp_Fechaf";
            this.dtp_Fechaf.Size = new System.Drawing.Size(105, 20);
            this.dtp_Fechaf.TabIndex = 81;
            this.dtp_Fechaf.TabStop = false;
            // 
            // dtp_Fechai
            // 
            this.dtp_Fechai.BackColor = System.Drawing.Color.White;
            this.dtp_Fechai.CustomFormat = "dd/MM/yyyy";
            this.dtp_Fechai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fechai.ForeColor = System.Drawing.Color.Black;
            this.dtp_Fechai.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fechai.Location = new System.Drawing.Point(97, 15);
            this.dtp_Fechai.Name = "dtp_Fechai";
            this.dtp_Fechai.Size = new System.Drawing.Size(105, 20);
            this.dtp_Fechai.TabIndex = 80;
            this.dtp_Fechai.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(713, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(213, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 49);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnBuscar, "BUSCAR REGISTROS");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgv_Entradas
            // 
            this.dtgv_Entradas.AllowUserToAddRows = false;
            this.dtgv_Entradas.AllowUserToDeleteRows = false;
            this.dtgv_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_Entradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_Entradas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgv_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Entradas.Location = new System.Drawing.Point(-1, 106);
            this.dtgv_Entradas.MultiSelect = false;
            this.dtgv_Entradas.Name = "dtgv_Entradas";
            this.dtgv_Entradas.ReadOnly = true;
            this.dtgv_Entradas.RowHeadersWidth = 20;
            this.dtgv_Entradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Entradas.Size = new System.Drawing.Size(706, 298);
            this.dtgv_Entradas.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "No.REPORTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "FECHA FINAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA INICIAL:";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SALIDA DE ALMACÉN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.btn_BuscarSalida);
            this.panel4.Controls.Add(this.dtgv_HistorialSalida);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btn_VerSalida);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.dtp_FechafSalida);
            this.panel4.Controls.Add(this.dtp_FechaiSalida);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(328, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 452);
            this.panel4.TabIndex = 8;
            // 
            // btn_BuscarSalida
            // 
            this.btn_BuscarSalida.BackColor = System.Drawing.Color.White;
            this.btn_BuscarSalida.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_BuscarSalida.FlatAppearance.BorderSize = 2;
            this.btn_BuscarSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_BuscarSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarSalida.ForeColor = System.Drawing.Color.Black;
            this.btn_BuscarSalida.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarSalida.Image")));
            this.btn_BuscarSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_BuscarSalida.Location = new System.Drawing.Point(86, 90);
            this.btn_BuscarSalida.Name = "btn_BuscarSalida";
            this.btn_BuscarSalida.Size = new System.Drawing.Size(83, 49);
            this.btn_BuscarSalida.TabIndex = 90;
            this.btn_BuscarSalida.TabStop = false;
            this.btn_BuscarSalida.Text = "BUSCAR";
            this.btn_BuscarSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_BuscarSalida, "BUSCAR REGISTROS");
            this.btn_BuscarSalida.UseVisualStyleBackColor = false;
            this.btn_BuscarSalida.Click += new System.EventHandler(this.btn_BuscarSalida_Click);
            // 
            // dtgv_HistorialSalida
            // 
            this.dtgv_HistorialSalida.AllowUserToAddRows = false;
            this.dtgv_HistorialSalida.AllowUserToDeleteRows = false;
            this.dtgv_HistorialSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_HistorialSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_HistorialSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_HistorialSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_HistorialSalida.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_HistorialSalida.Location = new System.Drawing.Point(4, 168);
            this.dtgv_HistorialSalida.MultiSelect = false;
            this.dtgv_HistorialSalida.Name = "dtgv_HistorialSalida";
            this.dtgv_HistorialSalida.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_HistorialSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_HistorialSalida.RowHeadersWidth = 10;
            this.dtgv_HistorialSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_HistorialSalida.Size = new System.Drawing.Size(365, 253);
            this.dtgv_HistorialSalida.TabIndex = 89;
            this.dtgv_HistorialSalida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HistorialSalida_CellDoubleClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(-1, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(377, 12);
            this.label15.TabIndex = 88;
            this.label15.Text = "______________________________________________________________";
            // 
            // btn_VerSalida
            // 
            this.btn_VerSalida.BackColor = System.Drawing.Color.White;
            this.btn_VerSalida.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_VerSalida.FlatAppearance.BorderSize = 2;
            this.btn_VerSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_VerSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VerSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerSalida.ForeColor = System.Drawing.Color.Black;
            this.btn_VerSalida.Image = ((System.Drawing.Image)(resources.GetObject("btn_VerSalida.Image")));
            this.btn_VerSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_VerSalida.Location = new System.Drawing.Point(204, 90);
            this.btn_VerSalida.Name = "btn_VerSalida";
            this.btn_VerSalida.Size = new System.Drawing.Size(83, 49);
            this.btn_VerSalida.TabIndex = 87;
            this.btn_VerSalida.TabStop = false;
            this.btn_VerSalida.Text = "VER SALIDA";
            this.btn_VerSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_VerSalida, "REPORTE DE ENTRADA");
            this.btn_VerSalida.UseVisualStyleBackColor = false;
            this.btn_VerSalida.Click += new System.EventHandler(this.btn_VerSalida_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DarkRed;
            this.label14.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(104, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 20);
            this.label14.TabIndex = 86;
            this.label14.Text = "VISUALIZAR SALIDAS";
            // 
            // dtp_FechafSalida
            // 
            this.dtp_FechafSalida.BackColor = System.Drawing.Color.White;
            this.dtp_FechafSalida.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechafSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechafSalida.ForeColor = System.Drawing.Color.Black;
            this.dtp_FechafSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechafSalida.Location = new System.Drawing.Point(197, 57);
            this.dtp_FechafSalida.Name = "dtp_FechafSalida";
            this.dtp_FechafSalida.Size = new System.Drawing.Size(105, 20);
            this.dtp_FechafSalida.TabIndex = 85;
            this.dtp_FechafSalida.TabStop = false;
            // 
            // dtp_FechaiSalida
            // 
            this.dtp_FechaiSalida.BackColor = System.Drawing.Color.White;
            this.dtp_FechaiSalida.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechaiSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaiSalida.ForeColor = System.Drawing.Color.Black;
            this.dtp_FechaiSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaiSalida.Location = new System.Drawing.Point(72, 57);
            this.dtp_FechaiSalida.Name = "dtp_FechaiSalida";
            this.dtp_FechaiSalida.Size = new System.Drawing.Size(105, 20);
            this.dtp_FechaiSalida.TabIndex = 84;
            this.dtp_FechaiSalida.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(195, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 83;
            this.label12.Text = "FECHA FINAL:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(70, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 12);
            this.label13.TabIndex = 82;
            this.label13.Text = "FECHA INICIAL:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lb_Totalc);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btn_Registrar);
            this.panel3.Controls.Add(this.lb_Total);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_Peso);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_Nota);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtp_FechaSalida);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dtgv_Salida);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_Rollo);
            this.panel3.Controls.Add(this.cb_Uso);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 452);
            this.panel3.TabIndex = 7;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.White;
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btn_Registrar.FlatAppearance.BorderSize = 2;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.ForeColor = System.Drawing.Color.Black;
            this.btn_Registrar.Image = global::Interfaz.Properties.Resources.disquete__2_;
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Registrar.Location = new System.Drawing.Point(219, 360);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(88, 75);
            this.btn_Registrar.TabIndex = 88;
            this.btn_Registrar.TabStop = false;
            this.btn_Registrar.Text = "REGISTRAR";
            this.btn_Registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btn_Registrar, "Registrar");
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Total.Location = new System.Drawing.Point(70, 377);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(11, 13);
            this.lb_Total.TabIndex = 87;
            this.lb_Total.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 86;
            this.label11.Text = "TOTAL:";
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(170, 128);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(54, 20);
            this.txt_Peso.TabIndex = 1;
            this.txt_Peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Peso_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(0, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 85;
            this.label10.Text = "NOTA:";
            // 
            // txt_Nota
            // 
            this.txt_Nota.Location = new System.Drawing.Point(64, 90);
            this.txt_Nota.Name = "txt_Nota";
            this.txt_Nota.Size = new System.Drawing.Size(255, 33);
            this.txt_Nota.TabIndex = 84;
            this.txt_Nota.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkRed;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(85, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "REGISTRO DE SALIDA";
            // 
            // dtp_FechaSalida
            // 
            this.dtp_FechaSalida.BackColor = System.Drawing.Color.White;
            this.dtp_FechaSalida.CustomFormat = "dd/MM/yyyy";
            this.dtp_FechaSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaSalida.ForeColor = System.Drawing.Color.Black;
            this.dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FechaSalida.Location = new System.Drawing.Point(64, 38);
            this.dtp_FechaSalida.Name = "dtp_FechaSalida";
            this.dtp_FechaSalida.Size = new System.Drawing.Size(105, 20);
            this.dtp_FechaSalida.TabIndex = 82;
            this.dtp_FechaSalida.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 81;
            this.label8.Text = "FECHA:";
            // 
            // dtgv_Salida
            // 
            this.dtgv_Salida.AllowUserToAddRows = false;
            this.dtgv_Salida.AllowUserToDeleteRows = false;
            this.dtgv_Salida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Salida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Salida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollo,
            this.peso});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_Salida.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_Salida.Location = new System.Drawing.Point(3, 168);
            this.dtgv_Salida.MultiSelect = false;
            this.dtgv_Salida.Name = "dtgv_Salida";
            this.dtgv_Salida.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_Salida.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_Salida.RowHeadersWidth = 20;
            this.dtgv_Salida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_Salida.Size = new System.Drawing.Size(316, 186);
            this.dtgv_Salida.TabIndex = 6;
            this.dtgv_Salida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgv_Salida_KeyDown);
            // 
            // rollo
            // 
            this.rollo.HeaderText = "# ROLLO";
            this.rollo.Name = "rollo";
            this.rollo.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "USO:";
            // 
            // txt_Rollo
            // 
            this.txt_Rollo.Location = new System.Drawing.Point(64, 128);
            this.txt_Rollo.Name = "txt_Rollo";
            this.txt_Rollo.Size = new System.Drawing.Size(100, 20);
            this.txt_Rollo.TabIndex = 0;
            this.txt_Rollo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rollo_KeyPress);
            // 
            // cb_Uso
            // 
            this.cb_Uso.DropDownHeight = 60;
            this.cb_Uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Uso.FormattingEnabled = true;
            this.cb_Uso.IntegralHeight = false;
            this.cb_Uso.ItemHeight = 13;
            this.cb_Uso.Location = new System.Drawing.Point(64, 63);
            this.cb_Uso.Name = "cb_Uso";
            this.cb_Uso.Size = new System.Drawing.Size(255, 21);
            this.cb_Uso.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "# ROLLO:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 429);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(217, 12);
            this.label16.TabIndex = 91;
            this.label16.Text = "DOBLE CLICK EN SALIDA PARA EDITAR";
            // 
            // lb_Totalc
            // 
            this.lb_Totalc.AutoSize = true;
            this.lb_Totalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Totalc.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_Totalc.Location = new System.Drawing.Point(69, 399);
            this.lb_Totalc.Name = "lb_Totalc";
            this.lb_Totalc.Size = new System.Drawing.Size(11, 13);
            this.lb_Totalc.TabIndex = 90;
            this.lb_Totalc.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 399);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 89;
            this.label18.Text = "BOBINAS:";
            // 
            // txt_NoReporte
            // 
            this.txt_NoReporte.Location = new System.Drawing.Point(97, 67);
            this.txt_NoReporte.Name = "txt_NoReporte";
            this.txt_NoReporte.Size = new System.Drawing.Size(105, 18);
            this.txt_NoReporte.TabIndex = 5;
            this.txt_NoReporte.Validar = false;
            // 
            // frmControlAlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmControlAlm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL ALMACÉN ";
            this.Load += new System.EventHandler(this.frmControlAlm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Entradas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HistorialSalida)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Salida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgv_Entradas;
        private Controles.textbox txt_NoReporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_Fechaf;
        private System.Windows.Forms.DateTimePicker dtp_Fechai;
        private System.Windows.Forms.Button btn_InventarioDet;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_InventarioRes;
        private System.Windows.Forms.Button btn_VerEntrada;
        private System.Windows.Forms.ComboBox cb_Uso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txt_Nota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_FechaSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgv_Salida;
        private System.Windows.Forms.TextBox txt_Rollo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollo;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_VerSalida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_FechafSalida;
        private System.Windows.Forms.DateTimePicker dtp_FechaiSalida;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_BuscarSalida;
        private System.Windows.Forms.DataGridView dtgv_HistorialSalida;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_Totalc;
        private System.Windows.Forms.Label label18;
    }
}