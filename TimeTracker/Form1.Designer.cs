namespace TimeTracker
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            resetBtn = new Button();
            comboBox1 = new ComboBox();
            AddBtn = new Button();
            label1 = new Label();
            StartBtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timerValue = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(resetBtn);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 209);
            panel1.TabIndex = 0;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(172, 140);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(123, 34);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Clear Modes";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(14, 140);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(126, 34);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "New Mode";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 54);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Select mode:\r\n";
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(381, 151);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(112, 34);
            StartBtn.TabIndex = 0;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timerValue
            // 
            timerValue.AutoSize = true;
            timerValue.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timerValue.ForeColor = Color.White;
            timerValue.Location = new Point(365, 52);
            timerValue.Name = "timerValue";
            timerValue.Size = new Size(138, 48);
            timerValue.TabIndex = 1;
            timerValue.Text = "0:00:00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(552, 208);
            Controls.Add(timerValue);
            Controls.Add(StartBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Time Tracker v1.0";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button StartBtn;
        private System.Windows.Forms.Timer timer1;
        private Label timerValue;
        private Label label1;
        private Button AddBtn;
        private ComboBox comboBox1;
        private Button resetBtn;
    }
}
