using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.Utilities
{

    public static class FormValidation
    {
        public static bool CheckNameField(string name)
        {
            if (ContainsNumbers(name) || name.Length > 30)
            {
                return false;
            }
            return true;
        }

        public static bool CheckNumberField(string phoneNumber)
        {
            if (!ContainsOnlyNumbers(phoneNumber) || phoneNumber.Length != 8)
            {
                return false;
            }
            return true;
        }

        public static bool ContainsNumbers(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsOnlyNumbers(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
