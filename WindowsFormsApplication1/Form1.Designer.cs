namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t1Input = new System.Windows.Forms.TextBox();
            this.t2Input = new System.Windows.Forms.TextBox();
            this.t3Input = new System.Windows.Forms.TextBox();
            this.t1Weight = new System.Windows.Forms.TextBox();
            this.t2Weight = new System.Windows.Forms.TextBox();
            this.t3Weight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t4Input = new System.Windows.Forms.TextBox();
            this.t4Weight = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.sc1 = new System.Windows.Forms.Label();
            this.sc2 = new System.Windows.Forms.Label();
            this.sc3 = new System.Windows.Forms.Label();
            this.sc4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Work Type1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Work Type2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Work Type3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 154);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t1Input
            // 
            this.t1Input.Location = new System.Drawing.Point(107, 40);
            this.t1Input.Name = "t1Input";
            this.t1Input.Size = new System.Drawing.Size(49, 20);
            this.t1Input.TabIndex = 1;
            // 
            // t2Input
            // 
            this.t2Input.Location = new System.Drawing.Point(107, 83);
            this.t2Input.Name = "t2Input";
            this.t2Input.Size = new System.Drawing.Size(49, 20);
            this.t2Input.TabIndex = 3;
            // 
            // t3Input
            // 
            this.t3Input.Location = new System.Drawing.Point(107, 132);
            this.t3Input.Name = "t3Input";
            this.t3Input.Size = new System.Drawing.Size(49, 20);
            this.t3Input.TabIndex = 5;
            // 
            // t1Weight
            // 
            this.t1Weight.Location = new System.Drawing.Point(212, 40);
            this.t1Weight.Name = "t1Weight";
            this.t1Weight.Size = new System.Drawing.Size(49, 20);
            this.t1Weight.TabIndex = 2;
            // 
            // t2Weight
            // 
            this.t2Weight.Location = new System.Drawing.Point(212, 83);
            this.t2Weight.Name = "t2Weight";
            this.t2Weight.Size = new System.Drawing.Size(49, 20);
            this.t2Weight.TabIndex = 4;
            // 
            // t3Weight
            // 
            this.t3Weight.Location = new System.Drawing.Point(212, 132);
            this.t3Weight.Name = "t3Weight";
            this.t3Weight.Size = new System.Drawing.Size(49, 20);
            this.t3Weight.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student\'s Average";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Weight (0-100)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Work Type4";
            // 
            // t4Input
            // 
            this.t4Input.Location = new System.Drawing.Point(107, 174);
            this.t4Input.Name = "t4Input";
            this.t4Input.Size = new System.Drawing.Size(49, 20);
            this.t4Input.TabIndex = 7;
            // 
            // t4Weight
            // 
            this.t4Weight.Location = new System.Drawing.Point(212, 174);
            this.t4Weight.Name = "t4Weight";
            this.t4Weight.Size = new System.Drawing.Size(49, 20);
            this.t4Weight.TabIndex = 8;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(294, 230);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(21, 29);
            this.Output.TabIndex = 16;
            this.Output.Text = "-";
            // 
            // sc1
            // 
            this.sc1.AutoSize = true;
            this.sc1.Location = new System.Drawing.Point(319, 43);
            this.sc1.Name = "sc1";
            this.sc1.Size = new System.Drawing.Size(13, 13);
            this.sc1.TabIndex = 17;
            this.sc1.Text = " -";
            // 
            // sc2
            // 
            this.sc2.AutoSize = true;
            this.sc2.Location = new System.Drawing.Point(319, 83);
            this.sc2.Name = "sc2";
            this.sc2.Size = new System.Drawing.Size(13, 13);
            this.sc2.TabIndex = 19;
            this.sc2.Text = " -";
            // 
            // sc3
            // 
            this.sc3.AutoSize = true;
            this.sc3.Location = new System.Drawing.Point(319, 132);
            this.sc3.Name = "sc3";
            this.sc3.Size = new System.Drawing.Size(13, 13);
            this.sc3.TabIndex = 21;
            this.sc3.Text = " -";
            // 
            // sc4
            // 
            this.sc4.AutoSize = true;
            this.sc4.Location = new System.Drawing.Point(319, 177);
            this.sc4.Name = "sc4";
            this.sc4.Size = new System.Drawing.Size(13, 13);
            this.sc4.TabIndex = 23;
            this.sc4.Text = " -";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Weighted Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Weighted Average:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 299);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sc4);
            this.Controls.Add(this.sc3);
            this.Controls.Add(this.sc2);
            this.Controls.Add(this.sc1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.t4Weight);
            this.Controls.Add(this.t4Input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t3Weight);
            this.Controls.Add(this.t2Weight);
            this.Controls.Add(this.t1Weight);
            this.Controls.Add(this.t3Input);
            this.Controls.Add(this.t2Input);
            this.Controls.Add(this.t1Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Weighted Avg. Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t1Input;
        private System.Windows.Forms.TextBox t2Input;
        private System.Windows.Forms.TextBox t3Input;
        private System.Windows.Forms.TextBox t1Weight;
        private System.Windows.Forms.TextBox t2Weight;
        private System.Windows.Forms.TextBox t3Weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t4Input;
        private System.Windows.Forms.TextBox t4Weight;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label sc1;
        private System.Windows.Forms.Label sc2;
        private System.Windows.Forms.Label sc3;
        private System.Windows.Forms.Label sc4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
    }
}

