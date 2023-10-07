namespace WindowsFormsApp124
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
            this.button1 = new System.Windows.Forms.Button();
            this.next1 = new WindowsFormsApp124.Next();
            this.next2 = new WindowsFormsApp124.Next();
            this.fButton1 = new WindowsFormsApp124.FButton();
            this.fButton2 = new WindowsFormsApp124.FButton();
            this.fButton3 = new WindowsFormsApp124.FButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 695);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(584, 156);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // next1
            // 
            this.next1.Location = new System.Drawing.Point(432, 221);
            this.next1.Multiline = true;
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(752, 64);
            this.next1.TabIndex = 3;
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(432, 346);
            this.next2.Multiline = true;
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(752, 64);
            this.next2.TabIndex = 4;
            // 
            // fButton1
            // 
            this.fButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton1.Location = new System.Drawing.Point(637, 442);
            this.fButton1.Name = "fButton1";
            this.fButton1.Size = new System.Drawing.Size(320, 94);
            this.fButton1.TabIndex = 5;
            this.fButton1.Text = "ثبت";
            this.fButton1.UseVisualStyleBackColor = false;
            // 
            // fButton2
            // 
            this.fButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton2.Location = new System.Drawing.Point(637, 581);
            this.fButton2.Name = "fButton2";
            this.fButton2.Size = new System.Drawing.Size(320, 87);
            this.fButton2.TabIndex = 6;
            this.fButton2.Text = "ثبت";
            this.fButton2.UseVisualStyleBackColor = false;
            // 
            // fButton3
            // 
            this.fButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.fButton3.Location = new System.Drawing.Point(625, 77);
            this.fButton3.Name = "fButton3";
            this.fButton3.Size = new System.Drawing.Size(320, 87);
            this.fButton3.TabIndex = 7;
            this.fButton3.Text = "ثبت";
            this.fButton3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 888);
            this.Controls.Add(this.fButton3);
            this.Controls.Add(this.fButton2);
            this.Controls.Add(this.fButton1);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Next next1;
        private Next next2;
        private FButton fButton1;
        private FButton fButton2;
        private FButton fButton3;
    }
}

