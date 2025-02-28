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
        public static void Add(BindingList<DataNotes> usuarios, DataNotes usuario)
        {
            try
            {
                if (usuario == null)
                {
                    throw new ArgumentNullException("O usuário não pode ser nulo ou vazio");
                }

                if (usuarios.Contains(usuario))
                {
                    throw new InvalidOperationException("O usuário já existe");
                }
                usuarios.Add(usuario);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ocorrou um erro inesperado:" + ex);
            }
        }


    }
}
