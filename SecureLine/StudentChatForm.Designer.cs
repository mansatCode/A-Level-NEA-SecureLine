namespace SecureLine
{
    partial class StudentChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentChatForm));
            this.TextBoxChatWindow = new System.Windows.Forms.TextBox();
            this.ButtonSendMessage = new System.Windows.Forms.Button();
            this.TextBoxTypeMessage = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxChatWindow
            // 
            this.TextBoxChatWindow.Location = new System.Drawing.Point(25, 12);
            this.TextBoxChatWindow.Multiline = true;
            this.TextBoxChatWindow.Name = "TextBoxChatWindow";
            this.TextBoxChatWindow.Size = new System.Drawing.Size(520, 241);
            this.TextBoxChatWindow.TabIndex = 3;
            this.TextBoxChatWindow.Text = "ChatWindow";
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMessage.Location = new System.Drawing.Point(25, 310);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(149, 39);
            this.ButtonSendMessage.TabIndex = 8;
            this.ButtonSendMessage.Text = "Send message";
            this.ButtonSendMessage.UseVisualStyleBackColor = true;
            // 
            // TextBoxTypeMessage
            // 
            this.TextBoxTypeMessage.Location = new System.Drawing.Point(25, 259);
            this.TextBoxTypeMessage.Multiline = true;
            this.TextBoxTypeMessage.Name = "TextBoxTypeMessage";
            this.TextBoxTypeMessage.Size = new System.Drawing.Size(520, 45);
            this.TextBoxTypeMessage.TabIndex = 9;
            this.TextBoxTypeMessage.Text = "Type message";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(396, 310);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "Disconnect";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // StudentChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 361);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TextBoxTypeMessage);
            this.Controls.Add(this.ButtonSendMessage);
            this.Controls.Add(this.TextBoxChatWindow);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StudentChatForm";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxChatWindow;
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.TextBox TextBoxTypeMessage;
        private System.Windows.Forms.Button ButtonExit;
    }
}