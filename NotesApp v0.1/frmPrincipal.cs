using NotesApp_v0._1.frmMenus;
using System.ComponentModel;
using NotesApp_v0._1.resc;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        //Adiciona uma lista de objetos contendo informa��es digitadas no frmAdd, como o nome e o n�mero de telefone
        //Diferente do met�do List<> que resumindo apenas e uma lista din�mica, que armazena diferentes tipos de dados, como objetos
        //BindingList<> no caso tamb�m e uma lista din�mica, mas ela conecta as informa��es na lista e atualiza as informa��es em interface
        //De forma automatica, conectando listNames e usuarios
        private BindingList<DataNotes> usuarios = new BindingList<DataNotes>();
        //BindingSource e o intermedi�rio entre a fonte de dados(BindingList usuarios) e a interface visual, como o listbox
        //Ele possui DataSource proprio, assim armazena informa��es em si, e permite alterar itens no listbox, sem alterar a fonte de dados
        //Ele atualiza as informa��es visuais de acordo com a fonte de dados
        private BindingSource bindingSource = new BindingSource();
        public frmPrincipal()
        {
            InitializeComponent();


            bindingSource.DataSource = usuarios;//No caso agora, bindingSource recebe suas informa��es de usuarios
            listNames.DataSource = bindingSource;//E repassa essas informa��es para a listbox
            listNames.DisplayMember = "Name";
            listNames.ValueMember = "NumberPhone";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //Abre um window, do tipo frmAdd, e nele coloco a refer�ncia do contexto do frmPrincipal
            var addWindow = new frmAdd(this);
            addWindow.ShowDialog();
        }

        //Recebe os dados de usuario frmAdd, coleta a lista usuarios, e chama a classe utilit�ria ManagerUsuarios
        public void AddUsuario(DataNotes usuario)
         {
            try
            {
                ManagerUsuarios.Add(usuarios, usuario);
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
         }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (listNames.SelectedItem != null)
            {
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
                DataNotes DataNoteSelected = (DataNotes)listNames.SelectedItem;
                usuarios.Remove(DataNoteSelected);
            }
            else
            {
                MessageBox.Show("Select an item to remove");
            }
        }

        //Respons�vel por esconder o icone de filtro, e exibir a combobox de filtro
        private void icon_filter_Click(object sender, EventArgs e)
        {
            if (filter_box.Visible == false)
            {
                icon_filter.Visible = false;
                filter_box.Visible = true;
                filter_box.Focus();
            }
        }

        //Respons�vel por esconder a combobox e exibir o icone de filtro
        private void filter_box_Leave(object sender, EventArgs e)
        {
            filter_box.Visible = false;
            icon_filter.Visible = true;

        }

        //Respons�vel por realizar a busca de itens pelo que esta escrito na caixa de texto ao clicar no icone de busca
        private void icon_Search_Click(object sender, EventArgs e)
        {
                var txtSearch = txt_Search.Text;
                ListFilter.Filter(usuarios, bindingSource, txtSearch);//Chama o m�todo de busca, enviando a refer�ncia de usuarios e da bindingSource
        }

        private void txt_Search_Enter(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if(txt_Search.Text == "")
            {
                txt_Search.Text = "Pesquisar";
            }
        }
    }
}