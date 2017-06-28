﻿namespace Interfaz.Consultas
{
    partial class frmcFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcFiltros));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioResumido = new System.Windows.Forms.RadioButton();
            this.radioDetallado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMaquina = new System.Windows.Forms.RadioButton();
            this.radioProducto = new System.Windows.Forms.RadioButton();
            this.radioOperador = new System.Windows.Forms.RadioButton();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 40);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "FILTROS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "FECHA INICIO:";
            // 
            // dtpdesde
            // 
            this.dtpdesde.BackColor = System.Drawing.Color.White;
            this.dtpdesde.CustomFormat = "dd/MM/yyyy";
            this.dtpdesde.ForeColor = System.Drawing.Color.Black;
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdesde.Location = new System.Drawing.Point(120, 56);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(103, 20);
            this.dtpdesde.TabIndex = 115;
            // 
            // dtphasta
            // 
            this.dtphasta.BackColor = System.Drawing.Color.White;
            this.dtphasta.CustomFormat = "dd/MM/yyyy";
            this.dtphasta.ForeColor = System.Drawing.Color.Black;
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtphasta.Location = new System.Drawing.Point(434, 57);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(103, 20);
            this.dtphasta.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(328, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 116;
            this.label1.Text = "FECHA FINAL:";
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
            this.cmbSupervisor.Location = new System.Drawing.Point(127, 93);
            this.cmbSupervisor.MaxDropDownItems = 30;
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(410, 26);
            this.cmbSupervisor.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "SUPERVISOR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "OPERADOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 121;
            this.label6.Text = "MAQUINA:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "CLIENTE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 123;
            this.label8.Text = "PRODUCTO:";
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
            this.cmbMaquina.Location = new System.Drawing.Point(127, 155);
            this.cmbMaquina.MaxDropDownItems = 30;
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(410, 26);
            this.cmbMaquina.TabIndex = 124;
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
            this.cmbOperador.Location = new System.Drawing.Point(127, 124);
            this.cmbOperador.MaxDropDownItems = 30;
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(410, 26);
            this.cmbOperador.TabIndex = 125;
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
            this.btnBuscar.Location = new System.Drawing.Point(500, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 24);
            this.btnBuscar.TabIndex = 134;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.cmbProducto.Location = new System.Drawing.Point(127, 183);
            this.cmbProducto.MaxDropDownItems = 30;
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(369, 26);
            this.cmbProducto.TabIndex = 133;
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
            this.cmbCliente.Location = new System.Drawing.Point(127, 211);
            this.cmbCliente.MaxDropDownItems = 30;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(410, 26);
            this.cmbCliente.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDetallado);
            this.groupBox1.Controls.Add(this.radioResumido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 42);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TIPO DE REPORTE";
            // 
            // radioResumido
            // 
            this.radioResumido.AutoSize = true;
            this.radioResumido.Location = new System.Drawing.Point(9, 19);
            this.radioResumido.Name = "radioResumido";
            this.radioResumido.Size = new System.Drawing.Size(91, 17);
            this.radioResumido.TabIndex = 0;
            this.radioResumido.TabStop = true;
            this.radioResumido.Text = "RESUMIDO";
            this.radioResumido.UseVisualStyleBackColor = true;
            // 
            // radioDetallado
            // 
            this.radioDetallado.AutoSize = true;
            this.radioDetallado.Location = new System.Drawing.Point(153, 19);
            this.radioDetallado.Name = "radioDetallado";
            this.radioDetallado.Size = new System.Drawing.Size(98, 17);
            this.radioDetallado.TabIndex = 1;
            this.radioDetallado.TabStop = true;
            this.radioDetallado.Text = "DETALLADO";
            this.radioDetallado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioOperador);
            this.groupBox2.Controls.Add(this.radioMaquina);
            this.groupBox2.Controls.Add(this.radioProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 51);
            this.groupBox2.TabIndex = 137;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AGRUPADO POR";
            // 
            // radioMaquina
            // 
            this.radioMaquina.AutoSize = true;
            this.radioMaquina.Location = new System.Drawing.Point(114, 19);
            this.radioMaquina.Name = "radioMaquina";
            this.radioMaquina.Size = new System.Drawing.Size(82, 17);
            this.radioMaquina.TabIndex = 1;
            this.radioMaquina.TabStop = true;
            this.radioMaquina.Text = "MAQUINA";
            this.radioMaquina.UseVisualStyleBackColor = true;
            // 
            // radioProducto
            // 
            this.radioProducto.AutoSize = true;
            this.radioProducto.Location = new System.Drawing.Point(6, 19);
            this.radioProducto.Name = "radioProducto";
            this.radioProducto.Size = new System.Drawing.Size(94, 17);
            this.radioProducto.TabIndex = 0;
            this.radioProducto.TabStop = true;
            this.radioProducto.Text = "PRODUCTO";
            this.radioProducto.UseVisualStyleBackColor = true;
            // 
            // radioOperador
            // 
            this.radioOperador.AutoSize = true;
            this.radioOperador.Location = new System.Drawing.Point(210, 19);
            this.radioOperador.Name = "radioOperador";
            this.radioOperador.Size = new System.Drawing.Size(94, 17);
            this.radioOperador.TabIndex = 2;
            this.radioOperador.TabStop = true;
            this.radioOperador.Text = "OPERADOR";
            this.radioOperador.UseVisualStyleBackColor = true;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.White;
            this.btnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnBusqueda.FlatAppearance.BorderSize = 2;
            this.btnBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.ForeColor = System.Drawing.Color.Black;
            this.btnBusqueda.Image = global::Interfaz.Properties.Resources.Search_icon1;
            this.btnBusqueda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusqueda.Location = new System.Drawing.Point(95, 348);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(107, 51);
            this.btnBusqueda.TabIndex = 138;
            this.btnBusqueda.TabStop = false;
            this.btnBusqueda.Text = "BUSCAR";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = global::Interfaz.Properties.Resources.salir_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(409, 348);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 51);
            this.btnSalir.TabIndex = 139;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::Interfaz.Properties.Resources.Clear_icon;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(252, 348);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 51);
            this.btnLimpiar.TabIndex = 140;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmcFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 411);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSupervisor);
            this.Controls.Add(this.dtphasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpdesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcFiltros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmcFiltros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.ComboBox cmbOperador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDetallado;
        private System.Windows.Forms.RadioButton radioResumido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioOperador;
        private System.Windows.Forms.RadioButton radioMaquina;
        private System.Windows.Forms.RadioButton radioProducto;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
    }
}