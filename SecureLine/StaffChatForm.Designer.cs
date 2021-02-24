namespace SecureLine
{
    partial class StaffChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffChatForm));
            this.TextBoxChatWindow = new System.Windows.Forms.TextBox();
            this.TextBoxTypeMessage = new System.Windows.Forms.TextBox();
            this.ButtonSendMessage = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonPinMessage = new System.Windows.Forms.Button();
            this.TextBoxStudentName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBoxChatWindow
            // 
            this.TextBoxChatWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxChatWindow.Location = new System.Drawing.Point(25, 53);
            this.TextBoxChatWindow.Multiline = true;
            this.TextBoxChatWindow.Name = "TextBoxChatWindow";
            this.TextBoxChatWindow.Size = new System.Drawing.Size(520, 200);
            this.TextBoxChatWindow.TabIndex = 4;
            this.TextBoxChatWindow.Text = "Chat";
            // 
            // TextBoxTypeMessage
            // 
            this.TextBoxTypeMessage.Location = new System.Drawing.Point(25, 259);
            this.TextBoxTypeMessage.Multiline = true;
            this.TextBoxTypeMessage.Name = "TextBoxTypeMessage";
            this.TextBoxTypeMessage.Size = new System.Drawing.Size(520, 45);
            this.TextBoxTypeMessage.TabIndex = 10;
            this.TextBoxTypeMessage.Text = "Type message";
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMessage.Location = new System.Drawing.Point(25, 310);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(149, 39);
            this.ButtonSendMessage.TabIndex = 11;
            this.ButtonSendMessage.Text = "Send message";
            this.ButtonSendMessage.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(396, 310);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.Text = "Disconnect";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonPinMessage
            // 
            this.ButtonPinMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPinMessage.Location = new System.Drawing.Point(180, 310);
            this.ButtonPinMessage.Name = "ButtonPinMessage";
            this.ButtonPinMessage.Size = new System.Drawing.Size(210, 39);
            this.ButtonPinMessage.TabIndex = 13;
            this.ButtonPinMessage.Text = "Pin selected message";
            this.ButtonPinMessage.UseVisualStyleBackColor = true;
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(25, 12);
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.Size = new System.Drawing.Size(520, 35);
            this.TextBoxStudentName.TabIndex = 14;
            this.TextBoxStudentName.Text = "Student name";
            // 
            // StaffChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 361);
            this.Controls.Add(this.TextBoxStudentName);
            this.Controls.Add(this.ButtonPinMessage);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSendMessage);
            this.Controls.Add(this.TextBoxTypeMessage);
            this.Controls.Add(this.TextBoxChatWindow);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StaffChatForm";
            this.Text = "StaffChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxChatWindow;
        private System.Windows.Forms.TextBox TextBoxTypeMessage;
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonPinMessage;
        private System.Windows.Forms.TextBox TextBoxStudentName;
    }
}