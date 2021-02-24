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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNoteForm));
            this.TextBoxStudentName = new System.Windows.Forms.TextBox();
            this.TextBoxNote = new System.Windows.Forms.TextBox();
            this.LabelTypeNote = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonAddNote = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxStudentName
            // 
            this.TextBoxStudentName.Location = new System.Drawing.Point(12, 12);
            this.TextBoxStudentName.Multiline = true;
            this.TextBoxStudentName.Name = "TextBoxStudentName";
            this.TextBoxStudentName.ReadOnly = true;
            this.TextBoxStudentName.Size = new System.Drawing.Size(572, 82);
            this.TextBoxStudentName.TabIndex = 5;
            this.TextBoxStudentName.Text = "Student name";
            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Location = new System.Drawing.Point(12, 130);
            this.TextBoxNote.MaxLength = 300;
            this.TextBoxNote.Multiline = true;
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(572, 256);
            this.TextBoxNote.TabIndex = 6;
            this.TextBoxNote.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNote_Validating);
            // 
            // LabelTypeNote
            // 
            this.LabelTypeNote.AutoSize = true;
            this.LabelTypeNote.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeNote.Location = new System.Drawing.Point(7, 97);
            this.LabelTypeNote.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTypeNote.Name = "LabelTypeNote";
            this.LabelTypeNote.Size = new System.Drawing.Size(104, 30);
            this.LabelTypeNote.TabIndex = 7;
            this.LabelTypeNote.Text = "Add note:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(435, 396);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 16;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAddNote
            // 
            this.ButtonAddNote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddNote.Location = new System.Drawing.Point(12, 396);
            this.ButtonAddNote.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddNote.Name = "ButtonAddNote";
            this.ButtonAddNote.Size = new System.Drawing.Size(149, 39);
            this.ButtonAddNote.TabIndex = 17;
            this.ButtonAddNote.Text = "Add note";
            this.ButtonAddNote.UseVisualStyleBackColor = true;
            this.ButtonAddNote.Click += new System.EventHandler(this.ButtonAddNote_Click);
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
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 63);
            this.panel2.TabIndex = 33;
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonAddNote);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelTypeNote);
            this.Controls.Add(this.TextBoxNote);
            this.Controls.Add(this.TextBoxStudentName);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "AddNoteForm";
            this.Text = "Add Note";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxStudentName;
        private System.Windows.Forms.TextBox TextBoxNote;
        private System.Windows.Forms.Label LabelTypeNote;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonAddNote;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}