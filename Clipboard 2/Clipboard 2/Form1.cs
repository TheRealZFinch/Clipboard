using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipboard_2
{
    public partial class Form1 : Form
    {
        string copy2 = Clipboard.GetText();
        int id = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Clipboard.GetText() != copy2)
            {
                if (!listBox1.Items.Contains(Clipboard.GetText()))
                {
                    listBox1.Items.Add(Clipboard.GetText());
                }
                copy2 = Clipboard.GetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Convert.ToString(listBox1.Items[listBox1.SelectedIndex]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[listBox1.SelectedIndex]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            id = listBox1.SelectedIndex;
            textBox1.Text = Convert.ToString(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
        }
    }
}
