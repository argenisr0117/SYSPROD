namespace Interfaz.Registros
{
    partial class frmHoraExtra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoraExtra));
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbCorrido = new System.Windows.Forms.CheckBox();
            this.chbFeriado = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvHorasExtra = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDpto2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chbVacaciones = new System.Windows.Forms.RadioButton();
            this.chbIncapacidad = new System.Windows.Forms.RadioButton();
            this.chbInasistencia = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorasExtra)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDpto
            // 
            this.cmbDpto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDpto.DropDownHeight = 160;
            this.cmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDpto.ForeColor = System.Drawing.Color.Black;
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.IntegralHeight = false;
            this.cmbDpto.Location = new System.Drawing.Point(125, 68);
            this.cmbDpto.MaxDropDownItems = 30;
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(292, 28);
            this.cmbDpto.TabIndex = 143;
            this.cmbDpto.SelectedValueChanged += new System.EventHandler(this.cmbDpto_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 142;
            this.label6.Text = "DEPARTAMENTO:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEmpleado.DropDownHeight = 160;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.ForeColor = System.Drawing.Color.Black;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.IntegralHeight = false;
            this.cmbEmpleado.Location = new System.Drawing.Point(125, 101);
            this.cmbEmpleado.MaxDropDownItems = 30;
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(292, 28);
            this.cmbEmpleado.TabIndex = 147;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "EMPLEADO:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbTurno.DropDownHeight = 160;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.ForeColor = System.Drawing.Color.Black;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.IntegralHeight = false;
            this.cmbTurno.Location = new System.Drawing.Point(125, 134);
            this.cmbTurno.MaxDropDownItems = 30;
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(292, 28);
            this.cmbTurno.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 148;
            this.label1.Text = "TURNO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 26);
            this.label2.TabIndex = 150;
            this.label2.Text = "REGISTRO DE HORAS EXTRAS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 152;
            this.label15.Text = "HORA ENTRADA:";
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.BackColor = System.Drawing.Color.White;
            this.dtpHoraEntrada.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpHoraEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraEntrada.ForeColor = System.Drawing.Color.Black;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(125, 169);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(191, 22);
            this.dtpHoraEntrada.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 154;
            this.label3.Text = "HORA SALIDA:";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.BackColor = System.Drawing.Color.White;
            this.dtpHoraSalida.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpHoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraSalida.ForeColor = System.Drawing.Color.Black;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(125, 197);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(191, 22);
            this.dtpHoraSalida.TabIndex = 153;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.chbInasistencia);
            this.panel1.Controls.Add(this.chbIncapacidad);
            this.panel1.Controls.Add(this.chbVacaciones);
            this.panel1.Controls.Add(this.chbCorrido);
            this.panel1.Controls.Add(this.chbFeriado);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbDpto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpHoraSalida);
            this.panel1.Controls.Add(this.cmbEmpleado);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpHoraEntrada);
            this.panel1.Controls.Add(this.cmbTurno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 251);
            this.panel1.TabIndex = 157;
            // 
            // chbCorrido
            // 
            this.chbCorrido.AutoSize = true;
            this.chbCorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCorrido.Location = new System.Drawing.Point(558, 68);
            this.chbCorrido.Name = "chbCorrido";
            this.chbCorrido.Size = new System.Drawing.Size(89, 19);
            this.chbCorrido.TabIndex = 159;
            this.chbCorrido.Text = "CORRIDO";
            this.chbCorrido.UseVisualStyleBackColor = true;
            // 
            // chbFeriado
            // 
            this.chbFeriado.AutoSize = true;
            this.chbFeriado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFeriado.Location = new System.Drawing.Point(433, 68);
            this.chbFeriado.Name = "chbFeriado";
            this.chbFeriado.Size = new System.Drawing.Size(85, 19);
            this.chbFeriado.TabIndex = 158;
            this.chbFeriado.Text = "FERIADO";
            this.chbFeriado.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnRegistrar.FlatAppearance.BorderSize = 2;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = global::Interfaz.Properties.Resources.save_icon;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistrar.Location = new System.Drawing.Point(433, 159);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 55);
            this.btnRegistrar.TabIndex = 157;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvHorasExtra);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 251);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 347);
            this.panel2.TabIndex = 158;
            // 
            // dtgvHorasExtra
            // 
            this.dtgvHorasExtra.AllowUserToAddRows = false;
            this.dtgvHorasExtra.AllowUserToDeleteRows = false;
            this.dtgvHorasExtra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvHorasExtra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvHorasExtra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvHorasExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHorasExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHorasExtra.Location = new System.Drawing.Point(0, 128);
            this.dtgvHorasExtra.MultiSelect = false;
            this.dtgvHorasExtra.Name = "dtgvHorasExtra";
            this.dtgvHorasExtra.ReadOnly = true;
            this.dtgvHorasExtra.RowHeadersVisible = false;
            this.dtgvHorasExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHorasExtra.Size = new System.Drawing.Size(596, 219);
            this.dtgvHorasExtra.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(596, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 219);
            this.panel4.TabIndex = 2;
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
            this.btnEliminar.Location = new System.Drawing.Point(4, 63);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 55);
            this.btnEliminar.TabIndex = 166;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
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
            this.btnEditar.Location = new System.Drawing.Point(4, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 55);
            this.btnEditar.TabIndex = 165;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnReporte);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbEmpresa);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cmbDpto2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dtpFechaHasta);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dtpFechaDesde);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 128);
            this.panel3.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::Interfaz.Properties.Resources.Search_icon1;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(379, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 58);
            this.btnBuscar.TabIndex = 165;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnReporte.FlatAppearance.BorderSize = 2;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.Color.Black;
            this.btnReporte.Image = global::Interfaz.Properties.Resources.Show_all_icon;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReporte.Location = new System.Drawing.Point(466, 41);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(81, 58);
            this.btnReporte.TabIndex = 164;
            this.btnReporte.TabStop = false;
            this.btnReporte.Text = "REPORTE";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(132, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 161;
            this.label9.Text = "EMPRESA:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbEmpresa.DropDownHeight = 160;
            this.cmbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpresa.ForeColor = System.Drawing.Color.Black;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.IntegralHeight = false;
            this.cmbEmpresa.Location = new System.Drawing.Point(132, 35);
            this.cmbEmpresa.MaxDropDownItems = 30;
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(236, 28);
            this.cmbEmpresa.TabIndex = 162;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(132, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 159;
            this.label8.Text = "DEPARTAMENTO:";
            // 
            // cmbDpto2
            // 
            this.cmbDpto2.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDpto2.DropDownHeight = 160;
            this.cmbDpto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDpto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDpto2.ForeColor = System.Drawing.Color.Black;
            this.cmbDpto2.FormattingEnabled = true;
            this.cmbDpto2.IntegralHeight = false;
            this.cmbDpto2.Location = new System.Drawing.Point(132, 82);
            this.cmbDpto2.MaxDropDownItems = 30;
            this.cmbDpto2.Name = "cmbDpto2";
            this.cmbDpto2.Size = new System.Drawing.Size(236, 28);
            this.cmbDpto2.TabIndex = 160;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 158;
            this.label4.Text = "HASTA:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.BackColor = System.Drawing.Color.White;
            this.dtpFechaHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Location = new System.Drawing.Point(7, 82);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaHasta.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "DESDE:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.BackColor = System.Drawing.Color.White;
            this.dtpFechaDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.ForeColor = System.Drawing.Color.Black;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesde.Location = new System.Drawing.Point(7, 35);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(109, 22);
            this.dtpFechaDesde.TabIndex = 155;
            // 
            // chbVacaciones
            // 
            this.chbVacaciones.AutoSize = true;
            this.chbVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVacaciones.Location = new System.Drawing.Point(433, 93);
            this.chbVacaciones.Name = "chbVacaciones";
            this.chbVacaciones.Size = new System.Drawing.Size(103, 17);
            this.chbVacaciones.TabIndex = 160;
            this.chbVacaciones.TabStop = true;
            this.chbVacaciones.Text = "VACACIONES";
            this.chbVacaciones.UseVisualStyleBackColor = true;
            // 
            // chbIncapacidad
            // 
            this.chbIncapacidad.AutoSize = true;
            this.chbIncapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIncapacidad.Location = new System.Drawing.Point(433, 116);
            this.chbIncapacidad.Name = "chbIncapacidad";
            this.chbIncapacidad.Size = new System.Drawing.Size(108, 17);
            this.chbIncapacidad.TabIndex = 161;
            this.chbIncapacidad.TabStop = true;
            this.chbIncapacidad.Text = "INCAPACIDAD";
            this.chbIncapacidad.UseVisualStyleBackColor = true;
            // 
            // chbInasistencia
            // 
            this.chbInasistencia.AutoSize = true;
            this.chbInasistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbInasistencia.Location = new System.Drawing.Point(558, 89);
            this.chbInasistencia.Name = "chbInasistencia";
            this.chbInasistencia.Size = new System.Drawing.Size(111, 17);
            this.chbInasistencia.TabIndex = 162;
            this.chbInasistencia.TabStop = true;
            this.chbInasistencia.Text = "INASISTENCIA";
            this.chbInasistencia.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::Interfaz.Properties.Resources.salir_icon;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(558, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 55);
            this.btnCancelar.TabIndex = 163;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 598);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHoraExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO HORAS EXTRAS";
            this.Load += new System.EventHandler(this.frmHoraExtra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorasExtra)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDpto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dtgvHorasExtra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chbCorrido;
        private System.Windows.Forms.CheckBox chbFeriado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDpto2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton chbInasistencia;
        private System.Windows.Forms.RadioButton chbIncapacidad;
        private System.Windows.Forms.RadioButton chbVacaciones;
        private System.Windows.Forms.Button btnCancelar;
    }
}