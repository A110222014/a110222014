using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int[] lotteryNumbers = new int[5];
            Random rand = new Random();
            Label[] labelsArray = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };

            for (int i = 0; i < lotteryNumbers.Length ; i++)
            {
                lotteryNumbers[i] = rand.Next(42) + 1;
            }

            //fifthLabel.Text = lotteryNumbers[0].ToString();
            //secondLabel.Text = lotteryNumbers[1].ToString();

            for(int i = 0; i < labelsArray.Length; i++)
            {
                labelsArray[i].Text = lotteryNumbers[i].ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
