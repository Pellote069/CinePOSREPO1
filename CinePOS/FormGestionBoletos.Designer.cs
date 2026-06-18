namespace CinePOS
{
    partial class FormGestionBoletos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrecioAdulto = new System.Windows.Forms.Label();
            this.lblPrecioNiño = new System.Windows.Forms.Label();
            this.numPrecioNiño = new System.Windows.Forms.NumericUpDown();
            this.numPrecioAdulto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioEspecial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarPrecios = new System.Windows.Forms.Button();
            this.numPrecioEspecial = new System.Windows.Forms.NumericUpDown();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioNiño)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioAdulto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioEspecial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnGuardarPrecios);
            this.panel1.Controls.Add(this.numPrecioEspecial);
            this.panel1.Controls.Add(this.lblPrecioEspecial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSala);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 168);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lblPrecioAdulto);
            this.groupBox1.Controls.Add(this.lblPrecioNiño);
            this.groupBox1.Controls.Add(this.numPrecioNiño);
            this.groupBox1.Controls.Add(this.numPrecioAdulto);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 101);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formato 2D";
            // 
            // lblPrecioAdulto
            // 
            this.lblPrecioAdulto.AutoSize = true;
            this.lblPrecioAdulto.Location = new System.Drawing.Point(198, 32);
            this.lblPrecioAdulto.Name = "lblPrecioAdulto";
            this.lblPrecioAdulto.Size = new System.Drawing.Size(52, 16);
            this.lblPrecioAdulto.TabIndex = 4;
            this.lblPrecioAdulto.Text = "Adultos";
            // 
            // lblPrecioNiño
            // 
            this.lblPrecioNiño.AutoSize = true;
            this.lblPrecioNiño.Location = new System.Drawing.Point(21, 32);
            this.lblPrecioNiño.Name = "lblPrecioNiño";
            this.lblPrecioNiño.Size = new System.Drawing.Size(147, 16);
            this.lblPrecioNiño.TabIndex = 3;
            this.lblPrecioNiño.Text = "Niños/Adultos mayores";
            // 
            // numPrecioNiño
            // 
            this.numPrecioNiño.Location = new System.Drawing.Point(29, 63);
            this.numPrecioNiño.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPrecioNiño.Name = "numPrecioNiño";
            this.numPrecioNiño.Size = new System.Drawing.Size(120, 22);
            this.numPrecioNiño.TabIndex = 1;
            this.numPrecioNiño.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPrecioAdulto
            // 
            this.numPrecioAdulto.Location = new System.Drawing.Point(198, 63);
            this.numPrecioAdulto.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrecioAdulto.Name = "numPrecioAdulto";
            this.numPrecioAdulto.Size = new System.Drawing.Size(120, 22);
            this.numPrecioAdulto.TabIndex = 2;
            this.numPrecioAdulto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecioEspecial
            // 
            this.lblPrecioEspecial.AutoSize = true;
            this.lblPrecioEspecial.Location = new System.Drawing.Point(12, 97);
            this.lblPrecioEspecial.Name = "lblPrecioEspecial";
            this.lblPrecioEspecial.Size = new System.Drawing.Size(122, 16);
            this.lblPrecioEspecial.TabIndex = 6;
            this.lblPrecioEspecial.Text = "Formatos 3D y 4DX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar tipo de sala";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGuardarPrecios
            // 
            this.btnGuardarPrecios.Location = new System.Drawing.Point(197, 124);
            this.btnGuardarPrecios.Name = "btnGuardarPrecios";
            this.btnGuardarPrecios.Size = new System.Drawing.Size(165, 34);
            this.btnGuardarPrecios.TabIndex = 4;
            this.btnGuardarPrecios.Text = "Guardar precios";
            this.btnGuardarPrecios.UseVisualStyleBackColor = true;
            this.btnGuardarPrecios.Click += new System.EventHandler(this.btnGuardarPrecios_Click_1);
            // 
            // numPrecioEspecial
            // 
            this.numPrecioEspecial.Location = new System.Drawing.Point(15, 125);
            this.numPrecioEspecial.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numPrecioEspecial.Name = "numPrecioEspecial";
            this.numPrecioEspecial.Size = new System.Drawing.Size(144, 22);
            this.numPrecioEspecial.TabIndex = 3;
            this.numPrecioEspecial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(15, 41);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(149, 24);
            this.cmbSala.TabIndex = 0;
            this.cmbSala.SelectedIndexChanged += new System.EventHandler(this.cmbTipoSala_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Listo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestionBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 168);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormGestionBoletos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestionBoletos";
            this.Load += new System.EventHandler(this.FormGestionBoletos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioNiño)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioAdulto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioEspecial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarPrecios;
        private System.Windows.Forms.NumericUpDown numPrecioEspecial;
        private System.Windows.Forms.NumericUpDown numPrecioAdulto;
        private System.Windows.Forms.NumericUpDown numPrecioNiño;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecioEspecial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrecioAdulto;
        private System.Windows.Forms.Label lblPrecioNiño;
        private System.Windows.Forms.Button button1;
    }
}