namespace CinePOS
{
    partial class FormVentaBoletos
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
            this.LbAdto = new System.Windows.Forms.Label();
            this.LbEspecial = new System.Windows.Forms.Label();
            this.UpDownAdto = new System.Windows.Forms.NumericUpDown();
            this.UpDownEspecial = new System.Windows.Forms.NumericUpDown();
            this.PnlBltEdad = new System.Windows.Forms.Panel();
            this.PnlBltGeneral = new System.Windows.Forms.Panel();
            this.PnlSeatMap = new System.Windows.Forms.Panel();
            this.LbAsientos = new System.Windows.Forms.Label();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.FlpSeatMap = new System.Windows.Forms.FlowLayoutPanel();
            this.UpDownGeneral = new System.Windows.Forms.NumericUpDown();
            this.LbGeneral = new System.Windows.Forms.Label();
            this.BtnNext2 = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblPrecioAdto = new System.Windows.Forms.Label();
            this.LblPrecioEspecial = new System.Windows.Forms.Label();
            this.LblPrecioGeneral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownAdto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownEspecial)).BeginInit();
            this.PnlBltEdad.SuspendLayout();
            this.PnlBltGeneral.SuspendLayout();
            this.PnlSeatMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAdto
            // 
            this.LbAdto.AutoSize = true;
            this.LbAdto.Location = new System.Drawing.Point(24, 42);
            this.LbAdto.Name = "LbAdto";
            this.LbAdto.Size = new System.Drawing.Size(149, 25);
            this.LbAdto.TabIndex = 17;
            this.LbAdto.Text = "Boletos Adulto :";
            // 
            // LbEspecial
            // 
            this.LbEspecial.AutoSize = true;
            this.LbEspecial.Location = new System.Drawing.Point(24, 136);
            this.LbEspecial.Name = "LbEspecial";
            this.LbEspecial.Size = new System.Drawing.Size(223, 25);
            this.LbEspecial.TabIndex = 18;
            this.LbEspecial.Text = "Boletos Niño/3ra Edad : ";
            // 
            // UpDownAdto
            // 
            this.UpDownAdto.Location = new System.Drawing.Point(290, 40);
            this.UpDownAdto.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDownAdto.Name = "UpDownAdto";
            this.UpDownAdto.Size = new System.Drawing.Size(120, 29);
            this.UpDownAdto.TabIndex = 21;
            // 
            // UpDownEspecial
            // 
            this.UpDownEspecial.Location = new System.Drawing.Point(290, 134);
            this.UpDownEspecial.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDownEspecial.Name = "UpDownEspecial";
            this.UpDownEspecial.Size = new System.Drawing.Size(120, 29);
            this.UpDownEspecial.TabIndex = 22;
            // 
            // PnlBltEdad
            // 
            this.PnlBltEdad.Controls.Add(this.PnlBltGeneral);
            this.PnlBltEdad.Controls.Add(this.UpDownEspecial);
            this.PnlBltEdad.Controls.Add(this.UpDownAdto);
            this.PnlBltEdad.Controls.Add(this.LbEspecial);
            this.PnlBltEdad.Controls.Add(this.LbAdto);
            this.PnlBltEdad.Controls.Add(this.BtnNext);
            this.PnlBltEdad.Controls.Add(this.LblPrecioAdto);
            this.PnlBltEdad.Controls.Add(this.LblPrecioEspecial);
            this.PnlBltEdad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBltEdad.Location = new System.Drawing.Point(0, 0);
            this.PnlBltEdad.Name = "PnlBltEdad";
            this.PnlBltEdad.Size = new System.Drawing.Size(645, 376);
            this.PnlBltEdad.TabIndex = 0;
            // 
            // PnlBltGeneral
            // 
            this.PnlBltGeneral.Controls.Add(this.PnlSeatMap);
            this.PnlBltGeneral.Controls.Add(this.UpDownGeneral);
            this.PnlBltGeneral.Controls.Add(this.LbGeneral);
            this.PnlBltGeneral.Controls.Add(this.BtnNext2);
            this.PnlBltGeneral.Controls.Add(this.LblPrecioGeneral);
            this.PnlBltGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBltGeneral.Location = new System.Drawing.Point(0, 0);
            this.PnlBltGeneral.Name = "PnlBltGeneral";
            this.PnlBltGeneral.Size = new System.Drawing.Size(645, 376);
            this.PnlBltGeneral.TabIndex = 24;
            // 
            // PnlSeatMap
            // 
            this.PnlSeatMap.Controls.Add(this.LbAsientos);
            this.PnlSeatMap.Controls.Add(this.BtnVenta);
            this.PnlSeatMap.Controls.Add(this.BtnBack);
            this.PnlSeatMap.Controls.Add(this.FlpSeatMap);
            this.PnlSeatMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSeatMap.Location = new System.Drawing.Point(0, 0);
            this.PnlSeatMap.Name = "PnlSeatMap";
            this.PnlSeatMap.Size = new System.Drawing.Size(645, 376);
            this.PnlSeatMap.TabIndex = 21;
            // 
            // LbAsientos
            // 
            this.LbAsientos.AutoSize = true;
            this.LbAsientos.Location = new System.Drawing.Point(203, 7);
            this.LbAsientos.Name = "LbAsientos";
            this.LbAsientos.Size = new System.Drawing.Size(226, 25);
            this.LbAsientos.TabIndex = 3;
            this.LbAsientos.Text = "Seleccione sus Asientos";
            // 
            // BtnVenta
            // 
            this.BtnVenta.Location = new System.Drawing.Point(453, 3);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(189, 43);
            this.BtnVenta.TabIndex = 2;
            this.BtnVenta.Text = "Proceder Pago";
            this.BtnVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVenta.UseVisualStyleBackColor = true;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(3, 3);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(170, 43);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "Regresar";
            this.BtnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FlpSeatMap
            // 
            this.FlpSeatMap.Location = new System.Drawing.Point(3, 52);
            this.FlpSeatMap.Name = "FlpSeatMap";
            this.FlpSeatMap.Size = new System.Drawing.Size(1246, 862);
            this.FlpSeatMap.TabIndex = 0;
            // 
            // UpDownGeneral
            // 
            this.UpDownGeneral.Location = new System.Drawing.Point(290, 40);
            this.UpDownGeneral.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.UpDownGeneral.Name = "UpDownGeneral";
            this.UpDownGeneral.Size = new System.Drawing.Size(120, 29);
            this.UpDownGeneral.TabIndex = 1;
            // 
            // LbGeneral
            // 
            this.LbGeneral.AutoSize = true;
            this.LbGeneral.Location = new System.Drawing.Point(34, 40);
            this.LbGeneral.Name = "LbGeneral";
            this.LbGeneral.Size = new System.Drawing.Size(199, 25);
            this.LbGeneral.TabIndex = 0;
            this.LbGeneral.Text = "Cantidad de Boletos :";
            // 
            // BtnNext2
            // 
            this.BtnNext2.Location = new System.Drawing.Point(479, 313);
            this.BtnNext2.Name = "BtnNext2";
            this.BtnNext2.Size = new System.Drawing.Size(154, 51);
            this.BtnNext2.TabIndex = 22;
            this.BtnNext2.Text = "Siguiente";
            this.BtnNext2.UseVisualStyleBackColor = true;
            this.BtnNext2.Click += new System.EventHandler(this.BtnNext2_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(505, 317);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(128, 47);
            this.BtnNext.TabIndex = 25;
            this.BtnNext.Text = "Siguiente";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblPrecioAdto
            // 
            this.LblPrecioAdto.AutoSize = true;
            this.LblPrecioAdto.Location = new System.Drawing.Point(478, 42);
            this.LblPrecioAdto.Name = "LblPrecioAdto";
            this.LblPrecioAdto.Size = new System.Drawing.Size(64, 25);
            this.LblPrecioAdto.TabIndex = 26;
            this.LblPrecioAdto.Text = "label1";
            // 
            // LblPrecioEspecial
            // 
            this.LblPrecioEspecial.AutoSize = true;
            this.LblPrecioEspecial.Location = new System.Drawing.Point(478, 135);
            this.LblPrecioEspecial.Name = "LblPrecioEspecial";
            this.LblPrecioEspecial.Size = new System.Drawing.Size(64, 25);
            this.LblPrecioEspecial.TabIndex = 27;
            this.LblPrecioEspecial.Text = "label2";
            // 
            // LblPrecioGeneral
            // 
            this.LblPrecioGeneral.AutoSize = true;
            this.LblPrecioGeneral.Location = new System.Drawing.Point(478, 40);
            this.LblPrecioGeneral.Name = "LblPrecioGeneral";
            this.LblPrecioGeneral.Size = new System.Drawing.Size(64, 25);
            this.LblPrecioGeneral.TabIndex = 23;
            this.LblPrecioGeneral.Text = "label1";
            // 
            // FormVentaBoletos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 376);
            this.Controls.Add(this.PnlBltEdad);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVentaBoletos";
            this.Text = "FormVentaBoletos";
            this.Load += new System.EventHandler(this.FormVentaBoletos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownAdto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownEspecial)).EndInit();
            this.PnlBltEdad.ResumeLayout(false);
            this.PnlBltEdad.PerformLayout();
            this.PnlBltGeneral.ResumeLayout(false);
            this.PnlBltGeneral.PerformLayout();
            this.PnlSeatMap.ResumeLayout(false);
            this.PnlSeatMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownGeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LbAdto;
        private System.Windows.Forms.Label LbEspecial;
        private System.Windows.Forms.NumericUpDown UpDownAdto;
        private System.Windows.Forms.NumericUpDown UpDownEspecial;
        private System.Windows.Forms.Panel PnlBltEdad;
        private System.Windows.Forms.Panel PnlBltGeneral;
        private System.Windows.Forms.Label LbGeneral;
        private System.Windows.Forms.NumericUpDown UpDownGeneral;
        private System.Windows.Forms.Panel PnlSeatMap;
        private System.Windows.Forms.FlowLayoutPanel FlpSeatMap;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LbAsientos;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnNext2;
        private System.Windows.Forms.Label LblPrecioGeneral;
        private System.Windows.Forms.Label LblPrecioAdto;
        private System.Windows.Forms.Label LblPrecioEspecial;
    }
}