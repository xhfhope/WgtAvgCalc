using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t1WS = 0.0;
            double t2WS = 0.0;
            double t3WS = 0.0;
            double t4WS = 0.0;

            if (t1Input.Text != "")
            {
                t1WS = double.Parse(t1Input.Text) * (double.Parse(t1Weight.Text) * .01);
                sc1.Text = t1WS.ToString();
            }
            if (t2Input.Text != "")
            {
                t2WS = double.Parse(t2Input.Text) * (double.Parse(t2Weight.Text) * .01);
                sc2.Text = t2WS.ToString();
            }
            if(t3Input.Text!="")
            {
                t3WS = double.Parse(t3Input.Text) * (double.Parse(t3Weight.Text) * .01);
                sc3.Text = t3WS.ToString();
            }
            if (t4Input.Text != "")
            {
                t4WS = double.Parse(t4Input.Text) * (double.Parse(t4Weight.Text) * .01);
                sc4.Text = t4WS.ToString();
            }

            Output.Text = (t1WS + t2WS + t3WS + t4WS).ToString();
        }
    }
}
