using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
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

        private void btngo_Click(object sender, EventArgs e)
        {
           if(textBox1.Text=="")
           {
               MessageBox.Show("Please enter any value");
               return;

           }
           for (int i = 0; i < listBox1.Items.Count; i++)
           {
               if (textBox1.Text == listBox1.Items[i].ToString())
               {
                   MessageBox.Show("Douplicate values are not allowed");
                   textBox1.Clear();
                   textBox1.Focus();
                   return;
               }
           }
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                listBox2.Items.Add(listBox1.SelectedIndex);
            }
        }
    }
}
