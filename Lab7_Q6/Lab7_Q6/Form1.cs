using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Lab7_Q6
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                textBox1.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Start();
        }
    }
}
