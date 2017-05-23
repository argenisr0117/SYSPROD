namespace Interfaz.Registros
{
    partial class frmPuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuerto));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpeed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBaud = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Puerto Serial:";
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbPuerto.DropDownHeight = 80;
            this.cmbPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuerto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPuerto.ForeColor = System.Drawing.Color.Black;
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.IntegralHeight = false;
            this.cmbPuerto.ItemHeight = 13;
            this.cmbPuerto.Location = new System.Drawing.Point(181, 76);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(182, 21);
            this.cmbPuerto.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(57, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 68;
            this.label2.Text = "Baud Speed:";
            // 
            // cmbSpeed
            // 
            this.cmbSpeed.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbSpeed.DropDownHeight = 80;
            this.cmbSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpeed.ForeColor = System.Drawing.Color.Black;
            this.cmbSpeed.FormattingEnabled = true;
            this.cmbSpeed.IntegralHeight = false;
            this.cmbSpeed.ItemHeight = 13;
            this.cmbSpeed.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400 ",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbSpeed.Location = new System.Drawing.Point(181, 124);
            this.cmbSpeed.Name = "cmbSpeed";
            this.cmbSpeed.Size = new System.Drawing.Size(182, 21);
            this.cmbSpeed.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(73, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 26);
            this.label4.TabIndex = 69;
            this.label4.Text = "AJUSTES DE PUERTO SERIAL BALANZA";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(228, 170);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(89, 32);
            this.btnregistrar.TabIndex = 70;
            this.btnregistrar.Text = "Cambiar";
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(369, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 71;
            this.label3.Text = "ACTUAL:";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.BackColor = System.Drawing.Color.White;
            this.lbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.ForeColor = System.Drawing.Color.Black;
            this.lbPort.Location = new System.Drawing.Point(446, 76);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(0, 16);
            this.lbPort.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(369, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 73;
            this.label5.Text = "ACTUAL:";
            // 
            // lbBaud
            // 
            this.lbBaud.AutoSize = true;
            this.lbBaud.BackColor = System.Drawing.Color.White;
            this.lbBaud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbBaud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaud.ForeColor = System.Drawing.Color.Black;
            this.lbBaud.Location = new System.Drawing.Point(446, 124);
            this.lbBaud.Name = "lbBaud";
            this.lbBaud.Size = new System.Drawing.Size(0, 16);
            this.lbBaud.TabIndex = 74;
            // 
            // frmPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 223);
            this.Controls.Add(this.lbBaud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPuerto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmPuerto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBaud;
    }
}