using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Sunday");
            comboBox1.Items.Add("Monday");
            comboBox1.Items.Add("Tuesday");

            statusTxt.Text = "Form Loaded..!";

         }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sunday");
            listBox1.Items.Add("Monday");
            listBox1.Items.Add("Tuesday");
            listBox1.Items.Add("Wednesday");
            listBox1.Items.Add("Thursday");
            listBox1.Items.Add("Friday");
            listBox1.Items.Add("Saturday");
            listBox1.SelectionMode = SelectionMode.MultiSimple;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            MessageBox.Show(item);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            progressBar.Value = 90;
        }

        private void button9_Click(object sender, EventArgs e)
        {

             
 

            DialogResult result3 = MessageBox.Show("Visual Studio is awesome?", "The Question is",
             MessageBoxButtons.YesNoCancel,
             
             MessageBoxIcon.Error);


        }

        private void toolStripProgressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
