using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Counter.ClassLibrary;

namespace Counter.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            countNumberBox.Enabled = true;
            countTextBox.Enabled = false;
            startButton.Enabled = true;
            intervalTimeBox.Enabled = true;
            numberButton.Enabled = false;
            textButton.Enabled = false;
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            countTextBox.Enabled = true;
            countNumberBox.Enabled = false;
            startButton.Enabled = true;
            intervalTimeBox.Enabled = true;
            numberButton.Enabled = false;
            textButton.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var counter = new Counting();
            var textinput = new EnglishToInt();
            int countNumber = 0;
            if (countNumberBox.Enabled == true)
            {
                countNumber = Decimal.ToInt32(countNumberBox.Value);
            }
            else if (countTextBox.Enabled == true)
            {
                countNumber = (int)textinput.WordtoNumb(countTextBox.Text);
            }
            try
            {
                int intervalTime = Int32.Parse(intervalTimeBox.Text);
                counter.Count(countNumber, intervalTime, (x) => counterResultBox.AppendText(x + "\n"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            numberButton.Enabled = true;
            textButton.Enabled = true;
            countTextBox.Enabled = false;
            countNumberBox.Enabled = false;
            intervalTimeBox.Enabled = false;
            countTextBox.Text = "";
            countNumberBox.Value = 1;
            intervalTimeBox.Text = "";
            counterResultBox.Clear();
        }
    }
}
