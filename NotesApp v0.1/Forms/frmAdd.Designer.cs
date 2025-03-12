namespace NotesApp_v0._1.frmMenus
{
    partial class frmAdd
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
            txtAdd_Name = new TextBox();
            txtAdd_Number = new TextBox();
            btnAdd_Confirm = new Button();
            label1 = new Label();
            label2 = new Label();
            checkBox_Favorite = new CheckBox();
            label3 = new Label();
            comboBox_Relationship = new ComboBox();
            label4 = new Label();
            input_Age = new MaskedTextBox();
            txtAdd_Lastname = new TextBox();
            label5 = new Label();
            txtAdd_Country = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtAdd_State = new TextBox();
            txtAdd_Street = new TextBox();
            label8 = new Label();
            txtLargeAdd_Commentary = new RichTextBox();
            label9 = new Label();
            comboBox_Gender = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            txtAdd_City = new TextBox();
            label12 = new Label();
            txtAdd_ZipCode = new TextBox();
            SuspendLayout();
            // 
            // txtAdd_Name
            // 
            txtAdd_Name.Location = new Point(12, 50);
            txtAdd_Name.MaxLength = 30;
            txtAdd_Name.Name = "txtAdd_Name";
            txtAdd_Name.Size = new Size(193, 27);
            txtAdd_Name.TabIndex = 0;
            // 
            // txtAdd_Number
            // 
            txtAdd_Number.Location = new Point(12, 103);
            txtAdd_Number.Name = "txtAdd_Number";
            txtAdd_Number.Size = new Size(193, 27);
            txtAdd_Number.TabIndex = 1;
            // 
            // btnAdd_Confirm
            // 
            btnAdd_Confirm.Location = new Point(12, 400);
            btnAdd_Confirm.Name = "btnAdd_Confirm";
            btnAdd_Confirm.Size = new Size(193, 29);
            btnAdd_Confirm.TabIndex = 2;
            btnAdd_Confirm.Text = "Confirm";
            btnAdd_Confirm.UseVisualStyleBackColor = true;
            btnAdd_Confirm.Click += btnAdd_Confirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Number Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 27);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // checkBox_Favorite
            // 
            checkBox_Favorite.AutoSize = true;
            checkBox_Favorite.Location = new Point(175, 349);
            checkBox_Favorite.Name = "checkBox_Favorite";
            checkBox_Favorite.Size = new Size(87, 24);
            checkBox_Favorite.TabIndex = 5;
            checkBox_Favorite.Text = " Favorite";
            checkBox_Favorite.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 7;
            label3.Text = "Age";
            // 
            // comboBox_Relationship
            // 
            comboBox_Relationship.FormattingEnabled = true;
            comboBox_Relationship.Items.AddRange(new object[] { "", "Acquaintance", "Friend", "Fellow", "Familiar", "Stranger" });
            comboBox_Relationship.Location = new Point(54, 155);
            comboBox_Relationship.Name = "comboBox_Relationship";
            comboBox_Relationship.Size = new Size(151, 28);
            comboBox_Relationship.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 134);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 9;
            label4.Text = "Relationship";
            // 
            // input_Age
            // 
            input_Age.Location = new Point(12, 155);
            input_Age.Mask = "000";
            input_Age.Name = "input_Age";
            input_Age.Size = new Size(36, 27);
            input_Age.TabIndex = 10;
            input_Age.ValidatingType = typeof(int);
            // 
            // txtAdd_Lastname
            // 
            txtAdd_Lastname.Location = new Point(211, 50);
            txtAdd_Lastname.MaxLength = 50;
            txtAdd_Lastname.Name = "txtAdd_Lastname";
            txtAdd_Lastname.Size = new Size(143, 27);
            txtAdd_Lastname.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 27);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 12;
            label5.Text = "Lastname";
            // 
            // txtAdd_Country
            // 
            txtAdd_Country.Location = new Point(211, 155);
            txtAdd_Country.MaxLength = 50;
            txtAdd_Country.Name = "txtAdd_Country";
            txtAdd_Country.Size = new Size(143, 27);
            txtAdd_Country.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 134);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 14;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(175, 240);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 15;
            label7.Text = "Street";
            // 
            // txtAdd_State
            // 
            txtAdd_State.Location = new Point(175, 210);
            txtAdd_State.MaxLength = 2;
            txtAdd_State.Name = "txtAdd_State";
            txtAdd_State.Size = new Size(30, 27);
            txtAdd_State.TabIndex = 16;
            // 
            // txtAdd_Street
            // 
            txtAdd_Street.Location = new Point(175, 263);
            txtAdd_Street.MaxLength = 50;
            txtAdd_Street.Name = "txtAdd_Street";
            txtAdd_Street.Size = new Size(179, 27);
            txtAdd_Street.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 187);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 18;
            label8.Text = "State";
            // 
            // txtLargeAdd_Commentary
            // 
            txtLargeAdd_Commentary.Location = new Point(12, 210);
            txtLargeAdd_Commentary.MaxLength = 200;
            txtLargeAdd_Commentary.Name = "txtLargeAdd_Commentary";
            txtLargeAdd_Commentary.Size = new Size(157, 160);
            txtLargeAdd_Commentary.TabIndex = 20;
            txtLargeAdd_Commentary.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 187);
            label9.Name = "label9";
            label9.Size = new Size(94, 20);
            label9.TabIndex = 21;
            label9.Text = "Commentary";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "", "Male", "Female", "Other", "Prefer not to say" });
            comboBox_Gender.Location = new Point(211, 103);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(143, 28);
            comboBox_Gender.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(211, 80);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 23;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(211, 187);
            label11.Name = "label11";
            label11.Size = new Size(34, 20);
            label11.TabIndex = 24;
            label11.Text = "City";
            // 
            // txtAdd_City
            // 
            txtAdd_City.Location = new Point(211, 210);
            txtAdd_City.MaxLength = 100;
            txtAdd_City.Name = "txtAdd_City";
            txtAdd_City.Size = new Size(143, 27);
            txtAdd_City.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(175, 293);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 26;
            label12.Text = "ZipCode";
            // 
            // txtAdd_ZipCode
            // 
            txtAdd_ZipCode.Location = new Point(175, 316);
            txtAdd_ZipCode.Name = "txtAdd_ZipCode";
            txtAdd_ZipCode.Size = new Size(121, 27);
            txtAdd_ZipCode.TabIndex = 27;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 441);
            Controls.Add(txtAdd_ZipCode);
            Controls.Add(label12);
            Controls.Add(txtAdd_City);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox_Gender);
            Controls.Add(label9);
            Controls.Add(txtLargeAdd_Commentary);
            Controls.Add(label8);
            Controls.Add(txtAdd_Street);
            Controls.Add(txtAdd_State);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAdd_Country);
            Controls.Add(label5);
            Controls.Add(txtAdd_Lastname);
            Controls.Add(input_Age);
            Controls.Add(label4);
            Controls.Add(comboBox_Relationship);
            Controls.Add(label3);
            Controls.Add(checkBox_Favorite);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd_Confirm);
            Controls.Add(txtAdd_Number);
            Controls.Add(txtAdd_Name);
            Name = "frmAdd";
            Text = "New Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdd_Name;
        private TextBox txtAdd_Number;
        private Button btnAdd_Confirm;
        private Label label1;
        private Label label2;
        private CheckBox checkBox_Favorite;
        private Label label3;
        private ComboBox comboBox_Relationship;
        private Label label4;
        private MaskedTextBox input_Age;
        private TextBox txtAdd_Lastname;
        private Label label5;
        private TextBox txtAdd_Country;
        private Label label6;
        private Label label7;
        private TextBox txtAdd_State;
        private TextBox txtAdd_Street;
        private Label label8;
        private RichTextBox txtLargeAdd_Commentary;
        private Label label9;
        private ComboBox comboBox_Gender;
        private Label label10;
        private Label label11;
        private TextBox txtAdd_City;
        private Label label12;
        private TextBox txtAdd_ZipCode;
    }
}