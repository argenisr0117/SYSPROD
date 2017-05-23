namespace Interfaz.Consultas
{
    partial class frmcProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbinf = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new Interfaz.Controles.textbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvProducto = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calibre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbinf);
            this.panel1.Controls.Add(this.cbestado);
            this.panel1.Controls.Add(this.rbDescripcion);
            this.panel1.Controls.Add(this.rbCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 107);
            this.panel1.TabIndex = 0;
            // 
            // lbinf
            // 
            this.lbinf.AutoSize = true;
            this.lbinf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbinf.ForeColor = System.Drawing.Color.Maroon;
            this.lbinf.Location = new System.Drawing.Point(433, 80);
            this.lbinf.Name = "lbinf";
            this.lbinf.Size = new System.Drawing.Size(129, 15);
            this.lbinf.TabIndex = 62;
            this.lbinf.Text = "Doble click para editar";
            this.lbinf.Visible = false;
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.Gainsboro;
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbestado.ForeColor = System.Drawing.Color.Black;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.ItemHeight = 13;
            this.cbestado.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.cbestado.Location = new System.Drawing.Point(660, 53);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(86, 21);
            this.cbestado.TabIndex = 61;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Location = new System.Drawing.Point(159, 80);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(98, 17);
            this.rbDescripcion.TabIndex = 60;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "DESCRIPCIÓN";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            this.rbDescripcion.CheckedChanged += new System.EventHandler(this.rbDescripcion_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(64, 80);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(67, 17);
            this.rbCodigo.TabIndex = 59;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "CÓDIGO";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "BUSCAR:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(64, 53);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(588, 21);
            this.txtbuscar.TabIndex = 57;
            this.txtbuscar.Validar = false;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(253, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "CONSULTA PRODUCTOS";
            // 
            // dtgvProducto
            // 
            this.dtgvProducto.AllowUserToAddRows = false;
            this.dtgvProducto.AllowUserToDeleteRows = false;
            this.dtgvProducto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.unidad,
            this.calibre,
            this.categoria});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProducto.Location = new System.Drawing.Point(0, 107);
            this.dtgvProducto.MultiSelect = false;
            this.dtgvProducto.Name = "dtgvProducto";
            this.dtgvProducto.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvProducto.RowHeadersWidth = 21;
            this.dtgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvProducto.Size = new System.Drawing.Size(775, 286);
            this.dtgvProducto.TabIndex = 1;
            this.dtgvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProducto_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "CÓDIGO";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 150;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 280;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "UNIDAD";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            this.unidad.Width = 80;
            // 
            // calibre
            // 
            this.calibre.HeaderText = "CALIBRE";
            this.calibre.Name = "calibre";
            this.calibre.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 129;
            // 
            // frmcProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 393);
            this.Controls.Add(this.dtgvProducto);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmcProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmcProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.Label label1;
        private Controles.textbox txtbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.DataGridView dtgvProducto;
        public System.Windows.Forms.Label lbinf;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn calibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}