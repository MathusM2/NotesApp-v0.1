using NotesApp_v0._1.frmMenus;
using System.ComponentModel;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        //Adiciona uma lista de objetos contendo informações digitadas no frmAdd, como o nome e o número de telefone
        //Diferente do metódo List<> que resumindo apenas e uma lista dinâmica, que armazena diferentes tipos de dados, como objetos
        //BindingList<> no caso também e uma lista dinâmica, mas ela conecta as informações na lista e atualiza as informações em interface
        //De forma automatica, conectando listNames e usuarios
        private BindingList<DataNotes> usuarios = new BindingList<DataNotes>();
        public frmPrincipal()
        {
            InitializeComponent();

            listNames.DataSource = usuarios;
            listNames.DisplayMember = "Name";
            listNames.ValueMember = "NumberPhone";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //Abre um window, do tipo frmAdd, e nele coloco a referência do contexto do frmPrincipal
            var addWindow = new frmAdd(this);
            addWindow.ShowDialog();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            DataNotes DataNotesSelecionado = (DataNotes)listNames.SelectedItem;
            var editWindow = new frmEdit(this, DataNotesSelecionado);
            editWindow.ShowDialog();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (listNames.SelectedItem != null)
            {
                DataNotes DataNoteSelecionado = (DataNotes)listNames.SelectedItem;
                usuarios.Remove(DataNoteSelecionado);

            }
        }

        //Esse método e usado em frmAdd, e recebe as informações para adicionar um novo objeto do tipo DataNote na lista usuarios
        //É para a adição de um novo item na listbox
        public void AddToList (string name, string numberPhone)
        {
            //Adição do objeto a lista usuários
            DataNotes newDataNotes = new DataNotes(name, numberPhone);
            newDataNotes.Name = name;
            
            
            usuarios.Add(newDataNotes);
        }


    }
}