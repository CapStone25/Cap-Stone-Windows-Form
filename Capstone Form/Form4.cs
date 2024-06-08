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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 form13 = new Form13();
            Form14 form14 = new Form14();
            Form15 form15 = new Form15();
            form13.Show();
            form14.Show();
            form15.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form16 form16 = new Form16();
            form16.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form17 form17 = new Form17();
            form17.Show();
        }
    }
}
