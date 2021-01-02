namespace SecureLine
{
    partial class SelectStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectStudentForm));
            this.ListBoxStudentList = new System.Windows.Forms.ListBox();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.ButtonViewNotes = new System.Windows.Forms.Button();
            this.ButtonSendMessage = new System.Windows.Forms.Button();
            this.ButtonAddNotes = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxStudentList
            // 
            this.ListBoxStudentList.FormattingEnabled = true;
            this.ListBoxStudentList.ItemHeight = 30;
            this.ListBoxStudentList.Location = new System.Drawing.Point(12, 12);
            this.ListBoxStudentList.Name = "ListBoxStudentList";
            this.ListBoxStudentList.Size = new System.Drawing.Size(341, 424);
            this.ListBoxStudentList.TabIndex = 0;
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.Location = new System.Drawing.Point(370, 12);
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(214, 35);
            this.TextBoxSearchBar.TabIndex = 3;
            this.TextBoxSearchBar.Text = "Search student";
            // 
            // ButtonViewNotes
            // 
            this.ButtonViewNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewNotes.Location = new System.Drawing.Point(370, 57);
            this.ButtonViewNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonViewNotes.Name = "ButtonViewNotes";
            this.ButtonViewNotes.Size = new System.Drawing.Size(214, 39);
            this.ButtonViewNotes.TabIndex = 8;
            this.ButtonViewNotes.Text = "View notes";
            this.ButtonViewNotes.UseVisualStyleBackColor = true;
            // 
            // ButtonSendMessage
            // 
            this.ButtonSendMessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSendMessage.Location = new System.Drawing.Point(370, 101);
            this.ButtonSendMessage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSendMessage.Name = "ButtonSendMessage";
            this.ButtonSendMessage.Size = new System.Drawing.Size(214, 39);
            this.ButtonSendMessage.TabIndex = 9;
            this.ButtonSendMessage.Text = "Send message";
            this.ButtonSendMessage.UseVisualStyleBackColor = true;
            // 
            // ButtonAddNotes
            // 
            this.ButtonAddNotes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNotes.Location = new System.Drawing.Point(370, 145);
            this.ButtonAddNotes.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddNotes.Name = "ButtonAddNotes";
            this.ButtonAddNotes.Size = new System.Drawing.Size(214, 39);
            this.ButtonAddNotes.TabIndex = 10;
            this.ButtonAddNotes.Text = "Add note";
            this.ButtonAddNotes.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(370, 397);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 39);
            this.ButtonExit.TabIndex = 14;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // SelectStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAddNotes);
            this.Controls.Add(this.ButtonSendMessage);
            this.Controls.Add(this.ButtonViewNotes);
            this.Controls.Add(this.TextBoxSearchBar);
            this.Controls.Add(this.ListBoxStudentList);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SelectStudentForm";
            this.Text = "Select Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxStudentList;
        private System.Windows.Forms.TextBox TextBoxSearchBar;
        private System.Windows.Forms.Button ButtonViewNotes;
        private System.Windows.Forms.Button ButtonSendMessage;
        private System.Windows.Forms.Button ButtonAddNotes;
        private System.Windows.Forms.Button ButtonExit;
    }
}