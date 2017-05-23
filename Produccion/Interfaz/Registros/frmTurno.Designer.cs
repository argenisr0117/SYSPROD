namespace Interfaz.Registros
{
    partial class frmTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTurno));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtturno = new Interfaz.Controles.textbox(this.components);
            this.txtabreviacion = new Interfaz.Controles.textbox(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.dtgvTurno = new System.Windows.Forms.DataGridView();
            this.abreviacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.White;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btneditar.FlatAppearance.BorderSize = 2;
            this.btneditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btneditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.Black;
            this.btneditar.Location = new System.Drawing.Point(326, 137);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(68, 32);
            this.btneditar.TabIndex = 3;
            this.btneditar.Text = "Editar";
            this.toolTip1.SetToolTip(this.btneditar, "Editar");
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnsalir.FlatAppearance.BorderSize = 2;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.Location = new System.Drawing.Point(326, 214);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(68, 32);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.toolTip1.SetToolTip(this.btnsalir, "Salir");
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnactivar
            // 
            this.btnactivar.BackColor = System.Drawing.Color.White;
            this.btnactivar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnactivar.FlatAppearance.BorderSize = 2;
            this.btnactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnactivar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactivar.ForeColor = System.Drawing.Color.Black;
            this.btnactivar.Location = new System.Drawing.Point(326, 176);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(68, 32);
            this.btnactivar.TabIndex = 4;
            this.btnactivar.Text = "Act/Dact";
            this.toolTip1.SetToolTip(this.btnactivar, "Activar/Desactivar");
            this.btnactivar.UseVisualStyleBackColor = false;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackColor = System.Drawing.Color.White;
            this.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.btnregistrar.FlatAppearance.BorderSize = 2;
            this.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistrar.ForeColor = System.Drawing.Color.Black;
            this.btnregistrar.Location = new System.Drawing.Point(326, 99);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(68, 32);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "Registrar";
            this.toolTip1.SetToolTip(this.btnregistrar, "Registrar");
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Turno";
            this.toolTip1.SetToolTip(this.label2, "Turno");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Abrev.";
            this.toolTip1.SetToolTip(this.label1, "Abreviación");
            // 
            // txtturno
            // 
            this.txtturno.Location = new System.Drawing.Point(100, 58);
            this.txtturno.Multiline = true;
            this.txtturno.Name = "txtturno";
            this.txtturno.Size = new System.Drawing.Size(204, 20);
            this.txtturno.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtturno, "Turno");
            this.txtturno.Validar = true;
            // 
            // txtabreviacion
            // 
            this.txtabreviacion.Location = new System.Drawing.Point(10, 58);
            this.txtabreviacion.Multiline = true;
            this.txtabreviacion.Name = "txtabreviacion";
            this.txtabreviacion.Size = new System.Drawing.Size(69, 20);
            this.txtabreviacion.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtabreviacion, "Abreviación");
            this.txtabreviacion.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbestado
            // 
            this.cbestado.BackColor = System.Drawing.Color.Gainsboro;
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbestado.ForeColor = System.Drawing.Color.Black;
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Activos",
            "Inactivos"});
            this.cbestado.Location = new System.Drawing.Point(326, 57);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(68, 21);
            this.cbestado.TabIndex = 19;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // dtgvTurno
            // 
            this.dtgvTurno.AllowUserToAddRows = false;
            this.dtgvTurno.AllowUserToDeleteRows = false;
            this.dtgvTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTurno.BackgroundColor = System.Drawing.Color.White;
            this.dtgvTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abreviacion,
            this.turno,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTurno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTurno.Location = new System.Drawing.Point(10, 100);
            this.dtgvTurno.MultiSelect = false;
            this.dtgvTurno.Name = "dtgvTurno";
            this.dtgvTurno.ReadOnly = true;
            this.dtgvTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvTurno.RowHeadersWidth = 20;
            this.dtgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTurno.Size = new System.Drawing.Size(294, 147);
            this.dtgvTurno.TabIndex = 14;
            // 
            // abreviacion
            // 
            this.abreviacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abreviacion.FillWeight = 60F;
            this.abreviacion.HeaderText = "Abrev.";
            this.abreviacion.Name = "abreviacion";
            this.abreviacion.ReadOnly = true;
            // 
            // turno
            // 
            this.turno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.turno.FillWeight = 80F;
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estado.FillWeight = 50F;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-5, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(447, 6);
            this.label6.TabIndex = 46;
            this.label6.Text = "_________________________________________________________________________________" +
    "______________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-7, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "_______________________________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(113, -3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 26);
            this.label4.TabIndex = 44;
            this.label4.Text = "REGISTRO TURNOS";
            // 
            // frmTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 253);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtturno);
            this.Controls.Add(this.txtabreviacion);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.dtgvTurno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.DataGridView dtgvTurno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controles.textbox txtturno;
        private Controles.textbox txtabreviacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn abreviacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
    }
}