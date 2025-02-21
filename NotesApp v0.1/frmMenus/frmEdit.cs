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
    public partial class frmEdit : Form
    {
        private frmPrincipal frmPrincipal;
        private DataNotes dataNoteSelecionado;
        public frmEdit(frmPrincipal principal, DataNotes dataNote)
        {
            InitializeComponent();
            frmPrincipal = principal;
            dataNoteSelecionado = dataNote;

            labelDataName.Text = dataNoteSelecionado.Name;
            labelDataNumber.Text = dataNoteSelecionado.NumberPhone;
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string Name = txtNameEdit.Text;
            string NumberPhone = txtPhoneEdit.Text;

            if (!string.IsNullOrEmpty(txtNameEdit.Text) && !string.IsNullOrEmpty(txtPhoneEdit.Text) )
            {
                dataNoteSelecionado.Name = Name;
                dataNoteSelecionado.NumberPhone = NumberPhone;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Try again or fill in the fields");
            }
        }
    }
}
