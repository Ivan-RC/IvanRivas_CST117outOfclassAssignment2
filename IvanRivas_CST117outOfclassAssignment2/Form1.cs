using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanRivas_CST117outOfclassAssignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Order_Click(object sender, EventArgs e)
        {

            //Drinks
            string drink;
            drink = listBox1_drinks.SelectedItem.ToString();
            switch (drink)
            {

                case "Coffee":
                    MessageBox.Show("Coffee coming right up.");
                    break;


                case "Tea":
                    MessageBox.Show("Tea coming right up.");
                    break;

                case "Milkshake":
                    MessageBox.Show("Milkshake coming up.");
                    break;

                case "Orange Juice":
                    MessageBox.Show("Orange Juice is on the way.");
                    break;

                case "Apple Juice":
                    MessageBox.Show("Apple Juice is on the way.");
                    break;

            }

            //Sizes
            if (radioButton1_small.Checked)
            {

                MessageBox.Show("Your " + drink + " will be small.");

            }
            else if (radioButton2_medium.Checked)
            {

                MessageBox.Show("Your " + drink + " will be medium.");

            }
            else if (radioButton3_large.Checked)
            {

                MessageBox.Show("Your " + drink + " will be large.");

            }
            else if (radioButton4_extraLarge.Checked)
            {

                MessageBox.Show("Your " + drink + " will be extra large.");

            }
        }

        private void checkBox1_sugar_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your drink will have sugar.");
        }

        private void checkBox2_cream_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your drink will have cream.");
        }

        private void checkBox3_honey_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your drink will have honey.");
        }

        private void checkBox4_whip_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Your drink will have whip cream.");
        }
    }
}
