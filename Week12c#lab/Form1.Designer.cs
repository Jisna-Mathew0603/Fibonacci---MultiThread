namespace Week12c_lab
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
            this.textBox1generate = new System.Windows.Forms.TextBox();
            this.button1generate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1generate
            // 
            this.textBox1generate.Location = new System.Drawing.Point(578, 57);
            this.textBox1generate.Name = "textBox1generate";
            this.textBox1generate.Size = new System.Drawing.Size(267, 31);
            this.textBox1generate.TabIndex = 0;
            // 
            // button1generate
            // 
            this.button1generate.Location = new System.Drawing.Point(117, 29);
            this.button1generate.Name = "button1generate";
            this.button1generate.Size = new System.Drawing.Size(368, 86);
            this.button1generate.TabIndex = 1;
            this.button1generate.Text = "Generate";
            this.button1generate.UseVisualStyleBackColor = true;
            this.button1generate.Click += new System.EventHandler(this.button1generate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(97, 180);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(926, 554);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 794);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1generate);
            this.Controls.Add(this.textBox1generate);
            this.Name = "Form1";
            this.Text = "Multi-Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1generate;
        private System.Windows.Forms.Button button1generate;
        private System.Windows.Forms.ListBox listBox1;
    }
}

