using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cybershield_project2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            if (selectedItem == "Add TV")
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox5.Enabled = false;

            }
            if (selectedItem == "Add Fridge")
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                groupBox5.Enabled = false;
            }
            if (selectedItem == "Add Stove")
            {
                groupBox5.Enabled = true;
                groupBox3.Enabled = false;
                groupBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tvid = textBox1.Text;
            Tv TV = new Tv(id:tvid, model:textBox2.Text , brand: textBox4.Text, price:textBox3.Text, size: textBox5.Text, res_time: textBox6.Text);
            
            My_database.AddProduct(tvid , TV);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }
    }
}
