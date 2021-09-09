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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DequeAndAverage = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.queueContentsTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enqueTextBox
            // 
            this.enqueTextBox.Location = new System.Drawing.Point(113, 13);
            this.enqueTextBox.Name = "enqueTextBox";
            this.enqueTextBox.Size = new System.Drawing.Size(100, 23);
            this.enqueTextBox.TabIndex = 0;
            this.enqueTextBox.TextChanged += new System.EventHandler(this.enqueTextBox_TextChanged);
            // 
            // enqueButton
            // 
            this.enqueButton.Location = new System.Drawing.Point(32, 12);
            this.enqueButton.Name = "enqueButton";
            this.enqueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueButton.TabIndex = 1;
            this.enqueButton.Text = "Enqueue";
            this.enqueButton.UseVisualStyleBackColor = true;
            this.enqueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items in Queue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "N: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Average: ";
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(32, 57);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 1;
            this.test.Text = "Dequeue";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.dequeButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 0;
            // 
            // DequeAndAverage
            // 
            this.DequeAndAverage.Location = new System.Drawing.Point(20, 149);
            this.DequeAndAverage.Name = "DequeAndAverage";
            this.DequeAndAverage.Size = new System.Drawing.Size(199, 23);
            this.DequeAndAverage.TabIndex = 1;
            this.DequeAndAverage.Text = "Deque and Average First N Data Points";
            this.DequeAndAverage.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(32, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(54, 23);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(154, 191);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(44, 23);
            this.textBox5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Queue Contents";
            // 
            // queueContentsTxtBox
            // 
            this.queueContentsTxtBox.Location = new System.Drawing.Point(12, 261);
            this.queueContentsTxtBox.Multiline = true;
            this.queueContentsTxtBox.Name = "queueContentsTxtBox";
            this.queueContentsTxtBox.Size = new System.Drawing.Size(183, 173);
            this.queueContentsTxtBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 460);
            this.Controls.Add(this.queueContentsTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.DequeAndAverage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enqueButton);
            this.Controls.Add(this.enqueTextBox);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button DequeAndAverage;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox queueContentsTxtBox;
    }
}

