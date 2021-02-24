namespace SecureLine
{
    partial class InformationBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationBoxForm));
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelMessage = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(205, 124);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(130, 29);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Close";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // LabelMessage
            // 
            this.LabelMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMessage.Location = new System.Drawing.Point(145, 23);
            this.LabelMessage.Name = "LabelMessage";
            this.LabelMessage.Size = new System.Drawing.Size(355, 87);
            this.LabelMessage.TabIndex = 2;
            this.LabelMessage.Text = "Message goes here.";
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::SecureLine.Properties.Resources.InformationIcon1;
            this.PictureBox.Location = new System.Drawing.Point(25, 23);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(91, 87);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(197)))), ((int)(((byte)(228)))));
            this.Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel.Location = new System.Drawing.Point(0, 170);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(512, 17);
            this.Panel.TabIndex = 3;
            // 
            // InformationBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 187);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.LabelMessage);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ButtonExit);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformationBoxForm";
            this.Text = "Info";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label LabelMessage;
        private System.Windows.Forms.Panel Panel;
    }
}