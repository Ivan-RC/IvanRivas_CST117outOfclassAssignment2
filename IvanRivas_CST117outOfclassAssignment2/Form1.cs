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

                case "coffee":
                    MessageBox.Show("Coffee coming right up.");
                    break;


                case "tea":
                    MessageBox.Show("Tea coming right up.");
                    break;

                case "milkshake":
                    MessageBox.Show("Milkshake coming up.");
                    break;

                case "orange juice":
                    MessageBox.Show("Orange Juice is on the way.");
                    break;

                case "apple Juice":
                    MessageBox.Show("Apple Juice is on the way.");
                    break;

                case "smoothie":
                    MessageBox.Show("Smoothie it is.");
                    break;

                case "water":
                    MessageBox.Show("You sure? Well okay.");
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
        //Extras
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
