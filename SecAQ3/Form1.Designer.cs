namespace Q3ProgrammingLanguagesApp
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
            lstLanguages = new ListBox();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(235, 40);
            label1.Name = "label1";
            label1.Size = new Size(307, 28);
            label1.TabIndex = 0;
            label1.Text = "My Favourite coding languages";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(220, 104);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(333, 144);
            lstLanguages.TabIndex = 1;
            // 
            // txtLanguage
            // 
            txtLanguage.ForeColor = SystemColors.WindowFrame;
            txtLanguage.Location = new Point(220, 273);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(333, 27);
            txtLanguage.TabIndex = 2;
            txtLanguage.Text = "Enter programming language";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Highlight;
            btnAdd.Location = new Point(220, 332);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(423, 332);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(130, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(350, 383);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtLanguage);
            Controls.Add(lstLanguages);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstLanguages;
        private TextBox txtLanguage;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblStatus;
    }
}
