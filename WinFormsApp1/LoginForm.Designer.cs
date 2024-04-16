namespace WinFormsApp1
{
    partial class LoginForm
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
            LoginBox = new TextBox();
            passBox = new TextBox();
            loginLabel = new Label();
            AuthoriseLabel = new Label();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.Cursor = Cursors.IBeam;
            LoginBox.Font = new Font("Segoe UI", 20F);
            LoginBox.ForeColor = Color.Gray;
            LoginBox.Location = new Point(117, 174);
            LoginBox.Multiline = true;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(257, 48);
            LoginBox.TabIndex = 0;
            LoginBox.Text = "Введите логин";
            LoginBox.Enter += LoginBox_Enter;
            LoginBox.Leave += LoginBox_Leave;
            // 
            // passBox
            // 
            passBox.Cursor = Cursors.IBeam;
            passBox.Font = new Font("Segoe UI", 22F);
            passBox.ForeColor = Color.Gray;
            passBox.Location = new Point(117, 269);
            passBox.Name = "passBox";
            passBox.Size = new Size(257, 47);
            passBox.TabIndex = 1;
            passBox.Text = "Введите пароль";
            passBox.Enter += passBox_Enter;
            passBox.Leave += passBox_Leave;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 20F);
            loginLabel.Location = new Point(153, 109);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(179, 37);
            loginLabel.TabIndex = 2;
            loginLabel.Text = "Авторизация";
            // 
            // AuthoriseLabel
            // 
            AuthoriseLabel.AutoSize = true;
            AuthoriseLabel.Cursor = Cursors.Hand;
            AuthoriseLabel.Location = new Point(192, 409);
            AuthoriseLabel.Name = "AuthoriseLabel";
            AuthoriseLabel.Size = new Size(107, 15);
            AuthoriseLabel.TabIndex = 3;
            AuthoriseLabel.Text = "Ещё нет аккаунта?";
            AuthoriseLabel.Click += AuthoriseLabel_Click;
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Location = new Point(182, 347);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(129, 38);
            LoginButton.TabIndex = 4;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(496, 450);
            Controls.Add(LoginButton);
            Controls.Add(AuthoriseLabel);
            Controls.Add(loginLabel);
            Controls.Add(passBox);
            Controls.Add(LoginBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox;
        private TextBox passBox;
        private Label loginLabel;
        private Label AuthoriseLabel;
        private Button LoginButton;
    }
}