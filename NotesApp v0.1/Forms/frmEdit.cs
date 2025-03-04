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
    public partial class frmEdit : Form
    {
        //recebe a referência de frmPrincipal e do item selecionado na lista(listBox)
        private frmPrincipal frmPrincipal;
        private DataContacts dataContactsSelected;
        public frmEdit(frmPrincipal principal, DataContacts dataContacts)
        {
            InitializeComponent();
            frmPrincipal = principal;
            dataContactsSelected = dataContacts;

            //Envia dos dados a serem preenchidos nos labels e campos de texto
            labelDataName.Text = dataContactsSelected.Name;

            //Verifica se o usuário definou o contato como sem NumberPhone
            if (dataContactsSelected.NumberPhone == "")
            {
                labelDataNumber.Text = "Empty";
            }
            else
            {
                labelDataNumber.Text = dataContactsSelected.NumberPhone;
            }

            //Adiciona aos campos de edição os valores para edição, facilitando a edição ao usuário
            txtNameEdit.Text = dataContactsSelected.Name;
            txtPhoneEdit.Text = dataContactsSelected.NumberPhone;
            checkBox_FavoriteEdited.Checked = dataContactsSelected.Favorited;

            this.Shown += new EventHandler(Form1_Shown);//Tira o foco dos campos de edição
        }

        //Realiza as checagens para edição
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string Name = txtNameEdit.Text;
            string NumberPhone = txtPhoneEdit.Text;
            bool favorited = checkBox_FavoriteEdited.Checked;

            if (!string.IsNullOrEmpty(txtNameEdit.Text))
            {
                try
                {
                    if (FormValidation.CheckNameField(Name))
                    {
                        if (FormValidation.CheckNumberField(NumberPhone))
                        {
                            DataContacts editedContact = new DataContacts(Name, NumberPhone, favorited);

                            ConfirmConcluided(editedContact, dataContactsSelected);

                            DialogResult = DialogResult.OK;
                            MessageBox.Show("Contact edited successfully!");
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
                catch(Exception ex)
                {
                    MessageBox.Show("Houve um erro no sistema, ao processar os dados","Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Try again or fill in the field name");
            }
        }

        //Ao concluir as checagens, realizada a chamado do delegado EditContact, e repassa os dados
        public void ConfirmConcluided(DataContacts editedContact, DataContacts dataContactsSelected)
        {
            frmPrincipal.EditContact(editedContact, dataContactsSelected);
        }

        //Caso o usuário deixe o campo Name vazio, o programa irá reescreve-lo novamente
        private void txtNameEdit_Leave(object sender, EventArgs e)
        {
            if (txtNameEdit.Text == "")
            {
                txtNameEdit.Text = dataContactsSelected.Name;
            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            // Remover o foco do TextBox
            this.button_Confirm.Focus();
        }


    }
}
       