namespace SecureLine
{
    partial class UpdateStaffListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateStaffListForm));
            this.LabelUpdateStaff = new System.Windows.Forms.Label();
            this.ListBoxStaffList = new System.Windows.Forms.ListBox();
            this.TextBoxSearchBar = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonDeleteStaff = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonAddStaff = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LabelUpdateStaff
            // 
            this.LabelUpdateStaff.AutoSize = true;
            this.LabelUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUpdateStaff.Location = new System.Drawing.Point(15, 9);
            this.LabelUpdateStaff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelUpdateStaff.Name = "LabelUpdateStaff";
            this.LabelUpdateStaff.Size = new System.Drawing.Size(133, 30);
            this.LabelUpdateStaff.TabIndex = 21;
            this.LabelUpdateStaff.Text = "Update Staff:";
            // 
            // ListBoxStaffList
            // 
            this.ListBoxStaffList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxStaffList.FormattingEnabled = true;
            this.ListBoxStaffList.ItemHeight = 30;
            this.ListBoxStaffList.Location = new System.Drawing.Point(20, 57);
            this.ListBoxStaffList.Name = "ListBoxStaffList";
            this.ListBoxStaffList.Size = new System.Drawing.Size(337, 364);
            this.ListBoxStaffList.TabIndex = 22;
            // 
            // TextBoxSearchBar
            // 
            this.TextBoxSearchBar.Location = new System.Drawing.Point(370, 10);
            this.TextBoxSearchBar.Name = "TextBoxSearchBar";
            this.TextBoxSearchBar.Size = new System.Drawing.Size(214, 33);
            this.TextBoxSearchBar.TabIndex = 23;
            this.TextBoxSearchBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchBar_KeyPress);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSearch.Location = new System.Drawing.Point(370, 57);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(214, 39);
            this.ButtonSearch.TabIndex = 24;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonDeleteStaff
            // 
            this.ButtonDeleteStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteStaff.Location = new System.Drawing.Point(370, 101);
            this.ButtonDeleteStaff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonDeleteStaff.Name = "ButtonDeleteStaff";
            this.ButtonDeleteStaff.Size = new System.Drawing.Size(214, 39);
            this.ButtonDeleteStaff.TabIndex = 25;
            this.ButtonDeleteStaff.Text = "Delete member";
            this.ButtonDeleteStaff.UseVisualStyleBackColor = true;
            this.ButtonDeleteStaff.Click += new System.EventHandler(this.ButtonDeleteStaff_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(373, 382);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(211, 39);
            this.ButtonExit.TabIndex = 26;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAddStaff
            // 
            this.ButtonAddStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddStaff.Location = new System.Drawing.Point(373, 340);
            this.ButtonAddStaff.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonAddStaff.Name = "ButtonAddStaff";
            this.ButtonAddStaff.Size = new System.Drawing.Size(214, 39);
            this.ButtonAddStaff.TabIndex = 27;
            this.ButtonAddStaff.Text = "Add member";
            this.ButtonAddStaff.UseVisualStyleBackColor = true;
            this.ButtonAddStaff.Click += new System.EventHandler(this.ButtonAddStaff_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 39);
            this.panel2.TabIndex = 34;
            // 
            // UpdateStaffListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 472);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ButtonAddStaff);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonDeleteStaff);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearchBar);
            this.Controls.Add(this.ListBoxStaffList);
            this.Controls.Add(this.LabelUpdateStaff);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UpdateStaffListForm";
            this.Text = "Update Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUpdateStaff;
        private System.Windows.Forms.ListBox ListBoxStaffList;
        private System.Windows.Forms.TextBox TextBoxSearchBar;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonDeleteStaff;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonAddStaff;
        private System.Windows.Forms.Panel panel2;
    }
}