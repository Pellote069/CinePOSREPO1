namespace CinePOS
{
    partial class FormGestionFunciones
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
            this.flpContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSelectorFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBuscador = new System.Windows.Forms.MaskedTextBox();
            this.cmbSelectorSala = new System.Windows.Forms.ComboBox();
            this.btnNuevaFuncion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flpContenedor.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpContenedor
            // 
            this.flpContenedor.AutoScroll = true;
            this.flpContenedor.Controls.Add(this.label4);
            this.flpContenedor.ForeColor = System.Drawing.Color.White;
            this.flpContenedor.Location = new System.Drawing.Point(0, 72);
            this.flpContenedor.Name = "flpContenedor";
            this.flpContenedor.Size = new System.Drawing.Size(1008, 653);
            this.flpContenedor.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.label3);
            this.pnlSuperior.Controls.Add(this.label2);
            this.pnlSuperior.Controls.Add(this.label1);
            this.pnlSuperior.Controls.Add(this.dtpSelectorFecha);
            this.pnlSuperior.Controls.Add(this.txtBuscador);
            this.pnlSuperior.Controls.Add(this.cmbSelectorSala);
            this.pnlSuperior.Controls.Add(this.btnNuevaFuncion);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1008, 87);
            this.pnlSuperior.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(729, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccionar fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(231, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Sala";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(441, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por pelicula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpSelectorFecha
            // 
            this.dtpSelectorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSelectorFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelectorFecha.Location = new System.Drawing.Point(669, 44);
            this.dtpSelectorFecha.Name = "dtpSelectorFecha";
            this.dtpSelectorFecha.Size = new System.Drawing.Size(300, 22);
            this.dtpSelectorFecha.TabIndex = 3;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBuscador.Location = new System.Drawing.Point(381, 44);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(246, 22);
            this.txtBuscador.TabIndex = 2;
            // 
            // cmbSelectorSala
            // 
            this.cmbSelectorSala.FormattingEnabled = true;
            this.cmbSelectorSala.Location = new System.Drawing.Point(217, 42);
            this.cmbSelectorSala.Name = "cmbSelectorSala";
            this.cmbSelectorSala.Size = new System.Drawing.Size(139, 24);
            this.cmbSelectorSala.TabIndex = 1;
            this.cmbSelectorSala.SelectedIndexChanged += new System.EventHandler(this.cmbSelectorSala_SelectedIndexChanged);
            // 
            // btnNuevaFuncion
            // 
            this.btnNuevaFuncion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnNuevaFuncion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaFuncion.Location = new System.Drawing.Point(27, 19);
            this.btnNuevaFuncion.Name = "btnNuevaFuncion";
            this.btnNuevaFuncion.Size = new System.Drawing.Size(142, 47);
            this.btnNuevaFuncion.TabIndex = 0;
            this.btnNuevaFuncion.Text = "Nueva Función";
            this.btnNuevaFuncion.UseVisualStyleBackColor = false;
            this.btnNuevaFuncion.Click += new System.EventHandler(this.btnNuevaFuncion_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(66, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 12);
            this.label5.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(79, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Por comenzar";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(404, 754);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 12);
            this.label7.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(417, 728);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Funcion corriendo";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(765, 728);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Funcion terminada";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(756, 754);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 12);
            this.label10.TabIndex = 6;
            // 
            // FormGestionFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1008, 775);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.flpContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionFunciones";
            this.Text = "FormGestionFunciones";
            this.Load += new System.EventHandler(this.FormGestionFunciones_Load);
            this.flpContenedor.ResumeLayout(false);
            this.flpContenedor.PerformLayout();
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpContenedor;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Button btnNuevaFuncion;
        private System.Windows.Forms.ComboBox cmbSelectorSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSelectorFecha;
        private System.Windows.Forms.MaskedTextBox txtBuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}