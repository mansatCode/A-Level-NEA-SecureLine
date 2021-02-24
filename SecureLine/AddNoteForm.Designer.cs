namespace SecureLine
{
    partial class AddNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteForm));
            this.TextBoxStudentName = new System.Windows.Forms.TextBox();
            this.TextBoxAddNote = new System.Windows.Forms.TextBox();
            this.LabelTypeNote = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.Size = new System.Drawing.Size(572, 35);
            this.TextBoxStudentName.TabIndex = 5;
            this.TextBoxStudentName.Text = "Student name";
            // 
            // TextBoxAddNote
            // 
            this.TextBoxAddNote.Location = new System.Drawing.Point(12, 83);
            this.TextBoxAddNote.Multiline = true;
            this.TextBoxAddNote.Name = "TextBoxAddNote";
            this.TextBoxAddNote.Size = new System.Drawing.Size(572, 256);
            this.TextBoxAddNote.TabIndex = 6;
            this.TextBoxAddNote.Text = "Type note";
            // 
            // LabelTypeNote
            // 
            this.LabelTypeNote.AutoSize = true;
            this.LabelTypeNote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeNote.Location = new System.Drawing.Point(7, 50);
            this.LabelTypeNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTypeNote.Name = "LabelTypeNote";
            this.LabelTypeNote.Size = new System.Drawing.Size(104, 30);
            this.LabelTypeNote.TabIndex = 7;
            this.LabelTypeNote.Text = "Add note:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(435, 349);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 16;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNote.Location = new System.Drawing.Point(12, 349);
            this.ButtonAddNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(149, 39);
            this.ButtonAddNote.TabIndex = 17;
            this.ButtonAddNote.Text = "Add note";
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 398);
            this.Controls.Add(this.ButtonAddNote);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelTypeNote);
            this.Controls.Add(this.TextBoxAddNote);
            this.Controls.Add(this.TextBoxStudentName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "AddNoteForm";
            this.Text = "Add Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxStudentName;
        private System.Windows.Forms.TextBox TextBoxAddNote;
        private System.Windows.Forms.Label LabelTypeNote;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonAddNote;
    }
}