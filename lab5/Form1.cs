using SaladFactory;
using THI_LAb3;

namespace lab5
{
    public partial class Salad : Form
    {
        public Salad()
        {
            InitializeComponent();
        }
        SaladFactory.Salad salad = new SaladFactory.Salad();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем фабрики
            VegetableFactory leafyGreenFactory = new LeafyGreenFactory();
            VegetableFactory rootVegetableFactory = new RootVegetableFactory();
            VegetableFactory fruitVegetableFactory = new CucubmerFactory();

            // Создаем салат
            salad.AddVegetable(leafyGreenFactory.CreateVegetable("Spinach", 23, "Flat"));
            salad.AddVegetable(rootVegetableFactory.CreateVegetable("Carrot", 41, "Loamy"));
            salad.AddVegetable(fruitVegetableFactory.CreateVegetable("Cucumber", 18, true));

            UpdateListBox();
        }
        private CreationForm _creationForm;
        private void addButton_Click(object sender, EventArgs e)
        {
            _creationForm = new CreationForm();
            _creationForm.ShowDialog();

            if (_creationForm.Result == DialogResult.OK)
            {
                Vegetable tempVeg = _creationForm.Veg;
                salad.vegetables.Add(tempVeg);
                UpdateListBox();
            }
        }

        private void editButton_click(object sender, EventArgs e)
        {
            if (vegetablesBox.SelectedIndex >= 0)
            {
                _creationForm = new CreationForm(salad.vegetables[vegetablesBox.SelectedIndex]);
                _creationForm.Show();
            }
        }
        
        private void UpdateListBox()
        {
            vegetablesBox.Items.Clear();
            foreach (Vegetable veg in salad.vegetables)
            {
                vegetablesBox.Items.Add($"{veg.Name} - {veg.Calories}");
            }
            colories.Text = salad.CalculateTotalCalories().ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (vegetablesBox.SelectedIndex >= 0)
            {
                salad.vegetables.RemoveAt(vegetablesBox.SelectedIndex);
            }
            UpdateListBox();
        }
    }
}
