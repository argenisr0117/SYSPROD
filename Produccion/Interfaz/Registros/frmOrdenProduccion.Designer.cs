namespace Interfaz.Registros
{
    partial class frmOrdenProduccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenProduccion));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new Interfaz.Controles.textbox(this.components);
            this.cmbDpto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxN1 = new Interfaz.Controles.textboxN(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 26);
            this.label2.TabIndex = 64;
            this.label2.Text = "REGISTRO ORDEN PRODUCCIÓN";
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
            this.btnBuscar.Location = new System.Drawing.Point(526, 149);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 24);
            this.btnBuscar.TabIndex = 137;
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
            this.cmbProducto.Location = new System.Drawing.Point(151, 148);
            this.cmbProducto.MaxDropDownItems = 30;
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(369, 26);
            this.cmbProducto.TabIndex = 136;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(50, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 135;
            this.label9.Text = "PRODUCTO:";
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
            this.cmbCliente.Location = new System.Drawing.Point(151, 179);
            this.cmbCliente.MaxDropDownItems = 30;
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(369, 26);
            this.cmbCliente.TabIndex = 134;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 133;
            this.label6.Text = "DEPARTAMENTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 138;
            this.label1.Text = "# ORDEN:";
            // 
            // textbox1
            // 
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.Location = new System.Drawing.Point(151, 89);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 22);
            this.textbox1.TabIndex = 139;
            this.textbox1.Validar = true;
            // 
            // cmbDpto
            // 
            this.cmbDpto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDpto.DropDownHeight = 160;
            this.cmbDpto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDpto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDpto.ForeColor = System.Drawing.Color.Black;
            this.cmbDpto.FormattingEnabled = true;
            this.cmbDpto.IntegralHeight = false;
            this.cmbDpto.Location = new System.Drawing.Point(151, 117);
            this.cmbDpto.MaxDropDownItems = 30;
            this.cmbDpto.Name = "cmbDpto";
            this.cmbDpto.Size = new System.Drawing.Size(369, 26);
            this.cmbDpto.TabIndex = 141;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 140;
            this.label3.Text = "CLIENTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 142;
            this.label4.Text = "CANTIDAD:";
            // 
            // textboxN1
            // 
            this.textboxN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxN1.Location = new System.Drawing.Point(151, 211);
            this.textboxN1.Name = "textboxN1";
            this.textboxN1.Size = new System.Drawing.Size(100, 22);
            this.textboxN1.TabIndex = 143;
            this.textboxN1.Validar = false;
            this.textboxN1.Valor = Interfaz.Controles.textboxN.Tipo.Números;
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
            this.btnLimpiar.Location = new System.Drawing.Point(272, 262);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 55);
            this.btnLimpiar.TabIndex = 145;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpiar.UseVisualStyleBackColor = false;
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
            this.btnRegistrar.Location = new System.Drawing.Point(163, 262);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 55);
            this.btnRegistrar.TabIndex = 144;
            this.btnRegistrar.TabStop = false;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegistrar.UseVisualStyleBackColor = false;
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
            this.btnSalir.Image = global::Interfaz.Properties.Resources.logout_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(381, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 55);
            this.btnSalir.TabIndex = 146;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmOrdenProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 329);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.textboxN1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmOrdenProduccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmOrdenProduccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Controles.textbox textbox1;
        private System.Windows.Forms.ComboBox cmbDpto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Controles.textboxN textboxN1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
    }
}