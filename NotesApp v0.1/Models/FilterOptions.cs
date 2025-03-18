using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.Models
{
    //Usado para capturar os valores e os indices dos campos e seletores do FilterForm 
    public class FilterOptions
    {
        //Contact Filter

        public (int index, string? text)? RelationsOptions { get; set; }
        public (int index, string? inputValue)? AgeOptions { get; set; }
        public (int index, string? text)? GenderOptions { get; set; }
        public int? HasNumber { get; set; }
        public int? FavoriteOption { get; set; }

        //Adress Filter

        public string? CountryInput { get; set; }
        public string? StateInput { get; set; }
        public string? CityInput { get; set; }
        public string? ZipCodeInput { get; set; }
        public string? StreetInput { get; set; }
    }
}
