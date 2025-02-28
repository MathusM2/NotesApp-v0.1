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
        private frmPrincipal frmPrincipal;
        private DataNotes dataNoteSelecionado;
        public frmEdit(frmPrincipal principal, DataNotes dataNote)
        {
            InitializeComponent();
            frmPrincipal = principal;
            dataNoteSelecionado = dataNote;

            labelDataName.Text = dataNoteSelecionado.Name;
            labelDataNumber.Text = dataNoteSelecionado.NumberPhone;

            txtNameEdit.Text = dataNoteSelecionado.Name;
            txtPhoneEdit.Text = dataNoteSelecionado.NumberPhone;

            this.Shown += new EventHandler(Form1_Shown);//O tipo de evento Shown, ordena que o programa adicione o foco a determinado componente, após o programa ser renderizado
        }                                               //Diferente de Load, que carregaria a ordem antes do programa ser renderizado
        private void Form1_Shown(object sender, EventArgs e)
        {
            // Remover o foco do TextBox
            this.button_Confirm.Focus();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string Name = txtNameEdit.Text;
            string NumberPhone = txtPhoneEdit.Text;

            if (!string.IsNullOrEmpty(txtNameEdit.Text) && !string.IsNullOrEmpty(txtPhoneEdit.Text))
            {
                if (FormValidation.CheckNameField(Name))
                {
                    if (FormValidation.CheckNumberField(NumberPhone))
                    {
                        dataNoteSelecionado.Name = Name;
                        dataNoteSelecionado.NumberPhone = NumberPhone;
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Contact edited successfully!");
                    }
                    else
                    {
                        MessageBox.Show("the phone number need a 8 digits, and cannot contain letters!");
                    }
                }
                else
                {
                    MessageBox.Show("The name field cannot contain numbers or greater than 30 characters!");
                }
            }
            else
            {
                MessageBox.Show("Try again or fill in the fields");
            }
        }

        private void txtNameEdit_Leave(object sender, EventArgs e)
        {
            if (txtNameEdit.Text == "")
            {
                txtNameEdit.Text = dataNoteSelecionado.Name;
            }
        }

        private void txtPhoneEdit_Leave(object sender, EventArgs e)
        {
            if (txtPhoneEdit.Text == "")
            {
                txtPhoneEdit.Text = dataNoteSelecionado.NumberPhone;
            }
        }


    }
}
       