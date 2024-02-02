using System;
using System.Drawing;
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
           if(!(textBox1.Text == string.Empty))
            {
                if (!comboBox1.Items.Contains(textBox1.Text))
                {
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Text = "";

                }
                else if (comboBox1.Items.Contains(textBox1.Text))
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
                }
                else if (comboBox1.Items.Contains(textBox1.Text) && comboBox2.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("The Word Exist in All Lists");
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a word above");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1  || comboBox2.SelectedIndex != -1)
            {
                if (button2.Text == "Concatenate")
                {
                    if (comboBox1.Text == comboBox2.Text)
                    {
                        MessageBox.Show("Cannot concatenate same words, Please choose different words");
                    }
                    else
                    {
                        label5.Text = comboBox1.Text + " " + comboBox2.Text;
                    }
                }
                else if (button2.Text == "Remove Item")
                {
                    if (radioButton1.Checked)
                    {
                        if (comboBox1.SelectedIndex != -1)
                        {
                            if (MessageBox.Show("Are you sure you want to delete item? ", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                        else
                        {
                            MessageBox.Show("Select a Word in the List to Continue");
                        }
                    }
                    else if (radioButton2.Checked)
                    {
                        if (comboBox2.SelectedIndex != -1)
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
                        else
                        {
                            MessageBox.Show("Select a Word in the List to Continue");
                        }
                    }  
                }
            }
            else
            {
                MessageBox.Show("Select a Word in the List to Continue");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Text = "Remove Item";
                button2.BackColor = Color.OrangeRed;
            }
            else if (!radioButton1.Checked)
            {
                button2.Text = "Concatenate";
                button2.BackColor = Color.Turquoise;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove Item";
                button2.BackColor = Color.OrangeRed;
            }
            else if (!radioButton2.Checked)
            {
                button2.Text = "Concatenate";
                button2.BackColor = Color.Turquoise;
            }
        }
    }
}
