using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApp_v0._1.Models;

namespace NotesApp_v0._1.Utilities
{
    public class ManagerUsuarios
    {
        public static void Add(BindingList<DataNotes> usuarios, DataNotes newUsuario)
        {
            try
            {
                if (newUsuario == null)
                {
                    throw new ArgumentNullException("O usuário não pode ser nulo ou vazio");
                }

                if (usuarios.Contains(newUsuario))
                {
                    throw new InvalidOperationException("O usuário já existe");
                }
                usuarios.Add(newUsuario);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorrou um erro inesperado:" + ex);
            }
        }
        
        public static void Edit(BindingList<DataNotes> usuarios, DataNotes editedUsuario, DataNotes dataNoteSelecionado)
        {
            try
            {
                if(editedUsuario == null)
                {
                    throw new ArgumentNullException("O usuário não pode ser nulo ou vazio");
                }

                if (usuarios.Contains(editedUsuario))
                {
                    throw new InvalidOperationException("O usuário já existe");
                }
                dataNoteSelecionado.Name = editedUsuario.Name;
                dataNoteSelecionado.NumberPhone = editedUsuario.NumberPhone;

            }
            catch(Exception ex)
            {
                throw new ApplicationException("Ocorrou um erro inesperado:" + ex);
            }
        }

        public static void Remove(BindingList<DataNotes> usuarios, DataNotes dataNoteSelecionado)
        {
            try
            {
                usuarios.Remove(dataNoteSelecionado);
                MessageBox.Show("User has been removed!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro no sistema, ao deletar o usuário", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
