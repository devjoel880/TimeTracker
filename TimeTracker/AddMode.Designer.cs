namespace TimeTracker
{
    partial class AddMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            hour = new NumericUpDown();
            minute = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minute).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 138);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 45);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Duration:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 31);
            textBox1.TabIndex = 3;
            // 
            // hour
            // 
            hour.Location = new Point(119, 90);
            hour.Name = "hour";
            hour.Size = new Size(55, 31);
            hour.TabIndex = 4;
            // 
            // minute
            // 
            minute.Location = new Point(190, 90);
            minute.Name = "minute";
            minute.Size = new Size(58, 31);
            minute.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(255, 92);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 6;
            label3.Text = "min";
            // 
            // AddMode
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(373, 199);
            Controls.Add(label3);
            Controls.Add(minute);
            Controls.Add(hour);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "AddMode";
            Text = "Add New Mode";
            Load += AddMode_Load;
            ((System.ComponentModel.ISupportInitialize)hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)minute).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private NumericUpDown hour;
        private NumericUpDown minute;
        private Label label3;
    }
}