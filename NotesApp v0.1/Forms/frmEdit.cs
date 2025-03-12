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

            /*-------------------------------------------------------------------------------------------------------------------------------*/


            //Envia dos dados a serem preenchidos nos labels e campos de texto
            labelDataName.Text = dataContactsSelected.Name + " " + dataContactsSelected.LastName;

            //Verifica se o usuário definou o contato como sem NumberPhone
            if (dataContactsSelected.NumberPhone == "")
            {
                labelDataNumber.Text = "Empty";
            }
            else
            {
                labelDataNumber.Text = dataContactsSelected.NumberPhone;
            }

            //Verifica se o usuário definou a idade do contato
            if (dataContactsSelected.Age > 0)
            {
                labelDataAge.Text = Convert.ToString(dataContactsSelected.Age);
            }
            else if (dataContactsSelected.Age == 0)
            {
                labelDataAge.Text = "Without";
            }
            labelDataRelationship.Text = dataContactsSelected.Relationship;
            labelDataGender.Text = dataContactsSelected.Gender;
            labelDataStreet.Text = dataContactsSelected.Adress.DataStreet;
            labelDataCity.Text = dataContactsSelected.Adress.DataCity;
            labelDataState.Text = dataContactsSelected.Adress.DataState;
            labelDataZipCode.Text = dataContactsSelected.Adress.DataZipCode;
            labelDataCountry.Text = dataContactsSelected.Adress.DataCountry;

            /*-------------------------------------------------------------------------------------------------------------------------------*/



            //Adiciona aos campos de edição os valores para edição, facilitando a edição ao usuário
            txtNameEdit.Text = dataContactsSelected.Name;
            txtLastnameEdit.Text = dataContactsSelected.LastName;
            txtPhoneEdit.Text = dataContactsSelected.NumberPhone;
            if (dataContactsSelected.Age > 0)
            {
                inputAgeEdit.Text = Convert.ToString(dataContactsSelected.Age);
            }
            else
            {
                inputAgeEdit.Text = null;
            }
            checkBox_FavoriteEdited.Checked = dataContactsSelected.Favorited;
            comboBoxRelationshipEdit.Text = dataContactsSelected.Relationship;
            comboBoxGenderEdit.Text = dataContactsSelected.Gender;
            txtStreetEdit.Text = dataContactsSelected.Adress.DataStreet;
            txtCityEdit.Text = dataContactsSelected.Adress.DataCity;
            txtStateEdit.Text = dataContactsSelected.Adress.DataState;
            txtZipCodeEdit.Text = dataContactsSelected.Adress.DataZipCode;
            txtCountryEdit.Text = dataContactsSelected.Adress.DataCountry;
            txtLargeCommentaryEdit.Text = dataContactsSelected.Commentary;




            this.Shown += new EventHandler(Form1_Shown);//Tira o foco dos campos de edição
        }

        //Realiza as checagens para edição
        private void button_Confirm_Click(object sender, EventArgs e)
        {

            //Demais Atribuições

            string Name = txtNameEdit.Text;
            string LastName = txtLastnameEdit.Text;
            string NumberPhone = txtPhoneEdit.Text;
            string Relationship = comboBoxRelationshipEdit.Text;
            bool favorited = checkBox_FavoriteEdited.Checked;
            bool hasNumber;
            int age;
            string Gender = comboBoxGenderEdit.Text;
            string Commentary = txtLargeCommentaryEdit.Text;

            string Street = txtStreetEdit.Text;
            string City = txtCityEdit.Text;
            string Country = txtCountryEdit.Text;
            string State = txtStateEdit.Text;
            string ZipCode = txtZipCodeEdit.Text;

            //---------------------------------------------------------------------------------------------------------------------



            /*Retira os espaços no inputAge*/
            if (int.TryParse(inputAgeEdit.Text.Replace(" ", ""), out age))
            {

            }
            else
            {
                MessageBox.Show("Invalid age!", "Confirmation:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*Verifica se o contato irá possuir número de telefone*/
            if (string.IsNullOrEmpty(NumberPhone))
            {
                hasNumber = false; //Não possui
            }
            else
            {
                hasNumber = true; //Possui
            }

            //----------------------------------------------------------------------------------------------------------------------



            /*Responsável por verificar primeiramente, se o campo "Name" está preenchido*/
            if (!string.IsNullOrEmpty(txtNameEdit.Text))
            {
                try //Irá ser realizado a repassagem de dados, antes por meio de uma checagem, há qualquer erro, o código retornará este ao user
                {
                    Adress adress = new Adress(Street, City, State, ZipCode, Country);

                    DataContacts editedContact = new DataContacts(Name, NumberPhone, favorited, hasNumber, age, Relationship, LastName, Gender, adress, Commentary);

                        if (ProcessCheck.CheckFormValidation(editedContact))
                        {
                        

                            ConfirmConcluided(editedContact, dataContactsSelected);

                            DialogResult = DialogResult.OK;
                            MessageBox.Show("Contact edited successfully!");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Houve um erro no sistema, ao processar os dados", "Erro:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Try again or fill in the field name");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------




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
       