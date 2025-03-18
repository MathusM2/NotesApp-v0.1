using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.Utilities.Helpers
{
    public static class ValidationHelper
    {

        /*Parte do código responsável pelos dados de endereço*/
        public static bool CheckCountryField(string country, out string errorMessage)
        {
            if (ContainsNumbers(country))
            {
                errorMessage = "The Country field cannot contains numbers";
                return false;
            }
            else if (country == "")
            {
                errorMessage = "";
                return true;
            }
                errorMessage = "Opa";
                return true;
        }

        public static bool CheckStateField(string state, out string errorMessage)
        {
            if (ContainsNumbers(state))
            {
                errorMessage = "The State field cannot contains numbers";
                return false;
            }
            else if (state == "")
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Se";
            return (true);
        }

        public static bool CheckStreetField(string street, out string errorMessage)
        {
            if (ContainsNumbers(street))
            {
                errorMessage = "The Street field cannot contains numbers";
                return false;
            }
            else if (street == "")
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "Se";
                return true;
        }

        public static bool CheckCityField(string city, out string errorMessage)
        {
            if (ContainsNumbers(city))
            {
                errorMessage = "The Street field cannot contains numbers";
                return false;
            }
            else if(city == "")
            {
                errorMessage = "";
                return true;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckZipCodeField(string zipCode)
        {
            return true;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------




        /*Parte do código responsável pela lógica de checagem dos campos*/
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
