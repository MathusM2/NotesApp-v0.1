using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp_v0._1.resc
{
    public static class ListFilter
    {
        public static void Filter(BindingList<DataNotes> usuarios, BindingSource bindingSource, string txtSearch)
        {
            string Search = txtSearch.ToLower();//Torna o texto para busca minúsculo

            if (Search == "")//Caso nada seja digitado, a listbox e a bindingSource serão resetados
            {          
                bindingSource.DataSource = usuarios;
            }
            else
            {
                var filtredItens = usuarios.Where(u => u.Name.ToLower().Contains(Search)).ToList(); //Se realiza a filtragem dos itens
                bindingSource.DataSource = new BindingList<DataNotes>(filtredItens);//Cria uma nova lista como referência para bindingSource, os itens dentro dessa lista, contem apenas os itens filtrados

                bindingSource.ResetBindings(false);//Realiza a atualização da interface
            }
        }


        }
        
    }
