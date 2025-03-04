namespace NotesApp_v0._1
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            label1 = new Label();
            listNames = new ListBox();
            button_Add = new Button();
            button_Edit = new Button();
            button_Remove = new Button();
            txt_Search = new TextBox();
            icon_Search = new PictureBox();
            icon_filter = new PictureBox();
            panelFilter = new Panel();
            panelFilter_CloseButton = new PictureBox();
            panelFilter_comboBoxRelations = new ComboBox();
            panelFilter_txtAge = new TextBox();
            panelFilter_labelAge = new Label();
            panelFilter_labelRelationship = new Label();
            checkBox_FilterHaveNumber = new CheckBox();
            checkBox_FilterFavorite = new CheckBox();
            panelFilter_labelTitle = new Label();
            buttonConfirm_Filter = new Button();
            ((System.ComponentModel.ISupportInitialize)icon_Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_filter).BeginInit();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelFilter_CloseButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "You Contacts";
            // 
            // listNames
            // 
            listNames.FormattingEnabled = true;
            listNames.Location = new Point(12, 153);
            listNames.Name = "listNames";
            listNames.Size = new Size(156, 304);
            listNames.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(220, 153);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(220, 188);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(94, 29);
            button_Edit.TabIndex = 3;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(220, 224);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(94, 29);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "Remove";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(43, 120);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(125, 27);
            txt_Search.TabIndex = 7;
            txt_Search.Text = "Pesquisar";
            txt_Search.Enter += txt_Search_Enter;
            txt_Search.Leave += txt_Search_Leave;
            // 
            // icon_Search
            // 
            icon_Search.Image = (Image)resources.GetObject("icon_Search.Image");
            icon_Search.Location = new Point(12, 120);
            icon_Search.Name = "icon_Search";
            icon_Search.Size = new Size(25, 27);
            icon_Search.SizeMode = PictureBoxSizeMode.Zoom;
            icon_Search.TabIndex = 8;
            icon_Search.TabStop = false;
            icon_Search.Click += icon_Search_Click;
            // 
            // icon_filter
            // 
            icon_filter.Image = (Image)resources.GetObject("icon_filter.Image");
            icon_filter.Location = new Point(174, 120);
            icon_filter.Name = "icon_filter";
            icon_filter.Size = new Size(25, 27);
            icon_filter.SizeMode = PictureBoxSizeMode.Zoom;
            icon_filter.TabIndex = 9;
            icon_filter.TabStop = false;
            icon_filter.Click += icon_filter_Click;
            // 
            // panelFilter
            // 
            panelFilter.BackColor = SystemColors.Window;
            panelFilter.Controls.Add(panelFilter_CloseButton);
            panelFilter.Controls.Add(panelFilter_comboBoxRelations);
            panelFilter.Controls.Add(panelFilter_txtAge);
            panelFilter.Controls.Add(panelFilter_labelAge);
            panelFilter.Controls.Add(panelFilter_labelRelationship);
            panelFilter.Controls.Add(checkBox_FilterHaveNumber);
            panelFilter.Controls.Add(checkBox_FilterFavorite);
            panelFilter.Controls.Add(panelFilter_labelTitle);
            panelFilter.Controls.Add(buttonConfirm_Filter);
            panelFilter.Location = new Point(-3, 55);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(202, 402);
            panelFilter.TabIndex = 10;
            // 
            // panelFilter_CloseButton
            // 
            panelFilter_CloseButton.Image = (Image)resources.GetObject("panelFilter_CloseButton.Image");
            panelFilter_CloseButton.Location = new Point(174, 0);
            panelFilter_CloseButton.Name = "panelFilter_CloseButton";
            panelFilter_CloseButton.Size = new Size(26, 41);
            panelFilter_CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            panelFilter_CloseButton.TabIndex = 17;
            panelFilter_CloseButton.TabStop = false;
            panelFilter_CloseButton.Click += panelFilter_CloseButton_Click;
            // 
            // panelFilter_comboBoxRelations
            // 
            panelFilter_comboBoxRelations.FormattingEnabled = true;
            panelFilter_comboBoxRelations.Items.AddRange(new object[] { "Acquaintance", "Friend", "Fellow", "Familiar", "Stranger" });
            panelFilter_comboBoxRelations.Location = new Point(10, 133);
            panelFilter_comboBoxRelations.Name = "panelFilter_comboBoxRelations";
            panelFilter_comboBoxRelations.Size = new Size(151, 28);
            panelFilter_comboBoxRelations.TabIndex = 16;
            // 
            // panelFilter_txtAge
            // 
            panelFilter_txtAge.Location = new Point(10, 80);
            panelFilter_txtAge.Name = "panelFilter_txtAge";
            panelFilter_txtAge.Size = new Size(111, 27);
            panelFilter_txtAge.TabIndex = 15;
            // 
            // panelFilter_labelAge
            // 
            panelFilter_labelAge.AutoSize = true;
            panelFilter_labelAge.Location = new Point(10, 57);
            panelFilter_labelAge.Name = "panelFilter_labelAge";
            panelFilter_labelAge.Size = new Size(36, 20);
            panelFilter_labelAge.TabIndex = 13;
            panelFilter_labelAge.Text = "Age";
            // 
            // panelFilter_labelRelationship
            // 
            panelFilter_labelRelationship.AutoSize = true;
            panelFilter_labelRelationship.Location = new Point(10, 110);
            panelFilter_labelRelationship.Name = "panelFilter_labelRelationship";
            panelFilter_labelRelationship.Size = new Size(91, 20);
            panelFilter_labelRelationship.TabIndex = 12;
            panelFilter_labelRelationship.Text = "Relationship";
            // 
            // checkBox_FilterHaveNumber
            // 
            checkBox_FilterHaveNumber.AutoSize = true;
            checkBox_FilterHaveNumber.Location = new Point(10, 199);
            checkBox_FilterHaveNumber.Name = "checkBox_FilterHaveNumber";
            checkBox_FilterHaveNumber.Size = new Size(178, 24);
            checkBox_FilterHaveNumber.TabIndex = 11;
            checkBox_FilterHaveNumber.Text = "Have a number phone";
            checkBox_FilterHaveNumber.UseVisualStyleBackColor = true;
            // 
            // checkBox_FilterFavorite
            // 
            checkBox_FilterFavorite.AutoSize = true;
            checkBox_FilterFavorite.Location = new Point(10, 169);
            checkBox_FilterFavorite.Name = "checkBox_FilterFavorite";
            checkBox_FilterFavorite.Size = new Size(89, 24);
            checkBox_FilterFavorite.TabIndex = 3;
            checkBox_FilterFavorite.Text = "Favorites";
            checkBox_FilterFavorite.UseVisualStyleBackColor = true;
            // 
            // panelFilter_labelTitle
            // 
            panelFilter_labelTitle.AutoSize = true;
            panelFilter_labelTitle.Font = new Font("Segoe UI", 18F);
            panelFilter_labelTitle.Location = new Point(48, 0);
            panelFilter_labelTitle.Name = "panelFilter_labelTitle";
            panelFilter_labelTitle.Size = new Size(83, 41);
            panelFilter_labelTitle.TabIndex = 1;
            panelFilter_labelTitle.Text = "Filter";
            // 
            // buttonConfirm_Filter
            // 
            buttonConfirm_Filter.Location = new Point(48, 356);
            buttonConfirm_Filter.Name = "buttonConfirm_Filter";
            buttonConfirm_Filter.Size = new Size(94, 29);
            buttonConfirm_Filter.TabIndex = 0;
            buttonConfirm_Filter.Text = "Confirm";
            buttonConfirm_Filter.TextImageRelation = TextImageRelation.ImageAboveText;
            buttonConfirm_Filter.UseVisualStyleBackColor = true;
            buttonConfirm_Filter.Click += buttonConfirm_Filter_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 479);
            Controls.Add(panelFilter);
            Controls.Add(icon_filter);
            Controls.Add(icon_Search);
            Controls.Add(txt_Search);
            Controls.Add(button_Remove);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(listNames);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "SimpCon";
            ((System.ComponentModel.ISupportInitialize)icon_Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_filter).EndInit();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelFilter_CloseButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listNames;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Remove;
        private TextBox txt_Search;
        private PictureBox icon_Search;
        private PictureBox icon_filter;
        public Panel panelFilter;
        protected Button buttonConfirm_Filter;
        protected Label panelFilter_labelTitle;
        protected CheckBox checkBox_FilterHaveNumber;
        protected CheckBox checkBox_FilterFavorite;
        protected Label panelFilter_labelAge;
        protected Label panelFilter_labelRelationship;
        protected TextBox panelFilter_txtAge;
        protected ComboBox panelFilter_comboBoxRelations;
        protected PictureBox panelFilter_CloseButton;
    }
}
