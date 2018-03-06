namespace _1SA_2SE_Laurin_Mair
{
    partial class tanken
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marke = new System.Windows.Forms.TextBox();
            this.farbe = new System.Windows.Forms.TextBox();
            this.ps = new System.Windows.Forms.TextBox();
            this.Tankgröse = new System.Windows.Forms.TextBox();
            this.verbrauch = new System.Windows.Forms.TextBox();
            this.autoerstellen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tank = new System.Windows.Forms.Button();
            this.fahren = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marke:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Farbe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ps:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tankgröße:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Verbrauch:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Neues Auto erstellen:";
            // 
            // marke
            // 
            this.marke.Location = new System.Drawing.Point(183, 44);
            this.marke.Name = "marke";
            this.marke.Size = new System.Drawing.Size(100, 20);
            this.marke.TabIndex = 6;
            this.marke.TextChanged += new System.EventHandler(this.marke_TextChanged);
            // 
            // farbe
            // 
            this.farbe.Location = new System.Drawing.Point(183, 78);
            this.farbe.Name = "farbe";
            this.farbe.Size = new System.Drawing.Size(100, 20);
            this.farbe.TabIndex = 7;
            this.farbe.TextChanged += new System.EventHandler(this.farbe_TextChanged);
            // 
            // ps
            // 
            this.ps.Location = new System.Drawing.Point(183, 109);
            this.ps.Name = "ps";
            this.ps.Size = new System.Drawing.Size(100, 20);
            this.ps.TabIndex = 8;
            this.ps.TextChanged += new System.EventHandler(this.ps_TextChanged);
            // 
            // Tankgröse
            // 
            this.Tankgröse.Location = new System.Drawing.Point(393, 40);
            this.Tankgröse.Name = "Tankgröse";
            this.Tankgröse.Size = new System.Drawing.Size(100, 20);
            this.Tankgröse.TabIndex = 9;
            this.Tankgröse.TextChanged += new System.EventHandler(this.Tankgröse_TextChanged);
            // 
            // verbrauch
            // 
            this.verbrauch.Location = new System.Drawing.Point(393, 81);
            this.verbrauch.Name = "verbrauch";
            this.verbrauch.Size = new System.Drawing.Size(100, 20);
            this.verbrauch.TabIndex = 10;
            this.verbrauch.TextChanged += new System.EventHandler(this.verbrauch_TextChanged);
            // 
            // autoerstellen
            // 
            this.autoerstellen.Location = new System.Drawing.Point(393, 129);
            this.autoerstellen.Name = "autoerstellen";
            this.autoerstellen.Size = new System.Drawing.Size(100, 23);
            this.autoerstellen.TabIndex = 11;
            this.autoerstellen.Text = "Auto erstellen";
            this.autoerstellen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tanken:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Liter";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fahren:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "km";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(145, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // tank
            // 
            this.tank.Location = new System.Drawing.Point(328, 249);
            this.tank.Name = "tank";
            this.tank.Size = new System.Drawing.Size(75, 23);
            this.tank.TabIndex = 20;
            this.tank.Text = "Tanken";
            this.tank.UseVisualStyleBackColor = true;
            // 
            // fahren
            // 
            this.fahren.Location = new System.Drawing.Point(328, 349);
            this.fahren.Name = "fahren";
            this.fahren.Size = new System.Drawing.Size(75, 23);
            this.fahren.TabIndex = 21;
            this.fahren.Text = "Fahren";
            this.fahren.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(149, 280);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(250, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Informationen:";
            // 
            // tanken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 602);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.fahren);
            this.Controls.Add(this.tank);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.autoerstellen);
            this.Controls.Add(this.verbrauch);
            this.Controls.Add(this.Tankgröse);
            this.Controls.Add(this.ps);
            this.Controls.Add(this.farbe);
            this.Controls.Add(this.marke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tanken";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox marke;
        private System.Windows.Forms.TextBox farbe;
        private System.Windows.Forms.TextBox ps;
        private System.Windows.Forms.TextBox Tankgröse;
        private System.Windows.Forms.TextBox verbrauch;
        private System.Windows.Forms.Button autoerstellen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button tank;
        private System.Windows.Forms.Button fahren;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
    }
}

