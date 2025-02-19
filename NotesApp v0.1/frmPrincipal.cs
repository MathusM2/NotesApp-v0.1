using NotesApp_v0._1.frmMenus;

namespace NotesApp_v0._1
{
    public partial class frmPrincipal : Form
    {
        private List<DataNotes> usuarios = new List<DataNotes>();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var addWindow = new frmAdd(this);
            addWindow.ShowDialog();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var editWindow = new frmEdit();
            editWindow.Show();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {

        }

        public void AddToListNames (string name)
        {
            listNames.Items.Add(name);
        }


    }
}