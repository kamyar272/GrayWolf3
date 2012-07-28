namespace GrayWolf
{
    partial class recivedMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.button1);
            this.xtraScrollableControl1.Controls.Add(this.richTextBox2);
            this.xtraScrollableControl1.Controls.Add(this.label1);
            this.xtraScrollableControl1.Controls.Add(this.richTextBox1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(508, 422);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "مشاهده متن";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(20, 215);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(451, 153);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "پیام‌های دریافتی";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 139);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // recivedMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "recivedMessage";
            this.Size = new System.Drawing.Size(508, 422);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
