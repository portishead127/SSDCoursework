using System;
using System.Linq;

namespace SSDCoursework
{
    internal static class Validation
    {
        static string caps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string nums = "0123456789";
        static string specialChars = "!\"£$%^&*()_-+={}@~\'#?/>.<,:;|\\¬`";
        static bool isEmpty;
        static bool isInvalidLength;
        static bool hasNoCaps;
        static bool hasNoNums;
        static bool hasNoSpecialChars;

        public static bool[] Validate(string textToValidate)
        {
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                isEmpty = true;
            }
            return new bool[] { isEmpty, isInvalidLength, hasNoCaps, hasNoNums, hasNoSpecialChars };
        }

        public static bool[] Validate(string textToValidate, int minLength, int maxLength)
        {
            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                isEmpty = true;
            }
            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                isInvalidLength = true;
            }
            return new bool[] { isEmpty, isInvalidLength, hasNoCaps, hasNoNums, hasNoSpecialChars };
        }

        public static bool[] Validate(string textToValidate, int minLength, int maxLength, bool passRequiredChars)
        {
            if (!passRequiredChars)
            {
                return Validate(textToValidate, minLength, maxLength);
            }

            ResetValidationFlags();

            if (string.IsNullOrEmpty(textToValidate))
            {
                isEmpty = true;
            }
            if (textToValidate.Length < minLength || textToValidate.Length > maxLength)
            {
                isInvalidLength = true;
            }

            hasNoCaps = !textToValidate.Any(c => caps.Contains(c));
            hasNoNums = !textToValidate.Any(c => nums.Contains(c));
            hasNoSpecialChars = !textToValidate.Any(c => specialChars.Contains(c));

            return new bool[] { isEmpty, isInvalidLength, hasNoCaps, hasNoNums, hasNoSpecialChars };
        }

        static void ResetValidationFlags()
        {
            isEmpty = false;
            isInvalidLength = false;
            hasNoCaps = false;
            hasNoNums = false;
            hasNoSpecialChars = false;
        }
    }
}
