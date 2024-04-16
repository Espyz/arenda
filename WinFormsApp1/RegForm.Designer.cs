namespace WinFormsApp1
{
    partial class RegForm
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
            AccauntLabel = new Label();
            loginLabel = new Label();
            PassBox = new TextBox();
            LoginBox = new TextBox();
            FioBox = new TextBox();
            PassportBox = new TextBox();
            PhoneBox = new TextBox();
            EmailBox = new TextBox();
            RegButton = new Button();
            SuspendLayout();
            // 
            // AccauntLabel
            // 
            AccauntLabel.AutoSize = true;
            AccauntLabel.Cursor = Cursors.Hand;
            AccauntLabel.Location = new Point(193, 409);
            AccauntLabel.Name = "AccauntLabel";
            AccauntLabel.Size = new Size(105, 15);
            AccauntLabel.TabIndex = 7;
            AccauntLabel.Text = "Уже есть аккаунт?";
            AccauntLabel.Click += AccauntLabel_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 20F);
            loginLabel.Location = new Point(161, 25);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(171, 37);
            loginLabel.TabIndex = 6;
            loginLabel.Text = "Регистрация";
            // 
            // PassBox
            // 
            PassBox.Cursor = Cursors.IBeam;
            PassBox.Font = new Font("Segoe UI", 18F);
            PassBox.ForeColor = Color.Gray;
            PassBox.Location = new Point(267, 274);
            PassBox.Name = "PassBox";
            PassBox.Size = new Size(217, 39);
            PassBox.TabIndex = 5;
            PassBox.Text = "Введите пароль";
            PassBox.Enter += PassBox_Enter;
            PassBox.Leave += PassBox_Leave;
            // 
            // LoginBox
            // 
            LoginBox.Cursor = Cursors.IBeam;
            LoginBox.Font = new Font("Segoe UI", 18F);
            LoginBox.ForeColor = Color.Gray;
            LoginBox.Location = new Point(12, 274);
            LoginBox.Multiline = true;
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(217, 39);
            LoginBox.TabIndex = 4;
            LoginBox.Text = "Введите логин";
            LoginBox.Enter += LoginBox_Enter;
            LoginBox.Leave += LoginBox_Leave;
            // 
            // FioBox
            // 
            FioBox.Cursor = Cursors.IBeam;
            FioBox.Font = new Font("Segoe UI", 18F);
            FioBox.ForeColor = Color.Gray;
            FioBox.Location = new Point(12, 189);
            FioBox.Multiline = true;
            FioBox.Name = "FioBox";
            FioBox.Size = new Size(217, 48);
            FioBox.TabIndex = 8;
            FioBox.Text = "Введите ФИО";
            FioBox.Enter += FioBox_Enter;
            FioBox.Leave += FioBox_Leave;
            // 
            // PassportBox
            // 
            PassportBox.Cursor = Cursors.IBeam;
            PassportBox.Font = new Font("Segoe UI", 18F);
            PassportBox.ForeColor = Color.Gray;
            PassportBox.Location = new Point(267, 189);
            PassportBox.Multiline = true;
            PassportBox.Name = "PassportBox";
            PassportBox.Size = new Size(217, 48);
            PassportBox.TabIndex = 9;
            PassportBox.Text = "Введите паспорт";
            PassportBox.Enter += PassportBox_Enter;
            PassportBox.Leave += PassportBox_Leave;
            // 
            // PhoneBox
            // 
            PhoneBox.Cursor = Cursors.IBeam;
            PhoneBox.Font = new Font("Segoe UI", 18F);
            PhoneBox.ForeColor = Color.Gray;
            PhoneBox.Location = new Point(12, 100);
            PhoneBox.Multiline = true;
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(217, 48);
            PhoneBox.TabIndex = 10;
            PhoneBox.Text = "Введите телефон";
            PhoneBox.Enter += PhoneBox_Enter;
            PhoneBox.Leave += PhoneBox_Leave;
            // 
            // EmailBox
            // 
            EmailBox.Cursor = Cursors.IBeam;
            EmailBox.Font = new Font("Segoe UI", 18F);
            EmailBox.ForeColor = Color.Gray;
            EmailBox.Location = new Point(267, 100);
            EmailBox.Multiline = true;
            EmailBox.Name = "EmailBox";
            EmailBox.Size = new Size(217, 48);
            EmailBox.TabIndex = 11;
            EmailBox.Text = "Введите почту";
            EmailBox.Enter += EmailBox_Enter;
            EmailBox.Leave += EmailBox_Leave;
            // 
            // RegButton
            // 
            RegButton.Location = new Point(161, 344);
            RegButton.Name = "RegButton";
            RegButton.Size = new Size(171, 42);
            RegButton.TabIndex = 12;
            RegButton.Text = "Зарегестрироваться";
            RegButton.UseVisualStyleBackColor = true;
            RegButton.Click += RegButton_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(496, 450);
            Controls.Add(RegButton);
            Controls.Add(EmailBox);
            Controls.Add(PhoneBox);
            Controls.Add(PassportBox);
            Controls.Add(FioBox);
            Controls.Add(AccauntLabel);
            Controls.Add(loginLabel);
            Controls.Add(PassBox);
            Controls.Add(LoginBox);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccauntLabel;
        private Label loginLabel;
        private TextBox PassBox;
        private TextBox LoginBox;
        private TextBox FioBox;
        private TextBox PassportBox;
        private TextBox PhoneBox;
        private TextBox EmailBox;
        private Button RegButton;
    }
}