namespace VendingMachineForm
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
            this.lblBottlePrice = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBottlePrice
            // 
            this.lblBottlePrice.AutoSize = true;
            this.lblBottlePrice.Location = new System.Drawing.Point(70, 51);
            this.lblBottlePrice.Name = "lblBottlePrice";
            this.lblBottlePrice.Size = new System.Drawing.Size(75, 16);
            this.lblBottlePrice.TabIndex = 0;
            this.lblBottlePrice.Text = "Bottle Price";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(239, 45);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(162, 22);
            this.txt1.TabIndex = 1;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(239, 107);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(162, 22);
            this.txt2.TabIndex = 3;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(70, 110);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(76, 16);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Bottle count";
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(239, 166);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(162, 22);
            this.Txt3.TabIndex = 5;
            this.Txt3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(70, 172);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 16);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Add Bottle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblBottlePrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBottlePrice;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.Label lbl3;
    }
}

