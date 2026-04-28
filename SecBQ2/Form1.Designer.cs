namespace HomeAffairsDigitalIdentityProcessor_
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
            lblName = new Label();
            lblID = new Label();
            lblCitizenship = new Label();
            lblResults = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            comboCitizenship = new TextBox();
            txtResults = new MaskedTextBox();
            comboCitizenship1 = new ComboBox();
            btnValidate = new Button();
            btnGenerate = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(448, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(79, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Full Name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(448, 132);
            lblID.Name = "lblID";
            lblID.Size = new Size(85, 20);
            lblID.TabIndex = 1;
            lblID.Text = "ID Number:";
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Location = new Point(448, 197);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(84, 20);
            lblCitizenship.TabIndex = 2;
            lblCitizenship.Text = "Citizenship:";
            lblCitizenship.Click += label3_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(448, 258);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(93, 20);
            lblResults.TabIndex = 3;
            lblResults.Text = "Results Area:";
            // 
            // txtName
            // 
            txtName.Location = new Point(590, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(590, 132);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 5;
            // 
            // comboCitizenship
            // 
            comboCitizenship.Location = new Point(590, 197);
            comboCitizenship.Name = "comboCitizenship";
            comboCitizenship.Size = new Size(80, 27);
            comboCitizenship.TabIndex = 6;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(590, 258);
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(179, 27);
            txtResults.TabIndex = 7;
            // 
            // comboCitizenship1
            // 
            comboCitizenship1.FormattingEnabled = true;
            comboCitizenship1.Location = new Point(690, 197);
            comboCitizenship1.Name = "comboCitizenship1";
            comboCitizenship1.Size = new Size(79, 28);
            comboCitizenship1.TabIndex = 8;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(448, 334);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(76, 29);
            btnValidate.TabIndex = 9;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(590, 334);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(125, 29);
            btnGenerate.TabIndex = 10;
            btnGenerate.Text = "Generate Profile";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(376, 21);
            label1.Name = "label1";
            label1.Size = new Size(384, 28);
            label1.TabIndex = 11;
            label1.Text = "Home Affairs Digital Identity Processor";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Coat_of_Arms;
            pictureBox1.Location = new Point(46, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(btnValidate);
            Controls.Add(comboCitizenship1);
            Controls.Add(txtResults);
            Controls.Add(comboCitizenship);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblResults);
            Controls.Add(lblCitizenship);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblID;
        private Label lblCitizenship;
        private Label lblResults;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox comboCitizenship;
        private MaskedTextBox txtResults;
        private ComboBox comboCitizenship1;
        private Button btnValidate;
        private Button btnGenerate;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
