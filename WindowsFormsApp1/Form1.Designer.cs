namespace WindowsFormsApp1
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
            this.userInfo1 = new System.Windows.Forms.TextBox();
            this.userInfo2 = new System.Windows.Forms.TextBox();
            this.userInfo3 = new System.Windows.Forms.TextBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "BOOM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInfo1
            // 
            this.userInfo1.Location = new System.Drawing.Point(360, 120);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(160, 26);
            this.userInfo1.TabIndex = 1;
            // 
            // userInfo2
            // 
            this.userInfo2.Location = new System.Drawing.Point(360, 152);
            this.userInfo2.Name = "userInfo2";
            this.userInfo2.Size = new System.Drawing.Size(160, 26);
            this.userInfo2.TabIndex = 2;
            this.userInfo2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // userInfo3
            // 
            this.userInfo3.Location = new System.Drawing.Point(360, 184);
            this.userInfo3.Name = "userInfo3";
            this.userInfo3.Size = new System.Drawing.Size(160, 26);
            this.userInfo3.TabIndex = 3;
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Location = new System.Drawing.Point(409, 61);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(51, 20);
            this.LABEL.TabIndex = 5;
            this.LABEL.Text = "label1";
            this.LABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.userInfo3);
            this.Controls.Add(this.userInfo2);
            this.Controls.Add(this.userInfo1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userInfo1;
        private System.Windows.Forms.TextBox userInfo2;
        private System.Windows.Forms.TextBox userInfo3;
        private System.Windows.Forms.Label LABEL;
    }
}

