namespace NotesApp_v0._1.Forms.Dialogs
{
    partial class FilterForm
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
            comboBoxFilterRelations = new ComboBox();
            label3 = new Label();
            comboBoxFilterGender = new ComboBox();
            label4 = new Label();
            comboBoxFilterAge = new ComboBox();
            label5 = new Label();
            comboBoxFilterHNumber = new ComboBox();
            ConfirmButtonFilter = new Button();
            label6 = new Label();
            comboBoxFilterFavorite = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtFilterState = new TextBox();
            txtFilterCountry = new TextBox();
            label9 = new Label();
            txtFilterCity = new TextBox();
            label10 = new Label();
            txtFilterStreet = new TextBox();
            txtFilterZipCode = new TextBox();
            txtFilterNumber = new TextBox();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 41);
            label1.TabIndex = 0;
            label1.Text = "Filter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Relations";
            // 
            // comboBoxFilterRelations
            // 
            comboBoxFilterRelations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterRelations.FormattingEnabled = true;
            comboBoxFilterRelations.Items.AddRange(new object[] { "-Not Selected-", "Acquaintance", "Friend", "Fellow", "Familiar", "Stranger" });
            comboBoxFilterRelations.Location = new Point(12, 80);
            comboBoxFilterRelations.Name = "comboBoxFilterRelations";
            comboBoxFilterRelations.Size = new Size(151, 28);
            comboBoxFilterRelations.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 111);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // comboBoxFilterGender
            // 
            comboBoxFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterGender.FormattingEnabled = true;
            comboBoxFilterGender.Items.AddRange(new object[] { "-Not Selected-", "Male", "Female", "Other" });
            comboBoxFilterGender.Location = new Point(12, 134);
            comboBoxFilterGender.Name = "comboBoxFilterGender";
            comboBoxFilterGender.Size = new Size(101, 28);
            comboBoxFilterGender.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 5;
            label4.Text = "Age";
            // 
            // comboBoxFilterAge
            // 
            comboBoxFilterAge.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterAge.FormattingEnabled = true;
            comboBoxFilterAge.Items.AddRange(new object[] { "-Not Selected-", "Age not set", "Child (1 - 9)", "Teen (10 - 16)", "Young (17 - 21)", "Young Adult (22 - 40)", "Adult (40 - 65)", "Aged (66 - 120)", "Find..." });
            comboBoxFilterAge.Location = new Point(12, 188);
            comboBoxFilterAge.Name = "comboBoxFilterAge";
            comboBoxFilterAge.Size = new Size(101, 28);
            comboBoxFilterAge.TabIndex = 6;
            comboBoxFilterAge.SelectedIndexChanged += comboBoxFilterAge_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 219);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 9;
            label5.Text = "Has Phone";
            // 
            // comboBoxFilterHNumber
            // 
            comboBoxFilterHNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterHNumber.FormattingEnabled = true;
            comboBoxFilterHNumber.Items.AddRange(new object[] { "-Not Selected-", "Yes", "No" });
            comboBoxFilterHNumber.Location = new Point(93, 242);
            comboBoxFilterHNumber.Name = "comboBoxFilterHNumber";
            comboBoxFilterHNumber.Size = new Size(70, 28);
            comboBoxFilterHNumber.TabIndex = 10;
            // 
            // ConfirmButtonFilter
            // 
            ConfirmButtonFilter.Location = new Point(12, 529);
            ConfirmButtonFilter.Name = "ConfirmButtonFilter";
            ConfirmButtonFilter.Size = new Size(191, 29);
            ConfirmButtonFilter.TabIndex = 11;
            ConfirmButtonFilter.Text = "Confirm";
            ConfirmButtonFilter.UseVisualStyleBackColor = true;
            ConfirmButtonFilter.Click += ConfirmButtonFilter_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 219);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 12;
            label6.Text = "Favorite";
            // 
            // comboBoxFilterFavorite
            // 
            comboBoxFilterFavorite.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilterFavorite.FormattingEnabled = true;
            comboBoxFilterFavorite.Items.AddRange(new object[] { "-Not Selected-", "Favorites", "No Favorites" });
            comboBoxFilterFavorite.Location = new Point(12, 242);
            comboBoxFilterFavorite.Name = "comboBoxFilterFavorite";
            comboBoxFilterFavorite.Size = new Size(70, 28);
            comboBoxFilterFavorite.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 278);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 14;
            label7.Text = "Country";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 278);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 15;
            label8.Text = "State";
            // 
            // txtFilterState
            // 
            txtFilterState.Location = new Point(142, 301);
            txtFilterState.MaxLength = 2;
            txtFilterState.Name = "txtFilterState";
            txtFilterState.Size = new Size(61, 27);
            txtFilterState.TabIndex = 16;
            // 
            // txtFilterCountry
            // 
            txtFilterCountry.Location = new Point(12, 301);
            txtFilterCountry.MaxLength = 50;
            txtFilterCountry.Name = "txtFilterCountry";
            txtFilterCountry.Size = new Size(111, 27);
            txtFilterCountry.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 384);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 18;
            label9.Text = "Street";
            // 
            // txtFilterCity
            // 
            txtFilterCity.Location = new Point(12, 354);
            txtFilterCity.MaxLength = 100;
            txtFilterCity.Name = "txtFilterCity";
            txtFilterCity.Size = new Size(191, 27);
            txtFilterCity.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 331);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 20;
            label10.Text = "City";
            // 
            // txtFilterStreet
            // 
            txtFilterStreet.Location = new Point(12, 407);
            txtFilterStreet.MaxLength = 100;
            txtFilterStreet.Name = "txtFilterStreet";
            txtFilterStreet.Size = new Size(191, 27);
            txtFilterStreet.TabIndex = 21;
            // 
            // txtFilterZipCode
            // 
            txtFilterZipCode.Location = new Point(12, 469);
            txtFilterZipCode.Name = "txtFilterZipCode";
            txtFilterZipCode.Size = new Size(111, 27);
            txtFilterZipCode.TabIndex = 22;
            // 
            // txtFilterNumber
            // 
            txtFilterNumber.Location = new Point(142, 469);
            txtFilterNumber.Name = "txtFilterNumber";
            txtFilterNumber.Size = new Size(66, 27);
            txtFilterNumber.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 446);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 24;
            label11.Text = "ZipCode";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(142, 446);
            label12.Name = "label12";
            label12.Size = new Size(63, 20);
            label12.TabIndex = 25;
            label12.Text = "Number";
            // 
            // FilterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 570);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtFilterNumber);
            Controls.Add(txtFilterZipCode);
            Controls.Add(txtFilterStreet);
            Controls.Add(label10);
            Controls.Add(txtFilterCity);
            Controls.Add(label9);
            Controls.Add(txtFilterCountry);
            Controls.Add(txtFilterState);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxFilterFavorite);
            Controls.Add(label6);
            Controls.Add(ConfirmButtonFilter);
            Controls.Add(comboBoxFilterHNumber);
            Controls.Add(label5);
            Controls.Add(comboBoxFilterAge);
            Controls.Add(label4);
            Controls.Add(comboBoxFilterGender);
            Controls.Add(label3);
            Controls.Add(comboBoxFilterRelations);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FilterForm";
            Text = "List Filter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxFilterRelations;
        private Label label3;
        private ComboBox comboBoxFilterGender;
        private Label label4;
        private ComboBox comboBoxFilterAge;
        private Label label5;
        private ComboBox comboBoxFilterHNumber;
        private Button ConfirmButtonFilter;
        private Label label6;
        private ComboBox comboBoxFilterFavorite;
        private Label label7;
        private Label label8;
        private TextBox txtFilterState;
        private TextBox txtFilterCountry;
        private Label label9;
        private TextBox txtFilterCity;
        private Label label10;
        private TextBox txtFilterStreet;
        private TextBox txtFilterZipCode;
        private TextBox txtFilterNumber;
        private Label label11;
        private Label label12;
    }
}