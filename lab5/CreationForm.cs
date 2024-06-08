using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THI_LAb3;

namespace lab5
{
    public partial class CreationForm : Form
    {
        public CreationForm()
        {
            InitializeComponent();
        }
        public CreationForm(Vegetable vegetable) : this()
        {
            if (vegetable != null)
            {
                nameTextBox.Text = vegetable.Name;
                caloriesTextBox.Text = vegetable.Calories.ToString();
            }
        }
        private Vegetable veg;
        public Vegetable Veg
        {
            get { return veg; }
            set { veg = value; }
        }
        private DialogResult _result;
        public DialogResult Result
        {
            get { return _result; }
            set { _result = value; }
        }
        private void CreationForm_Load(object sender, EventArgs e)
        {
            classComboBox.Items.Add("Cucumber");
            classComboBox.Items.Add("Root");
            classComboBox.Items.Add("Leaf");
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            Result = DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Vegetable veg;
            if (classComboBox.SelectedIndex == 0)
            {
                veg = new Cucumber(nameTextBox.Text, int.Parse(caloriesTextBox.Text), isCucumber.Checked);
            }
            else if (classComboBox.SelectedIndex == 1)
            {
                veg = new RootVegetable(nameTextBox.Text, int.Parse(caloriesTextBox.Text), soilType.Text);

            }
            else if (classComboBox.SelectedIndex == 2) {
                veg = new LeafyGreen(nameTextBox.Text, int.Parse(caloriesTextBox.Text),leafType.Text);
            }
            else
            {
                veg = new LeafyGreen("Test", 1, "test");
            }
            Result = DialogResult.OK;
            this.Close();
        }
    }
}
