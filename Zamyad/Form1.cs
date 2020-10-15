using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamyad
{

    public delegate void XHandler(object sender, System.EventArgs e); // 1
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        Stack oStack = new Stack();

        private void Form1_Load(object sender, EventArgs e)
        {
            oStack.X += new XHandler(oStack_X); //5
        }

        private static void oStack_X(object sender, System.EventArgs e) // 6th 
        {
            System.Windows.Forms.MessageBox.Show("Stack Over Flow");
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
               int Temp = Convert.ToInt32(textBox1.Text);
                oStack.Amount = Temp + oStack.Amount;
                textBox1.Text = "";
            }
        }
    }
}
