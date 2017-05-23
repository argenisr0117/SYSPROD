namespace Interfaz.Registros
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbdpto = new System.Windows.Forms.ComboBox();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbCargo = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtnombre = new Interfaz.Controles.textbox(this.components);
            this.txtcodigo = new Interfaz.Controles.textbox(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.dtgvEmpleado = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayudante = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.operador = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.supervisor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbempresa = new System.Windows.Forms.ComboBox();
            this.cbcargoi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel1.Location = new System.Drawing.Point(200, 51);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 33;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Departamento";
            this.toolTip1.SetToolTip(this.linkLabel1, "Agregar Departamento");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbdpto
            // 
            this.cbdpto.BackColor = System.Drawing.Color.Gainsboro;
            this.cbdpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdpto.ForeColor = System.Drawing.Color.Black;
            this.cbdpto.FormattingEnabled = true;
            this.cbdpto.ItemHeight = 13;
            this.cbdpto.Location = new System.Drawing.Point(280, 51);
            this.cbdpto.Name = "cbdpto";
            this.cbdpto.Size = new System.Drawing.Size(99, 21);
            this.cbdpto.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbdpto, "Departamento");
            this.cbdpto.DropDown += new System.EventHandler(this.cbdpto_DropDown);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btneditar.FlatAppearance.BorderSize = 2;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(519, 182);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(68, 32);
            this.btneditar.TabIndex = 25;
            this.btneditar.Text = "Editar";
            this.toolTip1.SetToolTip(this.btneditar, "Editar");
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(519, 259);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 32);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnsalir, "Salir");
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.BackColor = System.Drawing.Color.White;
            this.btnactivar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnactivar.FlatAppearance.BorderSize = 2;
            this.btnactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactivar.ForeColor = System.Drawing.Color.Black;
            this.btnactivar.Location = new System.Drawing.Point(519, 221);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(68, 32);
            this.btnactivar.TabIndex = 26;
            this.btnactivar.Text = "Act/Dact";
            this.toolTip1.SetToolTip(this.btnactivar, "Activar/Desactivar");
            this.btnactivar.UseVisualStyleBackColor = false;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(519, 144);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(68, 32);
            this.btnregistrar.TabIndex = 3;
            this.btnregistrar.Text = "Registrar";
            this.toolTip1.SetToolTip(this.btnregistrar, "Registrar");
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre Completo";
            this.toolTip1.SetToolTip(this.label2, "Nombre Completo");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código";
            this.toolTip1.SetToolTip(this.label1, "Código");
            // 
            // clbCargo
            // 
            this.clbCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbCargo.FormattingEnabled = true;
            this.clbCargo.Items.AddRange(new object[] {
            "Ayudante",
            "Operador",
            "Supervisor"});
            this.clbCargo.Location = new System.Drawing.Point(431, 53);
            this.clbCargo.Name = "clbCargo";
            this.clbCargo.Size = new System.Drawing.Size(82, 45);
            this.clbCargo.TabIndex = 36;
            this.toolTip1.SetToolTip(this.clbCargo, "Cargos");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(385, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cargos";
            this.toolTip1.SetToolTip(this.label3, "Cargos");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Empresa";
            this.toolTip1.SetToolTip(this.label7, "Empresa");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(262, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Cargo Indirecto";
            this.toolTip1.SetToolTip(this.label8, "Empresa");
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(123, 78);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(256, 20);
            this.txtnombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtnombre, "Nombre Completo");
            this.txtnombre.Validar = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(123, 52);
            this.txtcodigo.Multiline = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(68, 20);
            this.txtcodigo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtcodigo, "Código");
            this.txtcodigo.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.Gainsboro;
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbestado.ForeColor = System.Drawing.Color.Black;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.ItemHeight = 13;
            this.cbestado.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.cbestado.Location = new System.Drawing.Point(519, 103);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(68, 21);
            this.cbestado.TabIndex = 31;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // dtgvEmpleado
            // 
            this.dtgvEmpleado.AllowUserToAddRows = false;
            this.dtgvEmpleado.AllowUserToDeleteRows = false;
            this.dtgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.dpto,
            this.ayudante,
            this.operador,
            this.supervisor,
            this.estado,
            this.empresa,
            this.cargo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvEmpleado.Location = new System.Drawing.Point(9, 145);
            this.dtgvEmpleado.MultiSelect = false;
            this.dtgvEmpleado.Name = "dtgvEmpleado";
            this.dtgvEmpleado.ReadOnly = true;
            this.dtgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvEmpleado.RowHeadersWidth = 20;
            this.dtgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEmpleado.Size = new System.Drawing.Size(504, 147);
            this.dtgvEmpleado.TabIndex = 28;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigo.FillWeight = 50F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 65;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.FillWeight = 120F;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // dpto
            // 
            this.dpto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dpto.FillWeight = 70F;
            this.dpto.HeaderText = "Departamento";
            this.dpto.Name = "dpto";
            this.dpto.ReadOnly = true;
            this.dpto.Width = 99;
            // 
            // ayudante
            // 
            this.ayudante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ayudante.FillWeight = 50F;
            this.ayudante.HeaderText = "Ayudante";
            this.ayudante.Name = "ayudante";
            this.ayudante.ReadOnly = true;
            this.ayudante.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ayudante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ayudante.Width = 77;
            // 
            // operador
            // 
            this.operador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.operador.FillWeight = 50F;
            this.operador.HeaderText = "Operador";
            this.operador.Name = "operador";
            this.operador.ReadOnly = true;
            this.operador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.operador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.operador.Width = 76;
            // 
            // supervisor
            // 
            this.supervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.supervisor.FillWeight = 50F;
            this.supervisor.HeaderText = "Supervisor";
            this.supervisor.Name = "supervisor";
            this.supervisor.ReadOnly = true;
            this.supervisor.Width = 63;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.estado.FillWeight = 40F;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estado.Width = 65;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 73;
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo Ind.";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
            this.cargo.Width = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(159, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "REGISTRO EMPLEADOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-5, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(602, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(607, 6);
            this.label6.TabIndex = 40;
            this.label6.Text = "_________________________________________________________________________________" +
    "______________________________________________________________________";
            // 
            // cbempresa
            // 
            this.cbempresa.BackColor = System.Drawing.Color.Gainsboro;
            this.cbempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbempresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbempresa.ForeColor = System.Drawing.Color.Black;
            this.cbempresa.FormattingEnabled = true;
            this.cbempresa.ItemHeight = 13;
            this.cbempresa.Location = new System.Drawing.Point(123, 104);
            this.cbempresa.Name = "cbempresa";
            this.cbempresa.Size = new System.Drawing.Size(111, 21);
            this.cbempresa.TabIndex = 42;
            // 
            // cbcargoi
            // 
            this.cbcargoi.BackColor = System.Drawing.Color.Gainsboro;
            this.cbcargoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcargoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcargoi.ForeColor = System.Drawing.Color.Black;
            this.cbcargoi.FormattingEnabled = true;
            this.cbcargoi.ItemHeight = 13;
            this.cbcargoi.Items.AddRange(new object[] {
            "Mecánico",
            "Personal Indirecto",
            "Montacarguista",
            "Utility",
            "Supervisor General",
            "Indefinido"});
            this.cbcargoi.Location = new System.Drawing.Point(358, 103);
            this.cbcargoi.Name = "cbcargoi";
            this.cbcargoi.Size = new System.Drawing.Size(125, 21);
            this.cbcargoi.TabIndex = 44;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 306);
            this.Controls.Add(this.cbcargoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbempresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbCargo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.cbdpto);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dtgvEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolTip1.SetToolTip(this, "Registro Empleados");
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Controles.textbox txtnombre;
        private Controles.textbox txtcodigo;
        private System.Windows.Forms.ComboBox cbdpto;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.DataGridView dtgvEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbempresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbcargoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ayudante;
        private System.Windows.Forms.DataGridViewCheckBoxColumn operador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn supervisor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
    }
}