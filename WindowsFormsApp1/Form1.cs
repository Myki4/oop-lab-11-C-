using System;
using System.Windows.Forms;
using VehicleApp.Models;

namespace VehicleApp
{
    public partial class Form1 : Form
    {
        private Vehicle currentVehicle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxVehicleType.Items.AddRange(new string[] { "Літак", "Авто", "Корабель" });
            comboBoxVehicleType.SelectedIndex = 0;
            comboBoxVehicleType.SelectedIndexChanged += comboBoxVehicleType_SelectedIndexChanged;
            UpdateVisibility();
        }

        private void comboBoxVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }

        private void UpdateVisibility()
        {
            labelHeight.Visible = textBoxHeight.Visible = false;
            labelPassengers.Visible = textBoxPassengers.Visible = false;
            labelPort.Visible = textBoxPort.Visible = false;

            string selected = comboBoxVehicleType.SelectedItem.ToString();

            if (selected == "Літак")
            {
                labelHeight.Visible = textBoxHeight.Visible = true;
                labelPassengers.Visible = textBoxPassengers.Visible = true;
            }
            else if (selected == "Корабель")
            {
                labelPassengers.Visible = textBoxPassengers.Visible = true;
                labelPort.Visible = textBoxPort.Visible = true;
            }
        }

        private void buttonCreateVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                double price = double.Parse(textBoxPrice.Text);
                double speed = double.Parse(textBoxSpeed.Text);
                int year = int.Parse(textBoxYear.Text);

                string selected = comboBoxVehicleType.SelectedItem.ToString();
                if (selected == "Авто")
                {
                    currentVehicle = new Car(price, speed, year);
                }
                else if (selected == "Літак")
                {
                    double height = double.Parse(textBoxHeight.Text);
                    int passengers = int.Parse(textBoxPassengers.Text);
                    currentVehicle = new Plain(price, speed, year, height, passengers);
                }
                else if (selected == "Корабель")
                {
                    int passengers = int.Parse(textBoxPassengers.Text);
                    string port = textBoxPort.Text;
                    currentVehicle = new Ship(price, speed, year, passengers, port);
                }

                MessageBox.Show("Транспортний засіб створено успішно.", "Успіх",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при створенні транспортного засобу: " + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowInfo_Click(object sender, EventArgs e)
        {
            if (currentVehicle != null)
            {
                textBoxOutput.Text = currentVehicle.GetInfo();
            }
            else
            {
                MessageBox.Show("Спочатку створіть транспортний засіб.",
                    "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
