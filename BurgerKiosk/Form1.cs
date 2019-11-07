/* Name: Emily Welshhans
 * Project: 7, Hamburger Kiosk
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        // variables
        double totalPrice;

        // variables for message box
        string string1;
        string string2 = "Type: ";
        string string3 = "Bun: ";
        string string4 = "Cheese: ";
        string string5 = "Toppings: \n";
        string string6 = "Extras: \n";
        string string7;

        public Form1()
        {
            InitializeComponent();

            totalTextBox.Text = totalPrice.ToString("C");
            string1 = "Name: " + textBox1.Text;
            string7 = "Total: " + totalPrice.ToString("C");
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {
            CalculateBurgerOrder();

            string orderMessage = string1 + "\r\n" + string2 + "\r\n" + string3 + "\r\n" + string4 + "\r\n" + string5 + "\r\n" + string6 + "\r\n" + string7;

               // message box to show when submit button is clicked
            MessageBox.Show(orderMessage, "Order Summary", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // create & amend a file

            string filename = @"c:\temp\orders\order.txt";

            FileStream outFile = new FileStream(filename, FileMode.Create, FileAccess.Write);

            StreamWriter writer = new StreamWriter(outFile);

            writer.WriteLine(orderMessage);

            writer.Close();
            outFile.Close();

        }

        private void CalculateBurgerOrder()
        {
            // initializing variables for price and message box
            totalPrice = 0.00;
            totalTextBox.Text = totalPrice.ToString("C");
            string1 = "Name: " + textBox1.Text;
            string2 = "Type: ";
            string3 = "Bun: ";
            string4 = "Cheese: ";
            string5 = "Toppings: \n";
            string6 = "Extras: \n";
            string7 = "Total: " + totalPrice.ToString("C");

            // calculate the order & generate text for message box
            // add burger type price
            if (beefBurgerBox.Checked)
            {
                totalPrice += 4.00;
                string2 = string2 + "Beef";
            }

            if (turkeyBurgerBox.Checked)
            {
                totalPrice += 4.00;
                string2 = string2 + " Turkey";
            }

            if (vegBurgerBox.Checked)
            {
                totalPrice += 4.00;
                string2 = string2 + " Veggie";
            }

            if (beefBurgerBox.Checked && turkeyBurgerBox.Checked && vegBurgerBox.Checked)
            {
                // message box: error, select 1 or 2 burger types only
                MessageBox.Show("Please select 1 or 2 burger types only!", "Burger Type Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                beefBurgerBox.Checked = false;
                turkeyBurgerBox.Checked = false;
                vegBurgerBox.Checked = false;
            }

                // add bun price
                if (regBunRadio.Checked)
            {
                totalPrice += 1.00;
                string3 = string3 + "Regular";
            }

            if (brioBunRadio.Checked)
            {
                totalPrice += 1.00;
                string3 = string3 + "Brioche";
            }

            if (pretBunRadio.Checked)
            {
                totalPrice += 1.00;
                string3 = string3 + "Pretzel";
            }

            if (noBunRadio.Checked)
            {
                totalPrice += 0.00;
                string3 = string3 + "None";
            }

            // add cheese price
            string cheese1 = "", cheese2 = "";

            if (cheeseListBox1.SelectedIndex != -1)
            {
                // selected cheese is changed to a string that will be displayed in the message box
                cheese1 = cheeseListBox1.Items[cheeseListBox1.SelectedIndex].ToString();
                totalPrice = totalPrice + 0.00;
            } 
            if (cheeseListBox2.SelectedIndex != -1)
            {
                cheese2 = cheeseListBox2.Items[cheeseListBox2.SelectedIndex].ToString();
                totalPrice = totalPrice + 0.25;
            }
            string4 = string4 + cheese1 + " & " + cheese2;


            // add toppings price
            if (ketchupNumber.Value == 1)
            {
                string5 = string5 + "1 Ketchup \n";

            }
            if (ketchupNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Ketchup \n";

            }
            if (ketchupNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Ketchup \n";

            }
            if (ketchupNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Ketchup \n";
            }

            if (mustardNumber.Value == 1)
            {
                string5 = string5 + "1 Mustard \n";
            }
            if (mustardNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Mustard \n";
            }
            if (mustardNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Mustard \n";
            }
            if (mustardNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Mustard \n";
            }

            if (mayoNumber.Value == 1)
            {
                string5 = string5 + "1 Mayo \n";
            }
            if (mayoNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Mayo \n";
            }
            if (mayoNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Mayo \n";
            }
            if (mayoNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Mayo \n";
            }

            if (garlicNumber.Value == 1)
            {
                string5 = string5 + "1 Garlic Aioli \n";
            }
            if (garlicNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Garlic Aioli \n";
            }
            if (garlicNumber.Value == 3)
            {
               totalPrice += 0.10;
                string5 = string5 + "3 Garlic Aioli \n";
            }
            if (garlicNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Garlic Aioli \n";
            }

            if (lettuceNumber.Value == 1)
            {
                string5 = string5 + "1 Lettuce \n";
            }
            if (lettuceNumber.Value == 2)
            {
               totalPrice += 0.05;
                string5 = string5 + "2 Lettuce \n";
            }
            if (lettuceNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Lettuce \n";
            }
            if (lettuceNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Lettuce \n";
            }

            if (tomatoNumber.Value == 1)
            {
                string5 = string5 + "1 Tomato \n";
            }
            if (tomatoNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Tomato \n";
            }
            if (tomatoNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Tomato \n";
            }
            if (tomatoNumber.Value == 4)
            {
                totalPrice = totalPrice + 0.15;
                string5 = string5 + "4 Tomato \n";
            }

            if (onionNumber.Value == 1)
            {
                string5 = string5 + "1 Onion \n";
            }
            if (onionNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Onion \n";
            }
            if (onionNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Onion \n";
            }
            if (onionNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Onion \n";
            }

            if (pickleNumber.Value == 1)
            {
                string5 = string5 + "1 Pickle \n";
            }
            if (pickleNumber.Value == 2)
            {
                totalPrice += 0.05;
                string5 = string5 + "2 Pickle \n";
            }
            if (pickleNumber.Value == 3)
            {
                totalPrice += 0.10;
                string5 = string5 + "3 Pickle \n";
            }
            if (pickleNumber.Value == 4)
            {
                totalPrice += 0.15;
                string5 = string5 + "4 Pickle \n";
            }


            // add extras price
            if (baconNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Bacon \n";
            }
            else if (baconNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Bacon \n";
            }

            if (guacNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Guacamole \n";
            }
            else if (guacNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Guacamole \n";
            }

            if (eggNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Fried Egg \n";
            }
            else if (eggNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Fried Egg \n";
            }

            if (jalapenoNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Jalapeno \n";
            }
            else if (jalapenoNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Jalapeno \n";
            }

            if (caramelOnionNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Caramelized Onion \n";
            }
            else if (caramelOnionNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Caramelized Onion \n";
            }

            if (stringOnionNumber.Value == 1)
            {
                totalPrice += 0.50;
                string6 = string6 + "1 Onion Strings \n";
            }
            else if (stringOnionNumber.Value == 2)
            {
                totalPrice += 1.00;
                string6 = string6 + "2 Onion Strings \n";
            }

            // prints the price into the message box
            totalTextBox.Text = totalPrice.ToString("C");
            string7 = "Total: " + totalPrice.ToString("C");

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // this method calls the Calculate Burger method for any numeric up down object (in this case, toppings & extras)
            CalculateBurgerOrder();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // this method calls the Calculate Burger method for any check boxes (in this case, burger type selection: beef, turkey, veggie)
            CalculateBurgerOrder();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this method calls the Calculate Burger method for the two cheese list boxes
            CalculateBurgerOrder();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            // this method calls the Calculate Burger method for the radio buttons (bun selection)
            CalculateBurgerOrder();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // clear totalTextBox price
            totalTextBox.Clear();

            // changes all checkbox values to false (unchecked)
            beefBurgerBox.Checked = false;
            turkeyBurgerBox.Checked = false;
            vegBurgerBox.Checked = false;

            regBunRadio.Checked = false;
            brioBunRadio.Checked = false;
            pretBunRadio.Checked = false;
            noBunRadio.Checked = false;

            // clears cheese listbox selections
            cheeseListBox1.ClearSelected();
            cheeseListBox2.ClearSelected();

            // changes toppings & extras value to 0
            ketchupNumber.Value = 0;
            mustardNumber.Value = 0;
            mayoNumber.Value = 0;
            garlicNumber.Value = 0;
            lettuceNumber.Value = 0;
            tomatoNumber.Value = 0;
            onionNumber.Value = 0;
            pickleNumber.Value = 0;

            baconNumber.Value = 0;
            guacNumber.Value = 0;
            eggNumber.Value = 0;
            jalapenoNumber.Value = 0;
            caramelOnionNumber.Value = 0;
            stringOnionNumber.Value = 0;
        }

    }
}
