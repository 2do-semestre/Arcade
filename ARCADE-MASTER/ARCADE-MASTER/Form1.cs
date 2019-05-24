using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARCADE_MASTER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl2.Visible = true;
        }
        public void menu()
        {
            tabControl2.Visible = false;
        }
        private void BtnMenu4_Click(object sender, EventArgs e)
        {
            menu();
        }
        private void BtnMenu3_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void BtnMenu2_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void BtnMenu1_Click(object sender, EventArgs e)
        {
            menu();
        }

        private void BtnAjustesMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnScoresMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
