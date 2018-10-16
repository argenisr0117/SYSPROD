namespace Interfaz.Registros
{
    partial class frmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurno));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.dtgvTurno = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHorainicio = new System.Windows.Forms.DateTimePicker();
            this.dtpHorafin = new System.Windows.Forms.DateTimePicker();
            this.dtpFinHEnt = new System.Windows.Forms.DateTimePicker();
            this.dtpFinHSal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioHsal = new System.Windows.Forms.DateTimePicker();
            this.cbHoraComida = new System.Windows.Forms.CheckBox();
            this.nupDuracion = new System.Windows.Forms.NumericUpDown();
            this.dtpIniciohent = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtturno = new Interfaz.Controles.textbox(this.components);
            this.txtabreviacion = new Interfaz.Controles.textbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuracion)).BeginInit();
            this.SuspendLayout();
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
            this.btneditar.Location = new System.Drawing.Point(392, 278);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(68, 32);
            this.btneditar.TabIndex = 11;
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
            this.btnsalir.Location = new System.Drawing.Point(392, 355);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 32);
            this.btnsalir.TabIndex = 13;
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
            this.btnactivar.Location = new System.Drawing.Point(392, 317);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(68, 32);
            this.btnactivar.TabIndex = 12;
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
            this.btnregistrar.Location = new System.Drawing.Point(392, 240);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(68, 32);
            this.btnregistrar.TabIndex = 10;
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
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            this.toolTip1.SetToolTip(this.label2, "Turno");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Turno";
            this.toolTip1.SetToolTip(this.label1, "Abreviación");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Hora Inicio";
            this.toolTip1.SetToolTip(this.label3, "Abreviación");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(97, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Hora Fin";
            this.toolTip1.SetToolTip(this.label7, "Abreviación");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(277, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Fin H. Ent";
            this.toolTip1.SetToolTip(this.label8, "Abreviación");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(187, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Inicio H. Ent.";
            this.toolTip1.SetToolTip(this.label9, "Abreviación");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(97, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Fin H. Sal.";
            this.toolTip1.SetToolTip(this.label10, "Abreviación");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 55;
            this.label11.Text = "Inicio H. Sal.";
            this.toolTip1.SetToolTip(this.label11, "Abreviación");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(319, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 15);
            this.label12.TabIndex = 61;
            this.label12.Text = "Duración (Hrs)";
            this.toolTip1.SetToolTip(this.label12, "Turno");
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
            this.cbestado.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.cbestado.Location = new System.Drawing.Point(392, 189);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(68, 21);
            this.cbestado.TabIndex = 14;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // dtgvTurno
            // 
            this.dtgvTurno.AllowUserToAddRows = false;
            this.dtgvTurno.AllowUserToDeleteRows = false;
            this.dtgvTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgvTurno.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTurno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTurno.Location = new System.Drawing.Point(10, 241);
            this.dtgvTurno.MultiSelect = false;
            this.dtgvTurno.Name = "dtgvTurno";
            this.dtgvTurno.ReadOnly = true;
            this.dtgvTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvTurno.RowHeadersWidth = 20;
            this.dtgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTurno.Size = new System.Drawing.Size(376, 262);
            this.dtgvTurno.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-5, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(475, 6);
            this.label6.TabIndex = 46;
            this.label6.Text = "_________________________________________________________________________________" +
    "_____________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(504, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "_______________________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(133, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "REGISTRO TURNOS";
            // 
            // dtpHorainicio
            // 
            this.dtpHorainicio.CustomFormat = "HH:mm";
            this.dtpHorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorainicio.Location = new System.Drawing.Point(10, 116);
            this.dtpHorainicio.Name = "dtpHorainicio";
            this.dtpHorainicio.ShowUpDown = true;
            this.dtpHorainicio.Size = new System.Drawing.Size(72, 20);
            this.dtpHorainicio.TabIndex = 3;
            // 
            // dtpHorafin
            // 
            this.dtpHorafin.CustomFormat = "HH:mm";
            this.dtpHorafin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorafin.Location = new System.Drawing.Point(100, 116);
            this.dtpHorafin.Name = "dtpHorafin";
            this.dtpHorafin.ShowUpDown = true;
            this.dtpHorafin.Size = new System.Drawing.Size(72, 20);
            this.dtpHorafin.TabIndex = 4;
            // 
            // dtpFinHEnt
            // 
            this.dtpFinHEnt.CustomFormat = "HH:mm";
            this.dtpFinHEnt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinHEnt.Location = new System.Drawing.Point(280, 116);
            this.dtpFinHEnt.Name = "dtpFinHEnt";
            this.dtpFinHEnt.ShowUpDown = true;
            this.dtpFinHEnt.Size = new System.Drawing.Size(72, 20);
            this.dtpFinHEnt.TabIndex = 6;
            // 
            // dtpFinHSal
            // 
            this.dtpFinHSal.CustomFormat = "HH:mm";
            this.dtpFinHSal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinHSal.Location = new System.Drawing.Point(100, 178);
            this.dtpFinHSal.Name = "dtpFinHSal";
            this.dtpFinHSal.ShowUpDown = true;
            this.dtpFinHSal.Size = new System.Drawing.Size(72, 20);
            this.dtpFinHSal.TabIndex = 8;
            // 
            // dtpInicioHsal
            // 
            this.dtpInicioHsal.CustomFormat = "HH:mm";
            this.dtpInicioHsal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioHsal.Location = new System.Drawing.Point(10, 178);
            this.dtpInicioHsal.Name = "dtpInicioHsal";
            this.dtpInicioHsal.ShowUpDown = true;
            this.dtpInicioHsal.Size = new System.Drawing.Size(72, 20);
            this.dtpInicioHsal.TabIndex = 7;
            // 
            // cbHoraComida
            // 
            this.cbHoraComida.AutoSize = true;
            this.cbHoraComida.Location = new System.Drawing.Point(370, 116);
            this.cbHoraComida.Name = "cbHoraComida";
            this.cbHoraComida.Size = new System.Drawing.Size(87, 17);
            this.cbHoraComida.TabIndex = 9;
            this.cbHoraComida.Text = "Hora Comida";
            this.cbHoraComida.UseVisualStyleBackColor = true;
            // 
            // nupDuracion
            // 
            this.nupDuracion.Location = new System.Drawing.Point(322, 58);
            this.nupDuracion.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nupDuracion.Name = "nupDuracion";
            this.nupDuracion.Size = new System.Drawing.Size(73, 20);
            this.nupDuracion.TabIndex = 2;
            this.toolTip1.SetToolTip(this.nupDuracion, "Cantidad de horas que dura el turno");
            // 
            // dtpIniciohent
            // 
            this.dtpIniciohent.CustomFormat = "HH:mm";
            this.dtpIniciohent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIniciohent.Location = new System.Drawing.Point(190, 116);
            this.dtpIniciohent.Name = "dtpIniciohent";
            this.dtpIniciohent.ShowUpDown = true;
            this.dtpIniciohent.Size = new System.Drawing.Size(72, 20);
            this.dtpIniciohent.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(207, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 30);
            this.label13.TabIndex = 62;
            this.label13.Text = "Formato de 24 Horas\r\nEj: 01:00 pm -> 13:00";
            this.toolTip1.SetToolTip(this.label13, "Turno");
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(100, 58);
            this.txtturno.Multiline = true;
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(204, 20);
            this.txtturno.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtturno, "Turno");
            this.txtturno.Validar = true;
            // 
            // txtabreviacion
            // 
            this.txtabreviacion.Location = new System.Drawing.Point(10, 58);
            this.txtabreviacion.Multiline = true;
            this.txtabreviacion.Name = "txtabreviacion";
            this.txtabreviacion.Size = new System.Drawing.Size(84, 20);
            this.txtabreviacion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtabreviacion, "Abreviación");
            this.txtabreviacion.Validar = true;
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 515);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpIniciohent);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.nupDuracion);
            this.Controls.Add(this.cbHoraComida);
            this.Controls.Add(this.dtpFinHSal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpInicioHsal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpFinHEnt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpHorafin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHorainicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.txtabreviacion);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dtgvTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDuracion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.DataGridView dtgvTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.textbox txtturno;
        private Controles.textbox txtabreviacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nupDuracion;
        private System.Windows.Forms.CheckBox cbHoraComida;
        private System.Windows.Forms.DateTimePicker dtpFinHSal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpInicioHsal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpFinHEnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpHorafin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHorainicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpIniciohent;
        private System.Windows.Forms.Label label13;
    }
}