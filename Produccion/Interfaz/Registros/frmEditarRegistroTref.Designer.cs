namespace Interfaz.Registros
{
    partial class frmEditarRegistroTref
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarRegistroTref));
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCliente = new Interfaz.Controles.comboboxar(this.components);
            this.cmbMaquina = new Interfaz.Controles.comboboxar(this.components);
            this.cmbProducto = new Interfaz.Controles.comboboxar(this.components);
            this.cmbOperador = new Interfaz.Controles.comboboxar(this.components);
            this.cmbSupervisor = new Interfaz.Controles.comboboxar(this.components);
            this.txtPeso = new Interfaz.Controles.textboxN(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 139;
            this.label2.Text = "EDITAR REGISTRO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 16);
            this.label11.TabIndex = 138;
            this.label11.Text = "PESO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 137;
            this.label12.Text = "CLIENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 136;
            this.label9.Text = "MÁQUINA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(22, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 135;
            this.label10.Text = "PRODUCTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 134;
            this.label6.Text = "OPERADOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "SUPERVISOR";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Image = global::Interfaz.Properties.Resources.save_icon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(106, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 55);
            this.btnGuardar.TabIndex = 140;
            this.btnGuardar.TabStop = false;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(245, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 55);
            this.btnSalir.TabIndex = 141;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbCliente.DropDownHeight = 60;
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.IntegralHeight = false;
            this.cmbCliente.Location = new System.Drawing.Point(124, 180);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(272, 21);
            this.cmbCliente.TabIndex = 131;
            this.cmbCliente.Validar = true;
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbMaquina.DropDownHeight = 60;
            this.cmbMaquina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.IntegralHeight = false;
            this.cmbMaquina.Location = new System.Drawing.Point(124, 150);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(272, 21);
            this.cmbMaquina.TabIndex = 130;
            this.cmbMaquina.Validar = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbProducto.DropDownHeight = 60;
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.IntegralHeight = false;
            this.cmbProducto.Location = new System.Drawing.Point(124, 123);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(272, 21);
            this.cmbProducto.TabIndex = 129;
            this.cmbProducto.Validar = true;
            // 
            // cmbOperador
            // 
            this.cmbOperador.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbOperador.DropDownHeight = 60;
            this.cmbOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.IntegralHeight = false;
            this.cmbOperador.Location = new System.Drawing.Point(124, 94);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(272, 21);
            this.cmbOperador.TabIndex = 128;
            this.cmbOperador.Validar = true;
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSupervisor.DropDownHeight = 60;
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.IntegralHeight = false;
            this.cmbSupervisor.Location = new System.Drawing.Point(124, 63);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(272, 21);
            this.cmbSupervisor.TabIndex = 127;
            this.cmbSupervisor.Validar = true;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.White;
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.Location = new System.Drawing.Point(124, 209);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(272, 20);
            this.txtPeso.TabIndex = 132;
            this.txtPeso.Validar = true;
            this.txtPeso.Valor = Interfaz.Controles.textboxN.Tipo.Números;
            // 
            // frmEditarRegistroTref
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 338);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbMaquina);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.cmbSupervisor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarRegistroTref";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmEditarRegistroTref_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.comboboxar cmbCliente;
        private Controles.comboboxar cmbMaquina;
        private Controles.comboboxar cmbProducto;
        private Controles.comboboxar cmbOperador;
        private Controles.comboboxar cmbSupervisor;
        private System.Windows.Forms.Label label2;
        private Controles.textboxN txtPeso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}