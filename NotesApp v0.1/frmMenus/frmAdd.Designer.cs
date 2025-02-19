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
            SuspendLayout();
            // 
            // txtAdd_Name
            // 
            txtAdd_Name.Location = new Point(12, 29);
            txtAdd_Name.Name = "txtAdd_Name";
            txtAdd_Name.Size = new Size(189, 27);
            txtAdd_Name.TabIndex = 0;
            // 
            // txtAdd_Number
            // 
            txtAdd_Number.Location = new Point(12, 82);
            txtAdd_Number.Name = "txtAdd_Number";
            txtAdd_Number.Size = new Size(189, 27);
            txtAdd_Number.TabIndex = 1;
            // 
            // btnAdd_Confirm
            // 
            btnAdd_Confirm.Location = new Point(12, 127);
            btnAdd_Confirm.Name = "btnAdd_Confirm";
            btnAdd_Confirm.Size = new Size(222, 29);
            btnAdd_Confirm.TabIndex = 2;
            btnAdd_Confirm.Text = "Confirm";
            btnAdd_Confirm.UseVisualStyleBackColor = true;
            btnAdd_Confirm.Click += btnAdd_Confirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 3;
            label1.Text = "Number Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 6);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 168);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd_Confirm);
            Controls.Add(txtAdd_Number);
            Controls.Add(txtAdd_Name);
            Name = "frmAdd";
            Text = "New Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdd_Name;
        private TextBox txtAdd_Number;
        private Button btnAdd_Confirm;
        private Label label1;
        private Label label2;
    }
}