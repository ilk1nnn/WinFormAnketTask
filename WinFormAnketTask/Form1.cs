using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAnketTask
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

        private void nametxtbox_TextChanged(object sender, EventArgs e)
        {
            if(nametxtbox.Text.Length == 0)
            {
                nameshould.Text = "*name should be filled.";
            }
            else
            {
                nameshould.Text = String.Empty;
            }
        }

        private void surname_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (surname_txtbox.Text.Length == 0)
            {
                surnameshould.Text = "*surname should be filled.";
            }
            else
            {
                surnameshould.Text = String.Empty;
            }
        }

        private void age_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (age_txtbox.Text.Length == 0)
            {
                ageshould.Text = "*age should be filled.";
            }
            else
            {
                ageshould.Text = String.Empty;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if(nametxtbox.Text.Length>0 && surname_txtbox.Text.Length > 0 && age_txtbox.Text.Length>0)
            {
                MessageBox.Show("You Registred Successfully!");
            }
            else
            {

                MessageBox.Show("You must Fill All Textboxes for registrating!");

            }
        }
    }
}
