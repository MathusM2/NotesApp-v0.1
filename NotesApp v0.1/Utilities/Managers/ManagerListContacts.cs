using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities.Managers
{
    public class ManagerListContacts
    {
        public static void ToFilter(BindingSource bindingSource, List<DataContacts> contactsFiltred)
        {
            bindingSource.DataSource = contactsFiltred; //Recebe uma lista filtrada, e faz uma nova referencia para o DataSource da lista de contatos
        }
    }
}
