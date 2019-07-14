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
        List<CounterData> counterList = new List<CounterData>();
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
            foreach (var singleCounter in counterList)
            {
                Task task = Task.Factory.StartNew(() =>
                    counter.Count(singleCounter.countNumber, singleCounter.intervalTime, (currentStatus) =>
                        counterResultBox.Invoke(new Action(() =>
                            counterResultBox.AppendText(currentStatus + "\n")))));
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
            counterListBox.Clear();
            counterResultBox.Clear();
            counterList.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CounterData singleCounter = new CounterData();
            var textinput = new EnglishToInt();
            if (countNumberBox.Enabled == true)
            {
                singleCounter.countNumber = Decimal.ToInt32(countNumberBox.Value);
            }
            else if (countTextBox.Enabled == true)
            {
                singleCounter.countNumber = (int)textinput.WordtoNumb(countTextBox.Text);
            }
            singleCounter.intervalTime = Int32.Parse(intervalTimeBox.Text);
            counterList.Add(singleCounter);
            counterListBox.AppendText("Counter #" + (counterList.IndexOf(singleCounter)+1) + ": iterations - " + singleCounter.countNumber + ", delay - " + singleCounter.intervalTime + " ms\n");
        }
    }
}
