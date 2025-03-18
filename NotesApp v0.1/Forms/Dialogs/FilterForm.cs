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
using NotesApp_v0._1.Utilities.Filters;

namespace NotesApp_v0._1.Forms.Dialogs
{
    public partial class FilterForm : Form
    {
        //Recebe referencias de frmPrincipal e da lista de contacts
        private frmPrincipal frmPrincipal;
        private BindingList<DataContacts> dataContacts;
        public FilterForm(frmPrincipal principal, BindingList<DataContacts> contacts)
        {
            InitializeComponent();
            frmPrincipal = principal;
            dataContacts = contacts;
        }

        private bool customOptionAdded = true;
        private void ConfirmButtonFilter_Click(object sender, EventArgs e)
        {
            //Coleta todas as informações dos campos 
            var selectedFilters = new FilterOptions
            {
                RelationsOptions = (comboBoxFilterRelations.SelectedIndex,comboBoxFilterRelations.SelectedItem?.ToString()),
                GenderOptions = (comboBoxFilterGender.SelectedIndex, comboBoxFilterGender.SelectedItem?.ToString()),
                AgeOptions = (comboBoxFilterAge.SelectedIndex, comboBoxFilterAge.SelectedItem?.ToString()),
                HasNumber = (comboBoxFilterHNumber.SelectedIndex),
                FavoriteOption = (comboBoxFilterFavorite.SelectedIndex),

                CountryInput = (txtFilterCountry.Text),
                StateInput = (txtFilterState.Text),
                CityInput = (txtFilterCity.Text),
                StreetInput = (txtFilterStreet.Text),
                ZipCodeInput = (txtFilterZipCode.Text)
            };

            ConfirmFilterOptions(selectedFilters);
        }

        public void ConfirmFilterOptions(FilterOptions selectedFilters)
        {
            if (ProcessCheck.CheckFilterFormValidation(selectedFilters))
            {
                //Envia os dados a serem filtrados para ListFilter, e chama o metodo Filter para que ele retorne uma List
                var filtredOptions = ListFilter.Filter(dataContacts, selectedFilters);

                frmPrincipal.FilterList(filtredOptions);// Envia os dados filtrados para a camada intermediaria
            }
        }


        //Verificara se o user selecionou o item "Find..", no comboBox Age, para adicionar uma idade especifica a ser filtrada
        private void comboBoxFilterAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFindValue = comboBoxFilterAge.SelectedItem.ToString();
            int selectedFind = comboBoxFilterAge.SelectedIndex;

            
            if (selectedFindValue == "Find..." && customOptionAdded)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter your desired age:", "Adicionar age", "", -1, -1);

                if (!string.IsNullOrEmpty(input))
                {
                    comboBoxFilterAge.Items.Add(input);
                    comboBoxFilterAge.SelectedItem = 0;
                    customOptionAdded = false;

                    comboBoxFilterAge.Items.RemoveAt(selectedFind);
                    comboBoxFilterAge.Items.Add("Find...");

                }
                else
                {
                    comboBoxFilterAge.SelectedIndex = 0;
                }

            }
            else if (comboBoxFilterAge.SelectedIndex == comboBoxFilterAge.Items.Count - 1 && !customOptionAdded)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter your desired age:", "Edit age", "", -1, -1);

                comboBoxFilterAge.Items.RemoveAt((comboBoxFilterAge.Items.Count - 1) - 1);
                comboBoxFilterAge.Items.Insert(comboBoxFilterAge.Items.Count - 1, input);
            }
        }
    }
}
