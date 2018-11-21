using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using Tuc.School.WinFormApp;

namespace WindowsFormApp
{
    public partial class Form_Schools : Form
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["SCHOOLConnectionString"].ConnectionString;

        public Form_Schools()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fillSchools();
        }

        private void fillSchools()
        {
            DataSet ds = new DataSet();
            StudentWinForm schoolList = new StudentWinForm();

            ds = schoolList.GetSchools(connectionString);

            dataGrid_schools.DataSource = ds.Tables[0];

            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            labelID.Text = "";
            txtBx_Name.Text = "";
            txtBx_Description.Text = "";
            txtBx_Address.Text = "";
            txtBx_Phone.Text = "";
            txtBx_postCode.Text = "";
            txtBx_PostAddress.Text = "";
            groupBoxNew.Enabled = false;
            buttonEdit.Enabled = true;
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            labelID.Text = "";
            txtBx_Name.Text = "";
            txtBx_Description.Text = "";
            txtBx_Address.Text = "";
            txtBx_Phone.Text = "";
            txtBx_postCode.Text = "";
            txtBx_PostAddress.Text = "";
            groupBoxNew.Enabled = true;
            buttonEdit.Enabled = false;
        }

        private void dataGrid_schools_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_schools.Rows.Count > 0)
            {
                var row = dataGrid_schools.Rows[e.RowIndex];
                labelID.Text = row.Cells[0].Value.ToString();
                txtBx_Name.Text = row.Cells[1].Value.ToString();
                txtBx_Description.Text = row.Cells[2].Value.ToString();
                txtBx_Address.Text = row.Cells[3].Value.ToString();
                txtBx_Phone.Text = row.Cells[4].Value.ToString();
                txtBx_postCode.Text = row.Cells[5].Value.ToString();
                txtBx_PostAddress.Text = row.Cells[6].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            groupBoxNew.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Name = txtBx_Name.Text.ToString();
            string Desc = txtBx_Description.Text.ToString();
            string Addr = txtBx_Address.Text.ToString();
            string Phn = txtBx_Phone.Text.ToString();
            string PstCde = txtBx_postCode.Text.ToString();
            string PstAddr = txtBx_PostAddress.Text.ToString();

            var insert = string.Format("INSERT INTO School(SchoolName, Description, Address, Phone, PostCode, PostAddress) " +
                "VALUES({0}, {1}, {2}, {3}, {4}, {5}) ", Name, Desc, Addr, Phn, PstCde, PstAddr);


        }
    }
}
