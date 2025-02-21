using NotesApp_v0._1.frmMenus;
using System.ComponentModel;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        //Adiciona uma lista de objetos contendo informa��es digitadas no frmAdd, como o nome e o n�mero de telefone
        //Diferente do met�do List<> que resumindo apenas e uma lista din�mica, que armazena diferentes tipos de dados, como objetos
        //BindingList<> no caso tamb�m e uma lista din�mica, mas ela conecta as informa��es na lista e atualiza as informa��es em interface
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
            //Abre um window, do tipo frmAdd, e nele coloco a refer�ncia do contexto do frmPrincipal
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

        //Esse m�todo e usado em frmAdd, e recebe as informa��es para adicionar um novo objeto do tipo DataNote na lista usuarios
        //� para a adi��o de um novo item na listbox
        public void AddToList (string name, string numberPhone)
        {
            //Adi��o do objeto a lista usu�rios
            DataNotes newDataNotes = new DataNotes(name, numberPhone);
            newDataNotes.Name = name;
            
            
            usuarios.Add(newDataNotes);
        }


    }
}