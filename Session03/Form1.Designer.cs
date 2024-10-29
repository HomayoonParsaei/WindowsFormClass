namespace CurrentProject
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
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            buttonLogin = new Button();
            labelFirstName = new Label();
            textBoxFirstName = new TextBox();
            labelLastName = new Label();
            textBoxLastName = new TextBox();
            labelDateOfBirth = new Label();
            labelNationalCode = new Label();
            textBoxNationalCode = new TextBox();
            dateTimePickerDateOFBirth = new DateTimePicker();
            buttonRegister = new Button();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            textBoxPhoneNumber = new TextBox();
            labelPhoneNUmber = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassword.Location = new Point(89, 53);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(160, 23);
            textBoxPassword.TabIndex = 9;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(9, 56);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUserName.Location = new Point(89, 12);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(160, 23);
            textBoxUserName.TabIndex = 7;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(9, 15);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(60, 15);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "Username";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(9, 94);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(240, 36);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // labelFirstName
            // 
            labelFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(316, 15);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(70, 15);
            labelFirstName.TabIndex = 6;
            labelFirstName.Text = "First Name :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFirstName.Location = new Point(409, 12);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(160, 23);
            textBoxFirstName.TabIndex = 7;
            // 
            // labelLastName
            // 
            labelLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(316, 54);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(69, 15);
            labelLastName.TabIndex = 8;
            labelLastName.Text = "Last Name :";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxLastName.Location = new Point(409, 51);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(160, 23);
            textBoxLastName.TabIndex = 9;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Location = new Point(316, 171);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(83, 15);
            labelDateOfBirth.TabIndex = 6;
            labelDateOfBirth.Text = "Data OF Birth :";
            // 
            // labelNationalCode
            // 
            labelNationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNationalCode.AutoSize = true;
            labelNationalCode.Location = new Point(316, 210);
            labelNationalCode.Name = "labelNationalCode";
            labelNationalCode.Size = new Size(89, 15);
            labelNationalCode.TabIndex = 8;
            labelNationalCode.Text = "National Code :";
            // 
            // textBoxNationalCode
            // 
            textBoxNationalCode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNationalCode.Location = new Point(409, 207);
            textBoxNationalCode.Name = "textBoxNationalCode";
            textBoxNationalCode.Size = new Size(160, 23);
            textBoxNationalCode.TabIndex = 9;
            // 
            // dateTimePickerDateOFBirth
            // 
            dateTimePickerDateOFBirth.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerDateOFBirth.Cursor = Cursors.Hand;
            dateTimePickerDateOFBirth.CustomFormat = "MMM'/'dd'/'yyyy";
            dateTimePickerDateOFBirth.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOFBirth.Location = new Point(409, 168);
            dateTimePickerDateOFBirth.Name = "dateTimePickerDateOFBirth";
            dateTimePickerDateOFBirth.Size = new Size(160, 23);
            dateTimePickerDateOFBirth.TabIndex = 10;
            dateTimePickerDateOFBirth.Value = new DateTime(2024, 10, 5, 0, 0, 0, 0);
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRegister.Location = new Point(316, 287);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(253, 32);
            buttonRegister.TabIndex = 11;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxFullName.Enabled = false;
            textBoxFullName.Location = new Point(409, 90);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(160, 23);
            textBoxFullName.TabIndex = 13;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(316, 93);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(67, 15);
            labelFullName.TabIndex = 12;
            labelFullName.Text = "Full Name :";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPhoneNumber.Location = new Point(409, 129);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(160, 23);
            textBoxPhoneNumber.TabIndex = 15;
            // 
            // labelPhoneNUmber
            // 
            labelPhoneNUmber.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelPhoneNUmber.AutoSize = true;
            labelPhoneNUmber.Location = new Point(316, 132);
            labelPhoneNUmber.Name = "labelPhoneNUmber";
            labelPhoneNUmber.Size = new Size(94, 15);
            labelPhoneNUmber.TabIndex = 14;
            labelPhoneNUmber.Text = "Phone Number :";
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGender.AutoSize = true;
            labelGender.Location = new Point(316, 248);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(51, 15);
            labelGender.TabIndex = 16;
            labelGender.Text = "Gender :";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(409, 245);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(160, 23);
            comboBoxGender.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 357);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(labelPhoneNUmber);
            Controls.Add(textBoxFullName);
            Controls.Add(labelFullName);
            Controls.Add(buttonRegister);
            Controls.Add(dateTimePickerDateOFBirth);
            Controls.Add(textBoxNationalCode);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxPassword);
            Controls.Add(labelNationalCode);
            Controls.Add(labelLastName);
            Controls.Add(labelPassword);
            Controls.Add(labelDateOfBirth);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxUserName);
            Controls.Add(labelUserName);
            Controls.Add(buttonLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private Button buttonLogin;
        private Label labelFirstName;
        private TextBox textBoxFirstName;
        private Label labelLastName;
        private TextBox textBoxLastName;
        private Label labelDateOfBirth;
        private Label labelNationalCode;
        private TextBox textBoxNationalCode;
        private DateTimePicker dateTimePickerDateOFBirth;
        private Button buttonRegister;
        private TextBox textBoxFullName;
        private Label labelFullName;
        private TextBox textBoxPhoneNumber;
        private Label labelPhoneNUmber;
        private TextBox textBox1;
        private Label labelGender;
        private ComboBox comboBoxGender;
    }
}
