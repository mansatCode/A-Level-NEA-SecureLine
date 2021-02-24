using System;
using System.Windows.Forms;

namespace SecureLine
{
    public partial class InformationBoxForm : Form
    {
        public InformationBoxForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The message to be displayed on the InformationBoxForm.
        /// </summary>
        public string Message
        {
            get { return LabelMessage.Text; }
            set { LabelMessage.Text = value; }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
