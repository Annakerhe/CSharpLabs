using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleReflectionView
{
    public partial class Form2 : Form
    {
        public string value;
        public Form2(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            value = textBox1.Text;
            this.Close();
        }
    }
}
