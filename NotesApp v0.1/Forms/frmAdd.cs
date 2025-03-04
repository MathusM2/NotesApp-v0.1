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

        //E realizado a checagem dos campos para adicionar um novo contato
        private void btnAdd_Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtAdd_Name.Text;
                string phoneNumber = txtAdd_Number.Text;
                bool favorited = checkBox_Favorite.Checked;


                //Verifica se o campo para o name esta vazio, e realiza as validações dos campos name e phoneNumber
                if (!string.IsNullOrEmpty(txtAdd_Name.Text))
                {
                    if (FormValidation.CheckNameField(name))
                    {
                        if (FormValidation.CheckNumberField(phoneNumber))
                        {
                            DataContacts newContact = new DataContacts(name, phoneNumber, favorited);
                            ConfirmConcluided(newContact);
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
                    MessageBox.Show("Try again, field name cannot be empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um erro no sistema, ao processar os dados", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        //Após passar em todos os "checks", e chamado o método AddContact
        private void ConfirmConcluided(DataContacts newContact)
        {
            //Chama o método AddContact, repassando os dados, e returna DialogResult.ok, finalizando a janela
            frmPrincipal.AddContact(newContact);
            DialogResult = DialogResult.OK;
        }

    }
}
