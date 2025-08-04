using System;
using System.Windows.Forms;

namespace PercentageCalculatorUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double[] marks = new double[6];

            // Array of textbox controls – Make sure names match exactly with your form
            TextBox[] textBoxes = { txtSub1, txtSub2, txtSub3, txtSub4, txtSub5, txtSub6 };

            double total = 0;
            double maxMarks = 600;

            for (int i = 0; i < textBoxes.Length; i++)
            {
                string input = textBoxes[i].Text.Trim();

                if (double.TryParse(input, out double mark))
                {
                    if (mark >= 0 && mark <= 100)
                    {
                        marks[i] = mark;
                        total += mark;
                    }
                    else
                    {
                        MessageBox.Show($"Enter valid marks (0–100) for Subject {i + 1}.", "Invalid Marks", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid input for Subject {i + 1}. Please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            double percentage = (total / maxMarks) * 100;
            string result = $"Total Marks: {total} / {maxMarks}\nPercentage: {percentage:F2}%\n";

            if (percentage >= 40)
                result += "Status: Passed 🎉";
            else
                result += "Status: Failed ❌";

            lblResult.Text = result;
        }
    }
}
