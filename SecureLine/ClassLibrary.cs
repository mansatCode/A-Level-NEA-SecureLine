using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SecureLine
{
    public static class ClassLibrary
    {
        /// <summary>
        /// Takes a string as input. Converts to lower case. 
        /// Capitalises first letter.
        /// Also capitalises any letter after a hyphen.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Returns string formattted as a name</returns>
        public static string FormatName(string text)
        {
            text = text.ToLower();
            char[] textArray = text.ToCharArray();
            StringBuilder sb = new StringBuilder();

            //Capitalise the first letter
            char firstChar = textArray[0];
            string firstLetter = firstChar.ToString().ToUpper();
            firstChar = char.Parse(firstLetter);
            textArray[0] = firstChar;
            
            for (int i = 0; i < textArray.Length; i++)
            {
                //If the character is a hyphen, capitalise the next letter.
                //Don't need to worry about the next letter being outside the bounds of the 
                //array as a name cannot have a hyphen at the end.
                if (textArray[i] == '-')
                {
                    char ch = char.Parse(textArray[i + 1].ToString().ToUpper());
                    textArray[i + 1] = ch;
                }
            }

            foreach (char c in textArray)
            {
                sb.Append(c);
            }

            //Convert the StringBuilder to a string
            return sb.ToString();
        }


        /// <summary>
        /// Generates a random 10-character password.
        /// </summary>
        /// <returns>Returns 10-character string.</returns>
        public static string GenerateRandomPassword(int length)
        {
            //Define the character set used to generate the password
            IEnumerable<char> characterSet =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "+-/*!\"£$%&*(),.?@#[]";

            //Convert the IEnumberable to a array of type character
            var characterArray = characterSet.ToArray();

            //Create a new byte array
            var bytes = new byte[length * 8];

            //Fill the byte array with a *cryptographically strong* sequence 
            //of random numbers. This is a better alternative to Random r.Next() 
            //as these numbers are not truly random.
            new RNGCryptoServiceProvider().GetBytes(bytes);

            //Create a new character array to store the password
            var result = new char[length];

            for (int i = 0; i < length; i++)
            {
                //ulong - occupies 8 bytes. Used to store a large unsigned integer value.
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }

            StringBuilder sb = new StringBuilder();
            foreach (char c in result)
            {
                sb.Append(c);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Performs an XOR encryption on the character codes of each character 
        /// in a string with a key.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="key"></param>
        /// <returns>The string result of the XOR operation.</returns>
        public static string SymmetricEncryptDecrypt(string text, string key)
        {
            StringBuilder result = new StringBuilder();

            for (int c = 0; c < text.Length; c++)
            {
                // take next character from string
                char character = text[c];

                // cast to a uint
                uint charCode = (uint)character;

                // Figure out which character to take from the key.
                // Use modulo to "wrap round"
                int keyPosition = c % key.Length; 

                // take the key character
                char keyChar = key[keyPosition];

                // cast it to a uint also
                uint keyCode = (uint)keyChar;

                // perform XOR on the two character codes
                uint combinedCode = charCode ^ keyCode;

                // cast back to a char
                char combinedChar = (char)combinedCode;

                // add to the result
                result.Append(combinedChar);
            }

            return result.ToString();
        }

        /// <summary>
        /// Checks that a text box contains not null data. 
        /// If it does, it sets the error message as 
        /// NULLDATAERRORMESSAGE. Otherwise, the error message 
        /// is set to null. 
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        public static void CheckTextBoxNotNull(TextBox t, ErrorProvider e)
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

            if (string.IsNullOrEmpty(t.Text.Trim()))
            {
                e.SetError(t, NULLDATAERRORMESSAGE);
            }
            else
            {
                e.SetError(t, null);
            }
        }

        /// <summary>
        /// Checks that a text box contains not null data.
        /// Checks whether the final letter in the input is a '-'.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        public static void CheckNameIsValid(TextBox t, ErrorProvider e)
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";
            const string HYPHENERRORMESSAGE = "A hyphen cannot be placed at the end of a name";

            if (string.IsNullOrEmpty(t.Text.Trim()))
            {
                e.SetError(t, NULLDATAERRORMESSAGE);
            }
            //Do not allow hyphens at the end of the name
            else if (t.Text.LastIndexOf('-') == t.Text.Length-1)
            {
                e.SetError(t, HYPHENERRORMESSAGE);
            }
            else
            {
                e.SetError(t, null);
            }
        }

        /// <summary>
        /// Checks that a text box contains not null data.
        /// Checks that the input is in the matches the format 
        /// of an email address.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="e"></param>
        public static void CheckEmailIsValid(TextBox t, ErrorProvider e)
        {
            const string NULLDATAERRORMESSAGE = "Field cannot be left empty";

            if (string.IsNullOrEmpty(t.Text))
            {
                e.SetError(t, NULLDATAERRORMESSAGE);
            }
            else if (!ValidateEmail(t.Text))
            {
                e.SetError(t, "E-mail is in an incorrect format");
            }
            else
            {
                e.SetError(t, null);
            }
        }

        /// <summary>
        /// Uses a regular expression to check whether an input matches the pattern of an e-mail.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>A boolean indicating whether the input matches the format 
        /// of an e-mail address.</returns>
        public static bool ValidateEmail(string email)
        {
            bool isValid = false;
            //Regular expression to validate email address
            Regex r = new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");

            //If the input conforms with the regular expression, return true
            if (r.IsMatch(email))
            {
                isValid = true;
            }
            return isValid;
        }

    }
}
