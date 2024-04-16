namespace WinFormsApp1
{
    partial class RentForm
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
            DateStartLabel = new Label();
            DateEndLabel = new Label();
            DateStartPicker = new DateTimePicker();
            DateEndPicker = new DateTimePicker();
            StartRentButton = new Button();
            SuspendLayout();
            // 
            // DateStartLabel
            // 
            DateStartLabel.AutoSize = true;
            DateStartLabel.Location = new Point(55, 84);
            DateStartLabel.Name = "DateStartLabel";
            DateStartLabel.Size = new Size(162, 15);
            DateStartLabel.TabIndex = 0;
            DateStartLabel.Text = "Введите дату начала аренды";
            // 
            // DateEndLabel
            // 
            DateEndLabel.AutoSize = true;
            DateEndLabel.Location = new Point(55, 182);
            DateEndLabel.Name = "DateEndLabel";
            DateEndLabel.Size = new Size(183, 15);
            DateEndLabel.TabIndex = 1;
            DateEndLabel.Text = "Введите дату окончания аренды";
            // 
            // DateStartPicker
            // 
            DateStartPicker.Location = new Point(55, 120);
            DateStartPicker.Name = "DateStartPicker";
            DateStartPicker.Size = new Size(200, 23);
            DateStartPicker.TabIndex = 2;
            DateStartPicker.ValueChanged += DateStartPicker_ValueChanged;
            // 
            // DateEndPicker
            // 
            DateEndPicker.Location = new Point(55, 214);
            DateEndPicker.Name = "DateEndPicker";
            DateEndPicker.Size = new Size(200, 23);
            DateEndPicker.TabIndex = 3;
            // 
            // StartRentButton
            // 
            StartRentButton.Location = new Point(80, 289);
            StartRentButton.Name = "StartRentButton";
            StartRentButton.Size = new Size(147, 40);
            StartRentButton.TabIndex = 4;
            StartRentButton.Text = "Оформить аренду";
            StartRentButton.UseVisualStyleBackColor = true;
            StartRentButton.Click += StartRentButton_Click;
            // 
            // RentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(321, 358);
            Controls.Add(StartRentButton);
            Controls.Add(DateEndPicker);
            Controls.Add(DateStartPicker);
            Controls.Add(DateEndLabel);
            Controls.Add(DateStartLabel);
            Name = "RentForm";
            Text = "RentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateStartLabel;
        private Label DateEndLabel;
        private DateTimePicker DateStartPicker;
        private DateTimePicker DateEndPicker;
        private Button StartRentButton;
    }
}