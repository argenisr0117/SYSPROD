namespace Interfaz.Registros
{
    partial class frmPonche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPonche));
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONECTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCONECTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCARGARREGISTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARREGISTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALDEASISTENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hORASREGISTRADASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTEMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mANTTURNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNARTURNOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSIGNARPERMISOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROMANUALHORASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIASFERIADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RealTime_Dtg = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Attlog_Dtg = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealTime_Dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attlog_Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(0, 346);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(404, 186);
            this.lbSysOutputInfo.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.eMPLEADOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dispositivoToolStripMenuItem
            // 
            this.dispositivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONECTARToolStripMenuItem,
            this.dESCONECTARToolStripMenuItem,
            this.dESCARGARREGISTROSToolStripMenuItem,
            this.bORRARREGISTROSToolStripMenuItem});
            this.dispositivoToolStripMenuItem.Image = global::Interfaz.Properties.Resources.tap;
            this.dispositivoToolStripMenuItem.Name = "dispositivoToolStripMenuItem";
            this.dispositivoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dispositivoToolStripMenuItem.Text = "DISPOSITIVO";
            // 
            // cONECTARToolStripMenuItem
            // 
            this.cONECTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONECTARToolStripMenuItem.Image = global::Interfaz.Properties.Resources.power_button;
            this.cONECTARToolStripMenuItem.Name = "cONECTARToolStripMenuItem";
            this.cONECTARToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cONECTARToolStripMenuItem.Text = "CONECTAR";
            this.cONECTARToolStripMenuItem.Click += new System.EventHandler(this.cONECTARToolStripMenuItem_Click);
            // 
            // dESCONECTARToolStripMenuItem
            // 
            this.dESCONECTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCONECTARToolStripMenuItem.Image = global::Interfaz.Properties.Resources.power;
            this.dESCONECTARToolStripMenuItem.Name = "dESCONECTARToolStripMenuItem";
            this.dESCONECTARToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dESCONECTARToolStripMenuItem.Text = "DESCONECTAR";
            this.dESCONECTARToolStripMenuItem.Click += new System.EventHandler(this.dESCONECTARToolStripMenuItem_Click);
            // 
            // dESCARGARREGISTROSToolStripMenuItem
            // 
            this.dESCARGARREGISTROSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCARGARREGISTROSToolStripMenuItem.Image = global::Interfaz.Properties.Resources.file__1_;
            this.dESCARGARREGISTROSToolStripMenuItem.Name = "dESCARGARREGISTROSToolStripMenuItem";
            this.dESCARGARREGISTROSToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dESCARGARREGISTROSToolStripMenuItem.Text = "DESCARGAR REGISTROS";
            this.dESCARGARREGISTROSToolStripMenuItem.Click += new System.EventHandler(this.dESCARGARREGISTROSToolStripMenuItem_Click);
            // 
            // bORRARREGISTROSToolStripMenuItem
            // 
            this.bORRARREGISTROSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bORRARREGISTROSToolStripMenuItem.Image = global::Interfaz.Properties.Resources.file;
            this.bORRARREGISTROSToolStripMenuItem.Name = "bORRARREGISTROSToolStripMenuItem";
            this.bORRARREGISTROSToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bORRARREGISTROSToolStripMenuItem.Text = "BORRAR REGISTROS";
            this.bORRARREGISTROSToolStripMenuItem.Click += new System.EventHandler(this.bORRARREGISTROSToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hISTORIALDEASISTENCIAToolStripMenuItem,
            this.hORASREGISTRADASToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::Interfaz.Properties.Resources.Search_icon;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.reportesToolStripMenuItem.Text = "CONSULTAS";
            // 
            // hISTORIALDEASISTENCIAToolStripMenuItem
            // 
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Image = global::Interfaz.Properties.Resources.fingerprint_scanner;
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Name = "hISTORIALDEASISTENCIAToolStripMenuItem";
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Text = "HISTORIAL DE ASISTENCIA";
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Click += new System.EventHandler(this.hISTORIALDEASISTENCIAToolStripMenuItem_Click);
            // 
            // hORASREGISTRADASToolStripMenuItem
            // 
            this.hORASREGISTRADASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hORASREGISTRADASToolStripMenuItem.Image = global::Interfaz.Properties.Resources.calendar;
            this.hORASREGISTRADASToolStripMenuItem.Name = "hORASREGISTRADASToolStripMenuItem";
            this.hORASREGISTRADASToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hORASREGISTRADASToolStripMenuItem.Text = "HORAS REGISTRADAS";
            this.hORASREGISTRADASToolStripMenuItem.Click += new System.EventHandler(this.hORASREGISTRADASToolStripMenuItem_Click);
            // 
            // eMPLEADOToolStripMenuItem
            // 
            this.eMPLEADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTEMPToolStripMenuItem,
            this.mANTTURNOToolStripMenuItem,
            this.aSIGNARTURNOToolStripMenuItem,
            this.aSIGNARPERMISOSToolStripMenuItem,
            this.rEGISTROMANUALHORASToolStripMenuItem,
            this.dIASFERIADOSToolStripMenuItem});
            this.eMPLEADOToolStripMenuItem.Image = global::Interfaz.Properties.Resources.settings__1_;
            this.eMPLEADOToolStripMenuItem.Name = "eMPLEADOToolStripMenuItem";
            this.eMPLEADOToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.eMPLEADOToolStripMenuItem.Text = "MANTENIMIENTOS";
            // 
            // mANTEMPToolStripMenuItem
            // 
            this.mANTEMPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANTEMPToolStripMenuItem.Image = global::Interfaz.Properties.Resources.hired;
            this.mANTEMPToolStripMenuItem.Name = "mANTEMPToolStripMenuItem";
            this.mANTEMPToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.mANTEMPToolStripMenuItem.Text = "EMPLEADO";
            this.mANTEMPToolStripMenuItem.Click += new System.EventHandler(this.mANTEMPToolStripMenuItem_Click);
            // 
            // mANTTURNOToolStripMenuItem
            // 
            this.mANTTURNOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mANTTURNOToolStripMenuItem.Image = global::Interfaz.Properties.Resources.history;
            this.mANTTURNOToolStripMenuItem.Name = "mANTTURNOToolStripMenuItem";
            this.mANTTURNOToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.mANTTURNOToolStripMenuItem.Text = "TURNO";
            this.mANTTURNOToolStripMenuItem.Click += new System.EventHandler(this.mANTTURNOToolStripMenuItem_Click);
            // 
            // aSIGNARTURNOToolStripMenuItem
            // 
            this.aSIGNARTURNOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSIGNARTURNOToolStripMenuItem.Image = global::Interfaz.Properties.Resources.time__1_;
            this.aSIGNARTURNOToolStripMenuItem.Name = "aSIGNARTURNOToolStripMenuItem";
            this.aSIGNARTURNOToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aSIGNARTURNOToolStripMenuItem.Text = "ASIGNAR TURNO";
            this.aSIGNARTURNOToolStripMenuItem.Click += new System.EventHandler(this.aSIGNARTURNOToolStripMenuItem_Click);
            // 
            // aSIGNARPERMISOSToolStripMenuItem
            // 
            this.aSIGNARPERMISOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSIGNARPERMISOSToolStripMenuItem.Image = global::Interfaz.Properties.Resources.hospital;
            this.aSIGNARPERMISOSToolStripMenuItem.Name = "aSIGNARPERMISOSToolStripMenuItem";
            this.aSIGNARPERMISOSToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.aSIGNARPERMISOSToolStripMenuItem.Text = "ASIGNAR VAC, INC, PER, AUS";
            this.aSIGNARPERMISOSToolStripMenuItem.ToolTipText = "ASIGNAR VACACIONES, INCAPACIDADES, PERMISOS, AUSENCIAS";
            this.aSIGNARPERMISOSToolStripMenuItem.Click += new System.EventHandler(this.aSIGNARPERMISOSToolStripMenuItem_Click);
            // 
            // rEGISTROMANUALHORASToolStripMenuItem
            // 
            this.rEGISTROMANUALHORASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rEGISTROMANUALHORASToolStripMenuItem.Image = global::Interfaz.Properties.Resources.timeline;
            this.rEGISTROMANUALHORASToolStripMenuItem.Name = "rEGISTROMANUALHORASToolStripMenuItem";
            this.rEGISTROMANUALHORASToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.rEGISTROMANUALHORASToolStripMenuItem.Text = "REGISTRO MANUAL HORAS";
            this.rEGISTROMANUALHORASToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROMANUALHORASToolStripMenuItem_Click);
            // 
            // dIASFERIADOSToolStripMenuItem
            // 
            this.dIASFERIADOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dIASFERIADOSToolStripMenuItem.Image = global::Interfaz.Properties.Resources.wall_calendar;
            this.dIASFERIADOSToolStripMenuItem.Name = "dIASFERIADOSToolStripMenuItem";
            this.dIASFERIADOSToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.dIASFERIADOSToolStripMenuItem.Text = "DIAS FERIADOS";
            this.dIASFERIADOSToolStripMenuItem.Click += new System.EventHandler(this.dIASFERIADOSToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(285, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 30);
            this.label4.TabIndex = 45;
            this.label4.Text = "CONTROL DE ASISTENCIA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 41);
            this.panel1.TabIndex = 46;
            // 
            // RealTime_Dtg
            // 
            this.RealTime_Dtg.AllowUserToAddRows = false;
            this.RealTime_Dtg.AllowUserToDeleteRows = false;
            this.RealTime_Dtg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RealTime_Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RealTime_Dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.name,
            this.date});
            this.RealTime_Dtg.Location = new System.Drawing.Point(410, 346);
            this.RealTime_Dtg.Name = "RealTime_Dtg";
            this.RealTime_Dtg.ReadOnly = true;
            this.RealTime_Dtg.RowHeadersWidth = 10;
            this.RealTime_Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RealTime_Dtg.Size = new System.Drawing.Size(417, 186);
            this.RealTime_Dtg.TabIndex = 47;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 43;
            // 
            // name
            // 
            this.name.HeaderText = "NOMBRE";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // date
            // 
            this.date.HeaderText = "HORA PONCHE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ESTADO DEL DISPOSITIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(407, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "PONCHE EN TIEMPO REAL";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(841, 534);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 844;
            this.lineShape1.Y1 = 318;
            this.lineShape1.Y2 = 318;
            // 
            // Attlog_Dtg
            // 
            this.Attlog_Dtg.AllowUserToAddRows = false;
            this.Attlog_Dtg.AllowUserToDeleteRows = false;
            this.Attlog_Dtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Attlog_Dtg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Attlog_Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attlog_Dtg.Location = new System.Drawing.Point(410, 68);
            this.Attlog_Dtg.Name = "Attlog_Dtg";
            this.Attlog_Dtg.ReadOnly = true;
            this.Attlog_Dtg.RowHeadersWidth = 10;
            this.Attlog_Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Attlog_Dtg.Size = new System.Drawing.Size(417, 243);
            this.Attlog_Dtg.TabIndex = 52;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(54, 141);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(108, 25);
            this.dtpFecha.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(58, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 15);
            this.label3.TabIndex = 167;
            this.label3.Text = "CALCULAR REGISTRO DE HORAS TRABAJADAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 168;
            this.label5.Text = "DESDE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(228, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 170;
            this.label6.Text = "HASTA";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(276, 141);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(108, 25);
            this.dtpHasta.TabIndex = 169;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCalcular.FlatAppearance.BorderSize = 2;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.Black;
            this.btnCalcular.Image = global::Interfaz.Properties.Resources.save_icon;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(159, 238);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 51);
            this.btnCalcular.TabIndex = 166;
            this.btnCalcular.TabStop = false;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 171;
            this.label7.Text = "DEPARTAMENTO:";
            // 
            // cmbDpto
            // 
            this.cmbDpto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDpto.DropDownHeight = 160;
            this.cmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDpto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDpto.ForeColor = System.Drawing.Color.Black;
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.IntegralHeight = false;
            this.cmbDpto.Location = new System.Drawing.Point(111, 182);
            this.cmbDpto.MaxDropDownItems = 30;
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(273, 25);
            this.cmbDpto.TabIndex = 172;
            // 
            // frmPonche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 534);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDpto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.Attlog_Dtg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RealTime_Dtg);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSysOutputInfo);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPonche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPonche_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealTime_Dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attlog_Dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbSysOutputInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dispositivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView RealTime_Dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cONECTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCONECTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCARGARREGISTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARREGISTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDEASISTENCIAToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView Attlog_Dtg;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTEMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSIGNARTURNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSIGNARPERMISOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mANTTURNOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROMANUALHORASToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem hORASREGISTRADASToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ToolStripMenuItem dIASFERIADOSToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDpto;
    }
}