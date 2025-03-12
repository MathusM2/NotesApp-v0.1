using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.Models
{
    public class Adress
    {
        public string DataStreet { get; set; }
        public string DataCity { get; set; }
        public string DataState { get; set; }
        public string DataZipCode { get; set; }
        public string DataCountry { get; set; }

        /*-------------------------------------------------------------------------------------------------------------------------------*/



        public Adress(string street, string city, string state, string zipCode, string country)
        {
            DataStreet = street;
            DataCity = city;    
            DataState = state;
            DataZipCode = zipCode;
            DataCountry = country;
        }

        public override string ToString()
        {
            return $"{DataStreet}, \n{DataCity}, {DataState} {DataZipCode}\n{DataCountry}";
        }

    }
}
