using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleModels;

namespace VehicleView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<IVehicle> trams;

        public void Print_info(Tram print, int index)
        {
            dgv[0, index].Value = (index + 1).ToString();
            dgv[1, index].Value = print.TypeVehicle;
            dgv[2, index].Value = print.CurrentSpeed.ToString();
            dgv[3, index].Value = print.MaxSpeed.ToString();
            if (print.IsOverSpeed() == true)
            {
                dgv[4, index].Value = "Да";
            }
            else
            {
                dgv[4, index].Value = "Нет";
            }

            dgv[5, index].Value = print.CurrentPassCount.ToString();
            dgv[6, index].Value = print.MaxPassCount.ToString();
            if (print.IsOverFlow() == true)
            {
                dgv[7, index].Value = "Да";
            }
            else
            {
                dgv[7, index].Value = "Нет";
            }
            dgv[8, index].Value = print.CostTicket.ToString();

            dgv[9, index].Value = print.StopsCount.ToString();
            dgv[10, index].Value = print.TimeAverage.ToString();
            dgv[11, index].Value = print.TotalTimeStops();
            dgv[12, index].Value = print.TotalProfit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.trams = new List<IVehicle>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tram t = new Tram();
            t.TypeVehicle = "Трамвай";
            t.CurrentSpeed = Convert.ToInt32(this.textBox1.Text);
            t.MaxSpeed = Convert.ToInt32(this.textBox5.Text);
            t.CurrentPassCount = Convert.ToInt32(this.textBox2.Text);
            t.MaxPassCount = Convert.ToInt32(this.textBox3.Text);
            t.CostTicket = Convert.ToInt32(this.textBox4.Text);
            t.StopsCount = ( int )this.numericUpDown1.Value;
            t.TimeAverage = Convert.ToDouble(this.textBox6.Text);

            trams.Add(t);
            if (t.IsOverSpeed())
                MessageBox.Show(t.TypeVehicle +" №"+ trams.Count()+" превысил скорость. Погасите штраф в размере "+ t.GetFine()+".", "Сообщение о штрафе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            this.dgv.RowCount++;
            this.Print_info(t, trams.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.numericUpDown1.Value = this.numericUpDown1.Minimum;
            this.textBox5.Clear();
            this.textBox6.Clear();
            this.textBox1.Focus();
        }
    }

}
