using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDCoursework
{
    internal static class Validation
    {
        const string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string nums = "0123456789";
        const string specialChars = "!\"£$%^&*()_-+={}@~\'#?/>.<,:;|\\¬`";

        static readonly List<Exception> exceptions = new List<Exception>();
        static readonly Exception noCaps = new Exception("\t• No capital letters were included in the entered text");
        static readonly Exception noNums = new Exception("\t• No numbers were included in the entered text");
        static readonly Exception noSpecialChars = new Exception("\t• No special characters were included in the entered text");
        static readonly Exception invalidLength = new Exception("\t• The input was of invalid length");
        static readonly Exception empty = new Exception("\t• The input was empty");
        static readonly Exception incorrectEmailDomain = new Exception("\t• The email domain was not registered in our database");


        /// <summary>
        /// Checks if a string is empty
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
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                exceptions.Add(empty);
            }
            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                exceptions.Add(invalidLength);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range or doesn't include specified password characters
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <param name="passRequiredChars"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> ValidatePass(string textToValidate, int minLength, int maxLength)
        {
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                exceptions.Add(empty);
            }
            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                exceptions.Add(invalidLength);
            }
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
        /// Checks if a string is empty, outside of a length range or doesn't include an email domain
        /// </summary>
        /// <param name="textToValidate"></param>
        /// <param name="minLength"></param>
        /// <param name="maxLength"></param>
        /// <returns>A list of exceptions</returns>
        public static List<Exception> ValidateEmail(string textToValidate, int minLength, int maxLength)
        {
            ResetValidationFlags();
            string domain;

            try 
            { 
                 domain = textToValidate.Substring(textToValidate.IndexOf('@'));
            }
            catch(Exception)
            {
                exceptions.Add(incorrectEmailDomain);
                return exceptions;
            }

            if (string.IsNullOrEmpty(textToValidate))
            {
                exceptions.Add(empty);
            }
            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                exceptions.Add(invalidLength);
            }
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
