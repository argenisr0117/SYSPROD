namespace Interfaz.Consultas
{
    partial class frmcBuscarRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcBuscarRegistros));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbdestino = new Interfaz.Controles.comboboxar(this.components);
            this.cbproducto = new Interfaz.Controles.comboboxar(this.components);
            this.cbsupervisor = new Interfaz.Controles.comboboxar(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbmaquina = new Interfaz.Controles.comboboxar(this.components);
            this.txtcantidad = new Interfaz.Controles.textboxN(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnbuscar2 = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txttarjeta = new Interfaz.Controles.textboxN(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-14, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(547, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "_________________________________________________________________________________" +
    "_________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(171, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 128;
            this.label2.Text = "BUSCAR REGISTROS";
            // 
            // cbdestino
            // 
            this.cbdestino.BackColor = System.Drawing.Color.Gainsboro;
            this.cbdestino.DropDownHeight = 60;
            this.cbdestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbdestino.FormattingEnabled = true;
            this.cbdestino.IntegralHeight = false;
            this.cbdestino.Location = new System.Drawing.Point(87, 126);
            this.cbdestino.Name = "cbdestino";
            this.cbdestino.Size = new System.Drawing.Size(180, 21);
            this.cbdestino.TabIndex = 132;
            this.cbdestino.Validar = true;
            // 
            // cbproducto
            // 
            this.cbproducto.BackColor = System.Drawing.Color.Gainsboro;
            this.cbproducto.DropDownHeight = 60;
            this.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.IntegralHeight = false;
            this.cbproducto.Location = new System.Drawing.Point(87, 90);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(180, 21);
            this.cbproducto.TabIndex = 131;
            this.cbproducto.Validar = true;
            // 
            // cbsupervisor
            // 
            this.cbsupervisor.BackColor = System.Drawing.Color.Gainsboro;
            this.cbsupervisor.DropDownHeight = 60;
            this.cbsupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbsupervisor.FormattingEnabled = true;
            this.cbsupervisor.IntegralHeight = false;
            this.cbsupervisor.Location = new System.Drawing.Point(87, 54);
            this.cbsupervisor.Name = "cbsupervisor";
            this.cbsupervisor.Size = new System.Drawing.Size(180, 21);
            this.cbsupervisor.TabIndex = 130;
            this.cbsupervisor.Validar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(10, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 135;
            this.label12.Text = "Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(10, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 134;
            this.label10.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "Supervisor";
            // 
            // cbmaquina
            // 
            this.cbmaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cbmaquina.DropDownHeight = 60;
            this.cbmaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbmaquina.FormattingEnabled = true;
            this.cbmaquina.IntegralHeight = false;
            this.cbmaquina.Location = new System.Drawing.Point(86, 159);
            this.cbmaquina.Name = "cbmaquina";
            this.cbmaquina.Size = new System.Drawing.Size(79, 21);
            this.cbmaquina.TabIndex = 136;
            this.cbmaquina.Validar = true;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.ForeColor = System.Drawing.Color.Black;
            this.txtcantidad.Location = new System.Drawing.Point(85, 232);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(119, 20);
            this.txtcantidad.TabIndex = 137;
            this.txtcantidad.Validar = true;
            this.txtcantidad.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 139;
            this.label11.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 138;
            this.label9.Text = "Máquina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(8, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Tarjeta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnlimpiar);
            this.panel2.Controls.Add(this.btnbuscar2);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(263, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 52);
            this.panel2.TabIndex = 143;
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
            this.btnsalir.Location = new System.Drawing.Point(159, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(80, 50);
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
            this.btnlimpiar.Location = new System.Drawing.Point(79, 0);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(80, 50);
            this.btnlimpiar.TabIndex = 52;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar2
            // 
            this.btnbuscar2.BackColor = System.Drawing.Color.White;
            this.btnbuscar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnbuscar2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnbuscar2.FlatAppearance.BorderSize = 2;
            this.btnbuscar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnbuscar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnbuscar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar2.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar2.Image = global::Interfaz.Properties.Resources.search_b_icon;
            this.btnbuscar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar2.Location = new System.Drawing.Point(0, 0);
            this.btnbuscar2.Name = "btnbuscar2";
            this.btnbuscar2.Size = new System.Drawing.Size(79, 50);
            this.btnbuscar2.TabIndex = 53;
            this.btnbuscar2.Text = "Buscar";
            this.btnbuscar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar2.UseVisualStyleBackColor = false;
            this.btnbuscar2.Click += new System.EventHandler(this.btnbuscar2_Click);
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
            this.btnbuscar.Location = new System.Drawing.Point(273, 90);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(37, 21);
            this.btnbuscar.TabIndex = 142;
            this.btnbuscar.TabStop = false;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txttarjeta
            // 
            this.txttarjeta.Location = new System.Drawing.Point(87, 194);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.Size = new System.Drawing.Size(100, 20);
            this.txttarjeta.TabIndex = 144;
            this.txttarjeta.Validar = false;
            this.txttarjeta.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // frmcBuscarRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 286);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbmaquina);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbdestino);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.cbsupervisor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcBuscarRegistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmcBuscarRegistros_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Controles.comboboxar cbdestino;
        private Controles.comboboxar cbproducto;
        private Controles.comboboxar cbsupervisor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private Controles.comboboxar cbmaquina;
        private Controles.textboxN txtcantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnbuscar2;
        private Controles.textboxN txttarjeta;
    }
}