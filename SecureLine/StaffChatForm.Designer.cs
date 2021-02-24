namespace SecureLine
{
    partial class StaffChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffChatForm));
            this.LabelServerStatus = new System.Windows.Forms.Label();
            this.TextBoxServerStatus = new System.Windows.Forms.TextBox();
            this.ButtonStartServer = new System.Windows.Forms.Button();
            this.ButtonStopServer = new System.Windows.Forms.Button();
            this.LabelAvailableStudents = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.TreeViewClientList = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LabelServerStatus
            // 
            this.LabelServerStatus.AutoSize = true;
            this.LabelServerStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelServerStatus.Location = new System.Drawing.Point(56, 19);
            this.LabelServerStatus.Name = "LabelServerStatus";
            this.LabelServerStatus.Size = new System.Drawing.Size(136, 30);
            this.LabelServerStatus.TabIndex = 17;
            this.LabelServerStatus.Text = "Server status:";
            // 
            // TextBoxServerStatus
            // 
            this.TextBoxServerStatus.Location = new System.Drawing.Point(198, 19);
            this.TextBoxServerStatus.MaxLength = 50;
            this.TextBoxServerStatus.Name = "TextBoxServerStatus";
            this.TextBoxServerStatus.ReadOnly = true;
            this.TextBoxServerStatus.Size = new System.Drawing.Size(205, 35);
            this.TextBoxServerStatus.TabIndex = 18;
            this.TextBoxServerStatus.TabStop = false;
            // 
            // ButtonStartServer
            // 
            this.ButtonStartServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartServer.Location = new System.Drawing.Point(409, 16);
            this.ButtonStartServer.Name = "ButtonStartServer";
            this.ButtonStartServer.Size = new System.Drawing.Size(149, 39);
            this.ButtonStartServer.TabIndex = 19;
            this.ButtonStartServer.Text = "Start server";
            this.ButtonStartServer.UseVisualStyleBackColor = true;
            this.ButtonStartServer.Click += new System.EventHandler(this.ButtonStartServer_Click);
            // 
            // ButtonStopServer
            // 
            this.ButtonStopServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStopServer.Location = new System.Drawing.Point(564, 15);
            this.ButtonStopServer.Name = "ButtonStopServer";
            this.ButtonStopServer.Size = new System.Drawing.Size(149, 39);
            this.ButtonStopServer.TabIndex = 21;
            this.ButtonStopServer.Text = "Stop server";
            this.ButtonStopServer.UseVisualStyleBackColor = true;
            this.ButtonStopServer.Click += new System.EventHandler(this.ButtonStopServer_Click);
            // 
            // LabelAvailableStudents
            // 
            this.LabelAvailableStudents.AutoSize = true;
            this.LabelAvailableStudents.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAvailableStudents.Location = new System.Drawing.Point(56, 95);
            this.LabelAvailableStudents.Name = "LabelAvailableStudents";
            this.LabelAvailableStudents.Size = new System.Drawing.Size(187, 30);
            this.LabelAvailableStudents.TabIndex = 22;
            this.LabelAvailableStudents.Text = "Available students:";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(564, 476);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(149, 39);
            this.ButtonExit.TabIndex = 24;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TreeViewClientList
            // 
            this.TreeViewClientList.Location = new System.Drawing.Point(61, 129);
            this.TreeViewClientList.Margin = new System.Windows.Forms.Padding(4);
            this.TreeViewClientList.Name = "TreeViewClientList";
            this.TreeViewClientList.Size = new System.Drawing.Size(652, 340);
            this.TreeViewClientList.TabIndex = 25;
            this.TreeViewClientList.DoubleClick += new System.EventHandler(this.TreeViewClientList_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 39);
            this.panel2.TabIndex = 33;
            // 
            // StaffChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TreeViewClientList);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelAvailableStudents);
            this.Controls.Add(this.ButtonStopServer);
            this.Controls.Add(this.ButtonStartServer);
            this.Controls.Add(this.TextBoxServerStatus);
            this.Controls.Add(this.LabelServerStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.Name = "StaffChatForm";
            this.Text = "Staff Server Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelServerStatus;
        private System.Windows.Forms.TextBox TextBoxServerStatus;
        private System.Windows.Forms.Button ButtonStartServer;
        private System.Windows.Forms.Button ButtonStopServer;
        private System.Windows.Forms.Label LabelAvailableStudents;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TreeView TreeViewClientList;
        private System.Windows.Forms.Panel panel2;
    }
}