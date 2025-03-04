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
        public static void Filter(BindingList<DataContacts> contacts, BindingSource bindingSource, bool favorite)
        {
            if(favorite == false)
            {
                bindingSource.DataSource = contacts;
            }
            else
            {
                var favoriteFilter = contacts.Where(u => u.Favorited.Equals(favorite)).ToList();
                bindingSource.DataSource = new BindingList<DataContacts>(favoriteFilter);

                bindingSource.ResetBindings(false);//Realiza a atualização da interface
            }
    }
}
}
