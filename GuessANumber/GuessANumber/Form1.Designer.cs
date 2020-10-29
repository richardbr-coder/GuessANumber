namespace GuessANumber
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
            this.message = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option4 = new System.Windows.Forms.RadioButton();
            this.Option5 = new System.Windows.Forms.RadioButton();
            this.hintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(267, 125);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(89, 13);
            this.message.TabIndex = 0;
            this.message.Text = "Guess a Number!";
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(123, 187);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(31, 17);
            this.Option1.TabIndex = 1;
            this.Option1.TabStop = true;
            this.Option1.Text = "1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged_1);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(453, 187);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(31, 17);
            this.Option2.TabIndex = 2;
            this.Option2.TabStop = true;
            this.Option2.Text = "2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.Option2_CheckedChanged_1);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(123, 351);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(31, 17);
            this.Option3.TabIndex = 3;
            this.Option3.TabStop = true;
            this.Option3.Text = "3";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.Option3_CheckedChanged_1);
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(453, 351);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(31, 17);
            this.Option4.TabIndex = 4;
            this.Option4.TabStop = true;
            this.Option4.Text = "4";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.CheckedChanged += new System.EventHandler(this.Option4_CheckedChanged_1);
            // 
            // Option5
            // 
            this.Option5.AutoSize = true;
            this.Option5.Location = new System.Drawing.Point(314, 265);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(31, 17);
            this.Option5.TabIndex = 5;
            this.Option5.TabStop = true;
            this.Option5.Text = "5";
            this.Option5.UseVisualStyleBackColor = true;
            this.Option5.CheckedChanged += new System.EventHandler(this.Option5_CheckedChanged_1);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(270, 393);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(71, 13);
            this.hintLabel.TabIndex = 6;
            this.hintLabel.Text = "Hover for hint";
            this.hintLabel.Click += new System.EventHandler(this.hintLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.Option5);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option4;
        private System.Windows.Forms.RadioButton Option5;
        private System.Windows.Forms.Label hintLabel;
    }
}

