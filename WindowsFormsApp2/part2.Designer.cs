namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enqueTextBox = new System.Windows.Forms.TextBox();
            this.enqueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.itemsInQueueTxtBox = new System.Windows.Forms.TextBox();
            this.dequeTxtBox = new System.Windows.Forms.TextBox();
            this.DequeAndAverage = new System.Windows.Forms.Button();
            this.nTxtBox = new System.Windows.Forms.TextBox();
            this.averageTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queueContentsTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enqueTextBox
            // 
            this.enqueTextBox.Location = new System.Drawing.Point(129, 17);
            this.enqueTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enqueTextBox.Name = "enqueTextBox";
            this.enqueTextBox.Size = new System.Drawing.Size(114, 27);
            this.enqueTextBox.TabIndex = 0;
            this.enqueTextBox.TextChanged += new System.EventHandler(this.enqueTextBox_TextChanged);
            // 
            // enqueButton
            // 
            this.enqueButton.Location = new System.Drawing.Point(37, 16);
            this.enqueButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.enqueButton.Name = "enqueButton";
            this.enqueButton.Size = new System.Drawing.Size(86, 31);
            this.enqueButton.TabIndex = 1;
            this.enqueButton.Text = "Enqueue";
            this.enqueButton.UseVisualStyleBackColor = true;
            this.enqueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items in Queue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "N: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average: ";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(37, 76);
            this.test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(86, 31);
            this.test.TabIndex = 1;
            this.test.Text = "Dequeue";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.dequeButton_Click);
            // 
            // itemsInQueueTxtBox
            // 
            this.itemsInQueueTxtBox.Location = new System.Drawing.Point(129, 129);
            this.itemsInQueueTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsInQueueTxtBox.Name = "itemsInQueueTxtBox";
            this.itemsInQueueTxtBox.Size = new System.Drawing.Size(114, 27);
            this.itemsInQueueTxtBox.TabIndex = 0;
            // 
            // dequeTxtBox
            // 
            this.dequeTxtBox.Location = new System.Drawing.Point(129, 76);
            this.dequeTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dequeTxtBox.Name = "dequeTxtBox";
            this.dequeTxtBox.Size = new System.Drawing.Size(114, 27);
            this.dequeTxtBox.TabIndex = 0;
            // 
            // DequeAndAverage
            // 
            this.DequeAndAverage.Location = new System.Drawing.Point(23, 199);
            this.DequeAndAverage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DequeAndAverage.Name = "DequeAndAverage";
            this.DequeAndAverage.Size = new System.Drawing.Size(227, 31);
            this.DequeAndAverage.TabIndex = 1;
            this.DequeAndAverage.Text = "Deque and Average First N Data Points";
            this.DequeAndAverage.UseVisualStyleBackColor = true;
            this.DequeAndAverage.Click += new System.EventHandler(this.DequeAndAverage_Click);
            // 
            // nTxtBox
            // 
            this.nTxtBox.Location = new System.Drawing.Point(37, 251);
            this.nTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nTxtBox.Name = "nTxtBox";
            this.nTxtBox.Size = new System.Drawing.Size(61, 27);
            this.nTxtBox.TabIndex = 0;
            // 
            // averageTxtBox
            // 
            this.averageTxtBox.Location = new System.Drawing.Point(176, 255);
            this.averageTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.averageTxtBox.Name = "averageTxtBox";
            this.averageTxtBox.Size = new System.Drawing.Size(50, 27);
            this.averageTxtBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Queue Contents";
            // 
            // queueContentsTxtBox
            // 
            this.queueContentsTxtBox.Location = new System.Drawing.Point(14, 348);
            this.queueContentsTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.queueContentsTxtBox.Multiline = true;
            this.queueContentsTxtBox.Name = "queueContentsTxtBox";
            this.queueContentsTxtBox.Size = new System.Drawing.Size(209, 229);
            this.queueContentsTxtBox.TabIndex = 0;
            this.queueContentsTxtBox.TextChanged += new System.EventHandler(this.queueContentsTxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 613);
            this.Controls.Add(this.queueContentsTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageTxtBox);
            this.Controls.Add(this.nTxtBox);
            this.Controls.Add(this.DequeAndAverage);
            this.Controls.Add(this.dequeTxtBox);
            this.Controls.Add(this.itemsInQueueTxtBox);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enqueButton);
            this.Controls.Add(this.enqueTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enqueTextBox;
        private System.Windows.Forms.Button enqueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox itemsInQueueTxtBox;
        private System.Windows.Forms.TextBox dequeTxtBox;
        private System.Windows.Forms.Button DequeAndAverage;
        private System.Windows.Forms.TextBox nTxtBox;
        private System.Windows.Forms.TextBox averageTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox queueContentsTxtBox;
    }
}

