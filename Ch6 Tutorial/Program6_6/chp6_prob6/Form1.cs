using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp6_prob6
{
    public partial class Form1 : Form
    {
        const decimal stayPerDay = 5500.00m;
        public Form1()
        {
            InitializeComponent();
        }



        private decimal CalcStayCharges(int day)
        {
            return stayPerDay * day;
        }

        private decimal CalcMissCharges(decimal foodBill, decimal spaBill, decimal carRental, decimal medicaBill)
            {
            return (foodBill + spaBill + carRental + medicaBill);
        }

        private decimal CalcTotalCharges(decimal stayBill, decimal miscellaneous)
            {
            return (stayBill + miscellaneous);
        }
        private bool IsInputValid(ref int days, ref decimal fb, ref decimal sb, ref decimal cb, ref decimal nb)

        {
            if(int.TryParse(textBox1.Text, out days) && decimal.TryParse(textBox2.Text, out fb) && decimal.TryParse(textBox3.Text, out sb)&& decimal.TryParse(textBox4.Text, out cb)&& decimal.TryParse(textBox5.Text, out nb))
            {
                return true;
            }
            
                else
            {
                MessageBox.Show("資料格式錯誤");
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int days = 0;
            decimal fb = 0, sb = 0, cb = 0, mb = 0;
            decimal stayCharge, miscCharge;
            decimal totalCharge;

            if(IsInputValid (ref days, ref fb, ref sb, ref cb, ref mb))
            {
                stayCharge = CalcStayCharges(days);
                miscCharge = CalcMissCharges(fb, sb, cb, mb);
                totalCharge = CalcTotalCharges(stayCharge, miscCharge);
                MessageBox.Show("Total Bill:" + totalCharge.ToString("c"));
            }
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
