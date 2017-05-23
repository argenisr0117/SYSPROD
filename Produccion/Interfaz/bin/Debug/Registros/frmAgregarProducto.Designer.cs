namespace Interfaz.Registros
{
    partial class frmAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarProducto));
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txttarjeta = new Interfaz.Controles.textboxceros(this.components);
            this.cbdestino = new Interfaz.Controles.comboboxar(this.components);
            this.cbmaquina = new Interfaz.Controles.comboboxar(this.components);
            this.cbproducto = new Interfaz.Controles.comboboxar(this.components);
            this.cbturno = new Interfaz.Controles.comboboxar(this.components);
            this.cbayudante = new Interfaz.Controles.comboboxar(this.components);
            this.cboperador = new Interfaz.Controles.comboboxar(this.components);
            this.cbsupervisor = new Interfaz.Controles.comboboxar(this.components);
            this.txtcantidad = new Interfaz.Controles.textboxN(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpfecha
            // 
            this.dtpfecha.BackColor = System.Drawing.Color.White;
            this.dtpfecha.CustomFormat = "MM/dd/yyyy";
            this.dtpfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.ForeColor = System.Drawing.Color.Black;
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(81, 66);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(120, 20);
            this.dtpfecha.TabIndex = 5;
            this.dtpfecha.Value = new System.DateTime(2016, 9, 8, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(5, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 113;
            this.label11.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(4, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 112;
            this.label12.Text = "Destino";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(4, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 111;
            this.label9.Text = "Máquina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 110;
            this.label10.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 109;
            this.label7.Text = "Tarjeta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(4, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 108;
            this.label8.Text = "Turno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(5, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Ayudante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 106;
            this.label6.Text = "Operador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "Supervisor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Fecha";
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
            this.btnbuscar.Location = new System.Drawing.Point(253, 228);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 124;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(19, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 53);
            this.panel2.TabIndex = 125;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Image = global::Interfaz.Properties.Resources.logout_icon;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(160, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(81, 51);
            this.btnsalir.TabIndex = 49;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnlimpiar.FlatAppearance.BorderSize = 2;
            this.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.Image = global::Interfaz.Properties.Resources.Clear_icon;
            this.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnlimpiar.Location = new System.Drawing.Point(80, 0);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(80, 51);
            this.btnlimpiar.TabIndex = 52;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.White;
            this.btnagregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnagregar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnagregar.FlatAppearance.BorderSize = 2;
            this.btnagregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Image = global::Interfaz.Properties.Resources.add_icon;
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(0, 0);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(80, 51);
            this.btnagregar.TabIndex = 48;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 126;
            this.label2.Text = "AGREGAR REGISTRO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-8, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 13);
            this.label5.TabIndex = 127;
            this.label5.Text = "__________________________________________________";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txttarjeta
            // 
            this.txttarjeta.Location = new System.Drawing.Point(81, 203);
            this.txttarjeta.Longitud = 7;
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.ReadOnly = true;
            this.txttarjeta.Size = new System.Drawing.Size(120, 20);
            this.txttarjeta.TabIndex = 0;
            this.txttarjeta.Validar = true;
            this.txttarjeta.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // cbdestino
            // 
            this.cbdestino.BackColor = System.Drawing.Color.Gainsboro;
            this.cbdestino.DropDownHeight = 60;
            this.cbdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdestino.FormattingEnabled = true;
            this.cbdestino.IntegralHeight = false;
            this.cbdestino.Location = new System.Drawing.Point(81, 288);
            this.cbdestino.Name = "cbdestino";
            this.cbdestino.Size = new System.Drawing.Size(111, 21);
            this.cbdestino.TabIndex = 8;
            this.cbdestino.Validar = true;
            // 
            // cbmaquina
            // 
            this.cbmaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cbmaquina.DropDownHeight = 60;
            this.cbmaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmaquina.FormattingEnabled = true;
            this.cbmaquina.IntegralHeight = false;
            this.cbmaquina.Location = new System.Drawing.Point(81, 258);
            this.cbmaquina.Name = "cbmaquina";
            this.cbmaquina.Size = new System.Drawing.Size(56, 21);
            this.cbmaquina.TabIndex = 7;
            this.cbmaquina.Validar = true;
            // 
            // cbproducto
            // 
            this.cbproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.cbproducto.DropDownHeight = 60;
            this.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.IntegralHeight = false;
            this.cbproducto.Location = new System.Drawing.Point(81, 229);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(153, 21);
            this.cbproducto.TabIndex = 6;
            this.cbproducto.Validar = true;
            // 
            // cbturno
            // 
            this.cbturno.BackColor = System.Drawing.Color.Gainsboro;
            this.cbturno.DropDownHeight = 60;
            this.cbturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbturno.FormattingEnabled = true;
            this.cbturno.IntegralHeight = false;
            this.cbturno.Location = new System.Drawing.Point(81, 174);
            this.cbturno.Name = "cbturno";
            this.cbturno.Size = new System.Drawing.Size(121, 21);
            this.cbturno.TabIndex = 4;
            this.cbturno.Validar = true;
            // 
            // cbayudante
            // 
            this.cbayudante.BackColor = System.Drawing.Color.Gainsboro;
            this.cbayudante.DropDownHeight = 60;
            this.cbayudante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbayudante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbayudante.FormattingEnabled = true;
            this.cbayudante.IntegralHeight = false;
            this.cbayudante.Location = new System.Drawing.Point(81, 147);
            this.cbayudante.Name = "cbayudante";
            this.cbayudante.Size = new System.Drawing.Size(180, 21);
            this.cbayudante.TabIndex = 3;
            this.cbayudante.Validar = true;
            // 
            // cboperador
            // 
            this.cboperador.BackColor = System.Drawing.Color.Gainsboro;
            this.cboperador.DropDownHeight = 60;
            this.cboperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboperador.FormattingEnabled = true;
            this.cboperador.IntegralHeight = false;
            this.cboperador.Location = new System.Drawing.Point(81, 119);
            this.cboperador.Name = "cboperador";
            this.cboperador.Size = new System.Drawing.Size(180, 21);
            this.cboperador.TabIndex = 2;
            this.cboperador.Validar = true;
            // 
            // cbsupervisor
            // 
            this.cbsupervisor.BackColor = System.Drawing.Color.Gainsboro;
            this.cbsupervisor.DropDownHeight = 60;
            this.cbsupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsupervisor.FormattingEnabled = true;
            this.cbsupervisor.IntegralHeight = false;
            this.cbsupervisor.Location = new System.Drawing.Point(81, 92);
            this.cbsupervisor.Name = "cbsupervisor";
            this.cbsupervisor.Size = new System.Drawing.Size(180, 21);
            this.cbsupervisor.TabIndex = 1;
            this.cbsupervisor.Validar = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.ForeColor = System.Drawing.Color.Black;
            this.txtcantidad.Location = new System.Drawing.Point(82, 318);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(110, 20);
            this.txtcantidad.TabIndex = 9;
            this.txtcantidad.Validar = true;
            this.txtcantidad.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 417);
            this.ControlBox = false;
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.cbdestino);
            this.Controls.Add(this.cbmaquina);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.cbturno);
            this.Controls.Add(this.cbayudante);
            this.Controls.Add(this.cboperador);
            this.Controls.Add(this.cbsupervisor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar;
        private Controles.textboxN txtcantidad;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controles.comboboxar cbsupervisor;
        private Controles.comboboxar cbdestino;
        private Controles.comboboxar cbmaquina;
        private Controles.comboboxar cbproducto;
        private Controles.comboboxar cbturno;
        private Controles.comboboxar cbayudante;
        private Controles.comboboxar cboperador;
        private Controles.textboxceros txttarjeta;
    }
}