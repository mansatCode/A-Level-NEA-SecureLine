namespace SecureLine
{
    partial class ViewNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewNoteForm));
            this.TextBoxStudentName = new System.Windows.Forms.TextBox();
            this.ListBoxNoteList = new System.Windows.Forms.ListBox();
            this.ListBoxMessageList = new System.Windows.Forms.ListBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonDeleteNote = new System.Windows.Forms.Button();
            this.ButtonDeleteMessage = new System.Windows.Forms.Button();
            this.TextBoxNoteViewer = new System.Windows.Forms.TextBox();
            this.TextBoxMessageViewer = new System.Windows.Forms.TextBox();
            this.TextBoxDate = new System.Windows.Forms.TextBox();
            this.TextBoxTime = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxStudentName.Multiline = true;
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.ReadOnly = true;
            this.TextBoxStudentName.Size = new System.Drawing.Size(795, 78);
            this.TextBoxStudentName.TabIndex = 4;
            this.TextBoxStudentName.Text = "Student name";
            // 
            // ListBoxNoteList
            // 
            this.ListBoxNoteList.FormattingEnabled = true;
            this.ListBoxNoteList.ItemHeight = 30;
            this.ListBoxNoteList.Location = new System.Drawing.Point(12, 124);
            this.ListBoxNoteList.Name = "ListBoxNoteList";
            this.ListBoxNoteList.ScrollAlwaysVisible = true;
            this.ListBoxNoteList.Size = new System.Drawing.Size(174, 184);
            this.ListBoxNoteList.TabIndex = 5;
            this.ListBoxNoteList.SelectedIndexChanged += new System.EventHandler(this.ListBoxNoteList_SelectedIndexChanged);
            // 
            // ListBoxMessageList
            // 
            this.ListBoxMessageList.FormattingEnabled = true;
            this.ListBoxMessageList.ItemHeight = 30;
            this.ListBoxMessageList.Location = new System.Drawing.Point(12, 314);
            this.ListBoxMessageList.Name = "ListBoxMessageList";
            this.ListBoxMessageList.ScrollAlwaysVisible = true;
            this.ListBoxMessageList.Size = new System.Drawing.Size(174, 184);
            this.ListBoxMessageList.TabIndex = 6;
            this.ListBoxMessageList.SelectedIndexChanged += new System.EventHandler(this.ListBoxMessageList_SelectedIndexChanged);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(593, 505);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(214, 39);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonDeleteNote
            // 
            this.ButtonDeleteNote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteNote.Location = new System.Drawing.Point(593, 125);
            this.ButtonDeleteNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteNote.Name = "ButtonDeleteNote";
            this.ButtonDeleteNote.Size = new System.Drawing.Size(214, 59);
            this.ButtonDeleteNote.TabIndex = 16;
            this.ButtonDeleteNote.Text = "Delete selected note";
            this.ButtonDeleteNote.UseVisualStyleBackColor = true;
            this.ButtonDeleteNote.Click += new System.EventHandler(this.ButtonDeleteNote_Click);
            // 
            // ButtonDeleteMessage
            // 
            this.ButtonDeleteMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteMessage.Location = new System.Drawing.Point(593, 315);
            this.ButtonDeleteMessage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteMessage.Name = "ButtonDeleteMessage";
            this.ButtonDeleteMessage.Size = new System.Drawing.Size(214, 59);
            this.ButtonDeleteMessage.TabIndex = 17;
            this.ButtonDeleteMessage.Text = "Delete pinned message";
            this.ButtonDeleteMessage.UseVisualStyleBackColor = true;
            this.ButtonDeleteMessage.Click += new System.EventHandler(this.ButtonDeleteMessage_Click);
            // 
            // TextBoxNoteViewer
            // 
            this.TextBoxNoteViewer.Location = new System.Drawing.Point(193, 125);
            this.TextBoxNoteViewer.MaxLength = 300;
            this.TextBoxNoteViewer.Multiline = true;
            this.TextBoxNoteViewer.Name = "TextBoxNoteViewer";
            this.TextBoxNoteViewer.ReadOnly = true;
            this.TextBoxNoteViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxNoteViewer.Size = new System.Drawing.Size(391, 183);
            this.TextBoxNoteViewer.TabIndex = 18;
            // 
            // TextBoxMessageViewer
            // 
            this.TextBoxMessageViewer.Location = new System.Drawing.Point(193, 314);
            this.TextBoxMessageViewer.MaxLength = 252;
            this.TextBoxMessageViewer.Multiline = true;
            this.TextBoxMessageViewer.Name = "TextBoxMessageViewer";
            this.TextBoxMessageViewer.ReadOnly = true;
            this.TextBoxMessageViewer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxMessageViewer.Size = new System.Drawing.Size(391, 183);
            this.TextBoxMessageViewer.TabIndex = 19;
            // 
            // TextBoxDate
            // 
            this.TextBoxDate.Enabled = false;
            this.TextBoxDate.Location = new System.Drawing.Point(593, 391);
            this.TextBoxDate.MaxLength = 300;
            this.TextBoxDate.Multiline = true;
            this.TextBoxDate.Name = "TextBoxDate";
            this.TextBoxDate.Size = new System.Drawing.Size(214, 49);
            this.TextBoxDate.TabIndex = 20;
            // 
            // TextBoxTime
            // 
            this.TextBoxTime.Enabled = false;
            this.TextBoxTime.Location = new System.Drawing.Point(593, 446);
            this.TextBoxTime.MaxLength = 300;
            this.TextBoxTime.Multiline = true;
            this.TextBoxTime.Name = "TextBoxTime";
            this.TextBoxTime.Size = new System.Drawing.Size(214, 49);
            this.TextBoxTime.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 553);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 63);
            this.panel2.TabIndex = 34;
            // 
            // ViewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TextBoxTime);
            this.Controls.Add(this.TextBoxDate);
            this.Controls.Add(this.TextBoxMessageViewer);
            this.Controls.Add(this.TextBoxNoteViewer);
            this.Controls.Add(this.ButtonDeleteMessage);
            this.Controls.Add(this.ButtonDeleteNote);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ListBoxMessageList);
            this.Controls.Add(this.ListBoxNoteList);
            this.Controls.Add(this.TextBoxStudentName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "ViewNoteForm";
            this.Text = "View Notes & Messages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxStudentName;
        private System.Windows.Forms.ListBox ListBoxNoteList;
        private System.Windows.Forms.ListBox ListBoxMessageList;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonDeleteNote;
        private System.Windows.Forms.Button ButtonDeleteMessage;
        private System.Windows.Forms.TextBox TextBoxNoteViewer;
        private System.Windows.Forms.TextBox TextBoxMessageViewer;
        private System.Windows.Forms.TextBox TextBoxDate;
        private System.Windows.Forms.TextBox TextBoxTime;
        private System.Windows.Forms.Panel panel2;
    }
}