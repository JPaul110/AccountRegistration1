﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.StudentNo = long.Parse(textBox1.Text);
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.LastName = textBox2.Text.ToString();
            StudentInfoClass.FirstName = textBox3.Text.ToString();
            StudentInfoClass.MiddleName = textBox4.Text.ToString();
            StudentInfoClass.Age = long.Parse(textBox5.Text);
            StudentInfoClass.ContactNo = long.Parse(textBox6.Text);
            StudentInfoClass.Address = textBox7.Text.ToString();

            FrmConfirm Frm = new FrmConfirm();
            DialogResult Result = new DialogResult();
            Result = Frm.ShowDialog();
            if (Result == DialogResult.OK)
            {                
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                comboBox1.SelectedIndex = -1;
            }

        }
    }
}
