﻿namespace Interfaz
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbhora = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnproduccion = new System.Windows.Forms.Button();
            this.btnregistros = new System.Windows.Forms.Button();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIndustriaMenor = new System.Windows.Forms.Button();
            this.btnGalvanizado = new System.Windows.Forms.Button();
            this.btnTrefilado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbhora);
            this.panel1.Controls.Add(this.lbfecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 38);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACERO DEL CIBAO, S.R.L";
            // 
            // lbhora
            // 
            this.lbhora.AutoSize = true;
            this.lbhora.BackColor = System.Drawing.Color.Transparent;
            this.lbhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhora.ForeColor = System.Drawing.Color.Black;
            this.lbhora.Location = new System.Drawing.Point(512, 12);
            this.lbhora.Name = "lbhora";
            this.lbhora.Size = new System.Drawing.Size(34, 15);
            this.lbhora.TabIndex = 1;
            this.lbhora.Text = "Hora";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.BackColor = System.Drawing.Color.Transparent;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.ForeColor = System.Drawing.Color.Black;
            this.lbfecha.Location = new System.Drawing.Point(303, 12);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(41, 15);
            this.lbfecha.TabIndex = 0;
            this.lbfecha.Text = "Fecha";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "MENÚ PRINCIPAL";
            // 
            // btnproduccion
            // 
            this.btnproduccion.BackColor = System.Drawing.Color.Maroon;
            this.btnproduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproduccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnproduccion.FlatAppearance.BorderSize = 0;
            this.btnproduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduccion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduccion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnproduccion.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnproduccion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproduccion.Location = new System.Drawing.Point(0, 0);
            this.btnproduccion.Name = "btnproduccion";
            this.btnproduccion.Size = new System.Drawing.Size(153, 112);
            this.btnproduccion.TabIndex = 0;
            this.btnproduccion.Text = "Producción Diaria";
            this.btnproduccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproduccion.UseVisualStyleBackColor = false;
            this.btnproduccion.Click += new System.EventHandler(this.btnproduccion_Click);
            // 
            // btnregistros
            // 
            this.btnregistros.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnregistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregistros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnregistros.FlatAppearance.BorderSize = 0;
            this.btnregistros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistros.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnregistros.Image = global::Interfaz.Properties.Resources.icono_registro_converted1;
            this.btnregistros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregistros.Location = new System.Drawing.Point(153, 0);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(153, 112);
            this.btnregistros.TabIndex = 1;
            this.btnregistros.Text = "Registros Generales";
            this.btnregistros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnregistros.UseVisualStyleBackColor = false;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click);
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconsultas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsultas.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnconsultas.Image = global::Interfaz.Properties.Resources.printer3_converted1;
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnconsultas.Location = new System.Drawing.Point(306, 0);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(153, 112);
            this.btnconsultas.TabIndex = 2;
            this.btnconsultas.Text = "Consultas Generales";
            this.btnconsultas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.btnconsultas);
            this.panel2.Controls.Add(this.btnregistros);
            this.panel2.Controls.Add(this.btnproduccion);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(133, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 112);
            this.panel2.TabIndex = 1;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.Firebrick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.panel3.Controls.Add(this.btnIndustriaMenor);
            this.panel3.Controls.Add(this.btnGalvanizado);
            this.panel3.Controls.Add(this.btnTrefilado);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(133, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 112);
            this.panel3.TabIndex = 3;
            // 
            // btnIndustriaMenor
            // 
            this.btnIndustriaMenor.BackColor = System.Drawing.Color.Chocolate;
            this.btnIndustriaMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIndustriaMenor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIndustriaMenor.FlatAppearance.BorderSize = 0;
            this.btnIndustriaMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndustriaMenor.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndustriaMenor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIndustriaMenor.Image = global::Interfaz.Properties.Resources.printer3_converted1;
            this.btnIndustriaMenor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIndustriaMenor.Location = new System.Drawing.Point(306, 0);
            this.btnIndustriaMenor.Name = "btnIndustriaMenor";
            this.btnIndustriaMenor.Size = new System.Drawing.Size(153, 112);
            this.btnIndustriaMenor.TabIndex = 2;
            this.btnIndustriaMenor.Text = "Industria Menor";
            this.btnIndustriaMenor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndustriaMenor.UseVisualStyleBackColor = false;
            this.btnIndustriaMenor.Click += new System.EventHandler(this.btnIndustriaMenor_Click);
            // 
            // btnGalvanizado
            // 
            this.btnGalvanizado.BackColor = System.Drawing.Color.Indigo;
            this.btnGalvanizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGalvanizado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGalvanizado.FlatAppearance.BorderSize = 0;
            this.btnGalvanizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGalvanizado.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalvanizado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGalvanizado.Image = global::Interfaz.Properties.Resources.icono_registro_converted1;
            this.btnGalvanizado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGalvanizado.Location = new System.Drawing.Point(153, 0);
            this.btnGalvanizado.Name = "btnGalvanizado";
            this.btnGalvanizado.Size = new System.Drawing.Size(153, 112);
            this.btnGalvanizado.TabIndex = 1;
            this.btnGalvanizado.Text = "Galvanizado";
            this.btnGalvanizado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGalvanizado.UseVisualStyleBackColor = false;
            // 
            // btnTrefilado
            // 
            this.btnTrefilado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrefilado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrefilado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrefilado.FlatAppearance.BorderSize = 0;
            this.btnTrefilado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrefilado.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrefilado.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTrefilado.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnTrefilado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrefilado.Location = new System.Drawing.Point(0, 0);
            this.btnTrefilado.Name = "btnTrefilado";
            this.btnTrefilado.Size = new System.Drawing.Size(153, 112);
            this.btnTrefilado.TabIndex = 0;
            this.btnTrefilado.Text = "Trefilado";
            this.btnTrefilado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrefilado.UseVisualStyleBackColor = false;
            this.btnTrefilado.Click += new System.EventHandler(this.btnTrefilado_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbhora;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnproduccion;
        private System.Windows.Forms.Button btnregistros;
        private System.Windows.Forms.Button btnconsultas;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIndustriaMenor;
        private System.Windows.Forms.Button btnGalvanizado;
        private System.Windows.Forms.Button btnTrefilado;
    }
}