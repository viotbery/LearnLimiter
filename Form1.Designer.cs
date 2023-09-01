namespace 自律v2
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            pwText = new TextBox();
            answerText = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Cursor = Cursors.Hand;
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(70, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(667, 250);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(70, 389);
            button1.Name = "button1";
            button1.Size = new Size(207, 46);
            button1.TabIndex = 1;
            button1.Text = "启动";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(637, 389);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 2;
            button2.Text = "停止";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PotPlayerMini64", "sm18" });
            comboBox1.Location = new Point(70, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 39);
            // 
            // pwText
            // 
            pwText.Location = new Point(283, 331);
            pwText.Name = "pwText";
            pwText.ReadOnly = true;
            pwText.Size = new Size(454, 38);
            pwText.TabIndex = 5;
            // 
            // answerText
            // 
            answerText.Location = new Point(283, 394);
            answerText.Name = "answerText";
            answerText.Size = new Size(348, 38);
            answerText.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            button3.Location = new Point(70, 268);
            button3.Name = "button3";
            button3.Size = new Size(667, 46);
            button3.TabIndex = 7;
            button3.Text = "加载应用";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 461);
            Controls.Add(button3);
            Controls.Add(answerText);
            Controls.Add(pwText);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "LearnLimiter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private TextBox pwText;
        private TextBox answerText;
        private OpenFileDialog openFileDialog1;
        private Button button3;
    }
}