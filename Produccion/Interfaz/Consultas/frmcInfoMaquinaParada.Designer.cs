namespace Interfaz.Consultas
{
    partial class frmcInfoMaquinaParada
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcInfoMaquinaParada));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtRollos = new System.Windows.Forms.TextBox();
            this.txtTiempoparada = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.produccionChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produccionChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.lbTitulo.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitulo.Location = new System.Drawing.Point(194, 3);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(335, 24);
            this.lbTitulo.TabIndex = 69;
            this.lbTitulo.Text = "INFORMACION ESTADO DE MÁQUINA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "MÁQUINA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtComentario);
            this.panel1.Controls.Add(this.txtRollos);
            this.panel1.Controls.Add(this.txtTiempoparada);
            this.panel1.Controls.Add(this.txtMotivo);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtMaquina);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(147, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 289);
            this.panel1.TabIndex = 71;
            // 
            // txtComentario
            // 
            this.txtComentario.ForeColor = System.Drawing.Color.DarkRed;
            this.txtComentario.Location = new System.Drawing.Point(183, 170);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.ReadOnly = true;
            this.txtComentario.Size = new System.Drawing.Size(221, 68);
            this.txtComentario.TabIndex = 81;
            // 
            // txtRollos
            // 
            this.txtRollos.ForeColor = System.Drawing.Color.DarkRed;
            this.txtRollos.Location = new System.Drawing.Point(183, 141);
            this.txtRollos.Name = "txtRollos";
            this.txtRollos.ReadOnly = true;
            this.txtRollos.Size = new System.Drawing.Size(221, 20);
            this.txtRollos.TabIndex = 80;
            // 
            // txtTiempoparada
            // 
            this.txtTiempoparada.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTiempoparada.Location = new System.Drawing.Point(183, 112);
            this.txtTiempoparada.Name = "txtTiempoparada";
            this.txtTiempoparada.ReadOnly = true;
            this.txtTiempoparada.Size = new System.Drawing.Size(221, 20);
            this.txtTiempoparada.TabIndex = 79;
            // 
            // txtMotivo
            // 
            this.txtMotivo.ForeColor = System.Drawing.Color.DarkRed;
            this.txtMotivo.Location = new System.Drawing.Point(183, 82);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(221, 20);
            this.txtMotivo.TabIndex = 78;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpFecha.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(183, 54);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(221, 20);
            this.dtpFecha.TabIndex = 77;
            // 
            // txtMaquina
            // 
            this.txtMaquina.ForeColor = System.Drawing.Color.DarkRed;
            this.txtMaquina.Location = new System.Drawing.Point(183, 27);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.ReadOnly = true;
            this.txtMaquina.Size = new System.Drawing.Size(221, 20);
            this.txtMaquina.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "PRODUCCIÓN ESTIMADA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "TIEMPO PARADA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "COMENTARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "MOTIVO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "FECHA PARADA:";
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstado.Location = new System.Drawing.Point(9, 74);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(431, 91);
            this.lblEstado.TabIndex = 82;
            this.lblEstado.Text = "label7";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstado.Visible = false;
            // 
            // produccionChart
            // 
            this.produccionChart.BorderlineColor = System.Drawing.Color.Black;
            this.produccionChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.produccionChart.BorderlineWidth = 3;
            this.produccionChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.produccionChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.produccionChart.Legends.Add(legend1);
            this.produccionChart.Location = new System.Drawing.Point(3, 49);
            this.produccionChart.Name = "produccionChart";
            this.produccionChart.Size = new System.Drawing.Size(716, 311);
            this.produccionChart.TabIndex = 82;
            this.produccionChart.Text = "chart1";
            // 
            // frmcInfoMaquinaParada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.produccionChart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcInfoMaquinaParada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmcInfoMaquinaParada_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produccionChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtRollos;
        private System.Windows.Forms.TextBox txtTiempoparada;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataVisualization.Charting.Chart produccionChart;
    }
}