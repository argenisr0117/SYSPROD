namespace Interfaz.Registros
{
    partial class frmPonche
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPonche));
            this.btnTCPConnect = new System.Windows.Forms.Button();
            this.lbSysOutputInfo = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RealTime_Dtg = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aSISTENCIADIARIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONECTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCONECTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCARGARREGISTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARREGISTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIALDEASISTENCIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Attlog_Dtg = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealTime_Dtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attlog_Dtg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTCPConnect
            // 
            this.btnTCPConnect.Location = new System.Drawing.Point(12, 152);
            this.btnTCPConnect.Name = "btnTCPConnect";
            this.btnTCPConnect.Size = new System.Drawing.Size(104, 48);
            this.btnTCPConnect.TabIndex = 16;
            this.btnTCPConnect.Text = "CONECTAR";
            this.btnTCPConnect.UseVisualStyleBackColor = true;
            this.btnTCPConnect.Click += new System.EventHandler(this.btnTCPConnect_Click);
            // 
            // lbSysOutputInfo
            // 
            this.lbSysOutputInfo.FormattingEnabled = true;
            this.lbSysOutputInfo.Location = new System.Drawing.Point(0, 346);
            this.lbSysOutputInfo.Name = "lbSysOutputInfo";
            this.lbSysOutputInfo.Size = new System.Drawing.Size(404, 186);
            this.lbSysOutputInfo.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositivoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 41);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dispositivoToolStripMenuItem
            // 
            this.dispositivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONECTARToolStripMenuItem,
            this.dESCONECTARToolStripMenuItem,
            this.dESCARGARREGISTROSToolStripMenuItem,
            this.bORRARREGISTROSToolStripMenuItem});
            this.dispositivoToolStripMenuItem.Name = "dispositivoToolStripMenuItem";
            this.dispositivoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.dispositivoToolStripMenuItem.Text = "DISPOSITIVO";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aSISTENCIADIARIAToolStripMenuItem,
            this.hISTORIALDEASISTENCIAToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.reportesToolStripMenuItem.Text = "REPORTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(299, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "CONTROL DE ASISTENCIA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 41);
            this.panel1.TabIndex = 46;
            // 
            // RealTime_Dtg
            // 
            this.RealTime_Dtg.AllowUserToAddRows = false;
            this.RealTime_Dtg.AllowUserToDeleteRows = false;
            this.RealTime_Dtg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RealTime_Dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RealTime_Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RealTime_Dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.name,
            this.date});
            this.RealTime_Dtg.Location = new System.Drawing.Point(410, 346);
            this.RealTime_Dtg.Name = "RealTime_Dtg";
            this.RealTime_Dtg.ReadOnly = true;
            this.RealTime_Dtg.RowHeadersWidth = 10;
            this.RealTime_Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RealTime_Dtg.Size = new System.Drawing.Size(417, 186);
            this.RealTime_Dtg.TabIndex = 47;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "ID";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 43;
            // 
            // name
            // 
            this.name.HeaderText = "NOMBRE";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // date
            // 
            this.date.HeaderText = "HORA PONCHE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(0, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ESTADO DEL DISPOSITIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(407, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "PONCHE EN TIEMPO REAL";
            // 
            // aSISTENCIADIARIAToolStripMenuItem
            // 
            this.aSISTENCIADIARIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aSISTENCIADIARIAToolStripMenuItem.Name = "aSISTENCIADIARIAToolStripMenuItem";
            this.aSISTENCIADIARIAToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.aSISTENCIADIARIAToolStripMenuItem.Text = "ASISTENCIA DIARIA";
            // 
            // cONECTARToolStripMenuItem
            // 
            this.cONECTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cONECTARToolStripMenuItem.Name = "cONECTARToolStripMenuItem";
            this.cONECTARToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cONECTARToolStripMenuItem.Text = "CONECTAR";
            this.cONECTARToolStripMenuItem.Click += new System.EventHandler(this.cONECTARToolStripMenuItem_Click);
            // 
            // dESCONECTARToolStripMenuItem
            // 
            this.dESCONECTARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCONECTARToolStripMenuItem.Name = "dESCONECTARToolStripMenuItem";
            this.dESCONECTARToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dESCONECTARToolStripMenuItem.Text = "DESCONECTAR";
            this.dESCONECTARToolStripMenuItem.Click += new System.EventHandler(this.dESCONECTARToolStripMenuItem_Click);
            // 
            // dESCARGARREGISTROSToolStripMenuItem
            // 
            this.dESCARGARREGISTROSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dESCARGARREGISTROSToolStripMenuItem.Name = "dESCARGARREGISTROSToolStripMenuItem";
            this.dESCARGARREGISTROSToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.dESCARGARREGISTROSToolStripMenuItem.Text = "DESCARGAR REGISTROS";
            this.dESCARGARREGISTROSToolStripMenuItem.Click += new System.EventHandler(this.dESCARGARREGISTROSToolStripMenuItem_Click);
            // 
            // bORRARREGISTROSToolStripMenuItem
            // 
            this.bORRARREGISTROSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bORRARREGISTROSToolStripMenuItem.Name = "bORRARREGISTROSToolStripMenuItem";
            this.bORRARREGISTROSToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bORRARREGISTROSToolStripMenuItem.Text = "BORRAR REGISTROS";
            // 
            // hISTORIALDEASISTENCIAToolStripMenuItem
            // 
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Name = "hISTORIALDEASISTENCIAToolStripMenuItem";
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.hISTORIALDEASISTENCIAToolStripMenuItem.Text = "HISTORIAL DE ASISTENCIA";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(841, 534);
            this.shapeContainer1.TabIndex = 51;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 844;
            this.lineShape1.Y1 = 318;
            this.lineShape1.Y2 = 318;
            // 
            // Attlog_Dtg
            // 
            this.Attlog_Dtg.AllowUserToAddRows = false;
            this.Attlog_Dtg.AllowUserToDeleteRows = false;
            this.Attlog_Dtg.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Attlog_Dtg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Attlog_Dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Attlog_Dtg.Location = new System.Drawing.Point(214, 68);
            this.Attlog_Dtg.Name = "Attlog_Dtg";
            this.Attlog_Dtg.ReadOnly = true;
            this.Attlog_Dtg.RowHeadersWidth = 10;
            this.Attlog_Dtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Attlog_Dtg.Size = new System.Drawing.Size(613, 241);
            this.Attlog_Dtg.TabIndex = 52;
            // 
            // frmPonche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 534);
            this.Controls.Add(this.Attlog_Dtg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RealTime_Dtg);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSysOutputInfo);
            this.Controls.Add(this.btnTCPConnect);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPonche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPonche_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealTime_Dtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Attlog_Dtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTCPConnect;
        private System.Windows.Forms.ListBox lbSysOutputInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dispositivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView RealTime_Dtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cONECTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCONECTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCARGARREGISTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARREGISTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSISTENCIADIARIAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hISTORIALDEASISTENCIAToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridView Attlog_Dtg;
    }
}