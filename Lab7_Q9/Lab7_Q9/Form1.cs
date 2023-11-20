using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Q9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5)
            {
                MessageBox.Show("Entered text should be in between 5 characters ");
            }
            else
            {
                MessageBox.Show("OK!! Entered text is in between 5 characters ");
            }
                    
        }
    }
}
