namespace NotesApp_v0._1.frmMenus
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            labelDataName = new Label();
            labelDataNumber = new Label();
            txtPhoneEdit = new TextBox();
            txtNameEdit = new TextBox();
            button_Confirm = new Button();
            checkBox_FavoriteEdited = new CheckBox();
            label3 = new Label();
            labelDataAge = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxRelationshipEdit = new ComboBox();
            inputAgeEdit = new MaskedTextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelDataRelationship = new Label();
            comboBoxGenderEdit = new ComboBox();
            txtLastnameEdit = new TextBox();
            label9 = new Label();
            label10 = new Label();
            txtCountryEdit = new TextBox();
            txtStreetEdit = new TextBox();
            txtStateEdit = new TextBox();
            label16 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtLargeCommentaryEdit = new RichTextBox();
            label14 = new Label();
            label15 = new Label();
            labelDataGender = new Label();
            label17 = new Label();
            label18 = new Label();
            labelDataCountry = new Label();
            label20 = new Label();
            labelDataState = new Label();
            labelStreet = new Label();
            labelDataStreet = new Label();
            label24 = new Label();
            label11 = new Label();
            txtCityEdit = new TextBox();
            label19 = new Label();
            txtZipCodeEdit = new TextBox();
            label21 = new Label();
            label25 = new Label();
            label22 = new Label();
            labelDataCity = new Label();
            labelDataZipCode = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(431, 62);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(431, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "N.Phone:";
            // 
            // labelDataName
            // 
            labelDataName.AutoSize = true;
            labelDataName.Location = new Point(504, 62);
            labelDataName.Name = "labelDataName";
            labelDataName.Size = new Size(18, 20);
            labelDataName.TabIndex = 2;
            labelDataName.Text = "...";
            // 
            // labelDataNumber
            // 
            labelDataNumber.AutoSize = true;
            labelDataNumber.Location = new Point(504, 88);
            labelDataNumber.Name = "labelDataNumber";
            labelDataNumber.Size = new Size(18, 20);
            labelDataNumber.TabIndex = 3;
            labelDataNumber.Text = "...";
            // 
            // txtPhoneEdit
            // 
            txtPhoneEdit.Location = new Point(15, 128);
            txtPhoneEdit.Name = "txtPhoneEdit";
            txtPhoneEdit.Size = new Size(193, 27);
            txtPhoneEdit.TabIndex = 4;
            // 
            // txtNameEdit
            // 
            txtNameEdit.Location = new Point(15, 75);
            txtNameEdit.MaxLength = 30;
            txtNameEdit.Name = "txtNameEdit";
            txtNameEdit.Size = new Size(193, 27);
            txtNameEdit.TabIndex = 5;
            txtNameEdit.Leave += txtNameEdit_Leave;
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(12, 409);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(125, 29);
            button_Confirm.TabIndex = 6;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // checkBox_FavoriteEdited
            // 
            checkBox_FavoriteEdited.AutoSize = true;
            checkBox_FavoriteEdited.Location = new Point(175, 371);
            checkBox_FavoriteEdited.Name = "checkBox_FavoriteEdited";
            checkBox_FavoriteEdited.Size = new Size(83, 24);
            checkBox_FavoriteEdited.TabIndex = 7;
            checkBox_FavoriteEdited.Text = "Favorite";
            checkBox_FavoriteEdited.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(431, 159);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 8;
            label3.Text = "Age:";
            // 
            // labelDataAge
            // 
            labelDataAge.AutoSize = true;
            labelDataAge.Location = new Point(504, 159);
            labelDataAge.Name = "labelDataAge";
            labelDataAge.Size = new Size(18, 20);
            labelDataAge.TabIndex = 9;
            labelDataAge.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 105);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "Number Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 52);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // comboBoxRelationshipEdit
            // 
            comboBoxRelationshipEdit.FormattingEnabled = true;
            comboBoxRelationshipEdit.Items.AddRange(new object[] { "", "Acquaintance", "Friend", "Fellow", "Familiar", "Stranger" });
            comboBoxRelationshipEdit.Location = new Point(57, 181);
            comboBoxRelationshipEdit.Name = "comboBoxRelationshipEdit";
            comboBoxRelationshipEdit.Size = new Size(151, 28);
            comboBoxRelationshipEdit.TabIndex = 12;
            // 
            // inputAgeEdit
            // 
            inputAgeEdit.Location = new Point(15, 181);
            inputAgeEdit.Mask = "000";
            inputAgeEdit.Name = "inputAgeEdit";
            inputAgeEdit.Size = new Size(36, 27);
            inputAgeEdit.TabIndex = 13;
            inputAgeEdit.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 158);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 14;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 158);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 15;
            label7.Text = "Relationship";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(431, 135);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 16;
            label8.Text = "Relation:";
            // 
            // labelDataRelationship
            // 
            labelDataRelationship.AutoSize = true;
            labelDataRelationship.Location = new Point(504, 135);
            labelDataRelationship.Name = "labelDataRelationship";
            labelDataRelationship.Size = new Size(18, 20);
            labelDataRelationship.TabIndex = 17;
            labelDataRelationship.Text = "...";
            // 
            // comboBoxGenderEdit
            // 
            comboBoxGenderEdit.FormattingEnabled = true;
            comboBoxGenderEdit.Items.AddRange(new object[] { "", "Male", "Female", "Other", "Prefer not to say" });
            comboBoxGenderEdit.Location = new Point(214, 128);
            comboBoxGenderEdit.Name = "comboBoxGenderEdit";
            comboBoxGenderEdit.Size = new Size(143, 28);
            comboBoxGenderEdit.TabIndex = 18;
            // 
            // txtLastnameEdit
            // 
            txtLastnameEdit.Location = new Point(214, 75);
            txtLastnameEdit.MaxLength = 50;
            txtLastnameEdit.Name = "txtLastnameEdit";
            txtLastnameEdit.Size = new Size(143, 27);
            txtLastnameEdit.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(214, 105);
            label9.Name = "label9";
            label9.Size = new Size(57, 20);
            label9.TabIndex = 20;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(214, 52);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 21;
            label10.Text = "Lastname";
            // 
            // txtCountryEdit
            // 
            txtCountryEdit.Location = new Point(214, 182);
            txtCountryEdit.MaxLength = 50;
            txtCountryEdit.Name = "txtCountryEdit";
            txtCountryEdit.Size = new Size(143, 27);
            txtCountryEdit.TabIndex = 22;
            // 
            // txtStreetEdit
            // 
            txtStreetEdit.Location = new Point(175, 288);
            txtStreetEdit.MaxLength = 50;
            txtStreetEdit.Name = "txtStreetEdit";
            txtStreetEdit.Size = new Size(182, 27);
            txtStreetEdit.TabIndex = 23;
            // 
            // txtStateEdit
            // 
            txtStateEdit.Location = new Point(175, 235);
            txtStateEdit.MaxLength = 2;
            txtStateEdit.Name = "txtStateEdit";
            txtStateEdit.Size = new Size(30, 27);
            txtStateEdit.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(175, 265);
            label16.Name = "label16";
            label16.Size = new Size(48, 20);
            label16.TabIndex = 25;
            label16.Text = "Street";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(214, 159);
            label12.Name = "label12";
            label12.Size = new Size(60, 20);
            label12.TabIndex = 26;
            label12.Text = "Country";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(165, 212);
            label13.Name = "label13";
            label13.Size = new Size(43, 20);
            label13.TabIndex = 27;
            label13.Text = "State";
            // 
            // txtLargeCommentaryEdit
            // 
            txtLargeCommentaryEdit.Location = new Point(12, 235);
            txtLargeCommentaryEdit.Name = "txtLargeCommentaryEdit";
            txtLargeCommentaryEdit.Size = new Size(157, 160);
            txtLargeCommentaryEdit.TabIndex = 28;
            txtLargeCommentaryEdit.Text = "";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 212);
            label14.Name = "label14";
            label14.Size = new Size(94, 20);
            label14.TabIndex = 29;
            label14.Text = "Commentary";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(12, 9);
            label15.Name = "label15";
            label15.Size = new Size(68, 41);
            label15.TabIndex = 30;
            label15.Text = "Edit";
            // 
            // labelDataGender
            // 
            labelDataGender.AutoSize = true;
            labelDataGender.Location = new Point(504, 115);
            labelDataGender.Name = "labelDataGender";
            labelDataGender.Size = new Size(18, 20);
            labelDataGender.TabIndex = 31;
            labelDataGender.Text = "...";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(431, 115);
            label17.Name = "label17";
            label17.Size = new Size(60, 20);
            label17.TabIndex = 32;
            label17.Text = "Gender:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(431, 245);
            label18.Name = "label18";
            label18.Size = new Size(63, 20);
            label18.TabIndex = 33;
            label18.Text = "Country:";
            // 
            // labelDataCountry
            // 
            labelDataCountry.AutoSize = true;
            labelDataCountry.Location = new Point(506, 245);
            labelDataCountry.Name = "labelDataCountry";
            labelDataCountry.Size = new Size(18, 20);
            labelDataCountry.TabIndex = 34;
            labelDataCountry.Text = "...";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(431, 308);
            label20.Name = "label20";
            label20.Size = new Size(46, 20);
            label20.TabIndex = 35;
            label20.Text = "State:";
            // 
            // labelDataState
            // 
            labelDataState.AutoSize = true;
            labelDataState.Location = new Point(506, 308);
            labelDataState.Name = "labelDataState";
            labelDataState.Size = new Size(18, 20);
            labelDataState.TabIndex = 36;
            labelDataState.Text = "...";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(431, 288);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(51, 20);
            labelStreet.TabIndex = 37;
            labelStreet.Text = "Street:";
            // 
            // labelDataStreet
            // 
            labelDataStreet.AutoSize = true;
            labelDataStreet.Location = new Point(506, 285);
            labelDataStreet.Name = "labelDataStreet";
            labelDataStreet.Size = new Size(18, 20);
            labelDataStreet.TabIndex = 38;
            labelDataStreet.Text = "...";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 18F);
            label24.Location = new Point(431, 9);
            label24.Name = "label24";
            label24.Size = new Size(82, 41);
            label24.TabIndex = 39;
            label24.Text = "View";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(214, 212);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 40;
            label11.Text = "City";
            // 
            // txtCityEdit
            // 
            txtCityEdit.Location = new Point(214, 235);
            txtCityEdit.MaxLength = 100;
            txtCityEdit.Name = "txtCityEdit";
            txtCityEdit.Size = new Size(143, 27);
            txtCityEdit.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(175, 318);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 42;
            label19.Text = "ZipCode";
            // 
            // txtZipCodeEdit
            // 
            txtZipCodeEdit.Location = new Point(175, 341);
            txtZipCodeEdit.Name = "txtZipCodeEdit";
            txtZipCodeEdit.Size = new Size(121, 27);
            txtZipCodeEdit.TabIndex = 43;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14F);
            label21.Location = new Point(431, 200);
            label21.Name = "label21";
            label21.Size = new Size(84, 32);
            label21.TabIndex = 44;
            label21.Text = "Adress";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(431, 265);
            label25.Name = "label25";
            label25.Size = new Size(37, 20);
            label25.TabIndex = 45;
            label25.Text = "City:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(431, 328);
            label22.Name = "label22";
            label22.Size = new Size(69, 20);
            label22.TabIndex = 46;
            label22.Text = "ZipCode:";
            // 
            // labelDataCity
            // 
            labelDataCity.AutoSize = true;
            labelDataCity.Location = new Point(506, 265);
            labelDataCity.Name = "labelDataCity";
            labelDataCity.Size = new Size(18, 20);
            labelDataCity.TabIndex = 47;
            labelDataCity.Text = "...";
            // 
            // labelDataZipCode
            // 
            labelDataZipCode.AutoSize = true;
            labelDataZipCode.Location = new Point(506, 328);
            labelDataZipCode.Name = "labelDataZipCode";
            labelDataZipCode.Size = new Size(18, 20);
            labelDataZipCode.TabIndex = 48;
            labelDataZipCode.Text = "...";
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 447);
            Controls.Add(labelDataZipCode);
            Controls.Add(labelDataCity);
            Controls.Add(label22);
            Controls.Add(label25);
            Controls.Add(label21);
            Controls.Add(txtZipCodeEdit);
            Controls.Add(label19);
            Controls.Add(txtCityEdit);
            Controls.Add(label11);
            Controls.Add(label24);
            Controls.Add(labelDataStreet);
            Controls.Add(labelStreet);
            Controls.Add(labelDataState);
            Controls.Add(label20);
            Controls.Add(labelDataCountry);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(labelDataGender);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtLargeCommentaryEdit);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label16);
            Controls.Add(txtStateEdit);
            Controls.Add(txtStreetEdit);
            Controls.Add(txtCountryEdit);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtLastnameEdit);
            Controls.Add(comboBoxGenderEdit);
            Controls.Add(labelDataRelationship);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(inputAgeEdit);
            Controls.Add(comboBoxRelationshipEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelDataAge);
            Controls.Add(label3);
            Controls.Add(checkBox_FavoriteEdited);
            Controls.Add(button_Confirm);
            Controls.Add(txtNameEdit);
            Controls.Add(txtPhoneEdit);
            Controls.Add(labelDataNumber);
            Controls.Add(labelDataName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEdit";
            Text = "Edit Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelDataName;
        private Label labelDataNumber;
        private TextBox txtPhoneEdit;
        private TextBox txtNameEdit;
        private Button button_Confirm;
        private CheckBox checkBox_FavoriteEdited;
        private Label label3;
        private Label labelDataAge;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxRelationshipEdit;
        private MaskedTextBox inputAgeEdit;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelDataRelationship;
        private ComboBox comboBoxGenderEdit;
        private TextBox txtLastnameEdit;
        private Label label9;
        private Label label10;
        private TextBox txtCountryEdit;
        private TextBox txtStreetEdit;
        private TextBox txtStateEdit;
        private Label label16;
        private Label label12;
        private Label label13;
        private RichTextBox txtLargeCommentaryEdit;
        private Label label14;
        private Label label15;
        private Label labelDataGender;
        private Label label17;
        private Label label18;
        private Label labelDataCountry;
        private Label label20;
        private Label labelDataState;
        private Label labelStreet;
        private Label labelDataStreet;
        private Label label24;
        private Label label11;
        private TextBox txtCityEdit;
        private Label label19;
        private TextBox txtZipCodeEdit;
        private Label label21;
        private Label label25;
        private Label label22;
        private Label labelDataCity;
        private Label labelDataZipCode;
    }
}