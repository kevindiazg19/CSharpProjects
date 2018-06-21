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
    public partial class Form1 : Form
    {

        private string connectionString = 
            ConfigurationManager.ConnectionStrings["SCHOOLConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillStudentGrid();
        }

        private void FillStudentGrid()
        {
            DataSet ds = new DataSet();
            StudentWinForm studentList = new StudentWinForm();

            ds = studentList.GetStudent(connectionString);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_School_Click(object sender, EventArgs e)
        {
            Form_Schools form2 = new Form_Schools();
            form2.Show();
        }
    }
}
