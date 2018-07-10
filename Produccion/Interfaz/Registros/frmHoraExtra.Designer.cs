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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvHorasExtra = new System.Windows.Forms.DataGridView();
            this.chbFeriado = new System.Windows.Forms.CheckBox();
            this.chbCorrido = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHorasExtra)).BeginInit();
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
            this.dtpHoraEntrada.ForeColor = System.Drawing.Color.Black;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(125, 169);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(174, 20);
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
            this.dtpHoraSalida.ForeColor = System.Drawing.Color.Black;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraSalida.Location = new System.Drawing.Point(125, 197);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(174, 20);
            this.dtpHoraSalida.TabIndex = 153;
            // 
            // panel1
            // 
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
            this.panel1.Size = new System.Drawing.Size(664, 230);
            this.panel1.TabIndex = 157;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvHorasExtra);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 312);
            this.panel2.TabIndex = 158;
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
            this.btnRegistrar.Location = new System.Drawing.Point(478, 109);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 55);
            this.btnRegistrar.TabIndex = 157;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 57);
            this.panel3.TabIndex = 0;
            // 
            // dtgvHorasExtra
            // 
            this.dtgvHorasExtra.AllowUserToAddRows = false;
            this.dtgvHorasExtra.AllowUserToDeleteRows = false;
            this.dtgvHorasExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHorasExtra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvHorasExtra.Location = new System.Drawing.Point(0, 57);
            this.dtgvHorasExtra.MultiSelect = false;
            this.dtgvHorasExtra.Name = "dtgvHorasExtra";
            this.dtgvHorasExtra.ReadOnly = true;
            this.dtgvHorasExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHorasExtra.Size = new System.Drawing.Size(664, 255);
            this.dtgvHorasExtra.TabIndex = 1;
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
            // frmHoraExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 542);
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
    }
}