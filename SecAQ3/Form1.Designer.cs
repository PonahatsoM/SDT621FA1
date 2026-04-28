namespace SecAQ3
{
    partial class Form1
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
            btnAdd = new Button();
            btnRemove = new Button();
            listBoxLanguages = new ListBox();
            txtLanguage = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 53);
            label1.Name = "label1";
            label1.Size = new Size(370, 28);
            label1.TabIndex = 0;
            label1.Text = "My Favourite Programming Language";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Location = new Point(198, 325);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(458, 325);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(126, 29);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // listBoxLanguages
            // 
            listBoxLanguages.FormattingEnabled = true;
            listBoxLanguages.Location = new Point(198, 106);
            listBoxLanguages.Name = "listBoxLanguages";
            listBoxLanguages.Size = new Size(386, 124);
            listBoxLanguages.TabIndex = 3;
            listBoxLanguages.SelectedIndexChanged += listBoxLanguages_SelectedIndexChanged;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(198, 264);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(386, 27);
            txtLanguage.TabIndex = 4;
            txtLanguage.Text = "Enter Programming Language";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLanguage);
            Controls.Add(listBoxLanguages);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox listBoxLanguages;
        private TextBox txtLanguage;
    }
}
