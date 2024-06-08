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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            Form6 form6 = new Form6();
            form5.Show();
            form6.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
