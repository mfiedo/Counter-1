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
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            countTextBox.Enabled = true;
            countNumberBox.Enabled = false;
            startButton.Enabled = true;
            intervalTimeBox.Enabled = true;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            var counter = new Counting();
            int countNumber = Decimal.ToInt32(countNumberBox.Value);
            int intervalTime = Int32.Parse(intervalTimeBox.Text);
            counter.Count(countNumber, intervalTime, () => counterResultBox.AppendText(Counting.currentNumber.ToString()+"\n"));
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            counterResultBox.Clear();
        }
    }
}
