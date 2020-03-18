namespace TCP_Client_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.content = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.IP_textBox = new System.Windows.Forms.TextBox();
            this.Port_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content.Size = new System.Drawing.Size(369, 221);
            this.content.TabIndex = 0;
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(306, 242);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "連線";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // IP_textBox
            // 
            this.IP_textBox.Location = new System.Drawing.Point(45, 242);
            this.IP_textBox.Name = "IP_textBox";
            this.IP_textBox.Size = new System.Drawing.Size(149, 22);
            this.IP_textBox.TabIndex = 2;
            this.IP_textBox.Text = "";
            // 
            // Port_textBox
            // 
            this.Port_textBox.Location = new System.Drawing.Point(242, 242);
            this.Port_textBox.Name = "Port_textBox";
            this.Port_textBox.Size = new System.Drawing.Size(55, 22);
            this.Port_textBox.TabIndex = 3;
            this.Port_textBox.Text = "8250";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_textBox);
            this.Controls.Add(this.IP_textBox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.content);
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox IP_textBox;
        private System.Windows.Forms.TextBox Port_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
