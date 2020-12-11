namespace RSAtest
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
            this.encryptedMessage = new System.Windows.Forms.Label();
            this.DecryptMessage = new System.Windows.Forms.Label();
            this.RawMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryptedMessage
            // 
            this.encryptedMessage.AutoSize = true;
            this.encryptedMessage.Location = new System.Drawing.Point(273, 70);
            this.encryptedMessage.Name = "encryptedMessage";
            this.encryptedMessage.Size = new System.Drawing.Size(35, 13);
            this.encryptedMessage.TabIndex = 14;
            this.encryptedMessage.Text = "label1";
            // 
            // DecryptMessage
            // 
            this.DecryptMessage.AutoSize = true;
            this.DecryptMessage.Location = new System.Drawing.Point(156, 208);
            this.DecryptMessage.Name = "DecryptMessage";
            this.DecryptMessage.Size = new System.Drawing.Size(35, 13);
            this.DecryptMessage.TabIndex = 13;
            this.DecryptMessage.Text = "label1";
            // 
            // RawMessage
            // 
            this.RawMessage.Location = new System.Drawing.Point(156, 63);
            this.RawMessage.Name = "RawMessage";
            this.RawMessage.Size = new System.Drawing.Size(100, 20);
            this.RawMessage.TabIndex = 12;
            this.RawMessage.Text = "test";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 71);
            this.button2.TabIndex = 11;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 379);
            this.Controls.Add(this.encryptedMessage);
            this.Controls.Add(this.DecryptMessage);
            this.Controls.Add(this.RawMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label encryptedMessage;
        private System.Windows.Forms.Label DecryptMessage;
        private System.Windows.Forms.TextBox RawMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

