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
            dgv[1, index].Value = print.Type_vehicle;
            dgv[2, index].Value = print.Current_speed.ToString();
            dgv[3, index].Value = print.Max_speed.ToString();
            if (print.Is_overspeed() == true)
            {
                dgv[4, index].Value = "Да";
            }
            else
            {
                dgv[4, index].Value = "Нет";
            }

            dgv[5, index].Value = print.Current_pass_count.ToString();
            dgv[6, index].Value = print.Max_pass_count.ToString();
            if (print.Is_overflow() == true)
            {
                dgv[7, index].Value = "Да";
            }
            else
            {
                dgv[7, index].Value = "Нет";
            }
            dgv[8, index].Value = print.Cost_ticket.ToString();

            dgv[9, index].Value = print.Stops_count.ToString();
            dgv[10, index].Value = print.Time_average.ToString();
            dgv[11, index].Value = print.Total_time_stops();
            dgv[12, index].Value = print.Total_profit();
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
            t.Type_vehicle = "Трамвай";
            t.Current_speed = Convert.ToInt32(this.textBox1.Text);
            t.Max_speed = Convert.ToInt32(this.textBox5.Text);
            t.Current_pass_count = Convert.ToInt32(this.textBox2.Text);
            t.Max_pass_count = Convert.ToInt32(this.textBox3.Text);
            t.Cost_ticket = Convert.ToInt32(this.textBox4.Text);
            t.Stops_count = ( int )this.numericUpDown1.Value;
            t.Time_average = Convert.ToDouble(this.textBox6.Text);

            trams.Add(t);
            MessageBox.Show("Информация о новом трамвае успешно добавлена в базу данных.", "Сообщение для пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
