namespace lockfolrder_1660454
{
    partial class unlock
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mo = new System.Windows.Forms.Button();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 157);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mở khóa forlder";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mo);
            this.panel2.Controls.Add(this.pass2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 130);
            this.panel2.TabIndex = 0;
            // 
            // mo
            // 
            this.mo.Location = new System.Drawing.Point(230, 67);
            this.mo.Name = "mo";
            this.mo.Size = new System.Drawing.Size(241, 45);
            this.mo.TabIndex = 2;
            this.mo.Text = "Mở forlder";
            this.mo.UseVisualStyleBackColor = true;
            this.mo.Click += new System.EventHandler(this.mo_Click);
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(108, 25);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(293, 22);
            this.pass2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu :";
            // 
            // unlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 212);
            this.Controls.Add(this.groupBox2);
            this.Name = "unlock";
            this.Text = "unlock";
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button mo;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label2;
    }
}