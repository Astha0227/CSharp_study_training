using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicWindowsEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Hobbies_SelectedIndex { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Hobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Current index" + Hobbies_SelectedIndex.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked Me!");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.X.ToString());
        }
    }
}
