using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace demoapp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            initial_speed_form.Text = Properties.Settings.Default.initialSpeed.ToString();
            final_speed_form.Text = Properties.Settings.Default.maxSpeed.ToString();
            acceleration_form.Text = Properties.Settings.Default.acceleration.ToString();         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.acceleration = int.Parse(acceleration_form.Text);
            Properties.Settings.Default.maxSpeed = int.Parse(final_speed_form.Text);
            Properties.Settings.Default.initialSpeed = int.Parse(initial_speed_form.Text);
            Properties.Settings.Default.Save();

            this.Close();
        }

        private void ok_button_Validating(object sender, CancelEventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            if(!reg.IsMatch(acceleration_form.Text) || !reg.IsMatch(final_speed_form.Text) || !reg.IsMatch(initial_speed_form.Text))
            {
                MessageBox.Show("入力値が不正です");
                e.Cancel = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
