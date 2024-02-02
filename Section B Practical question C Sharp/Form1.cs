using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_B_Practical_question_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!comboBox1.Items.Contains(textBox1.Text))
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

            }else if (comboBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("The Word Exist in All List 1 We are adding " + textBox1.Text + " to List 2");
                if (comboBox2.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("The Word Exist in All List 2 Choose different Word");
                    textBox1.Text = "";
                }
                else
                {
                    comboBox2.Items.Add(textBox1.Text);
                    textBox1.Text = "";
                }
               
            }else if (comboBox1.Items.Contains(textBox1.Text) && comboBox2.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("The Word Exist in All Lists");
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button2.Text == "Concatenate")
            {
                label5.Text = comboBox1.Text + " " + comboBox2.Text;
            }
            else if (button2.Text == "Remove Item")
            {
                if (radioButton1.Checked)
                {
                    if (MessageBox.Show("Are you sure you want to delete item? ","Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show(comboBox1.Text + " word deleted successfully...");
                        comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                        radioButton1.Checked = false;
                        label5.Text = comboBox1.Text + " " + comboBox2.Text;
                    }
                    else
                    {
                        MessageBox.Show(comboBox1.Text + " word not deleted");
                        radioButton1.Checked = false;
                    }
                }
                else if (radioButton2.Checked)
                {
                    if (MessageBox.Show("Are you sure you want to delete item? ", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        MessageBox.Show(comboBox2.Text + " word deleted successfully...");
                        comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                        radioButton2.Checked = false;
                        label5.Text = comboBox1.Text + " " + comboBox2.Text;
                    }
                    else
                    {
                        MessageBox.Show(comboBox2.Text + " word not deleted");
                        radioButton2.Checked = false;
                    }
                }
            } 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Text = "Remove Item";
            }
            else if (!radioButton1.Checked)
            {
                button2.Text = "Concatenate";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove Item";
            }else if (!radioButton2.Checked)
            {
                button2.Text = "Concatenate";
            }
        }
    }
}
