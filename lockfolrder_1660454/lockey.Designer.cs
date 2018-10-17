namespace lockfolrder_1660454
{
    partial class lockey
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.khóa = new System.Windows.Forms.Button();
            this.pass1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 184);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pass khóa forlder";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.khóa);
            this.panel1.Controls.Add(this.pass1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 130);
            this.panel1.TabIndex = 0;
            // 
            // khóa
            // 
            this.khóa.Location = new System.Drawing.Point(230, 67);
            this.khóa.Name = "khóa";
            this.khóa.Size = new System.Drawing.Size(241, 45);
            this.khóa.TabIndex = 2;
            this.khóa.Text = "Khóa forlder";
            this.khóa.UseVisualStyleBackColor = true;
            this.khóa.Click += new System.EventHandler(this.khóa_Click);
            // 
            // pass1
            // 
            this.pass1.Location = new System.Drawing.Point(108, 25);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(293, 22);
            this.pass1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu :";
            // 
            // lockey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 225);
            this.Controls.Add(this.groupBox1);
            this.Name = "lockey";
            this.Text = "lockey";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button khóa;
        private System.Windows.Forms.TextBox pass1;
        private System.Windows.Forms.Label label1;
    }
}