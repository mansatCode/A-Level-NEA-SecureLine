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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentChatForm));
            this.ButtonSendMessage = new System.Windows.Forms.Button();
            this.TextBoxTypeMessage = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TextBoxConnectionStatus = new System.Windows.Forms.TextBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.LabelTypeMessage = new System.Windows.Forms.Label();
            this.LabelChatBox = new System.Windows.Forms.Label();
            this.RichTextBoxChatWindow = new System.Windows.Forms.RichTextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMessage.Location = new System.Drawing.Point(71, 407);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(149, 39);
            this.ButtonSendMessage.TabIndex = 8;
            this.ButtonSendMessage.Text = "Send message";
            this.ButtonSendMessage.UseVisualStyleBackColor = true;
            this.ButtonSendMessage.Click += new System.EventHandler(this.ButtonSendMessage_Click);
            // 
            // TextBoxTypeMessage
            // 
            this.TextBoxTypeMessage.Location = new System.Drawing.Point(71, 356);
            this.TextBoxTypeMessage.MaxLength = 150;
            this.TextBoxTypeMessage.Multiline = true;
            this.TextBoxTypeMessage.Name = "TextBoxTypeMessage";
            this.TextBoxTypeMessage.Size = new System.Drawing.Size(520, 45);
            this.TextBoxTypeMessage.TabIndex = 9;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(442, 407);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 10;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TextBoxConnectionStatus
            // 
            this.TextBoxConnectionStatus.Location = new System.Drawing.Point(152, 21);
            this.TextBoxConnectionStatus.MaxLength = 50;
            this.TextBoxConnectionStatus.Multiline = true;
            this.TextBoxConnectionStatus.Name = "TextBoxConnectionStatus";
            this.TextBoxConnectionStatus.ReadOnly = true;
            this.TextBoxConnectionStatus.Size = new System.Drawing.Size(165, 39);
            this.TextBoxConnectionStatus.TabIndex = 11;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(71, 24);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(74, 30);
            this.LabelStatus.TabIndex = 12;
            this.LabelStatus.Text = "Status:";
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.Location = new System.Drawing.Point(325, 21);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(130, 39);
            this.ButtonConnect.TabIndex = 13;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisconnect.Location = new System.Drawing.Point(461, 21);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(130, 39);
            this.ButtonDisconnect.TabIndex = 14;
            this.ButtonDisconnect.Text = "Disconnect";
            this.ButtonDisconnect.UseVisualStyleBackColor = true;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // LabelTypeMessage
            // 
            this.LabelTypeMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeMessage.Location = new System.Drawing.Point(12, 356);
            this.LabelTypeMessage.Name = "LabelTypeMessage";
            this.LabelTypeMessage.Size = new System.Drawing.Size(47, 32);
            this.LabelTypeMessage.TabIndex = 27;
            this.LabelTypeMessage.Text = "Type:";
            // 
            // LabelChatBox
            // 
            this.LabelChatBox.AutoSize = true;
            this.LabelChatBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChatBox.Location = new System.Drawing.Point(71, 76);
            this.LabelChatBox.Name = "LabelChatBox";
            this.LabelChatBox.Size = new System.Drawing.Size(61, 30);
            this.LabelChatBox.TabIndex = 30;
            this.LabelChatBox.Text = "Chat:";
            // 
            // RichTextBoxChatWindow
            // 
            this.RichTextBoxChatWindow.Location = new System.Drawing.Point(71, 109);
            this.RichTextBoxChatWindow.Name = "RichTextBoxChatWindow";
            this.RichTextBoxChatWindow.ReadOnly = true;
            this.RichTextBoxChatWindow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RichTextBoxChatWindow.ShortcutsEnabled = false;
            this.RichTextBoxChatWindow.Size = new System.Drawing.Size(520, 241);
            this.RichTextBoxChatWindow.TabIndex = 31;
            this.RichTextBoxChatWindow.Text = "";
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
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 39);
            this.panel2.TabIndex = 32;
            // 
            // StudentChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RichTextBoxChatWindow);
            this.Controls.Add(this.LabelChatBox);
            this.Controls.Add(this.LabelTypeMessage);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.TextBoxConnectionStatus);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.TextBoxTypeMessage);
            this.Controls.Add(this.ButtonSendMessage);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StudentChatForm";
            this.Text = "Student Chat Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentChatForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.TextBox TextBoxTypeMessage;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextBoxConnectionStatus;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.Windows.Forms.Label LabelTypeMessage;
        private System.Windows.Forms.Label LabelChatBox;
        private System.Windows.Forms.RichTextBox RichTextBoxChatWindow;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}