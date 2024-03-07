namespace DiceGame
{
    partial class DiceGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUusiPeli = new System.Windows.Forms.Button();
            this.btnJatkaPeli = new System.Windows.Forms.Button();
            this.btnHeittaNoppa = new System.Windows.Forms.Button();
            this.txtPelaaja1Piste = new System.Windows.Forms.TextBox();
            this.txtPelaaja2Piste = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPelaajaTieto = new System.Windows.Forms.TextBox();
            this.comboBoxGameOptions = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGameOptions2 = new System.Windows.Forms.ComboBox();
            this.pausebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sikka Noppa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelaaja1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pelaaja2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(507, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valitse Pelaaja1";
            // 
            // btnUusiPeli
            // 
            this.btnUusiPeli.Location = new System.Drawing.Point(404, 202);
            this.btnUusiPeli.Name = "btnUusiPeli";
            this.btnUusiPeli.Size = new System.Drawing.Size(119, 49);
            this.btnUusiPeli.TabIndex = 7;
            this.btnUusiPeli.Text = "Uusi Peli";
            this.btnUusiPeli.UseVisualStyleBackColor = true;
            this.btnUusiPeli.Click += new System.EventHandler(this.btnUusiPeli_Click);
            // 
            // btnJatkaPeli
            // 
            this.btnJatkaPeli.Location = new System.Drawing.Point(145, 202);
            this.btnJatkaPeli.Name = "btnJatkaPeli";
            this.btnJatkaPeli.Size = new System.Drawing.Size(119, 48);
            this.btnJatkaPeli.TabIndex = 8;
            this.btnJatkaPeli.Text = "Jatka Peli";
            this.btnJatkaPeli.UseVisualStyleBackColor = true;
            // 
            // btnHeittaNoppa
            // 
            this.btnHeittaNoppa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeittaNoppa.Location = new System.Drawing.Point(276, 272);
            this.btnHeittaNoppa.Name = "btnHeittaNoppa";
            this.btnHeittaNoppa.Size = new System.Drawing.Size(150, 59);
            this.btnHeittaNoppa.TabIndex = 9;
            this.btnHeittaNoppa.Text = "Heita Noppa";
            this.btnHeittaNoppa.UseVisualStyleBackColor = true;
            this.btnHeittaNoppa.Click += new System.EventHandler(this.btnHeittaNoppa_Click);
            // 
            // txtPelaaja1Piste
            // 
            this.txtPelaaja1Piste.Location = new System.Drawing.Point(79, 78);
            this.txtPelaaja1Piste.Name = "txtPelaaja1Piste";
            this.txtPelaaja1Piste.Size = new System.Drawing.Size(100, 22);
            this.txtPelaaja1Piste.TabIndex = 10;
            // 
            // txtPelaaja2Piste
            // 
            this.txtPelaaja2Piste.Location = new System.Drawing.Point(79, 117);
            this.txtPelaaja2Piste.Name = "txtPelaaja2Piste";
            this.txtPelaaja2Piste.Size = new System.Drawing.Size(100, 22);
            this.txtPelaaja2Piste.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pisteet";
            // 
            // txtPelaajaTieto
            // 
            this.txtPelaajaTieto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtPelaajaTieto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPelaajaTieto.Location = new System.Drawing.Point(215, 79);
            this.txtPelaajaTieto.Multiline = true;
            this.txtPelaajaTieto.Name = "txtPelaajaTieto";
            this.txtPelaajaTieto.Size = new System.Drawing.Size(262, 63);
            this.txtPelaajaTieto.TabIndex = 13;
            // 
            // comboBoxGameOptions
            // 
            this.comboBoxGameOptions.FormattingEnabled = true;
            this.comboBoxGameOptions.Location = new System.Drawing.Point(511, 70);
            this.comboBoxGameOptions.Name = "comboBoxGameOptions";
            this.comboBoxGameOptions.Size = new System.Drawing.Size(150, 24);
            this.comboBoxGameOptions.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valitse Pelaaja2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBoxGameOptions2
            // 
            this.comboBoxGameOptions2.FormattingEnabled = true;
            this.comboBoxGameOptions2.Location = new System.Drawing.Point(511, 158);
            this.comboBoxGameOptions2.Name = "comboBoxGameOptions2";
            this.comboBoxGameOptions2.Size = new System.Drawing.Size(150, 24);
            this.comboBoxGameOptions2.TabIndex = 16;
            // 
            // pausebtn
            // 
            this.pausebtn.Location = new System.Drawing.Point(276, 203);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(119, 48);
            this.pausebtn.TabIndex = 17;
            this.pausebtn.Text = "Pause";
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // DiceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 388);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.comboBoxGameOptions2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGameOptions);
            this.Controls.Add(this.txtPelaajaTieto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPelaaja2Piste);
            this.Controls.Add(this.txtPelaaja1Piste);
            this.Controls.Add(this.btnHeittaNoppa);
            this.Controls.Add(this.btnJatkaPeli);
            this.Controls.Add(this.btnUusiPeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DiceGame";
            this.Text = "DiceGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUusiPeli;
        private System.Windows.Forms.Button btnJatkaPeli;
        private System.Windows.Forms.Button btnHeittaNoppa;
        private System.Windows.Forms.TextBox txtPelaaja1Piste;
        private System.Windows.Forms.TextBox txtPelaaja2Piste;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPelaajaTieto;
        private System.Windows.Forms.ComboBox comboBoxGameOptions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGameOptions2;
        private System.Windows.Forms.Button pausebtn;
    }
}

