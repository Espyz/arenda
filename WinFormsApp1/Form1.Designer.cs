namespace WinFormsApp1
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
            menuStrip1 = new MenuStrip();
            задание1ToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            Quest1 = new TabPage();
            loginButton = new Button();
            button1 = new Button();
            Quest2 = new TabPage();
            MassButton = new Button();
            NameLabel2 = new Label();
            Llabel = new Label();
            LBox = new TextBox();
            MassLabel = new Label();
            MassBox = new TextBox();
            NameLabel1 = new Label();
            Quest3 = new TabPage();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            Quest1.SuspendLayout();
            Quest2.SuspendLayout();
            Quest3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(320, 24);
            menuStrip1.TabIndex = 2;
            // 
            // задание1ToolStripMenuItem
            // 
            задание1ToolStripMenuItem.Name = "задание1ToolStripMenuItem";
            задание1ToolStripMenuItem.Size = new Size(32, 19);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Quest1);
            tabControl1.Controls.Add(Quest2);
            tabControl1.Controls.Add(Quest3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(322, 502);
            tabControl1.TabIndex = 1;
            // 
            // Quest1
            // 
            Quest1.Controls.Add(loginButton);
            Quest1.Controls.Add(button1);
            Quest1.Location = new Point(4, 24);
            Quest1.Name = "Quest1";
            Quest1.Padding = new Padding(3);
            Quest1.Size = new Size(314, 474);
            Quest1.TabIndex = 0;
            Quest1.Text = "Задание 1";
            Quest1.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.Location = new Point(233, 6);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 1;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(92, 190);
            button1.Name = "button1";
            button1.Size = new Size(111, 47);
            button1.TabIndex = 0;
            button1.Text = "Получить список помещений доступный для аренды";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Quest2
            // 
            Quest2.Controls.Add(MassButton);
            Quest2.Controls.Add(NameLabel2);
            Quest2.Controls.Add(Llabel);
            Quest2.Controls.Add(LBox);
            Quest2.Controls.Add(MassLabel);
            Quest2.Controls.Add(MassBox);
            Quest2.Controls.Add(NameLabel1);
            Quest2.Location = new Point(4, 24);
            Quest2.Name = "Quest2";
            Quest2.Padding = new Padding(3);
            Quest2.Size = new Size(314, 474);
            Quest2.TabIndex = 1;
            Quest2.Text = "Задание 2";
            Quest2.UseVisualStyleBackColor = true;
            // 
            // MassButton
            // 
            MassButton.Location = new Point(100, 277);
            MassButton.Name = "MassButton";
            MassButton.Size = new Size(75, 23);
            MassButton.TabIndex = 6;
            MassButton.Text = "Узнать";
            MassButton.UseVisualStyleBackColor = true;
            MassButton.Click += MassButton_Click;
            // 
            // NameLabel2
            // 
            NameLabel2.AutoSize = true;
            NameLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel2.Location = new Point(91, 92);
            NameLabel2.Name = "NameLabel2";
            NameLabel2.Size = new Size(128, 30);
            NameLabel2.TabIndex = 5;
            NameLabel2.Text = "массы тела";
            // 
            // Llabel
            // 
            Llabel.AutoSize = true;
            Llabel.Location = new Point(91, 200);
            Llabel.Name = "Llabel";
            Llabel.Size = new Size(102, 15);
            Llabel.TabIndex = 4;
            Llabel.Text = "Введите рост, в м";
            // 
            // LBox
            // 
            LBox.Location = new Point(91, 218);
            LBox.Name = "LBox";
            LBox.Size = new Size(100, 23);
            LBox.TabIndex = 3;
            LBox.KeyPress += LBox_KeyPress;
            LBox.Leave += LBox_Leave;
            // 
            // MassLabel
            // 
            MassLabel.AutoSize = true;
            MassLabel.Location = new Point(91, 139);
            MassLabel.Name = "MassLabel";
            MassLabel.Size = new Size(97, 15);
            MassLabel.TabIndex = 2;
            MassLabel.Text = "Введите вес, в кг";
            // 
            // MassBox
            // 
            MassBox.Location = new Point(91, 157);
            MassBox.Name = "MassBox";
            MassBox.Size = new Size(100, 23);
            MassBox.TabIndex = 1;
            MassBox.KeyPress += MassBox_KeyPress;
            MassBox.Leave += MassBox_Leave;
            // 
            // NameLabel1
            // 
            NameLabel1.AutoSize = true;
            NameLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel1.Location = new Point(34, 62);
            NameLabel1.Name = "NameLabel1";
            NameLabel1.Size = new Size(235, 30);
            NameLabel1.TabIndex = 0;
            NameLabel1.Text = "Калькулятор индекса";
            // 
            // Quest3
            // 
            Quest3.Controls.Add(label3);
            Quest3.Controls.Add(label4);
            Quest3.Controls.Add(label2);
            Quest3.Controls.Add(label1);
            Quest3.Location = new Point(4, 24);
            Quest3.Name = "Quest3";
            Quest3.Size = new Size(314, 474);
            Quest3.TabIndex = 2;
            Quest3.Text = "Задание 3";
            Quest3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 84);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 3;
            label3.Text = "Т-223901-ИСТ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(28, 72);
            label4.Name = "label4";
            label4.Size = new Size(89, 30);
            label4.TabIndex = 2;
            label4.Text = "Группа:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 42);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 1;
            label2.Text = "Трухар Андрей Леонидович";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Автор:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 501);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MaximumSize = new Size(960, 540);
            MinimizeBox = false;
            MinimumSize = new Size(200, 540);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Курсовая";
            tabControl1.ResumeLayout(false);
            Quest1.ResumeLayout(false);
            Quest2.ResumeLayout(false);
            Quest2.PerformLayout();
            Quest3.ResumeLayout(false);
            Quest3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem задание1ToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage Quest1;
        private TabPage Quest2;
        private TabPage Quest3;
        private Button button1;
        private Label NameLabel1;
        private Label MassLabel;
        private TextBox MassBox;
        private Label Llabel;
        private TextBox LBox;
        private Button MassButton;
        private Label NameLabel2;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private static Button loginButton;
    }
}
