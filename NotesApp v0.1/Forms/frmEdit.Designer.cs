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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 35);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "N.Phone:";
            // 
            // labelDataName
            // 
            labelDataName.AutoSize = true;
            labelDataName.Location = new Point(315, 9);
            labelDataName.Name = "labelDataName";
            labelDataName.Size = new Size(18, 20);
            labelDataName.TabIndex = 2;
            labelDataName.Text = "...";
            // 
            // labelDataNumber
            // 
            labelDataNumber.AutoSize = true;
            labelDataNumber.Location = new Point(315, 32);
            labelDataNumber.Name = "labelDataNumber";
            labelDataNumber.Size = new Size(18, 20);
            labelDataNumber.TabIndex = 3;
            labelDataNumber.Text = "...";
            // 
            // txtPhoneEdit
            // 
            txtPhoneEdit.Location = new Point(12, 85);
            txtPhoneEdit.Name = "txtPhoneEdit";
            txtPhoneEdit.Size = new Size(190, 27);
            txtPhoneEdit.TabIndex = 4;
            // 
            // txtNameEdit
            // 
            txtNameEdit.Location = new Point(12, 32);
            txtNameEdit.Name = "txtNameEdit";
            txtNameEdit.Size = new Size(190, 27);
            txtNameEdit.TabIndex = 5;
            txtNameEdit.Leave += txtNameEdit_Leave;
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(9, 246);
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
            checkBox_FavoriteEdited.Location = new Point(12, 184);
            checkBox_FavoriteEdited.Name = "checkBox_FavoriteEdited";
            checkBox_FavoriteEdited.Size = new Size(83, 24);
            checkBox_FavoriteEdited.TabIndex = 7;
            checkBox_FavoriteEdited.Text = "Favorite";
            checkBox_FavoriteEdited.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 62);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // labelDataAge
            // 
            labelDataAge.AutoSize = true;
            labelDataAge.Location = new Point(315, 62);
            labelDataAge.Name = "labelDataAge";
            labelDataAge.Size = new Size(18, 20);
            labelDataAge.TabIndex = 9;
            labelDataAge.Text = "...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 10;
            label4.Text = "Number Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Name";
            // 
            // comboBoxRelationshipEdit
            // 
            comboBoxRelationshipEdit.FormattingEnabled = true;
            comboBoxRelationshipEdit.Items.AddRange(new object[] { "", "Acquaintance", "Friend", "Fellow", "Familiar", "Stranger" });
            comboBoxRelationshipEdit.Location = new Point(51, 138);
            comboBoxRelationshipEdit.Name = "comboBoxRelationshipEdit";
            comboBoxRelationshipEdit.Size = new Size(151, 28);
            comboBoxRelationshipEdit.TabIndex = 12;
            // 
            // inputAgeEdit
            // 
            inputAgeEdit.Location = new Point(9, 138);
            inputAgeEdit.Mask = "000";
            inputAgeEdit.Name = "inputAgeEdit";
            inputAgeEdit.Size = new Size(36, 27);
            inputAgeEdit.TabIndex = 13;
            inputAgeEdit.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 116);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 14;
            label6.Text = "Age";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 115);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 15;
            label7.Text = "Relationship";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 85);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 16;
            label8.Text = "Relation";
            // 
            // labelDataRelationship
            // 
            labelDataRelationship.AutoSize = true;
            labelDataRelationship.Location = new Point(315, 85);
            labelDataRelationship.Name = "labelDataRelationship";
            labelDataRelationship.Size = new Size(18, 20);
            labelDataRelationship.TabIndex = 17;
            labelDataRelationship.Text = "...";
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 289);
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
    }
}