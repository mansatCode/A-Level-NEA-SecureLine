namespace SecureLine
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.GroupBoxScale = new System.Windows.Forms.GroupBox();
            this.RadioButtonLarge = new System.Windows.Forms.RadioButton();
            this.RadioButtonStandard = new System.Windows.Forms.RadioButton();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.GroupBoxScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxScale
            // 
            this.GroupBoxScale.Controls.Add(this.RadioButtonLarge);
            this.GroupBoxScale.Controls.Add(this.RadioButtonStandard);
            this.GroupBoxScale.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxScale.Location = new System.Drawing.Point(24, 53);
            this.GroupBoxScale.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.GroupBoxScale.Name = "GroupBoxScale";
            this.GroupBoxScale.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.GroupBoxScale.Size = new System.Drawing.Size(259, 129);
            this.GroupBoxScale.TabIndex = 0;
            this.GroupBoxScale.TabStop = false;
            this.GroupBoxScale.Text = "Select Scale";
            // 
            // RadioButtonLarge
            // 
            this.RadioButtonLarge.AutoSize = true;
            this.RadioButtonLarge.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonLarge.Location = new System.Drawing.Point(7, 90);
            this.RadioButtonLarge.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.RadioButtonLarge.Name = "RadioButtonLarge";
            this.RadioButtonLarge.Size = new System.Drawing.Size(82, 34);
            this.RadioButtonLarge.TabIndex = 2;
            this.RadioButtonLarge.Text = "Large";
            this.RadioButtonLarge.UseVisualStyleBackColor = true;
            // 
            // RadioButtonStandard
            // 
            this.RadioButtonStandard.AutoSize = true;
            this.RadioButtonStandard.Checked = true;
            this.RadioButtonStandard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonStandard.Location = new System.Drawing.Point(7, 42);
            this.RadioButtonStandard.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.RadioButtonStandard.Name = "RadioButtonStandard";
            this.RadioButtonStandard.Size = new System.Drawing.Size(113, 34);
            this.RadioButtonStandard.TabIndex = 0;
            this.RadioButtonStandard.TabStop = true;
            this.RadioButtonStandard.Text = "Standard";
            this.RadioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(17, 9);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(112, 37);
            this.LabelHeader.TabIndex = 6;
            this.LabelHeader.Text = "Settings";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(24, 191);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(259, 39);
            this.ButtonExit.TabIndex = 11;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 238);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.GroupBoxScale);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.GroupBoxScale.ResumeLayout(false);
            this.GroupBoxScale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxScale;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.RadioButton RadioButtonLarge;
        private System.Windows.Forms.RadioButton RadioButtonStandard;
    }
}