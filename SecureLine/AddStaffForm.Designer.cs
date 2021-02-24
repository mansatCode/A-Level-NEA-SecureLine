namespace SecureLine
{
    partial class AddStaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStaffForm));
            this.LabelAddStudent = new System.Windows.Forms.Label();
            this.LabelStudentFirstName = new System.Windows.Forms.Label();
            this.TextBoxFirstNameValue = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.TextBoxLastNameValue = new System.Windows.Forms.TextBox();
            this.LabelStaffEmail = new System.Windows.Forms.Label();
            this.TextBoxStaffEmailValue = new System.Windows.Forms.TextBox();
            this.ButtonAddStaff = new System.Windows.Forms.Button();
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
            this.LabelAddStudent.Size = new System.Drawing.Size(230, 30);
            this.LabelAddStudent.TabIndex = 8;
            this.LabelAddStudent.Text = "Add new staff member:";
            // 
            // LabelStudentFirstName
            // 
            this.LabelStudentFirstName.AutoSize = true;
            this.LabelStudentFirstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStudentFirstName.Location = new System.Drawing.Point(62, 59);
            this.LabelStudentFirstName.Name = "LabelStudentFirstName";
            this.LabelStudentFirstName.Size = new System.Drawing.Size(102, 25);
            this.LabelStudentFirstName.TabIndex = 11;
            this.LabelStudentFirstName.Text = "First Name";
            // 
            // TextBoxFirstNameValue
            // 
            this.TextBoxFirstNameValue.Location = new System.Drawing.Point(228, 56);
            this.TextBoxFirstNameValue.MaxLength = 50;
            this.TextBoxFirstNameValue.Name = "TextBoxFirstNameValue";
            this.TextBoxFirstNameValue.Size = new System.Drawing.Size(220, 33);
            this.TextBoxFirstNameValue.TabIndex = 12;
            this.TextBoxFirstNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxFirstNameValue_KeyPress);
            this.TextBoxFirstNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxFirstNameValue_Validating);
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastName.Location = new System.Drawing.Point(64, 108);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(100, 25);
            this.LabelLastName.TabIndex = 13;
            this.LabelLastName.Text = "Last Name";
            // 
            // TextBoxLastNameValue
            // 
            this.TextBoxLastNameValue.Location = new System.Drawing.Point(228, 105);
            this.TextBoxLastNameValue.MaxLength = 50;
            this.TextBoxLastNameValue.Name = "TextBoxLastNameValue";
            this.TextBoxLastNameValue.Size = new System.Drawing.Size(220, 33);
            this.TextBoxLastNameValue.TabIndex = 14;
            this.TextBoxLastNameValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLastNameValue_KeyPress);
            this.TextBoxLastNameValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxLastNameValue_Validating);
            // 
            // LabelStaffEmail
            // 
            this.LabelStaffEmail.AutoSize = true;
            this.LabelStaffEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStaffEmail.Location = new System.Drawing.Point(64, 161);
            this.LabelStaffEmail.Name = "LabelStaffEmail";
            this.LabelStaffEmail.Size = new System.Drawing.Size(58, 25);
            this.LabelStaffEmail.TabIndex = 22;
            this.LabelStaffEmail.Text = "Email";
            // 
            // TextBoxStaffEmailValue
            // 
            this.TextBoxStaffEmailValue.Location = new System.Drawing.Point(228, 158);
            this.TextBoxStaffEmailValue.MaxLength = 100;
            this.TextBoxStaffEmailValue.Name = "TextBoxStaffEmailValue";
            this.TextBoxStaffEmailValue.Size = new System.Drawing.Size(220, 33);
            this.TextBoxStaffEmailValue.TabIndex = 23;
            this.TextBoxStaffEmailValue.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxStaffEmailValue_Validating);
            // 
            // ButtonAddStaff
            // 
            this.ButtonAddStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStaff.Location = new System.Drawing.Point(228, 201);
            this.ButtonAddStaff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddStaff.Name = "ButtonAddStaff";
            this.ButtonAddStaff.Size = new System.Drawing.Size(220, 39);
            this.ButtonAddStaff.TabIndex = 24;
            this.ButtonAddStaff.Text = "Add member";
            this.ButtonAddStaff.UseVisualStyleBackColor = true;
            this.ButtonAddStaff.Click += new System.EventHandler(this.ButtonAddStaff_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(124, 267);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(220, 39);
            this.ButtonExit.TabIndex = 25;
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
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(485, 63);
            this.panel2.TabIndex = 34;
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonAddStaff);
            this.Controls.Add(this.TextBoxStaffEmailValue);
            this.Controls.Add(this.LabelStaffEmail);
            this.Controls.Add(this.TextBoxLastNameValue);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.TextBoxFirstNameValue);
            this.Controls.Add(this.LabelStudentFirstName);
            this.Controls.Add(this.LabelAddStudent);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AddStaffForm";
            this.Text = "Add New Staff Member";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAddStudent;
        private System.Windows.Forms.Label LabelStudentFirstName;
        private System.Windows.Forms.TextBox TextBoxFirstNameValue;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.TextBox TextBoxLastNameValue;
        private System.Windows.Forms.Label LabelStaffEmail;
        private System.Windows.Forms.TextBox TextBoxStaffEmailValue;
        private System.Windows.Forms.Button ButtonAddStaff;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel2;
    }
}