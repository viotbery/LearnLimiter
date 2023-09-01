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
            menuStrip1 = new MenuStrip();
            comboBox1 = new ComboBox();
            pwText = new TextBox();
            answerText = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Cursor = Cursors.Hand;
            textBox1.ForeColor = Color.Lime;
            textBox1.Location = new Point(65, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(672, 250);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(70, 382);
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
            button2.Location = new Point(637, 382);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 2;
            button2.Text = "停止";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PotPlayerMini64", "sm18" });
            comboBox1.Location = new Point(70, 337);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 39);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pwText
            // 
            pwText.Location = new Point(283, 338);
            pwText.Name = "pwText";
            pwText.ReadOnly = true;
            pwText.Size = new Size(454, 38);
            pwText.TabIndex = 5;
            // 
            // answerText
            // 
            answerText.Location = new Point(283, 387);
            answerText.Name = "answerText";
            answerText.Size = new Size(348, 38);
            answerText.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(answerText);
            Controls.Add(pwText);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "LearnLimiter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ComboBox comboBox1;
        private TextBox pwText;
        private TextBox answerText;
    }
}