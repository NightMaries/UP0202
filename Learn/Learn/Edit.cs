﻿using System;
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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //открытие главной формы
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
