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
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "N.Phone:";
            // 
            // labelDataName
            // 
            labelDataName.AutoSize = true;
            labelDataName.Location = new Point(88, 9);
            labelDataName.Name = "labelDataName";
            labelDataName.Size = new Size(18, 20);
            labelDataName.TabIndex = 2;
            labelDataName.Text = "...";
            // 
            // labelDataNumber
            // 
            labelDataNumber.AutoSize = true;
            labelDataNumber.Location = new Point(88, 40);
            labelDataNumber.Name = "labelDataNumber";
            labelDataNumber.Size = new Size(18, 20);
            labelDataNumber.TabIndex = 3;
            labelDataNumber.Text = "...";
            // 
            // txtPhoneEdit
            // 
            txtPhoneEdit.Location = new Point(12, 155);
            txtPhoneEdit.Name = "txtPhoneEdit";
            txtPhoneEdit.Size = new Size(125, 27);
            txtPhoneEdit.TabIndex = 4;
            txtPhoneEdit.Leave += txtPhoneEdit_Leave;
            // 
            // txtNameEdit
            // 
            txtNameEdit.Location = new Point(12, 107);
            txtNameEdit.Name = "txtNameEdit";
            txtNameEdit.Size = new Size(125, 27);
            txtNameEdit.TabIndex = 5;
            txtNameEdit.Leave += txtNameEdit_Leave;
            // 
            // button_Confirm
            // 
            button_Confirm.Location = new Point(12, 208);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(125, 29);
            button_Confirm.TabIndex = 6;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = true;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 77);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Favorite";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 249);
            Controls.Add(checkBox1);
            Controls.Add(button_Confirm);
            Controls.Add(txtNameEdit);
            Controls.Add(txtPhoneEdit);
            Controls.Add(labelDataNumber);
            Controls.Add(labelDataName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEdit";
            Text = "frmEdit";
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
        private CheckBox checkBox1;
    }
}