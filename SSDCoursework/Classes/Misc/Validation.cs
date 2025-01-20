using SSDCoursework.Classes.DatabaseClasses;
using SSDCoursework.Classes.UserClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDCoursework.Classes.Misc
{
    internal static class Validation
    {
        const string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string nums = "0123456789";
        const string specialChars = "!\"£$%^&*()_-+={}@~\'#?/>.<,:;|\\¬`";

        //This list will contain the exceptions that are present in the given data.
        static readonly List<Exception> exceptions = new List<Exception>();

        //Possible exceptions:
        static readonly Exception noCaps = new Exception("\t• No capital letters were included in the entered text");
        static readonly Exception noNums = new Exception("\t• No numbers were included in the entered text");
        static readonly Exception noSpecialChars = new Exception("\t• No special characters were included in the entered text");
        static readonly Exception invalidLength = new Exception("\t• The input was of invalid length");
        static readonly Exception empty = new Exception("\t• The input was empty");
        static readonly Exception incorrectEmailDomain = new Exception("\t• The email domain was not registered in our database");
        static readonly Exception duplicateUsername = new Exception("\t• The username is not unique.");


        /// <summary>
        /// Checks if a string is empty.
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> Validate(string textToValidate)
        {
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                exceptions.Add(empty);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty or outside of a length range
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> Validate(string textToValidate, int minLength, int maxLength)
        {
            exceptions.AddRange(Validate(textToValidate));

            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                exceptions.Add(invalidLength);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range or doesn't include the specified password characters.
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <param name="passRequiredChars"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> ValidatePass(string textToValidate, int minLength, int maxLength)
        {
            exceptions.AddRange(Validate(textToValidate, minLength, maxLength));

            if (!textToValidate.Any(c => caps.Contains(c)))
            {
                exceptions.Add(noCaps);
            }
            if (!textToValidate.Any(c => nums.Contains(c)))
            {
                exceptions.Add(noNums);
            }
            if (!textToValidate.Any(c => specialChars.Contains(c)))
            {
                exceptions.Add(noSpecialChars);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range or isn't a unique username.
        /// </summary>
        /// <param name="usernameToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <param name="passRequiredChars"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> ValidateUsername(string usernameToValidate, int minLength, int maxLength)
        {
            exceptions.AddRange(Validate(usernameToValidate, minLength, maxLength));
            
            //Checks 
            foreach(User tempUser in UserDatabase.Instance.Entries)
            {
                if (tempUser.Username == usernameToValidate)
                {
                    exceptions.Add(duplicateUsername);
                }
            }

            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range or doesn't include an email domain.
        /// </summary>
        /// <param name="emailToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> ValidateEmail(string emailToValidate, int minLength, int maxLength)
        {
            string domain;

            //Attempts to get the domain of the email.
            try 
            { 
                 domain = emailToValidate.Substring(emailToValidate.IndexOf('@'));
            }
            catch
            {
                exceptions.Add(incorrectEmailDomain);
                return exceptions;
            }

            exceptions.AddRange(Validate(emailToValidate, minLength, maxLength));

            if (!EmailDomainDatabase.Instance.Entries.Contains(domain))
            {
                exceptions.Add(incorrectEmailDomain);
            }
            return exceptions;
        }

        static void ResetValidationFlags()
        {
            exceptions.Clear();
        }
    }
}
