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
            this.Close();
        }
    }
}
