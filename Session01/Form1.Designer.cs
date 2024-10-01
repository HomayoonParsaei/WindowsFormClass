namespace Session01
{
    partial class FormSignin
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
            buttonLogin = new Button();
            labelUserName = new Label();
            textBoxUserName = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(12, 88);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(240, 36);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(12, 9);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(60, 15);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "Username";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(92, 6);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(160, 23);
            textBoxUserName.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(12, 50);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(92, 47);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(160, 23);
            textBoxPassword.TabIndex = 4;
            // 
            // FormSignin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 136);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(labelUserName);
            Controls.Add(buttonLogin);
            Name = "FormSignin";
            Text = "Signin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label labelUserName;
        private TextBox textBoxUserName;
        private Label labelPassword;
        private TextBox textBoxPassword;
    }
}
