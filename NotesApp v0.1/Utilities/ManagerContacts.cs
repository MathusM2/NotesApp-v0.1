using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities
{
    //Método utilitário para controle de dados da lista Contacts
    public class ManagerContacts
    {
        public static void Add(BindingList<DataContacts> contacts, DataContacts newContact)
        {
            try
            {
                if (newContact == null)
                {
                    throw new ArgumentNullException("O contato não pode ser nulo ou vazio");
                }

                if (contacts.Contains(newContact))
                {
                    throw new InvalidOperationException("O contato já existe");
                }
                contacts.Add(newContact);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorrou um erro inesperado:" + ex);
            }
        }
        
        public static void Edit(BindingList<DataContacts> contacts, DataContacts editedContact, DataContacts dataContactsSelected)
        {
            try
            {
                if(editedContact == null)
                {
                    throw new ArgumentNullException("O contato não pode ser nulo ou vazio");
                }

                if (contacts.Contains(editedContact))
                {
                    throw new InvalidOperationException("O contato já existe");
                }
                dataContactsSelected.Name = editedContact.Name;
                dataContactsSelected.NumberPhone = editedContact.NumberPhone;
                dataContactsSelected.Favorited = editedContact.Favorited;


            }
            catch(Exception ex)
            {
                throw new ApplicationException("Ocorrou um erro inesperado:" + ex);
            }
        }

        public static void Remove(BindingList<DataContacts> contacts, DataContacts dataContactsSelected)
        {
            try
            {
                contacts.Remove(dataContactsSelected);
                MessageBox.Show("User has been removed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro no sistema, ao deletar o contato", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
