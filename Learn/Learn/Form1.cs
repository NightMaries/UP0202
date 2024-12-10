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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
            this.Hide();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Show();
            this.Hide();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "school_21ip213DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.school_21ip213DataSet.Service);
            //отключение работоспособности кнопок
            
            EditButton.Enabled = false;
            ViewButton.Enabled = false;
            RecordButton.Enabled = false;

        }

        private void kodButton_Click(object sender, EventArgs e)
        {
            //при правильном пароле кнопки активирутся
            if (kodBox.Text == "0000")
            {
                EditButton.Enabled = true;
                ViewButton.Enabled = true;
                RecordButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrected password");
            }
        }
    }
}
