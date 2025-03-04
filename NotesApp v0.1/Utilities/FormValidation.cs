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
            if (phoneNumber == "")
            {
                MessageBox.Show("Ok vazio");
                return true;
                
            }
            else if (!ContainsOnlyNumbers(phoneNumber) || phoneNumber.Length != 8)
            {
                MessageBox.Show("Ok falso");
                return false;
            }
            MessageBox.Show("Ok passou");
            return true;
        }

        public static bool ContainsNumbers(string input) //Verifica se o campo do nome, contém números ou dígito
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

        public static bool ContainsOnlyNumbers(string input) //Verifica se o campo possui apenas dígitos
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
