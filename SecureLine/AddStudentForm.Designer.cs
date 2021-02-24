namespace SecureLine
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.LabelAddStudent = new System.Windows.Forms.Label();
            this.LabelStudentID = new System.Windows.Forms.Label();
            this.TextBoxStudentIDValue = new System.Windows.Forms.TextBox();
            this.LabelStudentFirstName = new System.Windows.Forms.Label();
            this.TextBoxFirstNameValue = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextBoxLastNameValue = new System.Windows.Forms.TextBox();
            this.ButtonAddStudent = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAddStudent
            // 
            this.LabelAddStudent.AutoSize = true;
            this.LabelAddStudent.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAddStudent.Location = new System.Drawing.Point(15, 9);
            this.LabelAddStudent.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelAddStudent.Name = "LabelAddStudent";
            this.LabelAddStudent.Size = new System.Drawing.Size(176, 30);
            this.LabelAddStudent.TabIndex = 7;
            this.LabelAddStudent.Text = "Add new student:";
            // 
            // LabelStudentID
            // 
            this.LabelStudentID.AutoSize = true;
            this.LabelStudentID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentID.Location = new System.Drawing.Point(62, 59);
            this.LabelStudentID.Name = "LabelStudentID";
            this.LabelStudentID.Size = new System.Drawing.Size(111, 25);
            this.LabelStudentID.TabIndex = 8;
            this.LabelStudentID.Text = "Student\'s ID";
            // 
            // TextBoxStudentIDValue
            // 
            this.TextBoxStudentIDValue.Location = new System.Drawing.Point(228, 56);
            this.TextBoxStudentIDValue.MaxLength = 8;
            this.TextBoxStudentIDValue.Name = "TextBoxStudentIDValue";
            this.TextBoxStudentIDValue.Size = new System.Drawing.Size(264, 33);
            this.TextBoxStudentIDValue.TabIndex = 0;
            this.TextBoxStudentIDValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxStudentIDValue_Validating);
            // 
            // LabelStudentFirstName
            // 
            this.LabelStudentFirstName.AutoSize = true;
            this.LabelStudentFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentFirstName.Location = new System.Drawing.Point(62, 107);
            this.LabelStudentFirstName.Name = "LabelStudentFirstName";
            this.LabelStudentFirstName.Size = new System.Drawing.Size(102, 25);
            this.LabelStudentFirstName.TabIndex = 10;
            this.LabelStudentFirstName.Text = "First Name";
            // 
            // TextBoxFirstNameValue
            // 
            this.TextBoxFirstNameValue.Location = new System.Drawing.Point(228, 104);
            this.TextBoxFirstNameValue.MaxLength = 50;
            this.TextBoxFirstNameValue.Name = "TextBoxFirstNameValue";
            this.TextBoxFirstNameValue.Size = new System.Drawing.Size(264, 33);
            this.TextBoxFirstNameValue.TabIndex = 1;
            this.TextBoxFirstNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFirstNameValue_KeyPress);
            this.TextBoxFirstNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxFirstNameValue_Validating);
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(62, 158);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(100, 25);
            this.LabelLastName.TabIndex = 12;
            this.LabelLastName.Text = "Last Name";
            // 
            // TextBoxLastNameValue
            // 
            this.TextBoxLastNameValue.Location = new System.Drawing.Point(228, 155);
            this.TextBoxLastNameValue.MaxLength = 50;
            this.TextBoxLastNameValue.Name = "TextBoxLastNameValue";
            this.TextBoxLastNameValue.Size = new System.Drawing.Size(264, 33);
            this.TextBoxLastNameValue.TabIndex = 2;
            this.TextBoxLastNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLastNameValue_KeyPress);
            this.TextBoxLastNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxLastNameValue_Validating);
            // 
            // ButtonAddStudent
            // 
            this.ButtonAddStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStudent.Location = new System.Drawing.Point(228, 210);
            this.ButtonAddStudent.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddStudent.Name = "ButtonAddStudent";
            this.ButtonAddStudent.Size = new System.Drawing.Size(264, 39);
            this.ButtonAddStudent.TabIndex = 4;
            this.ButtonAddStudent.Text = "Add student";
            this.ButtonAddStudent.UseVisualStyleBackColor = true;
            this.ButtonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(154, 290);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 39);
            this.ButtonExit.TabIndex = 22;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
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
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 63);
            this.panel2.TabIndex = 34;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 404);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAddStudent);
            this.Controls.Add(this.TextBoxLastNameValue);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.TextBoxFirstNameValue);
            this.Controls.Add(this.LabelStudentFirstName);
            this.Controls.Add(this.TextBoxStudentIDValue);
            this.Controls.Add(this.LabelStudentID);
            this.Controls.Add(this.LabelAddStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AddStudentForm";
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddStudent;
        private System.Windows.Forms.Label LabelStudentID;
        private System.Windows.Forms.TextBox TextBoxStudentIDValue;
        private System.Windows.Forms.Label LabelStudentFirstName;
        private System.Windows.Forms.TextBox TextBoxFirstNameValue;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TextBoxLastNameValue;
        private System.Windows.Forms.Button ButtonAddStudent;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}