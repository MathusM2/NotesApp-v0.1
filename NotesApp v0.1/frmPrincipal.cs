using NotesApp_v0._1.frmMenus;
using System.ComponentModel;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        //Adiciona uma lista de objetos contendo informações digitadas no frmAdd, como o nome e o número de telefone
        //Diferente do metódo List<> que resumindo apenas e uma lista dinâmica, que armazena diferentes tipos de dados, como objetos
        //BindingList<> no caso também e uma lista dinâmica, mas ela conecta as informações na lista e atualiza as informações em interface
        //De forma automatica, conectando listNames e contacts
        protected BindingList<DataContacts> contacts = new BindingList<DataContacts>();
        //BindingSource e o intermediário entre a fonte de dados(BindingList contacts) e a interface visual, como o listbox
        //Ele possui DataSource proprio, assim armazena informações em si, e permite alterar itens no listbox, sem alterar a fonte de dados
        //Ele atualiza as informações visuais de acordo com a fonte de dados
        protected BindingSource bindingSource = new BindingSource();
        public frmPrincipal()
        {
            InitializeComponent();


            bindingSource.DataSource = contacts;//No caso agora, bindingSource recebe suas informações de contacts
            listNames.DataSource = bindingSource;//E repassa essas informações para a listbox
            listNames.DisplayMember = "Name";
            listNames.ValueMember = "NumberPhone";

            panelFilter.Visible = false;
        }


        /*------------------------------------------------------------------------------------------------------------------------------------*/


        //Delegators

        //Recebe os dados de contact frmAdd e frmEdit, e chama a classe utilitária ManagerContacts
        public void AddContact(DataContacts newContact)
        {
            try
            {
                ManagerContacts.Add(contacts, newContact);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditContact(DataContacts editedContact, DataContacts dataContactsSelected)
        {
            try
            {
                ManagerContacts.Edit(contacts, editedContact, dataContactsSelected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*------------------------------------------------------------------------------------------------------------------------------------*/


        //UI (User Interface)

        //Button Actions
        private void button_Add_Click(object sender, EventArgs e)
        {
            //Abre o Form frmAdd
            var addWindow = new frmAdd(this);
            addWindow.ShowDialog();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listNames.SelectedItem != null)
            {
                //Abre o Form frmEdit
                DataContacts DataContactsSelected = (DataContacts)listNames.SelectedItem;
                var editWindow = new frmEdit(this, DataContactsSelected);
                editWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select an item");
            }
        }
        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listNames.SelectedItem != null)
            {
                DataContacts DataContactsSelected = (DataContacts)listNames.SelectedItem;
                ManagerContacts.Remove(contacts, DataContactsSelected);
            }
            else
            {
                MessageBox.Show("Select an item to remove");
            }
        }


        /*------------------------------------------------------------------------------------------------------------------------------------*/


        //Filter

        //Responsável por abrir e esconder a aba de filtragem, da verificação dos campos e do button confirm para envio de dados

        private void icon_filter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
        }

        private void panelFilter_CloseButton_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
        }

        private void buttonConfirm_Filter_Click(object sender, EventArgs e)
        {
            int AgeField;
            var RelationshipField = panelFilter_comboBoxRelations.Text;
            bool FavoriteOption = checkBox_FilterFavorite.Checked;
            bool HaveNumberOption = checkBox_FilterHaveNumber.Checked;
            if (int.TryParse(panelFilterInput_Age.Text, out AgeField))
            {

            }
            else if (AgeField == 0)
            {

            }
            else
            {
                MessageBox.Show("A idade não é valida!");
            }


            ConfirmOptionsToFilter(HaveNumberOption, FavoriteOption, AgeField);
        }

        public void ConfirmOptionsToFilter(bool haveNumberOption, bool favoriteOption, int ageField)
        {
            if (haveNumberOption == true || favoriteOption == true || ageField > 0)
            {
                var filtredItens = ListFilter.Filter(contacts, haveNumberOption, favoriteOption, ageField); //Chama o método de filtragem e recebe uma lista IEnumerable

                bindingSource.DataSource = filtredItens; //Muda a referência de bindingSource para filtredItens
                panelFilter.Visible = false;
            }
            else
            {
                bindingSource.DataSource = contacts; //Caso nada seja filtrado, a lista e restaurada
            }
        }


        /*------------------------------------------------------------------------------------------------------------------------------------*/


        //Search

        //Responsável por realizar a busca de itens pelo que esta escrito na caixa de texto ao clicar no icone de busca
        private void icon_Search_Click(object sender, EventArgs e)
        {
            var txtSearch = txt_Search.Text;
            ListSearch.Search(contacts, bindingSource, txtSearch);//Chama o método de busca, enviando a referência de contacts e da bindingSource
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                txt_Search.Text = "Pesquisar";
            }
        }

        //Reset

        //Reseta a lista para a referência original
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = contacts;
        }
    }
}