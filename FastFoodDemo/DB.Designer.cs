namespace RecursoHumano
{
    partial class DB
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
            this.cat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cox = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cat
            // 
            this.cat.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cat.Location = new System.Drawing.Point(190, 108);
            this.cat.MaxLength = 100;
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(230, 33);
            this.cat.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "CATALOGO:";
            // 
            // bd
            // 
            this.bd.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bd.Location = new System.Drawing.Point(190, 42);
            this.bd.MaxLength = 100;
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(230, 33);
            this.bd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "BASE DE DATOS:";
            // 
            // pass
            // 
            this.pass.Enabled = false;
            this.pass.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.pass.Location = new System.Drawing.Point(190, 248);
            this.pass.MaxLength = 100;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(230, 33);
            this.pass.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONTRASEÑA:";
            // 
            // user
            // 
            this.user.Enabled = false;
            this.user.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.user.Location = new System.Drawing.Point(190, 182);
            this.user.MaxLength = 100;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(230, 33);
            this.user.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "USUARIO:";
            // 
            // cox
            // 
            this.cox.AutoSize = true;
            this.cox.Location = new System.Drawing.Point(190, 158);
            this.cox.Name = "cox";
            this.cox.Size = new System.Drawing.Size(132, 17);
            this.cox.TabIndex = 23;
            this.cox.Text = "CONEXION POR SQL";
            this.cox.UseVisualStyleBackColor = true;
            this.cox.CheckedChanged += new System.EventHandler(this.cox_CheckedChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(181)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(306, 324);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 52);
            this.button4.TabIndex = 24;
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
            this.button1.Location = new System.Drawing.Point(93, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 399);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.cox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.label3);
            this.Name = "DB";
            this.Load += new System.EventHandler(this.DB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
    }
}