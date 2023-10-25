namespace MenuForm.ChildForms
{
    partial class Cage
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
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(192, 193);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 31);
            textBox3.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 196);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 16;
            label3.Text = "Cage status";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 31);
            textBox2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 121);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 14;
            label2.Text = "Cage Name";
            // 
            // button3
            // 
            button3.Location = new Point(625, 378);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(459, 378);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 31);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 42);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 10;
            label1.Text = "Cage ID";
            // 
            // button1
            // 
            button1.Location = new Point(299, 378);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Cage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Cage";
            Text = "Cage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}