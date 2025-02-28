using NotesApp_v0._1.frmMenus;
using System.ComponentModel;
using NotesApp_v0._1.Models;
using NotesApp_v0._1.Utilities;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        //Adiciona uma lista de objetos contendo informações digitadas no frmAdd, como o nome e o número de telefone
        //Diferente do metódo List<> que resumindo apenas e uma lista dinâmica, que armazena diferentes tipos de dados, como objetos
        //BindingList<> no caso também e uma lista dinâmica, mas ela conecta as informações na lista e atualiza as informações em interface
        //De forma automatica, conectando listNames e usuarios
        private BindingList<DataNotes> usuarios = new BindingList<DataNotes>();
        //BindingSource e o intermediário entre a fonte de dados(BindingList usuarios) e a interface visual, como o listbox
        //Ele possui DataSource proprio, assim armazena informações em si, e permite alterar itens no listbox, sem alterar a fonte de dados
        //Ele atualiza as informações visuais de acordo com a fonte de dados
        private BindingSource bindingSource = new BindingSource();
        public frmPrincipal()
        {
            InitializeComponent();


            bindingSource.DataSource = usuarios;//No caso agora, bindingSource recebe suas informações de usuarios
            listNames.DataSource = bindingSource;//E repassa essas informações para a listbox
            listNames.DisplayMember = "Name";
            listNames.ValueMember = "NumberPhone";
        }

        //Delegators

        //Recebe os dados de usuario frmAdd e frmEdit, e chama a classe utilitária ManagerUsuarios
        public void AddUsuario(DataNotes newUsuario)
        {
            try
            {
                ManagerUsuarios.Add(usuarios, newUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EditUsuario(DataNotes editedUsuario,DataNotes dataNoteSelecionado)
        {
            try
            {
                ManagerUsuarios.Edit(usuarios, editedUsuario, dataNoteSelecionado);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




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
                DataNotes DataNotesSelecionado = (DataNotes)listNames.SelectedItem;
                var editWindow = new frmEdit(this, DataNotesSelecionado);
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
                DataNotes DataNotesSelecionado = (DataNotes)listNames.SelectedItem;
                ManagerUsuarios.Remove(usuarios, DataNotesSelecionado);
            }
            else
            {
                MessageBox.Show("Select an item to remove");
            }
        }
        //Filter

        //Responsável por esconder o icone de filtro, e exibir a combobox de filtro

        private void icon_filter_Click(object sender, EventArgs e)
        {
            if (filter_box.Visible == false)
            {
                icon_filter.Visible = false;
                filter_box.Visible = true;
                filter_box.Focus();
            }
        }
        //Responsável por esconder a combobox e exibir o icone de filtro
        private void filter_box_Leave(object sender, EventArgs e)
        {
            filter_box.Visible = false;
            icon_filter.Visible = true;

        }

        //Search

        //Responsável por realizar a busca de itens pelo que esta escrito na caixa de texto ao clicar no icone de busca
        private void icon_Search_Click(object sender, EventArgs e)
        {
            var txtSearch = txt_Search.Text;
            ListSearch.Search(usuarios, bindingSource, txtSearch);//Chama o método de busca, enviando a referência de usuarios e da bindingSource
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
    }
}