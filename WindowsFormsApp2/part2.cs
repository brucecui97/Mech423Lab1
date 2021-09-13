using System;
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
        Timer updateQueueDisplayTimer;
        public Form1()
        {
            InitializeComponent();
            updateQueueDisplayTimer = new Timer();
            updateQueueDisplayTimer.Interval = 100; //ms
            updateQueueDisplayTimer.Tick += UpdateQueueDisplayTimer_Tick;
            updateQueueDisplayTimer.Start();
        }
        private void UpdateQueueDisplayTimer_Tick(object sender, EventArgs e)
        {
            updateQueue();
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
                dequeTxtBox.Text= dataQueue.Dequeue().ToString();
                
            }
        }

        private void enqueTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void updateQueue() {
            queueContentsTxtBox.Clear();
            foreach (int data in dataQueue) {
                queueContentsTxtBox.AppendText(Convert.ToString(data) + ",");
            }
            itemsInQueueTxtBox.Text = dataQueue.Count.ToString();

        }

        private void DequeAndAverage_Click(object sender, EventArgs e)
        {
            int N = -1;

            if (!int.TryParse(nTxtBox.Text, out N))
            {
                MessageBox.Show("the N value you entered is not an int");
            }
            else if (N <= 0)
            {
                MessageBox.Show("the N value you entered is less than or equal 0");
            }

            else if (dataQueue.Count<N) {
                MessageBox.Show("the N value you entered is greater than size of the queue");
            }
            else {
                List<int> poppedValues = new List<int>();
                for (int i = 0; i < N; i++) {
                    poppedValues.Add(dataQueue.Dequeue());
                }
                averageTxtBox.Text = Convert.ToString(poppedValues.Average());
            }
        }
    }
}
