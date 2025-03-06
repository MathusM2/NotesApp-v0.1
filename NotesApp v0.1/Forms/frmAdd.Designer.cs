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
            SuspendLayout();
            // 
            // txtAdd_Name
            // 
            txtAdd_Name.Location = new Point(12, 50);
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
            btnAdd_Confirm.Location = new Point(12, 286);
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
            checkBox_Favorite.Location = new Point(12, 189);
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
            label4.Location = new Point(54, 133);
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
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 327);
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
    }
}