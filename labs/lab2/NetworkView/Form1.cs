using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetworkModel;

namespace NetworkView
{
    public partial class fmain : Form
    {
        public fmain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int count = Convert.ToInt32(this.numericUpDown1.Value);
            double dist = Convert.ToDouble(this.textBox2.Text);

            PC_Network pc = new PC_Network(name, count, dist);
            MessageBox.Show("Информация о новой компьютерной сети добавлена в БД", "Сообщение для пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
            net.Add(pc);
            this.dataGridView1.RowCount++;

            int row_index = net.Count - 1;
            this.dataGridView1[0, row_index].Value = (row_index + 1).ToString();
            this.dataGridView1[1, row_index].Value = name;
            this.dataGridView1[2, row_index].Value = count.ToString();
            this.dataGridView1[3, row_index].Value = dist.ToString();
            this.dataGridView1[4, row_index].Value = pc.Get_quality().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.numericUpDown1.Value = 1;
            this.textBox2.Clear();
            this.textBox1.Focus();
        }

        public List<PC_Network> net;
        public List<Speed_Network> speed_net;

        private void fmain_Load(object sender, EventArgs e)
        {
            this.net = new List<PC_Network>();
            this.speed_net = new List<Speed_Network>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
            this.textBox3.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int count = Convert.ToInt32(this.numericUpDown1.Value);
            double dist = Convert.ToDouble(this.textBox2.Text);
            double speed = Convert.ToDouble(this.textBox3.Text);

            Speed_Network sn = new Speed_Network(name, count, dist, speed);
            MessageBox.Show("Информация о новой скоростной компьютерной сети добавлена в БД", "Сообщение для пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
            speed_net.Add(sn);
            this.dataGridView2.RowCount++;

            int row_index = speed_net.Count - 1;
            this.dataGridView2[0, row_index].Value = (row_index + 1).ToString();
            this.dataGridView2[1, row_index].Value = name;
            this.dataGridView2[2, row_index].Value = count.ToString();
            this.dataGridView2[3, row_index].Value = dist.ToString();
            this.dataGridView2[4, row_index].Value = speed.ToString();
            this.dataGridView2[5, row_index].Value = sn.Get_quality().ToString();
        }
    }
   
}
