namespace FastFoodDemo
{
    partial class ConvenioEnf
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
            this.fecha1 = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.companero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servicio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.RadioButton();
            this.pago = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.motivo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(174, 180);
            this.fecha1.MinimumSize = new System.Drawing.Size(0, 29);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(226, 29);
            this.fecha1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "FECHA:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(169, 74);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(89, 25);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "NOMBRE";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(326, 499);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 52);
            this.button4.TabIndex = 7;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(116, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOMBRE:";
            // 
            // companero
            // 
            this.companero.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.companero.Location = new System.Drawing.Point(174, 233);
            this.companero.MaxLength = 100;
            this.companero.Name = "companero";
            this.companero.Size = new System.Drawing.Size(427, 33);
            this.companero.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "COMPAÑERA(O):";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.A.Location = new System.Drawing.Point(6, 16);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(42, 29);
            this.A.TabIndex = 18;
            this.A.TabStop = true;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "TURNO:";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.B.Location = new System.Drawing.Point(119, 16);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(41, 29);
            this.B.TabIndex = 21;
            this.B.TabStop = true;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.C.Location = new System.Drawing.Point(231, 16);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(42, 29);
            this.C.TabIndex = 22;
            this.C.TabStop = true;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Location = new System.Drawing.Point(174, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 54);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // servicio
            // 
            this.servicio.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.servicio.Location = new System.Drawing.Point(174, 286);
            this.servicio.MaxLength = 100;
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(427, 33);
            this.servicio.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "DEL SERVICIO DE:";
            // 
            // tiempo
            // 
            this.tiempo.AutoSize = true;
            this.tiempo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tiempo.Location = new System.Drawing.Point(370, 337);
            this.tiempo.Name = "tiempo";
            this.tiempo.Size = new System.Drawing.Size(141, 29);
            this.tiempo.TabIndex = 29;
            this.tiempo.TabStop = true;
            this.tiempo.Text = "CON TIEMPO";
            this.tiempo.UseVisualStyleBackColor = true;
            // 
            // pago
            // 
            this.pago.AutoSize = true;
            this.pago.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pago.Location = new System.Drawing.Point(174, 337);
            this.pago.Name = "pago";
            this.pago.Size = new System.Drawing.Size(190, 29);
            this.pago.TabIndex = 28;
            this.pago.TabStop = true;
            this.pago.Text = "PAGO MONETARIO";
            this.pago.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-4, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "COMPROMISO DE:";
            // 
            // motivo
            // 
            this.motivo.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.motivo.Location = new System.Drawing.Point(174, 396);
            this.motivo.MaxLength = 100;
            this.motivo.Multiline = true;
            this.motivo.Name = "motivo";
            this.motivo.Size = new System.Drawing.Size(427, 61);
            this.motivo.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "MOTIVO:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ConvenioEnf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 561);
            this.ControlBox = false;
            this.Controls.Add(this.motivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tiempo);
            this.Controls.Add(this.pago);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.companero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha1);
            this.Name = "ConvenioEnf";
            this.Text = "Agregar Convenio De Turnos";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime fecha1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox companero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox servicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton tiempo;
        private System.Windows.Forms.RadioButton pago;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox motivo;
        private System.Windows.Forms.Label label10;
    }
}