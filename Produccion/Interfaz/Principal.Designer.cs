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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnconsultas = new System.Windows.Forms.Button();
            this.btnregistros = new System.Windows.Forms.Button();
            this.btnproduccion = new System.Windows.Forms.Button();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIndustriaMenor = new System.Windows.Forms.Button();
            this.btnGalvanizado = new System.Windows.Forms.Button();
            this.btnTrefilado = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerPruebasCald = new System.Windows.Forms.Button();
            this.btnPruebasCalidad = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAlmacenLineaGalv = new System.Windows.Forms.Button();
            this.btnAlmacenTerminados = new System.Windows.Forms.Button();
            this.btnAlmacenIntermedios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbhora);
            this.panel1.Controls.Add(this.lbfecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 38);
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
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "MENÚ PRINCIPAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel2.Controls.Add(this.btnconsultas);
            this.panel2.Controls.Add(this.btnregistros);
            this.panel2.Controls.Add(this.btnproduccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 112);
            this.panel2.TabIndex = 1;
            // 
            // btnconsultas
            // 
            this.btnconsultas.BackColor = System.Drawing.Color.Gray;
            this.btnconsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconsultas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnconsultas.FlatAppearance.BorderSize = 0;
            this.btnconsultas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsultas.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsultas.ForeColor = System.Drawing.Color.White;
            this.btnconsultas.Image = global::Interfaz.Properties.Resources.la_busqueda_de_empleo;
            this.btnconsultas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnconsultas.Location = new System.Drawing.Point(400, 0);
            this.btnconsultas.Name = "btnconsultas";
            this.btnconsultas.Size = new System.Drawing.Size(200, 112);
            this.btnconsultas.TabIndex = 2;
            this.btnconsultas.Text = "Consultas Generales";
            this.btnconsultas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnconsultas.UseVisualStyleBackColor = false;
            this.btnconsultas.Click += new System.EventHandler(this.btnconsultas_Click);
            // 
            // btnregistros
            // 
            this.btnregistros.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnregistros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregistros.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnregistros.FlatAppearance.BorderSize = 0;
            this.btnregistros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistros.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistros.ForeColor = System.Drawing.Color.White;
            this.btnregistros.Image = global::Interfaz.Properties.Resources.icono_registro_converted1;
            this.btnregistros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnregistros.Location = new System.Drawing.Point(200, 0);
            this.btnregistros.Name = "btnregistros";
            this.btnregistros.Size = new System.Drawing.Size(200, 112);
            this.btnregistros.TabIndex = 1;
            this.btnregistros.Text = "Registros Generales";
            this.btnregistros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnregistros.UseVisualStyleBackColor = false;
            this.btnregistros.Click += new System.EventHandler(this.btnregistros_Click);
            // 
            // btnproduccion
            // 
            this.btnproduccion.BackColor = System.Drawing.Color.DarkRed;
            this.btnproduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproduccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnproduccion.FlatAppearance.BorderSize = 0;
            this.btnproduccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnproduccion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduccion.ForeColor = System.Drawing.Color.White;
            this.btnproduccion.Image = global::Interfaz.Properties.Resources.trabajador_de_ordenador_en_vista_posterior;
            this.btnproduccion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproduccion.Location = new System.Drawing.Point(0, 0);
            this.btnproduccion.Name = "btnproduccion";
            this.btnproduccion.Size = new System.Drawing.Size(200, 112);
            this.btnproduccion.TabIndex = 0;
            this.btnproduccion.Text = "Producción Diaria";
            this.btnproduccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproduccion.UseVisualStyleBackColor = false;
            this.btnproduccion.Click += new System.EventHandler(this.btnproduccion_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.Firebrick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel3.Controls.Add(this.btnIndustriaMenor);
            this.panel3.Controls.Add(this.btnGalvanizado);
            this.panel3.Controls.Add(this.btnTrefilado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 112);
            this.panel3.TabIndex = 3;
            // 
            // btnIndustriaMenor
            // 
            this.btnIndustriaMenor.BackColor = System.Drawing.Color.Peru;
            this.btnIndustriaMenor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIndustriaMenor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIndustriaMenor.FlatAppearance.BorderSize = 0;
            this.btnIndustriaMenor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIndustriaMenor.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndustriaMenor.ForeColor = System.Drawing.Color.White;
            this.btnIndustriaMenor.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnIndustriaMenor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIndustriaMenor.Location = new System.Drawing.Point(400, 0);
            this.btnIndustriaMenor.Name = "btnIndustriaMenor";
            this.btnIndustriaMenor.Size = new System.Drawing.Size(200, 112);
            this.btnIndustriaMenor.TabIndex = 2;
            this.btnIndustriaMenor.Text = "Industria Menor";
            this.btnIndustriaMenor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIndustriaMenor.UseVisualStyleBackColor = false;
            this.btnIndustriaMenor.Click += new System.EventHandler(this.btnIndustriaMenor_Click);
            // 
            // btnGalvanizado
            // 
            this.btnGalvanizado.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGalvanizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGalvanizado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGalvanizado.FlatAppearance.BorderSize = 0;
            this.btnGalvanizado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGalvanizado.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGalvanizado.ForeColor = System.Drawing.Color.White;
            this.btnGalvanizado.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnGalvanizado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGalvanizado.Location = new System.Drawing.Point(200, 0);
            this.btnGalvanizado.Name = "btnGalvanizado";
            this.btnGalvanizado.Size = new System.Drawing.Size(200, 112);
            this.btnGalvanizado.TabIndex = 1;
            this.btnGalvanizado.Text = "Galvanizado";
            this.btnGalvanizado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGalvanizado.UseVisualStyleBackColor = false;
            this.btnGalvanizado.Click += new System.EventHandler(this.btnGalvanizado_Click);
            // 
            // btnTrefilado
            // 
            this.btnTrefilado.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTrefilado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrefilado.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrefilado.FlatAppearance.BorderSize = 0;
            this.btnTrefilado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrefilado.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrefilado.ForeColor = System.Drawing.Color.White;
            this.btnTrefilado.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnTrefilado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrefilado.Location = new System.Drawing.Point(0, 0);
            this.btnTrefilado.Name = "btnTrefilado";
            this.btnTrefilado.Size = new System.Drawing.Size(200, 112);
            this.btnTrefilado.TabIndex = 0;
            this.btnTrefilado.Text = "Trefilado";
            this.btnTrefilado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrefilado.UseVisualStyleBackColor = false;
            this.btnTrefilado.Click += new System.EventHandler(this.btnTrefilado_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.btnVerPruebasCald);
            this.panel4.Controls.Add(this.btnPruebasCalidad);
            this.panel4.Controls.Add(this.btnOrden);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 112);
            this.panel4.TabIndex = 4;
            // 
            // btnVerPruebasCald
            // 
            this.btnVerPruebasCald.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnVerPruebasCald.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVerPruebasCald.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVerPruebasCald.FlatAppearance.BorderSize = 0;
            this.btnVerPruebasCald.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPruebasCald.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPruebasCald.ForeColor = System.Drawing.Color.White;
            this.btnVerPruebasCald.Image = global::Interfaz.Properties.Resources.visualizacion;
            this.btnVerPruebasCald.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerPruebasCald.Location = new System.Drawing.Point(400, 0);
            this.btnVerPruebasCald.Name = "btnVerPruebasCald";
            this.btnVerPruebasCald.Size = new System.Drawing.Size(200, 112);
            this.btnVerPruebasCald.TabIndex = 2;
            this.btnVerPruebasCald.Text = "Visualizar Pruebas Calidad";
            this.btnVerPruebasCald.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVerPruebasCald.UseVisualStyleBackColor = false;
            this.btnVerPruebasCald.Click += new System.EventHandler(this.btnVerPruebasCald_Click);
            // 
            // btnPruebasCalidad
            // 
            this.btnPruebasCalidad.BackColor = System.Drawing.Color.Maroon;
            this.btnPruebasCalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPruebasCalidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPruebasCalidad.FlatAppearance.BorderSize = 0;
            this.btnPruebasCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPruebasCalidad.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruebasCalidad.ForeColor = System.Drawing.Color.White;
            this.btnPruebasCalidad.Image = global::Interfaz.Properties.Resources.proddiaria_converted;
            this.btnPruebasCalidad.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPruebasCalidad.Location = new System.Drawing.Point(200, 0);
            this.btnPruebasCalidad.Name = "btnPruebasCalidad";
            this.btnPruebasCalidad.Size = new System.Drawing.Size(200, 112);
            this.btnPruebasCalidad.TabIndex = 1;
            this.btnPruebasCalidad.Text = "Registro Pruebas Calidad";
            this.btnPruebasCalidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPruebasCalidad.UseVisualStyleBackColor = false;
            this.btnPruebasCalidad.Click += new System.EventHandler(this.btnPruebasCalidad_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrden.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOrden.FlatAppearance.BorderSize = 0;
            this.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrden.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrden.ForeColor = System.Drawing.Color.White;
            this.btnOrden.Image = global::Interfaz.Properties.Resources.soporte_de_red_de_trabajo;
            this.btnOrden.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrden.Location = new System.Drawing.Point(0, 0);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(200, 112);
            this.btnOrden.TabIndex = 0;
            this.btnOrden.Text = "Orden Producción";
            this.btnOrden.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrden.UseVisualStyleBackColor = false;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(161, 71);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 450);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.panel6.Controls.Add(this.btnAlmacenLineaGalv);
            this.panel6.Controls.Add(this.btnAlmacenTerminados);
            this.panel6.Controls.Add(this.btnAlmacenIntermedios);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 336);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 112);
            this.panel6.TabIndex = 5;
            // 
            // btnAlmacenLineaGalv
            // 
            this.btnAlmacenLineaGalv.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnAlmacenLineaGalv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlmacenLineaGalv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlmacenLineaGalv.FlatAppearance.BorderSize = 0;
            this.btnAlmacenLineaGalv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacenLineaGalv.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenLineaGalv.ForeColor = System.Drawing.Color.White;
            this.btnAlmacenLineaGalv.Image = global::Interfaz.Properties.Resources.almacen;
            this.btnAlmacenLineaGalv.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlmacenLineaGalv.Location = new System.Drawing.Point(400, 0);
            this.btnAlmacenLineaGalv.Name = "btnAlmacenLineaGalv";
            this.btnAlmacenLineaGalv.Size = new System.Drawing.Size(200, 112);
            this.btnAlmacenLineaGalv.TabIndex = 2;
            this.btnAlmacenLineaGalv.Text = "Almacén Linea Galv.";
            this.btnAlmacenLineaGalv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlmacenLineaGalv.UseVisualStyleBackColor = false;
            this.btnAlmacenLineaGalv.Click += new System.EventHandler(this.btnAlmacenLineaGalv_Click);
            // 
            // btnAlmacenTerminados
            // 
            this.btnAlmacenTerminados.BackColor = System.Drawing.Color.Olive;
            this.btnAlmacenTerminados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlmacenTerminados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlmacenTerminados.FlatAppearance.BorderSize = 0;
            this.btnAlmacenTerminados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacenTerminados.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenTerminados.ForeColor = System.Drawing.Color.White;
            this.btnAlmacenTerminados.Image = global::Interfaz.Properties.Resources.almacen__1_;
            this.btnAlmacenTerminados.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlmacenTerminados.Location = new System.Drawing.Point(200, 0);
            this.btnAlmacenTerminados.Name = "btnAlmacenTerminados";
            this.btnAlmacenTerminados.Size = new System.Drawing.Size(200, 112);
            this.btnAlmacenTerminados.TabIndex = 1;
            this.btnAlmacenTerminados.Text = "Almacén Terminados";
            this.btnAlmacenTerminados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlmacenTerminados.UseVisualStyleBackColor = false;
            this.btnAlmacenTerminados.Click += new System.EventHandler(this.btnAlmacenTerminados_Click);
            // 
            // btnAlmacenIntermedios
            // 
            this.btnAlmacenIntermedios.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAlmacenIntermedios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlmacenIntermedios.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlmacenIntermedios.FlatAppearance.BorderSize = 0;
            this.btnAlmacenIntermedios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlmacenIntermedios.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenIntermedios.ForeColor = System.Drawing.Color.White;
            this.btnAlmacenIntermedios.Image = global::Interfaz.Properties.Resources.almacen;
            this.btnAlmacenIntermedios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlmacenIntermedios.Location = new System.Drawing.Point(0, 0);
            this.btnAlmacenIntermedios.Name = "btnAlmacenIntermedios";
            this.btnAlmacenIntermedios.Size = new System.Drawing.Size(200, 112);
            this.btnAlmacenIntermedios.TabIndex = 0;
            this.btnAlmacenIntermedios.Text = "Almacén Intermedios";
            this.btnAlmacenIntermedios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlmacenIntermedios.UseVisualStyleBackColor = false;
            this.btnAlmacenIntermedios.Click += new System.EventHandler(this.btnAlmacenIntermedios_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE PRODUCCIÓN";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnVerPruebasCald;
        private System.Windows.Forms.Button btnPruebasCalidad;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAlmacenTerminados;
        private System.Windows.Forms.Button btnAlmacenLineaGalv;
        private System.Windows.Forms.Button btnAlmacenIntermedios;
    }
}