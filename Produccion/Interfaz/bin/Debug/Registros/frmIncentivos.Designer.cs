namespace Interfaz.Registros
{
    partial class frmIncentivos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncentivos));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbdpto = new System.Windows.Forms.ComboBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvIncentivo = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.cbdpto2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cbmaquina = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbtipo2 = new System.Windows.Forms.ComboBox();
            this.txttarifa = new Interfaz.Controles.textboxN(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncentivo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "REGISTRO INCENTIVOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(588, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel1.Location = new System.Drawing.Point(12, 90);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 15);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Departamento";
            // 
            // cbdpto
            // 
            this.cbdpto.BackColor = System.Drawing.Color.Gainsboro;
            this.cbdpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdpto.ForeColor = System.Drawing.Color.Black;
            this.cbdpto.FormattingEnabled = true;
            this.cbdpto.ItemHeight = 13;
            this.cbdpto.Location = new System.Drawing.Point(104, 90);
            this.cbdpto.Name = "cbdpto";
            this.cbdpto.Size = new System.Drawing.Size(159, 21);
            this.cbdpto.TabIndex = 41;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Black;
            this.linkLabel2.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel2.Location = new System.Drawing.Point(12, 117);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(56, 15);
            this.linkLabel2.TabIndex = 44;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Producto";
            // 
            // cbproducto
            // 
            this.cbproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.cbproducto.DropDownHeight = 70;
            this.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbproducto.ForeColor = System.Drawing.Color.Black;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.IntegralHeight = false;
            this.cbproducto.ItemHeight = 13;
            this.cbproducto.Location = new System.Drawing.Point(104, 117);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(303, 21);
            this.cbproducto.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 62;
            this.label3.Text = "Tarifa";
            // 
            // dtgvIncentivo
            // 
            this.dtgvIncentivo.AllowUserToAddRows = false;
            this.dtgvIncentivo.AllowUserToDeleteRows = false;
            this.dtgvIncentivo.BackgroundColor = System.Drawing.Color.White;
            this.dtgvIncentivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvIncentivo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvIncentivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvIncentivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvIncentivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvIncentivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.tarifa,
            this.tipo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvIncentivo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvIncentivo.Location = new System.Drawing.Point(15, 316);
            this.dtgvIncentivo.MultiSelect = false;
            this.dtgvIncentivo.Name = "dtgvIncentivo";
            this.dtgvIncentivo.ReadOnly = true;
            this.dtgvIncentivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvIncentivo.RowHeadersWidth = 20;
            this.dtgvIncentivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvIncentivo.Size = new System.Drawing.Size(453, 212);
            this.dtgvIncentivo.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnactivar);
            this.panel1.Controls.Add(this.btneditar);
            this.panel1.Controls.Add(this.btnregistrar);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(474, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(88, 212);
            this.panel1.TabIndex = 64;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(0, 156);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(84, 52);
            this.btnsalir.TabIndex = 47;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.BackColor = System.Drawing.Color.White;
            this.btnactivar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnactivar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnactivar.FlatAppearance.BorderSize = 2;
            this.btnactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactivar.ForeColor = System.Drawing.Color.Black;
            this.btnactivar.Location = new System.Drawing.Point(0, 104);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(84, 52);
            this.btnactivar.TabIndex = 48;
            this.btnactivar.Text = "Act/Dact";
            this.btnactivar.UseVisualStyleBackColor = false;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btneditar.FlatAppearance.BorderSize = 2;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(0, 52);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(84, 52);
            this.btneditar.TabIndex = 46;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(0, 0);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(84, 52);
            this.btnregistrar.TabIndex = 45;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // cbdpto2
            // 
            this.cbdpto2.BackColor = System.Drawing.Color.Gainsboro;
            this.cbdpto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdpto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdpto2.ForeColor = System.Drawing.Color.Black;
            this.cbdpto2.FormattingEnabled = true;
            this.cbdpto2.ItemHeight = 13;
            this.cbdpto2.Location = new System.Drawing.Point(104, 278);
            this.cbdpto2.Name = "cbdpto2";
            this.cbdpto2.Size = new System.Drawing.Size(159, 21);
            this.cbdpto2.TabIndex = 66;
            this.cbdpto2.SelectedValueChanged += new System.EventHandler(this.cbdpto2_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(159, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 30);
            this.label4.TabIndex = 68;
            this.label4.Text = "FILTRAR INCENTIVOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-10, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "_________________________________________________________________________________" +
    "__";
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnbuscar.FlatAppearance.BorderSize = 2;
            this.btnbuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Image = global::Interfaz.Properties.Resources.Search_icon;
            this.btnbuscar.Location = new System.Drawing.Point(413, 117);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 104;
            this.btnbuscar.TabStop = false;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.cbestado.Location = new System.Drawing.Point(474, 279);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(86, 21);
            this.cbestado.TabIndex = 105;
            this.cbestado.SelectedValueChanged += new System.EventHandler(this.cbestado_SelectedValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbtipo
            // 
            this.cbtipo.BackColor = System.Drawing.Color.Gainsboro;
            this.cbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtipo.ForeColor = System.Drawing.Color.Black;
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.ItemHeight = 13;
            this.cbtipo.Items.AddRange(new object[] {
            "Producto",
            "Maquina"});
            this.cbtipo.Location = new System.Drawing.Point(321, 90);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(86, 21);
            this.cbtipo.TabIndex = 106;
            this.cbtipo.SelectedValueChanged += new System.EventHandler(this.cbtipo_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(284, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "Tipo";
            // 
            // producto
            // 
            this.producto.FillWeight = 99.49239F;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 325;
            // 
            // tarifa
            // 
            dataGridViewCellStyle2.Format = "C3";
            dataGridViewCellStyle2.NullValue = null;
            this.tarifa.DefaultCellStyle = dataGridViewCellStyle2;
            this.tarifa.FillWeight = 40F;
            this.tarifa.HeaderText = "Tarifa";
            this.tarifa.Name = "tarifa";
            this.tarifa.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.White;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.ForeColor = System.Drawing.Color.Black;
            this.linkLabel3.LinkColor = System.Drawing.Color.Firebrick;
            this.linkLabel3.Location = new System.Drawing.Point(12, 144);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(56, 15);
            this.linkLabel3.TabIndex = 109;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Máquina";
            // 
            // cbmaquina
            // 
            this.cbmaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cbmaquina.DropDownHeight = 80;
            this.cbmaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmaquina.ForeColor = System.Drawing.Color.Black;
            this.cbmaquina.FormattingEnabled = true;
            this.cbmaquina.IntegralHeight = false;
            this.cbmaquina.ItemHeight = 13;
            this.cbmaquina.Location = new System.Drawing.Point(104, 144);
            this.cbmaquina.Name = "cbmaquina";
            this.cbmaquina.Size = new System.Drawing.Size(159, 21);
            this.cbmaquina.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(294, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 111;
            this.label8.Text = "Tipo";
            // 
            // cbtipo2
            // 
            this.cbtipo2.BackColor = System.Drawing.Color.Gainsboro;
            this.cbtipo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtipo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtipo2.ForeColor = System.Drawing.Color.Black;
            this.cbtipo2.FormattingEnabled = true;
            this.cbtipo2.ItemHeight = 13;
            this.cbtipo2.Items.AddRange(new object[] {
            "Producto",
            "Maquina"});
            this.cbtipo2.Location = new System.Drawing.Point(331, 278);
            this.cbtipo2.Name = "cbtipo2";
            this.cbtipo2.Size = new System.Drawing.Size(86, 21);
            this.cbtipo2.TabIndex = 110;
            this.cbtipo2.SelectedValueChanged += new System.EventHandler(this.cbtipo2_SelectedValueChanged);
            // 
            // txttarifa
            // 
            this.txttarifa.Location = new System.Drawing.Point(104, 171);
            this.txttarifa.Multiline = true;
            this.txttarifa.Name = "txttarifa";
            this.txttarifa.Size = new System.Drawing.Size(100, 20);
            this.txttarifa.TabIndex = 61;
            this.txttarifa.Validar = true;
            this.txttarifa.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // frmIncentivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 540);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbtipo2);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.cbmaquina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbtipo);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbdpto2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvIncentivo);
            this.Controls.Add(this.txttarifa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cbdpto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIncentivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIncentivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvIncentivo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbdpto;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox cbproducto;
        private Controles.textboxN txttarifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgvIncentivo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cbdpto2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox cbmaquina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbtipo2;
    }
}