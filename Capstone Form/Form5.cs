using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone_Form
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 form9 = new Form9();
            form9.Show();
        }
    }
}
