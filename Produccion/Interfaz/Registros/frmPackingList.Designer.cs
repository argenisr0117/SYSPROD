namespace Interfaz.Registros
{
    partial class frmPackingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingList));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUndSel = new Interfaz.Controles.textboxN(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdSel = new Interfaz.Controles.textboxN(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtUndDisp = new Interfaz.Controles.textboxN(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdDisp = new Interfaz.Controles.textboxN(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgSeleccionadas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAQUINA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Removeall_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Addall_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.dtgDisponibles = new System.Windows.Forms.DataGridView();
            this.fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtConduce = new Interfaz.Controles.textboxN(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.cmbUso = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.txtContenedor = new Interfaz.Controles.textbox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeleccionadas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibles)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 26);
            this.label2.TabIndex = 66;
            this.label2.Text = "GENERAR PACKING LIST";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "BOBINAS DISPONIBLES";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUndSel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProdSel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUndDisp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProdDisp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtgSeleccionadas);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgDisponibles);
            this.groupBox1.Location = new System.Drawing.Point(30, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 410);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // txtUndSel
            // 
            this.txtUndSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndSel.Location = new System.Drawing.Point(442, 374);
            this.txtUndSel.Name = "txtUndSel";
            this.txtUndSel.ReadOnly = true;
            this.txtUndSel.Size = new System.Drawing.Size(100, 21);
            this.txtUndSel.TabIndex = 77;
            this.txtUndSel.Validar = false;
            this.txtUndSel.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "TOTAL UND:";
            // 
            // txtProdSel
            // 
            this.txtProdSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdSel.Location = new System.Drawing.Point(442, 348);
            this.txtProdSel.Name = "txtProdSel";
            this.txtProdSel.ReadOnly = true;
            this.txtProdSel.Size = new System.Drawing.Size(100, 21);
            this.txtProdSel.TabIndex = 75;
            this.txtProdSel.Validar = false;
            this.txtProdSel.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "TOTAL QQS:";
            // 
            // txtUndDisp
            // 
            this.txtUndDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUndDisp.Location = new System.Drawing.Point(101, 374);
            this.txtUndDisp.Name = "txtUndDisp";
            this.txtUndDisp.ReadOnly = true;
            this.txtUndDisp.Size = new System.Drawing.Size(100, 21);
            this.txtUndDisp.TabIndex = 73;
            this.txtUndDisp.Validar = false;
            this.txtUndDisp.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "TOTAL UND:";
            // 
            // txtProdDisp
            // 
            this.txtProdDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDisp.Location = new System.Drawing.Point(101, 348);
            this.txtProdDisp.Name = "txtProdDisp";
            this.txtProdDisp.ReadOnly = true;
            this.txtProdDisp.Size = new System.Drawing.Size(100, 21);
            this.txtProdDisp.TabIndex = 71;
            this.txtProdDisp.Validar = false;
            this.txtProdDisp.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "TOTAL QQS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "BOBINAS SELECCIONADAS";
            // 
            // dtgSeleccionadas
            // 
            this.dtgSeleccionadas.AllowUserToAddRows = false;
            this.dtgSeleccionadas.AllowUserToDeleteRows = false;
            this.dtgSeleccionadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.tarjeta,
            this.peso,
            this.MAQUINA1,
            this.PRODUCTO,
            this.CLIENTE1});
            this.dtgSeleccionadas.Location = new System.Drawing.Point(354, 40);
            this.dtgSeleccionadas.MultiSelect = false;
            this.dtgSeleccionadas.Name = "dtgSeleccionadas";
            this.dtgSeleccionadas.ReadOnly = true;
            this.dtgSeleccionadas.RowHeadersWidth = 20;
            this.dtgSeleccionadas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgSeleccionadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSeleccionadas.Size = new System.Drawing.Size(264, 305);
            this.dtgSeleccionadas.TabIndex = 68;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // tarjeta
            // 
            this.tarjeta.HeaderText = "TARJETA";
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.HeaderText = "PESO(QQS)";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // MAQUINA1
            // 
            this.MAQUINA1.HeaderText = "MAQUINA";
            this.MAQUINA1.Name = "MAQUINA1";
            this.MAQUINA1.ReadOnly = true;
            this.MAQUINA1.Visible = false;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "CODIGO_PROD1";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.Visible = false;
            // 
            // CLIENTE1
            // 
            this.CLIENTE1.HeaderText = "CLIENTE";
            this.CLIENTE1.Name = "CLIENTE1";
            this.CLIENTE1.ReadOnly = true;
            this.CLIENTE1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Removeall_btn);
            this.panel1.Controls.Add(this.Remove_btn);
            this.panel1.Controls.Add(this.Addall_btn);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Location = new System.Drawing.Point(286, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 174);
            this.panel1.TabIndex = 66;
            // 
            // Removeall_btn
            // 
            this.Removeall_btn.BackColor = System.Drawing.Color.White;
            this.Removeall_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Removeall_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removeall_btn.Location = new System.Drawing.Point(0, 126);
            this.Removeall_btn.Name = "Removeall_btn";
            this.Removeall_btn.Size = new System.Drawing.Size(58, 42);
            this.Removeall_btn.TabIndex = 66;
            this.Removeall_btn.Text = "<<";
            this.Removeall_btn.UseVisualStyleBackColor = false;
            this.Removeall_btn.Click += new System.EventHandler(this.Removeall_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.BackColor = System.Drawing.Color.White;
            this.Remove_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remove_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.Location = new System.Drawing.Point(0, 84);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(58, 42);
            this.Remove_btn.TabIndex = 65;
            this.Remove_btn.Text = "<";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_btn_Click);
            // 
            // Addall_btn
            // 
            this.Addall_btn.BackColor = System.Drawing.Color.White;
            this.Addall_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Addall_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addall_btn.Location = new System.Drawing.Point(0, 42);
            this.Addall_btn.Name = "Addall_btn";
            this.Addall_btn.Size = new System.Drawing.Size(58, 42);
            this.Addall_btn.TabIndex = 64;
            this.Addall_btn.Text = ">>";
            this.Addall_btn.UseVisualStyleBackColor = false;
            this.Addall_btn.Click += new System.EventHandler(this.Addall_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.White;
            this.Add_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.Location = new System.Drawing.Point(0, 0);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(58, 42);
            this.Add_btn.TabIndex = 63;
            this.Add_btn.Text = ">";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // dtgDisponibles
            // 
            this.dtgDisponibles.AllowUserToAddRows = false;
            this.dtgDisponibles.AllowUserToDeleteRows = false;
            this.dtgDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha1,
            this.tarjeta1,
            this.peso1,
            this.maquina,
            this.CODIGO,
            this.CLIENTE});
            this.dtgDisponibles.Location = new System.Drawing.Point(16, 40);
            this.dtgDisponibles.MultiSelect = false;
            this.dtgDisponibles.Name = "dtgDisponibles";
            this.dtgDisponibles.ReadOnly = true;
            this.dtgDisponibles.RowHeadersWidth = 20;
            this.dtgDisponibles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDisponibles.Size = new System.Drawing.Size(264, 305);
            this.dtgDisponibles.TabIndex = 0;
            // 
            // fecha1
            // 
            this.fecha1.HeaderText = "FECHA";
            this.fecha1.Name = "fecha1";
            this.fecha1.ReadOnly = true;
            // 
            // tarjeta1
            // 
            this.tarjeta1.HeaderText = "TARJETA";
            this.tarjeta1.Name = "tarjeta1";
            this.tarjeta1.ReadOnly = true;
            // 
            // peso1
            // 
            this.peso1.HeaderText = "PESO(QQS)";
            this.peso1.Name = "peso1";
            this.peso1.ReadOnly = true;
            // 
            // maquina
            // 
            this.maquina.HeaderText = "MAQUINA";
            this.maquina.Name = "maquina";
            this.maquina.ReadOnly = true;
            this.maquina.Visible = false;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO_PROD";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Visible = false;
            // 
            // CLIENTE
            // 
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Visible = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnGenerar.FlatAppearance.BorderSize = 2;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.Black;
            this.btnGenerar.Image = global::Interfaz.Properties.Resources.Box_icon;
            this.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerar.Location = new System.Drawing.Point(297, 571);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 55);
            this.btnGenerar.TabIndex = 69;
            this.btnGenerar.TabStop = false;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtConduce);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbUso);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(this.cmbEmpresa);
            this.groupBox2.Controls.Add(this.cmbTamano);
            this.groupBox2.Controls.Add(this.txtContenedor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(30, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 107);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            // 
            // txtConduce
            // 
            this.txtConduce.Location = new System.Drawing.Point(514, 75);
            this.txtConduce.Name = "txtConduce";
            this.txtConduce.ReadOnly = true;
            this.txtConduce.Size = new System.Drawing.Size(100, 20);
            this.txtConduce.TabIndex = 147;
            this.txtConduce.Validar = false;
            this.txtConduce.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(428, 79);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 146;
            this.label14.Text = "#CONDUCE:";
            // 
            // cmbUso
            // 
            this.cmbUso.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbUso.DropDownHeight = 160;
            this.cmbUso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbUso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUso.ForeColor = System.Drawing.Color.Black;
            this.cmbUso.FormattingEnabled = true;
            this.cmbUso.IntegralHeight = false;
            this.cmbUso.Location = new System.Drawing.Point(120, 75);
            this.cmbUso.MaxDropDownItems = 30;
            this.cmbUso.Name = "cmbUso";
            this.cmbUso.Size = new System.Drawing.Size(302, 21);
            this.cmbUso.TabIndex = 144;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 143;
            this.label13.Text = "USO:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(342, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 142;
            this.label12.Text = "CLIENTE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(274, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "PIES";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCliente.DropDownHeight = 160;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCliente.ForeColor = System.Drawing.Color.Black;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.Location = new System.Drawing.Point(419, 41);
            this.cmbCliente.MaxDropDownItems = 30;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(199, 21);
            this.cmbCliente.TabIndex = 141;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEmpresa.DropDownHeight = 160;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.ForeColor = System.Drawing.Color.Black;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.IntegralHeight = false;
            this.cmbEmpresa.Location = new System.Drawing.Point(419, 14);
            this.cmbEmpresa.MaxDropDownItems = 30;
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(199, 21);
            this.cmbEmpresa.TabIndex = 118;
            // 
            // cmbTamano
            // 
            this.cmbTamano.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbTamano.DropDownHeight = 160;
            this.cmbTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamano.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTamano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamano.ForeColor = System.Drawing.Color.Black;
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.IntegralHeight = false;
            this.cmbTamano.Items.AddRange(new object[] {
            "20",
            "40"});
            this.cmbTamano.Location = new System.Drawing.Point(120, 43);
            this.cmbTamano.MaxDropDownItems = 30;
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(148, 21);
            this.cmbTamano.TabIndex = 117;
            // 
            // txtContenedor
            // 
            this.txtContenedor.Location = new System.Drawing.Point(120, 14);
            this.txtContenedor.Name = "txtContenedor";
            this.txtContenedor.Size = new System.Drawing.Size(190, 20);
            this.txtContenedor.TabIndex = 0;
            this.txtContenedor.Validar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "EMPRESA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "TAMAÑO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CONTENEDOR:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 639);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPackingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERAR PACKING LIST";
            this.Load += new System.EventHandler(this.frmPackingList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSeleccionadas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Removeall_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Addall_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.DataGridView dtgDisponibles;
        private Controles.textboxN txtUndSel;
        private System.Windows.Forms.Label label6;
        private Controles.textboxN txtProdSel;
        private System.Windows.Forms.Label label7;
        private Controles.textboxN txtUndDisp;
        private System.Windows.Forms.Label label5;
        private Controles.textboxN txtProdDisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgSeleccionadas;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQUINA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.GroupBox groupBox2;
        private Controles.textbox txtContenedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCliente;
        private Controles.textboxN txtConduce;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbUso;
        private System.Windows.Forms.Label label13;
    }
}