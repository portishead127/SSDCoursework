using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDCoursework
{
    internal static class Validation
    { 
        static string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string nums = "0123456789";
        static string specialChars = "!\"£$%^&*()_-+={}@~\'#?/>.<,:;|\\¬`";

        static List<Exception> exceptions = new List<Exception>();
        static Exception noCaps = new Exception("\t• No capital letters were included in the entered text");
        static Exception noNums = new Exception("\t• No numbers were included in the entered text");
        static Exception noSpecialChars = new Exception("\t• No special characters were included in the entered text");
        static Exception invalidLength= new Exception("\t• The input was of invalid length");
        static Exception empty = new Exception("\t• The input was empty");

        public static List<Exception> Validate(string textToValidate)
        {
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                exceptions.Add(empty);
            }
            return exceptions;
        }

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

        public static List<Exception> Validate(string textToValidate, int minLength, int maxLength, bool passRequiredChars)
        {
            if (!passRequiredChars)
            {
                return Validate(textToValidate, minLength, maxLength);
            }

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

        static void ResetValidationFlags()
        {
            exceptions.Clear();
        }
    }
}
