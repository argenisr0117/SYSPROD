namespace Interfaz
{
    partial class ConsultasGenerales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasGenerales));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acumuladoMensualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaGalvanizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incentivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grapasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.púasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sunchosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mallasCiclonicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mallasGallineroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rollosRollitosCortadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trefiladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaGalvanizadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flejadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varillasAceradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbempresa = new System.Windows.Forms.ToolStripComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnanual = new System.Windows.Forms.Button();
            this.btnmensual = new System.Windows.Forms.Button();
            this.mecanicoIndustriaMenorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(266, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONSULTAS GENERALES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 40);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ForeColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acumuladoMensualToolStripMenuItem,
            this.incentivosToolStripMenuItem,
            this.empresaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acumuladoMensualToolStripMenuItem
            // 
            this.acumuladoMensualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.intermediosToolStripMenuItem,
            this.terminadosToolStripMenuItem,
            this.lineaGalvanizadoToolStripMenuItem});
            this.acumuladoMensualToolStripMenuItem.Name = "acumuladoMensualToolStripMenuItem";
            this.acumuladoMensualToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.acumuladoMensualToolStripMenuItem.Text = "Acumulado Mensual";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // intermediosToolStripMenuItem
            // 
            this.intermediosToolStripMenuItem.Name = "intermediosToolStripMenuItem";
            this.intermediosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.intermediosToolStripMenuItem.Text = "Intermedios";
            this.intermediosToolStripMenuItem.Click += new System.EventHandler(this.intermediosToolStripMenuItem_Click);
            // 
            // terminadosToolStripMenuItem
            // 
            this.terminadosToolStripMenuItem.Name = "terminadosToolStripMenuItem";
            this.terminadosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.terminadosToolStripMenuItem.Text = "Terminados";
            this.terminadosToolStripMenuItem.Click += new System.EventHandler(this.terminadosToolStripMenuItem_Click);
            // 
            // lineaGalvanizadoToolStripMenuItem
            // 
            this.lineaGalvanizadoToolStripMenuItem.Name = "lineaGalvanizadoToolStripMenuItem";
            this.lineaGalvanizadoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.lineaGalvanizadoToolStripMenuItem.Text = "Linea Galvanizado";
            this.lineaGalvanizadoToolStripMenuItem.Click += new System.EventHandler(this.lineaGalvanizadoToolStripMenuItem_Click);
            // 
            // incentivosToolStripMenuItem
            // 
            this.incentivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grapasToolStripMenuItem,
            this.púasToolStripMenuItem,
            this.sunchosToolStripMenuItem,
            this.mallasCiclonicasToolStripMenuItem,
            this.mallasGallineroToolStripMenuItem,
            this.rollosRollitosCortadoToolStripMenuItem,
            this.trefiladoToolStripMenuItem,
            this.lineaGalvanizadoToolStripMenuItem1,
            this.flejadoToolStripMenuItem,
            this.varillasAceradasToolStripMenuItem,
            this.mecanicoIndustriaMenorToolStripMenuItem});
            this.incentivosToolStripMenuItem.Name = "incentivosToolStripMenuItem";
            this.incentivosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.incentivosToolStripMenuItem.Text = "Incentivos";
            // 
            // grapasToolStripMenuItem
            // 
            this.grapasToolStripMenuItem.Name = "grapasToolStripMenuItem";
            this.grapasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.grapasToolStripMenuItem.Text = "Grapas";
            this.grapasToolStripMenuItem.Click += new System.EventHandler(this.grapasToolStripMenuItem_Click);
            // 
            // púasToolStripMenuItem
            // 
            this.púasToolStripMenuItem.Name = "púasToolStripMenuItem";
            this.púasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.púasToolStripMenuItem.Text = "Púas";
            this.púasToolStripMenuItem.Click += new System.EventHandler(this.púasToolStripMenuItem_Click);
            // 
            // sunchosToolStripMenuItem
            // 
            this.sunchosToolStripMenuItem.Name = "sunchosToolStripMenuItem";
            this.sunchosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sunchosToolStripMenuItem.Text = "Sunchos";
            this.sunchosToolStripMenuItem.Click += new System.EventHandler(this.sunchosToolStripMenuItem_Click);
            // 
            // mallasCiclonicasToolStripMenuItem
            // 
            this.mallasCiclonicasToolStripMenuItem.Name = "mallasCiclonicasToolStripMenuItem";
            this.mallasCiclonicasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mallasCiclonicasToolStripMenuItem.Text = "Mallas Ciclonicas";
            this.mallasCiclonicasToolStripMenuItem.Click += new System.EventHandler(this.mallasCiclonicasToolStripMenuItem_Click);
            // 
            // mallasGallineroToolStripMenuItem
            // 
            this.mallasGallineroToolStripMenuItem.Name = "mallasGallineroToolStripMenuItem";
            this.mallasGallineroToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mallasGallineroToolStripMenuItem.Text = "Mallas Gallinero";
            this.mallasGallineroToolStripMenuItem.Click += new System.EventHandler(this.mallasGallineroToolStripMenuItem_Click);
            // 
            // rollosRollitosCortadoToolStripMenuItem
            // 
            this.rollosRollitosCortadoToolStripMenuItem.Name = "rollosRollitosCortadoToolStripMenuItem";
            this.rollosRollitosCortadoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.rollosRollitosCortadoToolStripMenuItem.Text = "Rollos,Rollitos,Cortado";
            this.rollosRollitosCortadoToolStripMenuItem.Click += new System.EventHandler(this.rollosRollitosCortadoToolStripMenuItem_Click);
            // 
            // trefiladoToolStripMenuItem
            // 
            this.trefiladoToolStripMenuItem.Name = "trefiladoToolStripMenuItem";
            this.trefiladoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.trefiladoToolStripMenuItem.Text = "Trefilado";
            this.trefiladoToolStripMenuItem.Click += new System.EventHandler(this.trefiladoToolStripMenuItem_Click);
            // 
            // lineaGalvanizadoToolStripMenuItem1
            // 
            this.lineaGalvanizadoToolStripMenuItem1.Name = "lineaGalvanizadoToolStripMenuItem1";
            this.lineaGalvanizadoToolStripMenuItem1.Size = new System.Drawing.Size(213, 22);
            this.lineaGalvanizadoToolStripMenuItem1.Text = "Linea Galvanizado";
            this.lineaGalvanizadoToolStripMenuItem1.Click += new System.EventHandler(this.lineaGalvanizadoToolStripMenuItem1_Click);
            // 
            // flejadoToolStripMenuItem
            // 
            this.flejadoToolStripMenuItem.Name = "flejadoToolStripMenuItem";
            this.flejadoToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.flejadoToolStripMenuItem.Text = "Flejado";
            this.flejadoToolStripMenuItem.Click += new System.EventHandler(this.flejadoToolStripMenuItem_Click);
            // 
            // varillasAceradasToolStripMenuItem
            // 
            this.varillasAceradasToolStripMenuItem.Name = "varillasAceradasToolStripMenuItem";
            this.varillasAceradasToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.varillasAceradasToolStripMenuItem.Text = "Varillas Aceradas";
            this.varillasAceradasToolStripMenuItem.Click += new System.EventHandler(this.varillasAceradasToolStripMenuItem_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbempresa});
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            // 
            // tscbempresa
            // 
            this.tscbempresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbempresa.Name = "tscbempresa";
            this.tscbempresa.Size = new System.Drawing.Size(121, 23);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnanual);
            this.panel2.Controls.Add(this.btnmensual);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 70);
            this.panel2.TabIndex = 6;
            // 
            // btnanual
            // 
            this.btnanual.BackColor = System.Drawing.Color.White;
            this.btnanual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnanual.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnanual.FlatAppearance.BorderSize = 2;
            this.btnanual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnanual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnanual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanual.ForeColor = System.Drawing.Color.Black;
            this.btnanual.Image = global::Interfaz.Properties.Resources.boxes_brown_icon;
            this.btnanual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnanual.Location = new System.Drawing.Point(111, 0);
            this.btnanual.Name = "btnanual";
            this.btnanual.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnanual.Size = new System.Drawing.Size(111, 66);
            this.btnanual.TabIndex = 50;
            this.btnanual.TabStop = false;
            this.btnanual.Text = "Cierre Anual";
            this.btnanual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnanual.UseVisualStyleBackColor = false;
            // 
            // btnmensual
            // 
            this.btnmensual.BackColor = System.Drawing.Color.White;
            this.btnmensual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnmensual.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnmensual.FlatAppearance.BorderSize = 2;
            this.btnmensual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnmensual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmensual.ForeColor = System.Drawing.Color.Black;
            this.btnmensual.Image = global::Interfaz.Properties.Resources.Box_icon;
            this.btnmensual.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmensual.Location = new System.Drawing.Point(0, 0);
            this.btnmensual.Name = "btnmensual";
            this.btnmensual.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btnmensual.Size = new System.Drawing.Size(111, 66);
            this.btnmensual.TabIndex = 49;
            this.btnmensual.TabStop = false;
            this.btnmensual.Text = "Cierre Mensual";
            this.btnmensual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmensual.UseVisualStyleBackColor = false;
            this.btnmensual.Click += new System.EventHandler(this.btnmensual_Click);
            // 
            // mecanicoIndustriaMenorToolStripMenuItem
            // 
            this.mecanicoIndustriaMenorToolStripMenuItem.Name = "mecanicoIndustriaMenorToolStripMenuItem";
            this.mecanicoIndustriaMenorToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.mecanicoIndustriaMenorToolStripMenuItem.Text = "Mecanico Industria Menor";
            this.mecanicoIndustriaMenorToolStripMenuItem.Click += new System.EventHandler(this.mecanicoIndustriaMenorToolStripMenuItem_Click);
            // 
            // ConsultasGenerales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ConsultasGenerales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultasGenerales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acumuladoMensualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaGalvanizadoToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnanual;
        private System.Windows.Forms.Button btnmensual;
        private System.Windows.Forms.ToolStripMenuItem incentivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem púasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sunchosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mallasCiclonicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mallasGallineroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rollosRollitosCortadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscbempresa;
        private System.Windows.Forms.ToolStripMenuItem trefiladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaGalvanizadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem flejadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varillasAceradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecanicoIndustriaMenorToolStripMenuItem;
    }
}