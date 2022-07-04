using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form1 : Form
    {
        //initialize variables
        int setLastDOM = 0;
        static int luckyNumber;

        public Form1()
        {
            InitializeComponent();
        }

        public void userBirthDay()
        {
            //determine which days of the month have 31 days
            if (birthMonth.SelectedIndex == 0 || birthMonth.SelectedIndex == 2 || birthMonth.SelectedIndex == 4
                || birthMonth.SelectedIndex == 6 || birthMonth.SelectedIndex == 7 || birthMonth.SelectedIndex == 9
                || birthMonth.SelectedIndex == 11)
            {
                setLastDOM = 31;
            }

            //determine if user was born in Feb
            else if (birthMonth.SelectedIndex == 1)
            {
                int bYear = Int32.Parse(birthYear.Text);

                //determine if it is a leap year - if so, and if user was born in Feb, set last DOM to 29
                if (bYear % 4 == 0)
                {
                    setLastDOM = 29;
                }

                //else if born in feb, set last DOM to 28
                else
                {
                    setLastDOM = 28;
                }
            }

            //if not born in a month with 31 days, set last DOM to 30
            else
            {
                setLastDOM = 30;
            }        
        }

        private void birthYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBirthDay();
        }

        private void birthMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            userBirthDay();
        }

        private void btnLuckyNumber_Click(object sender, EventArgs e)
        {
            //prompt the user to fill out the form if they did not select a value for all fields
            if (birthYear.SelectedIndex >= 0 && birthMonth.SelectedIndex >= 0 && birthDay.SelectedIndex >= 0 && favoriteColor.SelectedIndex >= 0)
            {
                //calculate lucky number
                luckyNumber = (birthYear.SelectedIndex + birthMonth.SelectedIndex + birthDay.SelectedIndex + favoriteColor.SelectedIndex);
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Fill The Above Form");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birthYear.Text = "Select Year";
            birthDay.Text = "Select Day";
            birthMonth.Text = "Select Month";
            favoriteColor.Text = "Select Color";
        }

        public int getLuckyNumber()
        {
            return luckyNumber;
        }
    }
}