using System.Windows.Forms;

namespace SecureLine
{
    public static class MyMessageBox
    {
        /// <summary>
        /// Creates a new instance of InformationBoxForm and 
        /// displays the message input.
        /// </summary>
        /// <param name="message"></param>
        public static void ShowMessage(string message)
        {
            //The InformationBoxForm doesn't return any data
            DialogResult dlgResult = DialogResult.None;
            using (InformationBoxForm form = new InformationBoxForm())
            {
                //Displayed at the top of the form
                form.Text = "Information";
                //The message displayed in the form
                form.Message = message;
                dlgResult = form.ShowDialog();
            }
        }
    }
}
