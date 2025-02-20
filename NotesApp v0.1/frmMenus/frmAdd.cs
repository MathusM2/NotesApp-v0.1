using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        private void btnAdd_Confirm_Click(object sender, EventArgs e)
        {
            string name = txtAdd_Name.Text;
            string phoneNumber = txtAdd_Number.Text;

            if(!string.IsNullOrEmpty(txtAdd_Name.Text) && !string.IsNullOrEmpty(txtAdd_Number.Text) )
            {
                //Chama o metódo AddToList, repassando os dados, e returna DialogResult.ok, finalizando a janela
                frmPrincipal.AddToList(name, phoneNumber);
                DialogResult = DialogResult.OK;
                
            }
            else
            {
                MessageBox.Show("Try again or fill in the fields!");
            }
        }
    }
}
