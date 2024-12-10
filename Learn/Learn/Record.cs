using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_21ip213DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_21ip213DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_21ip213DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.school_21ip213DataSet1.Client);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //преобразование часов и минут в секунды
        int TimeInSecond(int a, int b) 
        {
            return a * 3600 + b * 60;
        }

        //метод для преобразования секунд в часы и минуты
        public void SecondInHoursAndMinuts( int sec, out int hr , out int min)
        {
            hr = sec / 3600;
            min = (sec %3600)/ 60;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            int ch, min, sec;
            
            ch = Convert.ToInt32(textBox1.Text);

            min = Convert.ToInt32(textBox2.Text);

            sec = TimeInSecond(ch, min);
            int dur = Convert.ToInt32(textBox3.Text);
            sec = sec + dur;
            SecondInHoursAndMinuts(sec, out ch, out min);
            textBox5.Text = Convert.ToString(ch);
            sec %= 3600;
            textBox4.Text = Convert.ToString(min);
        }
    }
}
