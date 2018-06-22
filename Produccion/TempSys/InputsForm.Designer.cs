namespace TempSys
{
    partial class InputsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barraSup_pn = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cerrar_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion_txt = new System.Windows.Forms.TextBox();
            this.entradas_dtgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.entrada_nud = new System.Windows.Forms.NumericUpDown();
            this.horno_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guardar_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.guardarMinMax_btn = new System.Windows.Forms.Button();
            this.Zmax_txt = new System.Windows.Forms.NumericUpDown();
            this.Zmin_txt = new System.Windows.Forms.NumericUpDown();
            this.Pmax_txt = new System.Windows.Forms.NumericUpDown();
            this.Pmin_txt = new System.Windows.Forms.NumericUpDown();
            this.barraSup_pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradas_dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada_nud)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zmax_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zmin_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmax_txt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmin_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // barraSup_pn
            // 
            this.barraSup_pn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            this.barraSup_pn.Controls.Add(this.label2);
            this.barraSup_pn.Controls.Add(this.cerrar_btn);
            this.barraSup_pn.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraSup_pn.Location = new System.Drawing.Point(0, 0);
            this.barraSup_pn.Name = "barraSup_pn";
            this.barraSup_pn.Size = new System.Drawing.Size(552, 31);
            this.barraSup_pn.TabIndex = 0;
            this.barraSup_pn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraSup_pn_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "REGISTRO DE ENTRADAS DE HORNOS - MAXIMOS/MINIMOS";
            // 
            // cerrar_btn
            // 
            this.cerrar_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar_btn.Image = global::TempSys.Properties.Resources.close_button;
            this.cerrar_btn.Location = new System.Drawing.Point(530, 3);
            this.cerrar_btn.Name = "cerrar_btn";
            this.cerrar_btn.Size = new System.Drawing.Size(19, 15);
            this.cerrar_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerrar_btn.TabIndex = 5;
            this.cerrar_btn.TabStop = false;
            this.cerrar_btn.Click += new System.EventHandler(this.cerrar_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESCRIPCIÓN:";
            // 
            // descripcion_txt
            // 
            this.descripcion_txt.Location = new System.Drawing.Point(95, 15);
            this.descripcion_txt.MaxLength = 25;
            this.descripcion_txt.Name = "descripcion_txt";
            this.descripcion_txt.Size = new System.Drawing.Size(240, 22);
            this.descripcion_txt.TabIndex = 2;
            // 
            // entradas_dtgv
            // 
            this.entradas_dtgv.AllowUserToAddRows = false;
            this.entradas_dtgv.AllowUserToDeleteRows = false;
            this.entradas_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.entradas_dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.entradas_dtgv.BackgroundColor = System.Drawing.Color.White;
            this.entradas_dtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entradas_dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.entradas_dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.entradas_dtgv.ColumnHeadersHeight = 30;
            this.entradas_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.entradas_dtgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.entradas_dtgv.EnableHeadersVisualStyles = false;
            this.entradas_dtgv.GridColor = System.Drawing.Color.White;
            this.entradas_dtgv.Location = new System.Drawing.Point(12, 193);
            this.entradas_dtgv.Name = "entradas_dtgv";
            this.entradas_dtgv.ReadOnly = true;
            this.entradas_dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.entradas_dtgv.RowHeadersVisible = false;
            this.entradas_dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.entradas_dtgv.Size = new System.Drawing.Size(354, 141);
            this.entradas_dtgv.TabIndex = 3;
            this.entradas_dtgv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.entradas_dtgv_CellContentDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "# ENTRADA:";
            // 
            // entrada_nud
            // 
            this.entrada_nud.Location = new System.Drawing.Point(95, 43);
            this.entrada_nud.Name = "entrada_nud";
            this.entrada_nud.Size = new System.Drawing.Size(240, 22);
            this.entrada_nud.TabIndex = 3;
            // 
            // horno_cb
            // 
            this.horno_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.horno_cb.FormattingEnabled = true;
            this.horno_cb.Items.AddRange(new object[] {
            "PLOMO",
            "ZINC"});
            this.horno_cb.Location = new System.Drawing.Point(95, 72);
            this.horno_cb.Name = "horno_cb";
            this.horno_cb.Size = new System.Drawing.Size(240, 21);
            this.horno_cb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TIPO HORNO:";
            // 
            // guardar_btn
            // 
            this.guardar_btn.BackColor = System.Drawing.Color.White;
            this.guardar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            this.guardar_btn.FlatAppearance.BorderSize = 2;
            this.guardar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar_btn.ForeColor = System.Drawing.Color.Black;
            this.guardar_btn.Image = global::TempSys.Properties.Resources.save;
            this.guardar_btn.Location = new System.Drawing.Point(124, 104);
            this.guardar_btn.Name = "guardar_btn";
            this.guardar_btn.Size = new System.Drawing.Size(130, 43);
            this.guardar_btn.TabIndex = 4;
            this.guardar_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardar_btn.UseVisualStyleBackColor = false;
            this.guardar_btn.Click += new System.EventHandler(this.guardar_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.horno_cb);
            this.panel1.Controls.Add(this.guardar_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descripcion_txt);
            this.panel1.Controls.Add(this.entrada_nud);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 153);
            this.panel1.TabIndex = 9;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(552, 346);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 373;
            this.lineShape1.X2 = 373;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 333;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "TEMP. MAX ZINC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "°F";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "°F";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TEMP. MIN ZINC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(481, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "°F";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(382, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "TEMP. MAX PLOMO:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "°F";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "TEMP. MIN PLOMO:";
            // 
            // guardarMinMax_btn
            // 
            this.guardarMinMax_btn.BackColor = System.Drawing.Color.White;
            this.guardarMinMax_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(143)))));
            this.guardarMinMax_btn.FlatAppearance.BorderSize = 2;
            this.guardarMinMax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardarMinMax_btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarMinMax_btn.ForeColor = System.Drawing.Color.Black;
            this.guardarMinMax_btn.Image = global::TempSys.Properties.Resources.save;
            this.guardarMinMax_btn.Location = new System.Drawing.Point(401, 268);
            this.guardarMinMax_btn.Name = "guardarMinMax_btn";
            this.guardarMinMax_btn.Size = new System.Drawing.Size(130, 43);
            this.guardarMinMax_btn.TabIndex = 25;
            this.guardarMinMax_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guardarMinMax_btn.UseVisualStyleBackColor = false;
            this.guardarMinMax_btn.Click += new System.EventHandler(this.guardarMinMax_btn_Click);
            // 
            // Zmax_txt
            // 
            this.Zmax_txt.Location = new System.Drawing.Point(385, 59);
            this.Zmax_txt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Zmax_txt.Name = "Zmax_txt";
            this.Zmax_txt.Size = new System.Drawing.Size(90, 22);
            this.Zmax_txt.TabIndex = 26;
            // 
            // Zmin_txt
            // 
            this.Zmin_txt.Location = new System.Drawing.Point(385, 110);
            this.Zmin_txt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Zmin_txt.Name = "Zmin_txt";
            this.Zmin_txt.Size = new System.Drawing.Size(90, 22);
            this.Zmin_txt.TabIndex = 27;
            // 
            // Pmax_txt
            // 
            this.Pmax_txt.Location = new System.Drawing.Point(385, 167);
            this.Pmax_txt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Pmax_txt.Name = "Pmax_txt";
            this.Pmax_txt.Size = new System.Drawing.Size(90, 22);
            this.Pmax_txt.TabIndex = 28;
            // 
            // Pmin_txt
            // 
            this.Pmin_txt.Location = new System.Drawing.Point(385, 220);
            this.Pmin_txt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Pmin_txt.Name = "Pmin_txt";
            this.Pmin_txt.Size = new System.Drawing.Size(90, 22);
            this.Pmin_txt.TabIndex = 29;
            // 
            // InputsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(552, 346);
            this.Controls.Add(this.Pmin_txt);
            this.Controls.Add(this.Pmax_txt);
            this.Controls.Add(this.Zmin_txt);
            this.Controls.Add(this.Zmax_txt);
            this.Controls.Add(this.guardarMinMax_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entradas_dtgv);
            this.Controls.Add(this.barraSup_pn);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputsForm";
            this.Load += new System.EventHandler(this.InputsForm_Load);
            this.barraSup_pn.ResumeLayout(false);
            this.barraSup_pn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradas_dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrada_nud)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zmax_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zmin_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmax_txt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pmin_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel barraSup_pn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion_txt;
        private System.Windows.Forms.DataGridView entradas_dtgv;
        private System.Windows.Forms.Button guardar_btn;
        private System.Windows.Forms.PictureBox cerrar_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown entrada_nud;
        private System.Windows.Forms.ComboBox horno_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button guardarMinMax_btn;
        private System.Windows.Forms.NumericUpDown Zmax_txt;
        private System.Windows.Forms.NumericUpDown Zmin_txt;
        private System.Windows.Forms.NumericUpDown Pmax_txt;
        private System.Windows.Forms.NumericUpDown Pmin_txt;
    }
}