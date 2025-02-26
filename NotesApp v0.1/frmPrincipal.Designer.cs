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
            filter_box = new ComboBox();
            txt_Search = new TextBox();
            icon_Search = new PictureBox();
            icon_filter = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)icon_Search).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_filter).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "You Notes";
            // 
            // listNames
            // 
            listNames.FormattingEnabled = true;
            listNames.Location = new Point(12, 92);
            listNames.Name = "listNames";
            listNames.Size = new Size(156, 164);
            listNames.TabIndex = 1;
            // 
            // button_Add
            // 
            button_Add.Location = new Point(350, 132);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 2;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Edit
            // 
            button_Edit.Location = new Point(350, 181);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(94, 29);
            button_Edit.TabIndex = 3;
            button_Edit.Text = "Edit";
            button_Edit.UseVisualStyleBackColor = true;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Remove
            // 
            button_Remove.Location = new Point(350, 227);
            button_Remove.Name = "button_Remove";
            button_Remove.Size = new Size(94, 29);
            button_Remove.TabIndex = 4;
            button_Remove.Text = "Remove";
            button_Remove.UseVisualStyleBackColor = true;
            button_Remove.Click += button_Remove_Click;
            // 
            // filter_box
            // 
            filter_box.FormattingEnabled = true;
            filter_box.Items.AddRange(new object[] { "Mais Recente", "Mais Antiga", "Ordem Alfabética (A-Z)", "Ordem Alfabética (Z-A)" });
            filter_box.Location = new Point(174, 58);
            filter_box.Name = "filter_box";
            filter_box.Size = new Size(87, 28);
            filter_box.TabIndex = 5;
            filter_box.Visible = false;
            filter_box.Leave += filter_box_Leave;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(43, 59);
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
            icon_Search.Location = new Point(12, 59);
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
            icon_filter.Location = new Point(174, 59);
            icon_filter.Name = "icon_filter";
            icon_filter.Size = new Size(25, 27);
            icon_filter.SizeMode = PictureBoxSizeMode.Zoom;
            icon_filter.TabIndex = 9;
            icon_filter.TabStop = false;
            icon_filter.Click += icon_filter_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 268);
            Controls.Add(icon_filter);
            Controls.Add(icon_Search);
            Controls.Add(txt_Search);
            Controls.Add(filter_box);
            Controls.Add(button_Remove);
            Controls.Add(button_Edit);
            Controls.Add(button_Add);
            Controls.Add(listNames);
            Controls.Add(label1);
            Name = "frmPrincipal";
            Text = "Notes App";
            ((System.ComponentModel.ISupportInitialize)icon_Search).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_filter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listNames;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Remove;
        private ComboBox filter_box;
        private TextBox txt_Search;
        private PictureBox icon_Search;
        private PictureBox icon_filter;
    }
}
