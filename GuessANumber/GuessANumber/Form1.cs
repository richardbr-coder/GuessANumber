using System;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Random rand = new Random();
        int randomNumber = rand.Next(1, 6);
        int wrongNumber;
       
    
        private void Form1_Load(object sender, EventArgs e)
        {
            wrongNumber = rand.Next(1, 6);
            while (wrongNumber == randomNumber)
            {
                wrongNumber = rand.Next(1, 6);
            }
        }

        private void Option3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (randomNumber == 3)
            {
                MessageBox.Show(
                "You guessed the Right Number!");
                Option2.Enabled = false;
                Option1.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                "You guessed the Wrong Number!");
                Option2.Enabled = false;
                Option1.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
        }

        private void Option5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (randomNumber == 5)
            {
                MessageBox.Show(
                "You guessed the Right Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option1.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                "You guessed the Wrong Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option1.Enabled = false;
            }
        }

        private void hintLabel_Click(object sender, EventArgs e)
        {
            switch (wrongNumber)
            {
                case 1:
                    Option1.Text = "Wrong option";
                    break;
                case 2:
                    Option2.Text = "Wrong option";
                    break;
                case 3:
                    Option3.Text = "Wrong option";
                    break;
                case 4:
                    Option4.Text = "Wrong option";
                    break;
                case 5:
                    Option5.Text = "Wrong option";
                    break;
            }
        }

        private void Option1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (randomNumber == 1)
            {
                MessageBox.Show(
                "You guessed the Right Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                "You guessed the Wrong Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
        }

        private void Option2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (randomNumber == 2)
            {
                MessageBox.Show(
                "You guessed the Right Number!");
                Option1.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                "You guessed the Wrong Number!");
                Option1.Enabled = false;
                Option3.Enabled = false;
                Option4.Enabled = false;
                Option5.Enabled = false;
            }
        }

        private void Option4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (randomNumber == 4)
            {
                MessageBox.Show(
                "You guessed the Right Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option1.Enabled = false;
                Option5.Enabled = false;
            }
            else
            {
                MessageBox.Show(
                "You guessed the Wrong Number!");
                Option2.Enabled = false;
                Option3.Enabled = false;
                Option1.Enabled = false;
                Option5.Enabled = false;
            }
        }
    }
}