/* Name: Emily Welshhans
 * Project: 8, Cook Order Form; Hamburger Kiosk
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

namespace BurgerOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            string filename = @"c:\temp\orders\order.txt";

            // object created to open & read the order.txt file
            FileStream inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);

            // filestream object passed to streamreader object's constructor
            StreamReader reader = new StreamReader(inFile);

            orderTextBox.Text = reader.ReadToEnd();

            // retrieve one line at a time from orders.txt
            string recordIn = reader.ReadLine();
     
            reader.Close();
            inFile.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            orderTextBox.Text = " ";
            inProgressButton.Enabled = true;
            completedButton.Enabled = true;
            newOrderButton.Enabled = true;
            closeButton.Enabled = true;

        }

        private void inProgressButton_Click(object sender, EventArgs e)
        {
            string prog = "IN PROGRESS";
            const string filename = @"c:\temp\orders\order.txt";

            FileStream inFile = new FileStream(filename, FileMode.Create, FileAccess.Write);

            // filestream object passed to streamreader object's constructor
            StreamWriter writer = new StreamWriter(inFile);

            writer.WriteLine(prog);

            newOrderButton.Enabled = false;
            closeButton.Enabled = false;
            completedButton.Enabled = true;

            writer.Close();
        }

        private void completedButton_Click(object sender, EventArgs e)
        {
            string prog = "COMPLETED";
            const string filename = @"c:\temp\orders\order.txt";

            FileStream inFile = new FileStream(filename, FileMode.Create, FileAccess.Write);

            // filestream object passed to streamreader object's constructor
            StreamWriter writer = new StreamWriter(inFile);

            writer.WriteLine(prog);

            inProgressButton.Enabled = false;
            newOrderButton.Enabled = false;
            closeButton.Enabled = true;

            writer.Close();
        }
    }
}
