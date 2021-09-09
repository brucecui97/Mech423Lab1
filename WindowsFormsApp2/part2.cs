﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Queue<Int32> dataQueue = new Queue<Int32>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataQueue.Enqueue(Convert.ToInt32(enqueTextBox.Text));
        }

        private void dequeButton_Click(object sender, EventArgs e)
        {
            if (dataQueue.Count == 0)
            {
                MessageBox.Show("error. You cannot dequeu a queue of size 0");
            }
            else {
                dataQueue.Dequeue();
            }
        }

        private void enqueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateQueue() {

            foreach (int data in dataQueue) {
                queueContentsTxtBox.AppendText(Convert.ToString(data) + ",");
            }

        }
    }
}
