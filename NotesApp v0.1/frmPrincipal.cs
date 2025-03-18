using NotesApp_v0._1.frmMenus;
using System.ComponentModel;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NotesApp_v0._1.Forms.Dialogs;
using NotesApp_v0._1.Utilities.Managers;

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
        }
        /*------------------------------------------------------------------------------------------------------------------------------------*/


        //Delegators

        //Recebe os dados de contact frmAdd, frmEdit, e chama a classe utilitária ManagerContacts
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

        //Recebe de FilterForm, uma lista de dados filtrada e envia esta para ManagerListContacts
        public void FilterList(List<DataContacts> filtredOptions)
        {
            ManagerListContacts.ToFilter(bindingSource, filtredOptions);
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
            var filterWindow = new FilterForm(this, contacts);
            filterWindow.ShowDialog();
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