using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities.Helpers;

namespace NotesApp_v0._1.Utilities.Filters
{
    public static class FilterFormValidation
    {
        public static (bool isValid,string messages) CheckFields(FilterOptions filtredInfo)
        {
            List<string> errorMessages = new List<string>();

            if(!ValidationHelper.CheckCountryField(filtredInfo.CountryInput, out string countryError))
            {
                errorMessages.Add(countryError);
            }

            if(!ValidationHelper.CheckStateField(filtredInfo.StateInput, out string stateError))
            {
                errorMessages.Add(stateError);
            }

            if(!ValidationHelper.CheckCityField(filtredInfo.CityInput, out string cityError))
            {
                errorMessages.Add(cityError);
            }

            if(!ValidationHelper.CheckStreetField(filtredInfo.StreetInput, out string streetError))
            {
                errorMessages.Add(streetError);
            }

            if (errorMessages.Count > 0)
            {
                return (false, string.Join(Environment.NewLine, errorMessages));
            }

            return (true, "");
        }



        
    }
}
