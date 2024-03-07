namespace Sanalomake
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
            this.ohje1 = new System.Windows.Forms.TextBox();
            this.lisaysruutu = new System.Windows.Forms.TextBox();
            this.lisaysnappula = new System.Windows.Forms.Button();
            this.ohje2 = new System.Windows.Forms.TextBox();
            this.naytaOikein = new System.Windows.Forms.Button();
            this.kaantaennappula = new System.Windows.Forms.Button();
            this.nayttoruutu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ohje1
            // 
            this.ohje1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ohje1.Location = new System.Drawing.Point(17, 16);
            this.ohje1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ohje1.Multiline = true;
            this.ohje1.Name = "ohje1";
            this.ohje1.ReadOnly = true;
            this.ohje1.Size = new System.Drawing.Size(400, 25);
            this.ohje1.TabIndex = 0;
            // 
            // lisaysruutu
            // 
            this.lisaysruutu.Location = new System.Drawing.Point(17, 60);
            this.lisaysruutu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lisaysruutu.Name = "lisaysruutu";
            this.lisaysruutu.Size = new System.Drawing.Size(192, 22);
            this.lisaysruutu.TabIndex = 1;
            this.lisaysruutu.TextChanged += new System.EventHandler(this.lisaysruutu_TextChanged);
            // 
            // lisaysnappula
            // 
            this.lisaysnappula.Location = new System.Drawing.Point(219, 58);
            this.lisaysnappula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lisaysnappula.Name = "lisaysnappula";
            this.lisaysnappula.Size = new System.Drawing.Size(100, 28);
            this.lisaysnappula.TabIndex = 2;
            this.lisaysnappula.Text = "Lisää sana";
            this.lisaysnappula.UseVisualStyleBackColor = true;
            this.lisaysnappula.Click += new System.EventHandler(this.lisaysnappula_Click);
            // 
            // ohje2
            // 
            this.ohje2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ohje2.Location = new System.Drawing.Point(17, 107);
            this.ohje2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ohje2.Multiline = true;
            this.ohje2.Name = "ohje2";
            this.ohje2.ReadOnly = true;
            this.ohje2.Size = new System.Drawing.Size(400, 49);
            this.ohje2.TabIndex = 3;
            // 
            // naytaOikein
            // 
            this.naytaOikein.Location = new System.Drawing.Point(17, 153);
            this.naytaOikein.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naytaOikein.Name = "naytaOikein";
            this.naytaOikein.Size = new System.Drawing.Size(193, 28);
            this.naytaOikein.TabIndex = 4;
            this.naytaOikein.Text = "Näytä syöttöjärjestyksessä";
            this.naytaOikein.UseVisualStyleBackColor = true;
            this.naytaOikein.Click += new System.EventHandler(this.naytaOikein_Click);
            // 
            // kaantaennappula
            // 
            this.kaantaennappula.Location = new System.Drawing.Point(219, 153);
            this.kaantaennappula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kaantaennappula.Name = "kaantaennappula";
            this.kaantaennappula.Size = new System.Drawing.Size(199, 28);
            this.kaantaennappula.TabIndex = 5;
            this.kaantaennappula.Text = "Näytä kääntäen";
            this.kaantaennappula.UseVisualStyleBackColor = true;
            this.kaantaennappula.Click += new System.EventHandler(this.kaantaennappula_Click);
            // 
            // nayttoruutu
            // 
            this.nayttoruutu.BackColor = System.Drawing.SystemColors.Window;
            this.nayttoruutu.Location = new System.Drawing.Point(145, 188);
            this.nayttoruutu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nayttoruutu.Multiline = true;
            this.nayttoruutu.Name = "nayttoruutu";
            this.nayttoruutu.ReadOnly = true;
            this.nayttoruutu.Size = new System.Drawing.Size(199, 122);
            this.nayttoruutu.TabIndex = 6;
            this.nayttoruutu.TextChanged += new System.EventHandler(this.nayttoruutu_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 350);
            this.Controls.Add(this.nayttoruutu);
            this.Controls.Add(this.kaantaennappula);
            this.Controls.Add(this.naytaOikein);
            this.Controls.Add(this.ohje2);
            this.Controls.Add(this.lisaysnappula);
            this.Controls.Add(this.lisaysruutu);
            this.Controls.Add(this.ohje1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ohje1;
        private System.Windows.Forms.TextBox lisaysruutu;
        private System.Windows.Forms.Button lisaysnappula;
        private System.Windows.Forms.TextBox ohje2;
        private System.Windows.Forms.Button naytaOikein;
        private System.Windows.Forms.Button kaantaennappula;
        private System.Windows.Forms.TextBox nayttoruutu;
    }
}

