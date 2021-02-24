namespace SecureLine
{
    partial class ChatDialogForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatDialogForm));
            this.ListBoxChat = new System.Windows.Forms.ListBox();
            this.LabelChatBox = new System.Windows.Forms.Label();
            this.TextBoxConnectionStatus = new System.Windows.Forms.TextBox();
            this.LabelConnectionStatus = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextBoxTypeMessage = new System.Windows.Forms.TextBox();
            this.ButtonSendMessage = new System.Windows.Forms.Button();
            this.LabelTypeMessage = new System.Windows.Forms.Label();
            this.LabelStudent = new System.Windows.Forms.Label();
            this.TextBoxStudentName = new System.Windows.Forms.TextBox();
            this.ButtonPinMessage = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxChat
            // 
            this.ListBoxChat.FormattingEnabled = true;
            this.ListBoxChat.HorizontalScrollbar = true;
            this.ListBoxChat.ItemHeight = 30;
            this.ListBoxChat.Location = new System.Drawing.Point(92, 219);
            this.ListBoxChat.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ListBoxChat.Name = "ListBoxChat";
            this.ListBoxChat.ScrollAlwaysVisible = true;
            this.ListBoxChat.Size = new System.Drawing.Size(661, 274);
            this.ListBoxChat.TabIndex = 0;
            // 
            // LabelChatBox
            // 
            this.LabelChatBox.AutoSize = true;
            this.LabelChatBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChatBox.Location = new System.Drawing.Point(87, 182);
            this.LabelChatBox.Name = "LabelChatBox";
            this.LabelChatBox.Size = new System.Drawing.Size(61, 30);
            this.LabelChatBox.TabIndex = 31;
            this.LabelChatBox.Text = "Chat:";
            // 
            // TextBoxConnectionStatus
            // 
            this.TextBoxConnectionStatus.Location = new System.Drawing.Point(308, 130);
            this.TextBoxConnectionStatus.MaxLength = 50;
            this.TextBoxConnectionStatus.Name = "TextBoxConnectionStatus";
            this.TextBoxConnectionStatus.ReadOnly = true;
            this.TextBoxConnectionStatus.Size = new System.Drawing.Size(445, 35);
            this.TextBoxConnectionStatus.TabIndex = 32;
            this.TextBoxConnectionStatus.TabStop = false;
            // 
            // LabelConnectionStatus
            // 
            this.LabelConnectionStatus.AutoSize = true;
            this.LabelConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConnectionStatus.Location = new System.Drawing.Point(87, 133);
            this.LabelConnectionStatus.Name = "LabelConnectionStatus";
            this.LabelConnectionStatus.Size = new System.Drawing.Size(185, 30);
            this.LabelConnectionStatus.TabIndex = 33;
            this.LabelConnectionStatus.Text = "Connection status:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(604, 553);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 34;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextBoxTypeMessage
            // 
            this.TextBoxTypeMessage.Location = new System.Drawing.Point(92, 503);
            this.TextBoxTypeMessage.MaxLength = 150;
            this.TextBoxTypeMessage.Multiline = true;
            this.TextBoxTypeMessage.Name = "TextBoxTypeMessage";
            this.TextBoxTypeMessage.Size = new System.Drawing.Size(661, 45);
            this.TextBoxTypeMessage.TabIndex = 35;
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMessage.Location = new System.Drawing.Point(92, 553);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(149, 39);
            this.ButtonSendMessage.TabIndex = 36;
            this.ButtonSendMessage.Text = "Send message";
            this.ButtonSendMessage.UseVisualStyleBackColor = true;
            this.ButtonSendMessage.Click += new System.EventHandler(this.ButtonSendMessage_Click);
            // 
            // LabelTypeMessage
            // 
            this.LabelTypeMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeMessage.Location = new System.Drawing.Point(24, 503);
            this.LabelTypeMessage.Name = "LabelTypeMessage";
            this.LabelTypeMessage.Size = new System.Drawing.Size(47, 32);
            this.LabelTypeMessage.TabIndex = 37;
            this.LabelTypeMessage.Text = "Type:";
            // 
            // LabelStudent
            // 
            this.LabelStudent.AutoSize = true;
            this.LabelStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudent.Location = new System.Drawing.Point(87, 9);
            this.LabelStudent.Name = "LabelStudent";
            this.LabelStudent.Size = new System.Drawing.Size(89, 30);
            this.LabelStudent.TabIndex = 38;
            this.LabelStudent.Text = "Student:";
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(308, 4);
            this.TextBoxStudentName.MaxLength = 50;
            this.TextBoxStudentName.Multiline = true;
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.ReadOnly = true;
            this.TextBoxStudentName.Size = new System.Drawing.Size(445, 89);
            this.TextBoxStudentName.TabIndex = 39;
            this.TextBoxStudentName.TabStop = false;
            // 
            // ButtonPinMessage
            // 
            this.ButtonPinMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPinMessage.Location = new System.Drawing.Point(449, 553);
            this.ButtonPinMessage.Name = "ButtonPinMessage";
            this.ButtonPinMessage.Size = new System.Drawing.Size(149, 39);
            this.ButtonPinMessage.TabIndex = 40;
            this.ButtonPinMessage.Text = "Pin message";
            this.ButtonPinMessage.UseVisualStyleBackColor = true;
            this.ButtonPinMessage.Click += new System.EventHandler(this.ButtonPinMessage_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 39);
            this.panel2.TabIndex = 41;
            // 
            // ChatDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 645);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonPinMessage);
            this.Controls.Add(this.TextBoxStudentName);
            this.Controls.Add(this.LabelStudent);
            this.Controls.Add(this.LabelTypeMessage);
            this.Controls.Add(this.ButtonSendMessage);
            this.Controls.Add(this.TextBoxTypeMessage);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelConnectionStatus);
            this.Controls.Add(this.TextBoxConnectionStatus);
            this.Controls.Add(this.LabelChatBox);
            this.Controls.Add(this.ListBoxChat);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "ChatDialogForm";
            this.Text = "Staff Chat Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatDialogForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxChat;
        private System.Windows.Forms.Label LabelChatBox;
        private System.Windows.Forms.TextBox TextBoxConnectionStatus;
        private System.Windows.Forms.Label LabelConnectionStatus;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextBoxTypeMessage;
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.Label LabelTypeMessage;
        private System.Windows.Forms.Label LabelStudent;
        private System.Windows.Forms.TextBox TextBoxStudentName;
        private System.Windows.Forms.Button ButtonPinMessage;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}