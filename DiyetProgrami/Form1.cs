using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetProgrami
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Visible = true;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 4;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
