using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) // register
        {
            // Get values from textboxes
            string name = textBox1.Text;// box1: name
            string password = textBox2.Text;//box2: pass
            string confirm = textBox3.Text;//box3: confirm

            // Validate inputs and provide appropriate messages
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else if (string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please retype your password to confirm", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
            }
            else if (password == confirm)
            {
                MessageBox.Show("Registration successful", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Additional code to handle successful registration can be added here
                //Form1 form1 = new Form1();
                //form1.Hide();

                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Register un-success. Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                textBox3.Clear();
                textBox2.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
