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

        const int minEntryLength = 5;
        const int maxEntryLength = 25;

        // Possible exceptions:
        static readonly Exception noCaps = new Exception("\t• No capital letters were included in the entered text");
        static readonly Exception noNums = new Exception("\t• No numbers were included in the entered text");
        static readonly Exception noSpecialChars = new Exception("\t• No special characters were included in the entered text");
        static readonly Exception invalidLength = new Exception("\t• The input was of invalid length");
        static readonly Exception invalidCharacter = new Exception("\t• The input was empty or contained a comma");
        static readonly Exception incorrectEmailDomain = new Exception("\t• The email domain was not registered in our database");
        static readonly Exception duplicateUsername = new Exception("\t• The username is not unique.");

        /// <summary>
        /// Checks if a string is empty.
        /// </summary>
        public static List<Exception> Validate(string textToValidate)
        {
            var exceptions = new List<Exception>(); // Create a new list for each validation call

            if (string.IsNullOrEmpty(textToValidate) || textToValidate.Contains(','))
            {
                exceptions.Add(invalidCharacter);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty or outside of a length range.
        /// </summary>
        public static List<Exception> ValidateWithLength(string textToValidate)
        {
            var exceptions = Validate(textToValidate); // Start with basic validation

            if (textToValidate.Length < minEntryLength || textToValidate.Length > maxEntryLength)
            {
                exceptions.Add(invalidLength);
            }
            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range, or doesn't include the specified password characters.
        /// </summary>
        public static List<Exception> ValidatePass(string textToValidate)
        {
            var exceptions = ValidateWithLength(textToValidate); // Start with length validation

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
        /// Checks if a string is empty, outside of a length range, or isn't a unique username.
        /// </summary>
        public static List<Exception> ValidateUsername(string usernameToValidate)
        {
            var exceptions = ValidateWithLength(usernameToValidate); // Start with length validation

            // Check in user database
            if (UserDatabase.Instance.Entries.Any(user => user.Username == usernameToValidate))
            {
                exceptions.Add(duplicateUsername);
            }

            return exceptions;
        }

        /// <summary>
        /// Checks if a string is empty, outside of a length range, or doesn't include an email domain.
        /// </summary>
        public static List<Exception> ValidateEmail(string emailToValidate)
        {
            var exceptions = new List<Exception>();

            try
            {
                string domain = emailToValidate.Substring(emailToValidate.IndexOf('@'));

                exceptions.AddRange(ValidateDomain(domain));

                if (!EmailDomainDatabase.Instance.Entries.Contains(domain))
                {
                    exceptions.Add(incorrectEmailDomain);
                }
            }
            catch
            {
                exceptions.Add(incorrectEmailDomain);
            }

            return exceptions;
        }

        public static List<Exception> ValidateDomain(string domain)
        {
            var exceptions = new List<Exception>();

            try
            {
                if (domain.First() != '@')
                {
                    exceptions.Add(incorrectEmailDomain);
                }
            }
            catch
            {
                exceptions.Add(incorrectEmailDomain);
            }

            exceptions.AddRange(Validate(domain));
            return exceptions;
        }
    }
}
