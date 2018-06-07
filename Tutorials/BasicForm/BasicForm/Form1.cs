using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = listCity.GetItemText(listCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String address = txtAddress.Text;

            MessageBox.Show(name + " "+ address);
        }
    }
}
