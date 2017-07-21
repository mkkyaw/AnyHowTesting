using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyHowTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Counter counter = new Counter();
            counter.NumberReached += AlreadyNumberReached;
            counter.CountTo(1, 1);
            counter.CountTo(1, 2);
            
        }

        protected void AlreadyNumberReached(object sender, NumberReachedEventArgs e)
        {
            MessageBox.Show(e.ReachedNumber.ToString());
        }
    }
}
