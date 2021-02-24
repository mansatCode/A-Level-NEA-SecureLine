namespace SecureLine
{
    partial class UpdateStudentListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStudentListForm));
            this.ListBoxStudentList = new System.Windows.Forms.ListBox();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDeleteStudent = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.LabelUpdateStudents = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ListBoxStudentList
            // 
            this.ListBoxStudentList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxStudentList.FormattingEnabled = true;
            this.ListBoxStudentList.HorizontalScrollbar = true;
            this.ListBoxStudentList.ItemHeight = 30;
            this.ListBoxStudentList.Location = new System.Drawing.Point(12, 55);
            this.ListBoxStudentList.Name = "ListBoxStudentList";
            this.ListBoxStudentList.ScrollAlwaysVisible = true;
            this.ListBoxStudentList.Size = new System.Drawing.Size(337, 364);
            this.ListBoxStudentList.TabIndex = 1;
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.Location = new System.Drawing.Point(370, 12);
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(214, 33);
            this.TextBoxSearchBar.TabIndex = 4;
            this.TextBoxSearchBar.Text = "Search student";
            this.TextBoxSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchBar_KeyPress);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(370, 55);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(214, 39);
            this.ButtonSearch.TabIndex = 16;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDeleteStudent
            // 
            this.ButtonDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteStudent.Location = new System.Drawing.Point(370, 98);
            this.ButtonDeleteStudent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteStudent.Name = "ButtonDeleteStudent";
            this.ButtonDeleteStudent.Size = new System.Drawing.Size(214, 39);
            this.ButtonDeleteStudent.TabIndex = 17;
            this.ButtonDeleteStudent.Text = "Delete student";
            this.ButtonDeleteStudent.UseVisualStyleBackColor = true;
            this.ButtonDeleteStudent.Click += new System.EventHandler(this.ButtonDeleteStudent_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(370, 380);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 39);
            this.ButtonExit.TabIndex = 18;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.Location = new System.Drawing.Point(370, 336);
            this.ButtonAddStudent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(214, 39);
            this.ButtonAddStudent.TabIndex = 19;
            this.ButtonAddStudent.Text = "Add student";
            this.ButtonAddStudent.UseVisualStyleBackColor = true;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // LabelUpdateStudents
            // 
            this.LabelUpdateStudents.AutoSize = true;
            this.LabelUpdateStudents.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdateStudents.Location = new System.Drawing.Point(7, 12);
            this.LabelUpdateStudents.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUpdateStudents.Name = "LabelUpdateStudents";
            this.LabelUpdateStudents.Size = new System.Drawing.Size(170, 30);
            this.LabelUpdateStudents.TabIndex = 20;
            this.LabelUpdateStudents.Text = "Update students:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 39);
            this.panel2.TabIndex = 35;
            // 
            // UpdateStudentListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LabelUpdateStudents);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDeleteStudent);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearchBar);
            this.Controls.Add(this.ListBoxStudentList);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "UpdateStudentListForm";
            this.Text = "Update Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxStudentList;
        private System.Windows.Forms.TextBox TextBoxSearchBar;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDeleteStudent;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonAddStudent;
        private System.Windows.Forms.Label LabelUpdateStudents;
        private System.Windows.Forms.Panel panel2;
    }
}