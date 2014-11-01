using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Top;
            button2.Dock = DockStyle.Bottom;
            
            button4.BringToFront();
            button3.Dock = DockStyle.Bottom;
            button3.BringToFront();
            button4.Dock = DockStyle.Bottom;
            button2.BringToFront();
        }
    }
}
