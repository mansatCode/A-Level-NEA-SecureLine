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
            this.SuspendLayout();
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.Size = new System.Drawing.Size(572, 35);
            this.TextBoxStudentName.TabIndex = 4;
            this.TextBoxStudentName.Text = "Student name";
            // 
            // ListBoxNoteList
            // 
            this.ListBoxNoteList.FormattingEnabled = true;
            this.ListBoxNoteList.ItemHeight = 30;
            this.ListBoxNoteList.Location = new System.Drawing.Point(12, 53);
            this.ListBoxNoteList.Name = "ListBoxNoteList";
            this.ListBoxNoteList.Size = new System.Drawing.Size(341, 184);
            this.ListBoxNoteList.TabIndex = 5;
            // 
            // ListBoxMessageList
            // 
            this.ListBoxMessageList.FormattingEnabled = true;
            this.ListBoxMessageList.ItemHeight = 30;
            this.ListBoxMessageList.Location = new System.Drawing.Point(12, 243);
            this.ListBoxMessageList.Name = "ListBoxMessageList";
            this.ListBoxMessageList.Size = new System.Drawing.Size(341, 184);
            this.ListBoxMessageList.TabIndex = 6;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(370, 428);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(214, 39);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteNote
            // 
            this.ButtonDeleteNote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteNote.Location = new System.Drawing.Point(370, 53);
            this.ButtonDeleteNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteNote.Name = "ButtonDeleteNote";
            this.ButtonDeleteNote.Size = new System.Drawing.Size(214, 59);
            this.ButtonDeleteNote.TabIndex = 16;
            this.ButtonDeleteNote.Text = "Delete note";
            this.ButtonDeleteNote.UseVisualStyleBackColor = true;
            // 
            // ButtonDeleteMessage
            // 
            this.ButtonDeleteMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteMessage.Location = new System.Drawing.Point(370, 243);
            this.ButtonDeleteMessage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteMessage.Name = "ButtonDeleteMessage";
            this.ButtonDeleteMessage.Size = new System.Drawing.Size(214, 59);
            this.ButtonDeleteMessage.TabIndex = 17;
            this.ButtonDeleteMessage.Text = "Delete pinned message";
            this.ButtonDeleteMessage.UseVisualStyleBackColor = true;
            // 
            // ViewNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 477);
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
            this.Name = "ViewNoteForm";
            this.Text = "View Notes";
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
    }
}