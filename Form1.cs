using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presidents1_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
            textBox2.Text = textBox2.Text.ToLower();
            textBox3.Text = textBox3.Text.ToLower();
            textBox4.Text = textBox4.Text.ToLower();
            textBox5.Text = textBox5.Text.ToLower();
            textBox6.Text = textBox6.Text.ToLower();
            textBox7.Text = textBox7.Text.ToLower();
            textBox8.Text = textBox8.Text.ToLower();
            textBox9.Text = textBox9.Text.ToLower();
            textBox10.Text = textBox10.Text.ToLower();
            textBox11.Text = textBox11.Text.ToLower();
            if (textBox1.Text == "george washington")
            {
                firstPres.Checked = true;
            }
            if (textBox1.Text != "george washington")
            {
                firstPres.Checked = false;
            }
            if (textBox2.Text == "john adams")
            {
                secondPres.Checked = true;
            }
            if (textBox2.Text != "john adams")
            {
                secondPres.Checked = false;
            }
            if (textBox3.Text == "thomas jefferson")
            {
                thirdPres.Checked = true;
            }
            if (textBox3.Text != "thomas jefferson")
            {
                thirdPres.Checked = false;
            }
            if (textBox4.Text == "james madison")
            {
                fourthPres.Checked = true;
            }
            if (textBox4.Text != "james madison")
            {
                fourthPres.Checked = false;
            }
            if (textBox5.Text == "james monroe")
            {
                fifthPres.Checked = true;
            }
            if (textBox5.Text != "james monroe")
            {
                fifthPres.Checked = false;
            }
            if (textBox6.Text == "john quincy adams")
            {
                sixthPres.Checked = true;
            }
            if (textBox6.Text != "john quincy adams")
            {
                sixthPres.Checked = false;
            }
            if (textBox7.Text == "andrew jackson")
            {
                seventhPres.Checked = true;
            }
            if (textBox7.Text != "andrew jackson")
            {
                seventhPres.Checked = false;
            }
            if (textBox8.Text == "martin van buren")
            {
                eighthPres.Checked = true;
            }
            if (textBox8.Text != "martin van buren")
            {
                eighthPres.Checked = false;
            }
            if (textBox9.Text == "william henry harrison")
            {
                ninthPres.Checked = true;
            }
            if (textBox9.Text != "william henry harrison")
            {
                ninthPres.Checked = false;
            }
            if (textBox10.Text == "john tyler")
            {
                tenthPres.Checked = true;
            }
            if (textBox10.Text != "john tyler")
            {
                tenthPres.Checked = false;
            }
            if (textBox11.Text == "james polk")
            {
                eleventhPres.Checked = true;
            }
            if (textBox11.Text != "james polk")
            {
                eleventhPres.Checked = false;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// made to clean up after the user is done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            //clears the text boxes
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();

            //clears the checkboxes 
            firstPres.Checked = false;
            secondPres.Checked = false;
            thirdPres.Checked = false;
            fourthPres.Checked = false;
            fifthPres.Checked = false;
            sixthPres.Checked = false;
            seventhPres.Checked = false;
            eighthPres.Checked = false;
            ninthPres.Checked = false;
            tenthPres.Checked = false;
            eleventhPres.Checked = false;
        }
    }
}
