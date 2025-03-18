using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities.Filters
{

    public static class FormValidation
    {
        //Responsável por verificar se todos os campos estão corretos, caso contrário, returna uma mensagem de erro e impede o envio do Form
        public static (bool isValid, string message) CheckFields(DataContacts contactsInfo)
        {
            List<string> errorMessages = new List<string>();

            if (!CheckNameField(contactsInfo.Name, out string nameError))
            {
                errorMessages.Add(nameError);
            }

            if (!CheckLastNameField(contactsInfo.LastName, out string lastNameError))
            {
                errorMessages.Add(lastNameError);
            }

            if (!CheckNumberField(contactsInfo.NumberPhone, out string numberError))
            {
                errorMessages.Add(numberError);
            }

            if (!CheckAgeField(contactsInfo.Age, out string ageError))
            {
                errorMessages.Add(ageError);
            }

            if (!CheckCountryField(contactsInfo.Adress.DataCountry, out string countryError))
            {
                errorMessages.Add(countryError);
            }

            if (!CheckStateField(contactsInfo.Adress.DataState, out string stateError))
            {
                errorMessages.Add(stateError);
            }

            if (!CheckCityField(contactsInfo.Adress.DataCity, out string cityError))
            {
                errorMessages.Add(cityError);
            }

            if (!CheckStreetField(contactsInfo.Adress.DataStreet, out string streetError))
            {
                errorMessages.Add(streetError);
            }

            if (errorMessages.Count > 0)
            {
                return (false, string.Join(Environment.NewLine, errorMessages));
            }

            return (true, "");

            //----------------------------------------------------------------------------------------------------------------------------------------------




            /*Parte do código responsável pelos dados pessoas*/
        }
        public static bool CheckNameField(string name, out string errorMessage)
        {
            if (ContainsNumbers(name) || name.Length > 30)
            {
                errorMessage = "The Name field cannot contain numbers or greater than 30 characters!";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckLastNameField(string lastname, out string errorMessage)
        {
            if (ContainsNumbers(lastname) || lastname.Length > 50)
            {
                errorMessage = "The Lastname field cannot contain numbers or greater than 50 characters!";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckNumberField(string phoneNumber, out string errorMessage)
        {
            if (phoneNumber == "")
            {
                errorMessage = "";
                return true;

            }
            else if (!ContainsOnlyNumbers(phoneNumber) || phoneNumber.Length != 8)
            {
                errorMessage = "The Phone Number need a 8 digits, and cannot contain letters!";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckAgeField(int age, out string errorMessage)
        {

            if (age == 0)
            {
                DialogResult result = MessageBox.Show("You want create a contact without an a age?", "Confirmation:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    errorMessage = "";
                    return true;
                }
                else
                {
                    errorMessage = "Error Age";
                    return false;
                }
            }
            else if (age > 120)
            {
                errorMessage = "Enter a valid age";
                return false;
            }
            errorMessage = "";
            return true;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------





        /*Parte do código responsável pelos dados de endereço*/
        public static bool CheckCountryField(string country, out string errorMessage)
        {
            if (ContainsNumbers(country))
            {
                errorMessage = "The Country field cannot contains numbers";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckStateField(string state, out string errorMessage)
        {
            if (ContainsNumbers(state))
            {
                errorMessage = "The State field cannot contains numbers";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckStreetField(string street, out string errorMessage)
        {
            if (ContainsNumbers(street))
            {
                errorMessage = "The Street field cannot contains numbers";
                return false;
            }
            errorMessage = "";
            return true;
        }

        public static bool CheckCityField(string city, out string errorMessage)
        {
            if (ContainsNumbers(city))
            {
                errorMessage = "The Street field cannot contains numbers";
                return false;
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
