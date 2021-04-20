using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ww2PicBx.Visible = false;
            pcPicBx.Visible = false;
            tvPicBx.Visible = false;
        }

        private void answerBtn1_Click(object sender, EventArgs e)
        {
            answerLbl.Text = "September 1, 1939";
            ww2PicBx.Visible = true;
            pcPicBx.Visible = false;
            tvPicBx.Visible = false;
        }

        private void answerBtn2_Click(object sender, EventArgs e)
        {
            answerLbl.Text = "1822";
            ww2PicBx.Visible = false;
            pcPicBx.Visible = true;
            tvPicBx.Visible = false;
        }

        private void q2Lbl_Click(object sender, EventArgs e)
        {

        }

        private void answerBtn3_Click(object sender, EventArgs e)
        {
            ww2PicBx.Visible = false;
            pcPicBx.Visible = false;
            tvPicBx.Visible = true;
            answerLbl.Text = "Sept. 7, 1927";


        }
    }
}
