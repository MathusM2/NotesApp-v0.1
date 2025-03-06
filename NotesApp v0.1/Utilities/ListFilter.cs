using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities
{
    public static class ListFilter 
    {
        //Returna, quanto recebe uma lista do tipo DataContacts, método utilizado para a filtragem da listBox
        public static List<DataContacts> Filter(BindingList<DataContacts> contacts, //contacts e um paramêtro obrigatório
            bool? hasNumber = null,
            bool? favorite = null,
            int? age = null)// paramêtros como "int? age = null" são opcionais, ou seja, não necessitam ser repassados para o método
            {

            var query = contacts.AsEnumerable(); //AsEnumerable converte uma coleção de dados, como o List, para IEnumerable, que é uma interface, que permite percorrer uma coleção, sem a necessidade de se criar uma nova


            if (favorite == true)
            {
                query = query.Where(c => c.Favorited == favorite.Value);
            }

            if (hasNumber == true)
            {
                query = query.Where(c => c.HasNumber == hasNumber.Value);   
            }

            if (age > 0)
            {
                query = query.Where(c => c.Age == age.Value);
            }

            

                return query.ToList();//Returna a lista
            
        }
    }
}
