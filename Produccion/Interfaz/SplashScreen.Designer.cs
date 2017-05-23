namespace Interfaz
{
    partial class SplashScreen
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circulo5 = new System.Windows.Forms.PictureBox();
            this.circulo4 = new System.Windows.Forms.PictureBox();
            this.circulo3 = new System.Windows.Forms.PictureBox();
            this.circulo2 = new System.Windows.Forms.PictureBox();
            this.circulo1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.circulo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circulo5
            // 
            this.circulo5.BackColor = System.Drawing.Color.Transparent;
            this.circulo5.BackgroundImage = global::Interfaz.Properties.Resources.Circle1;
            this.circulo5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circulo5.Location = new System.Drawing.Point(329, 3);
            this.circulo5.Name = "circulo5";
            this.circulo5.Size = new System.Drawing.Size(27, 28);
            this.circulo5.TabIndex = 6;
            this.circulo5.TabStop = false;
            // 
            // circulo4
            // 
            this.circulo4.BackColor = System.Drawing.Color.Transparent;
            this.circulo4.BackgroundImage = global::Interfaz.Properties.Resources.Circle1;
            this.circulo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circulo4.Location = new System.Drawing.Point(297, 3);
            this.circulo4.Name = "circulo4";
            this.circulo4.Size = new System.Drawing.Size(26, 28);
            this.circulo4.TabIndex = 5;
            this.circulo4.TabStop = false;
            // 
            // circulo3
            // 
            this.circulo3.BackColor = System.Drawing.Color.Transparent;
            this.circulo3.BackgroundImage = global::Interfaz.Properties.Resources.Circle1;
            this.circulo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circulo3.Location = new System.Drawing.Point(265, 3);
            this.circulo3.Name = "circulo3";
            this.circulo3.Size = new System.Drawing.Size(26, 28);
            this.circulo3.TabIndex = 4;
            this.circulo3.TabStop = false;
            // 
            // circulo2
            // 
            this.circulo2.BackColor = System.Drawing.Color.Transparent;
            this.circulo2.BackgroundImage = global::Interfaz.Properties.Resources.Circle1;
            this.circulo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circulo2.Location = new System.Drawing.Point(237, 3);
            this.circulo2.Name = "circulo2";
            this.circulo2.Size = new System.Drawing.Size(26, 28);
            this.circulo2.TabIndex = 3;
            this.circulo2.TabStop = false;
            // 
            // circulo1
            // 
            this.circulo1.BackColor = System.Drawing.Color.Transparent;
            this.circulo1.BackgroundImage = global::Interfaz.Properties.Resources.Circle1;
            this.circulo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circulo1.Location = new System.Drawing.Point(205, 3);
            this.circulo1.Name = "circulo1";
            this.circulo1.Size = new System.Drawing.Size(26, 28);
            this.circulo1.TabIndex = 2;
            this.circulo1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.circulo1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.circulo2);
            this.panel1.Controls.Add(this.circulo5);
            this.panel1.Controls.Add(this.circulo3);
            this.panel1.Controls.Add(this.circulo4);
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 52);
            this.panel1.TabIndex = 8;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = Properties.Resources.logoacisa51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(536, 250);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashScreen_FormClosing);
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circulo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circulo1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox circulo1;
        private System.Windows.Forms.PictureBox circulo2;
        private System.Windows.Forms.PictureBox circulo3;
        private System.Windows.Forms.PictureBox circulo4;
        private System.Windows.Forms.PictureBox circulo5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}