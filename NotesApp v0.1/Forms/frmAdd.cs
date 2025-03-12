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

        /*-------------------------------------------------------------------------------------------------------------------------------*/

        //Demais atribuições
        private void btnAdd_Confirm_Click(object sender, EventArgs e)
        {
            string name = txtAdd_Name.Text;
            string lastName = txtAdd_Lastname.Text;
            string phoneNumber = txtAdd_Number.Text;
            string relationship = comboBox_Relationship.Text;
            bool favorited = checkBox_Favorite.Checked;
            bool hasNumber;
            int age;
            string gender = comboBox_Gender.Text;
            string commentary = txtLargeAdd_Commentary.Text;

            //Parte relacionada ao endereço
            string country = txtAdd_Country.Text;
            string street = txtAdd_Street.Text;
            string city = txtAdd_City.Text;
            string state = txtAdd_State.Text;
            string zipCode = txtAdd_ZipCode.Text;

            /*-------------------------------------------------------------------------------------------------------------------------------*/


            /*Retira os espaços de inputAge*/
            if (int.TryParse(input_Age.Text.Replace(" ", ""), out age))
            {

            }
            else
            {
                MessageBox.Show("Invalid age!", "Confirmation:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*Verifica se o contato irá possuir número de telefone*/
            if (string.IsNullOrEmpty(txtAdd_Number.Text))
            {
                hasNumber = false; //Não possui
            }
            else
            {
                hasNumber = true; //Possui
            }

            /*-------------------------------------------------------------------------------------------------------------------------------*/



            //Verifica se o campo para o name esta vazio, e depois realiza as validações dos campos 
            if (!string.IsNullOrEmpty(txtAdd_Name.Text))
            {
                try
                {
                    Adress adress = new Adress(street, city, state, zipCode, country);

                    DataContacts contactsInfo = new DataContacts(name, phoneNumber, favorited, hasNumber, age, relationship, lastName, gender, adress, commentary);

                        if (ProcessCheck.CheckFormValidation(contactsInfo))
                        {
                            ConfirmConcluided(contactsInfo);
                            MessageBox.Show("The contact is registered!");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro no sistema, ao processar os dados", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Try again, field name cannot be empty!");
            }
        }

        /*-------------------------------------------------------------------------------------------------------------------------------*/



        //Após passar em todos os "checks", e chamado o método AddContact
        private void ConfirmConcluided(DataContacts newContact)
        {
            //Chama o método AddContact, repassando os dados, e returna DialogResult.ok, finalizando a janela
            frmPrincipal.AddContact(newContact);
            DialogResult = DialogResult.OK;
        }
    }
}
