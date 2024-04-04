using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week12c_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the button click event
        private void button1generate_Click(object sender, EventArgs e)
        {
            // Attempt to parse the input from the text box
            if (int.TryParse(textBox1generate.Text, out int number))
            {
                // Start a new task to generate Fibonacci numbers asynchronously
                Task task1 = Task.Run(() => GenerateNumbers(number));

                // Clear the list box
                listBox1.Items.Clear();
            }
            else
            {
                // Display an error message for invalid input
                MessageBox.Show("Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Method to generate Fibonacci numbers
        private void GenerateNumbers(int number)
        {
            // Initialize the first two numbers in the sequence
            int a = 0;
            int b = 1;
            int c = 0;
            // Generate the Fibonacci numbers
            for(int i = 0; i < number; i++)
            {
                c = a + b;
                a = b;
                b = c;
                listBox1.Invoke(new Action(() => listBox1.Items.Add(c)));
                // Simulate a delay
                Thread.Sleep(1000);
            }
        }
    }
}