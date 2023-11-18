namespace System_Programming_File_Transfer_Homework
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
            label1 = new Label();
            label2 = new Label();
            fromTB = new TextBox();
            toTB = new TextBox();
            button1 = new Button();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 96);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // fromTB
            // 
            fromTB.Location = new Point(77, 39);
            fromTB.Name = "fromTB";
            fromTB.Size = new Size(357, 23);
            fromTB.TabIndex = 2;
            // 
            // toTB
            // 
            toTB.Location = new Point(77, 93);
            toTB.Name = "toTB";
            toTB.Size = new Size(357, 23);
            toTB.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(443, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "File ..";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(443, 90);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "File ..";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(21, 146);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 23);
            progressBar1.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(177, 146);
            button3.Name = "button3";
            button3.Size = new Size(95, 23);
            button3.TabIndex = 7;
            button3.Text = "Suspend";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(278, 146);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "Resume";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(359, 146);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "Abort";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(443, 146);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "Copy";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 194);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(toTB);
            Controls.Add(fromTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "File Transfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox fromTB;
        private TextBox toTB;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}