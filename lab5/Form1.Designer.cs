namespace lab5
{
    partial class Salad
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
            vegetablesBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            button3 = new Button();
            label1 = new Label();
            colories = new Label();
            SuspendLayout();
            // 
            // vegetablesBox
            // 
            vegetablesBox.FormattingEnabled = true;
            vegetablesBox.ItemHeight = 15;
            vegetablesBox.Location = new Point(105, 23);
            vegetablesBox.Name = "vegetablesBox";
            vegetablesBox.Size = new Size(120, 94);
            vegetablesBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 23);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(12, 81);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 23);
            removeButton.TabIndex = 2;
            removeButton.Text = "remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 52);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += editButton_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 129);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 4;
            label1.Text = "Всего колорий:";
            // 
            // colories
            // 
            colories.AutoSize = true;
            colories.Location = new Point(110, 129);
            colories.Name = "colories";
            colories.Size = new Size(38, 15);
            colories.TabIndex = 5;
            colories.Text = "label2";
            // 
            // Salad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 153);
            Controls.Add(colories);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(vegetablesBox);
            Name = "Salad";
            Text = "Salad";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox vegetablesBox;
        private Button addButton;
        private Button removeButton;
        private Button button3;
        private Label label1;
        private Label colories;
    }
}
