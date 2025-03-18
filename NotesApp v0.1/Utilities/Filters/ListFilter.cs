using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities.Filters
{
    public static class ListFilter
    {
        //Returna, quanto recebe uma lista do tipo DataContacts, método utilizado para a filtragem da listBox
        public static List<DataContacts> Filter(BindingList<DataContacts> contacts, //contacts e um paramêtro obrigatório
            FilterOptions selectedFilters)// paramêtros como "int? age = null" são opcionais, ou seja, não necessitam ser repassados para o método
        {
            var query = contacts.AsEnumerable(); //AsEnumerable converte uma coleção de dados, como o List, para IEnumerable, que é uma interface, que permite percorrer uma coleção, sem a necessidade de se criar uma nova

            //Contact Filter

            if (selectedFilters.RelationsOptions.HasValue)
            {
                switch (selectedFilters.RelationsOptions.Value.index)
                {
                    case 0:
                        break;
                    case 1:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    case 2:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    case 3:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    case 4:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    case 5:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    case 6:
                        query = query.Where(c => c.Relationship == selectedFilters.RelationsOptions.Value.text);
                        break;
                    default:
                        break;

                }
            }

            if (selectedFilters.GenderOptions.HasValue)
            {
                switch (selectedFilters.GenderOptions.Value.index)
                {
                    case 0:
                        break;
                    case 1:
                        query = query.Where(c => c.Gender == selectedFilters.GenderOptions.Value.text);
                        break;
                    case 2:
                        query = query.Where(c => c.Gender == selectedFilters.GenderOptions.Value.text);
                        break;
                    case 4:
                        query = query.Where(c => c.Gender == selectedFilters.GenderOptions.Value.text);
                        break;
                }
            }


            if (selectedFilters.AgeOptions.HasValue)
            {
                switch (selectedFilters.AgeOptions.Value.index)
                {
                    case 0:
                        break;
                    case 1:
                        query = query.Where(c => c.Age == 0);
                        break;
                    case 2:
                        query = query.Where(c => c.Age > 0 && c.Age <= 9);
                        break;
                    case 3:
                        query = query.Where(c => c.Age >= 10 && c.Age <= 16);
                        break;
                    case 4:
                        query = query.Where(c => c.Age >= 17 && c.Age <= 21);
                        break;
                    case 5:
                        query = query.Where(c => c.Age >= 22 && c.Age <= 40);
                        break;
                    case 6:
                        query = query.Where(c => c.Age >= 41 && c.Age <= 60);
                        break;
                    case 7:
                        query = query.Where(c => c.Age >= 61 && c.Age < 120);
                        break;
                    case 9:
                        query = query.Where(c => c.Age == Convert.ToInt32(selectedFilters.AgeOptions.Value.inputValue));
                        break;

                }
            }

            if (selectedFilters.HasNumber.HasValue)
            {
                if (selectedFilters.HasNumber.Value.ToString() == "1")
                {
                    query = query.Where(c => c.HasNumber == true);
                }

                else if (selectedFilters.HasNumber.Value.ToString() == "2")
                {
                    query = query.Where(c => c.HasNumber == false);
                }

                else
                {

                }


            }

            if (selectedFilters.FavoriteOption.HasValue)
            {
                if (selectedFilters.FavoriteOption.Value.ToString() == "1")
                {
                    query = query.Where(c => c.Favorited == true);
                }

                else if (selectedFilters.FavoriteOption.Value.ToString() == "2")
                {
                    query = query.Where(c => c.Favorited == false);
                }

                else
                {

                }
            }

            //Adress Filter


            if (selectedFilters.CountryInput != "")
            {
                query = query.Where(c => c.Adress.DataCountry.ToLower().Contains(selectedFilters.CountryInput.ToLower()));
            }

            if (selectedFilters.StateInput != "")
            {
                query = query.Where(c => c.Adress.DataState.ToLower().Contains(selectedFilters.StateInput.ToLower()));
            }

            if (selectedFilters.CityInput != "")
            {
                query = query.Where(c => c.Adress.DataCity.ToLower().Contains(selectedFilters.CityInput.ToLower()));
            }

            if (selectedFilters.StreetInput != "")
            {
                query = query.Where(c => c.Adress.DataStreet.ToLower().Contains(selectedFilters.StreetInput.ToLower()));
            }


            return query.ToList();//Returna a lista

        }
    }
}
