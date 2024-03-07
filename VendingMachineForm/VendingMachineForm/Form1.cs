using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendingMachineForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            double bottleprice = 2;
            int Initialbottlecount = 5;
            txt1.Text= bottleprice.ToString("n");
           txt2.Text= Initialbottlecount.ToString("n");
              }
       

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            //Convert.ToDouble(Txt3.Text);
            // Convert.ToDouble(txt2.Text);
            //txt2.Text = (int.Parse(txt2.Text) )+ (int.Parse(Txt3.Text)).ToString;
            //txt2.Text =Txt3.Text + txt2.Text;
            
            //Txt3.Text)) + (Convert.ToDouble(txt2.Text)).ToString();
            //int x = (int)Convert.ToDouble(Txt3.Text + txt2.Text);
            // txt2.Text = x.ToString("n");

        }
    }
}
