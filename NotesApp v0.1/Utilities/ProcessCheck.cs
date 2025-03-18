using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities.Filters;

namespace NotesApp_v0._1.Utilities
{
    //Método utilitário, usado para servir como intermediário entre utilities como ListFilter, ListSearch, FormValidation, e frms, como Add e Edit
    public static class ProcessCheck
    {

        public static bool CheckFormValidation(DataContacts contactsInfo)
        {
            var (isValid, messages) = FormValidation.CheckFields(contactsInfo);
            if (!isValid)
            {
                MessageBox.Show(messages,"Erro de validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
            

        }

        public static bool CheckFilterFormValidation(FilterOptions filtredInfo)
        {
            var (isValid, messages) = FilterFormValidation.CheckFields(filtredInfo);
            if (!isValid)
            {
                MessageBox.Show(messages, "Erro de validação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                else
            {
                return true;
            }
        }
    }
}
