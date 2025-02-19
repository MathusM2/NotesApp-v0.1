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
            label1 = new Label();
            listNames = new ListBox();
            button_Add = new Button();
            button_Edit = new Button();
            button_Remove = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "You Notes";
            // 
            // listNames
            // 
            listNames.FormattingEnabled = true;
            listNames.Location = new Point(12, 58);
            listNames.Name = "listNames";
            listNames.Size = new Size(159, 144);
            listNames.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(312, 74);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(312, 125);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(94, 29);
            button_Edit.TabIndex = 3;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(312, 173);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(94, 29);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "Remove";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 226);
            Controls.Add(button_Remove);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(listNames);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Notes App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listNames;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Remove;
    }
}
