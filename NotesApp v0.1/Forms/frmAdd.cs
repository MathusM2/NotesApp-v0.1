using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities;


namespace NotesApp_v0._1.frmMenus
{
    public partial class frmAdd : Form
    {
        //recebe a referência do contexto de frmPrincipal
        private frmPrincipal frmPrincipal;
        public frmAdd(frmPrincipal principal)
        {
            InitializeComponent();
            frmPrincipal = principal;
        }

        private void btnAdd_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAdd_Name.Text;
                string phoneNumber = txtAdd_Number.Text;
                bool favorited = checkBox_Favorite.Checked;

                if (!string.IsNullOrEmpty(txtAdd_Name.Text) && !string.IsNullOrEmpty(txtAdd_Number.Text))
                {
                    if (FormValidation.CheckNameField(name))
                    {
                        if (FormValidation.CheckNumberField(phoneNumber))
                        {
                            DataNotes newUsario = new DataNotes(name, phoneNumber, favorited);
                            ConfirmConcluided(newUsario);
                            MessageBox.Show("The contact is registered!");
                        }
                        else
                        {
                            MessageBox.Show("the phone number need a 8 digits, and cannot contain letters!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The name field cannot contain numbers or greater than 30 characters!");
                    }

                }
                else
                {
                    MessageBox.Show("Try again, field cannot be empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro no sistema, ao processar os dados", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Após passar em todos os "checks", e chamado o método AddToList
        private void ConfirmConcluided(DataNotes newUsuario)
        {
            //Chama o metódo AddUsuario, repassando os dados, e returna DialogResult.ok, finalizando a janela
            frmPrincipal.AddUsuario(newUsuario);
            DialogResult = DialogResult.OK;
        }

    }
}
