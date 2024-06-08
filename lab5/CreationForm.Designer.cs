namespace lab5
{
    partial class CreationForm
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
            okButton = new Button();
            button2 = new Button();
            label1 = new Label();
            classComboBox = new ComboBox();
            label2 = new Label();
            nameTextBox = new TextBox();
            label3 = new Label();
            caloriesTextBox = new TextBox();
            isCucumber = new CheckBox();
            soilType = new TextBox();
            soil = new Label();
            label4 = new Label();
            leafType = new TextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 253);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 0;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 253);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Class";
            // 
            // classComboBox
            // 
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(52, 25);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(121, 23);
            classComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(57, 58);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Calories";
            // 
            // caloriesTextBox
            // 
            caloriesTextBox.Location = new Point(57, 87);
            caloriesTextBox.Name = "caloriesTextBox";
            caloriesTextBox.Size = new Size(100, 23);
            caloriesTextBox.TabIndex = 7;
            // 
            // isCucumber
            // 
            isCucumber.AutoSize = true;
            isCucumber.Location = new Point(12, 116);
            isCucumber.Name = "isCucumber";
            isCucumber.Size = new Size(49, 19);
            isCucumber.TabIndex = 8;
            isCucumber.Text = "Ripe";
            isCucumber.UseVisualStyleBackColor = true;
            // 
            // soilType
            // 
            soilType.Location = new Point(68, 141);
            soilType.Name = "soilType";
            soilType.Size = new Size(100, 23);
            soilType.TabIndex = 9;
            // 
            // soil
            // 
            soil.AutoSize = true;
            soil.Location = new Point(2, 144);
            soil.Name = "soil";
            soil.Size = new Size(53, 15);
            soil.TabIndex = 10;
            soil.Text = "Soil Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 173);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "Leaf Type";
            // 
            // leafType
            // 
            leafType.Location = new Point(73, 170);
            leafType.Name = "leafType";
            leafType.Size = new Size(100, 23);
            leafType.TabIndex = 11;
            // 
            // CreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 359);
            Controls.Add(label4);
            Controls.Add(leafType);
            Controls.Add(soil);
            Controls.Add(soilType);
            Controls.Add(isCucumber);
            Controls.Add(caloriesTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(classComboBox);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(okButton);
            Name = "CreationForm";
            Text = "CreationForm";
            Load += CreationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button button2;
        private Label label1;
        private ComboBox classComboBox;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private TextBox caloriesTextBox;
        private CheckBox isCucumber;
        private TextBox soilType;
        private Label soil;
        private Label label4;
        private TextBox leafType;
    }
}