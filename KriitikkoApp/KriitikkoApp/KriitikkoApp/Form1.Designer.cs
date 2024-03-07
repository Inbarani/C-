namespace KriitikkoApp
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.leffanNimi = new System.Windows.Forms.TextBox();
            this.leffanKommentti = new System.Windows.Forms.TextBox();
            this.leffanPituus = new System.Windows.Forms.TextBox();
            this.leffanArvosana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(112, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leffa-arvostelut";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(10, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 154);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lisää uusi arvostelu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kommentti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pituus(h:m:s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Arvosana";
            // 
            // leffanNimi
            // 
            this.leffanNimi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leffanNimi.Location = new System.Drawing.Point(7, 259);
            this.leffanNimi.Name = "leffanNimi";
            this.leffanNimi.Size = new System.Drawing.Size(138, 26);
            this.leffanNimi.TabIndex = 7;
            // 
            // leffanKommentti
            // 
            this.leffanKommentti.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leffanKommentti.Location = new System.Drawing.Point(158, 259);
            this.leffanKommentti.Name = "leffanKommentti";
            this.leffanKommentti.Size = new System.Drawing.Size(227, 26);
            this.leffanKommentti.TabIndex = 8;
            // 
            // leffanPituus
            // 
            this.leffanPituus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leffanPituus.Location = new System.Drawing.Point(398, 258);
            this.leffanPituus.Name = "leffanPituus";
            this.leffanPituus.Size = new System.Drawing.Size(100, 26);
            this.leffanPituus.TabIndex = 9;
            // 
            // leffanArvosana
            // 
            this.leffanArvosana.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leffanArvosana.Location = new System.Drawing.Point(508, 258);
            this.leffanArvosana.Name = "leffanArvosana";
            this.leffanArvosana.Size = new System.Drawing.Size(73, 26);
            this.leffanArvosana.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(7, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Lisää arvostelu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leffanArvosana);
            this.Controls.Add(this.leffanPituus);
            this.Controls.Add(this.leffanKommentti);
            this.Controls.Add(this.leffanNimi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "KriitikkoApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox leffanNimi;
        private System.Windows.Forms.TextBox leffanKommentti;
        private System.Windows.Forms.TextBox leffanPituus;
        private System.Windows.Forms.TextBox leffanArvosana;
        private System.Windows.Forms.Button button1;
    }
}

