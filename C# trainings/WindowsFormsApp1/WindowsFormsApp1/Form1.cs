using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);

            int result = a + b;

            MessageBox.Show("Addition: " + result);
        }

        private void LogMessage(string message)
        {
            listBox2.Items.Add(DateTime.Now.ToString() + " - " + message);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            LogMessage("Task Started");

            Task task1 = WashAndDryClothes();
            Task task2 = CookFood();
            Task task3 = CleaningHouse();

            await Task.WhenAll(task1, task2, task3);

            LogMessage("Task Ended");
        }

        private async Task WashAndDryClothes()
        {
            string wetClothes = await WashClothes();
            await DryClothes(wetClothes);
        }

        private async Task<string> WashClothes()
        {
            LogMessage("Washing Clothes");
            await Task.Delay(1000);
            LogMessage("Completed Washing Clothes");
            return "Wet Clothes";
        }

        private async Task DryClothes(string clothes)
        {
            LogMessage("Drying Clothes");
            await Task.Delay(1000);
            LogMessage("Completed Drying Clothes");
        }

        private async Task CookFood()
        {
            LogMessage("Cooking Food");
            await Task.Delay(2000);
            LogMessage("Completed Cooking");
        }

        private async Task CleaningHouse()
        {
            LogMessage("Cleaning House");
            await Task.Delay(2000);
            LogMessage("Completed Cleaning House");
        }

        
    }
}
