using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentsDBC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
        }

        private void Form1_Load()
        {
            cmbxGen.Items.Add("Male");
            cmbxGen.Items.Add("Female");
            Display();
        }

        public void Display()
        {
            using (StudentInformationEntities _entity=new StudentInformationEntities())
            {
                List<StudentInformation> _studentList = new List<StudentInformation>();
                _studentList = _entity.StudentDetails.Select(x => new StudentInformation
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();
                dataGridView1.DataSource = _studentList;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            StudentDetail stu = new StudentDetail();
            stu.Name = textBox_name.Text;
            stu.Age = Convert.ToInt32(textBox_age.Text);
            stu.City = textBox_city.Text;
            stu.Gender = cmbxGen.SelectedItem.ToString();
            bool result = SaveStudentDetails(stu);
            ShowStatus(result, "Save");
            //MessageBox.Show("Saved successfully");
            //Display();
        }

        public bool SaveStudentDetails(StudentDetail Stu)
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                _entity.StudentDetails.Add(Stu);//HERE AddObject? where
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        //HELP HERE!!! :O
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.Rows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //        {
        //            label_id_hid.Text = row.Cells[0].Value.ToString();
        //            textBox_name.Text = row.Cells[1].Value.ToString();
        //            textBox_age.Text = row.Cells[2].Value.ToString();
        //            textBox_city.Text = row.Cells[3].Value.ToString();
        //            cmbxGen.SelectedItem = row.Cells[4].Value.ToString();
        //        }
                
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbxGen.Items.Add("Male");
            cmbxGen.Items.Add("Female");
            Display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                //{
                    label_id_hid.Text = row.Cells[0].Value.ToString();
                    textBox_name.Text = row.Cells[1].Value.ToString();
                    textBox_age.Text = row.Cells[2].Value.ToString();
                    textBox_city.Text = row.Cells[3].Value.ToString();
                    cmbxGen.SelectedItem = row.Cells[4].Value.ToString();
                //}

            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //Binding values to Student InformationModel
            StudentDetail stu = SetValues(Convert.ToInt32(label_id_hid.Text), textBox_name.Text, Convert.ToInt32(textBox_age.Text), textBox_city.Text, cmbxGen.SelectedItem.ToString());
            bool result = UpdateStudentDetails(stu);
            ShowStatus(result, "Update");
        }

        public bool UpdateStudentDetails(StudentDetail Stu)
        {
            bool result = false;
            using(StudentInformationEntities _entity = new StudentInformationEntities())
            {
                StudentDetail _student = _entity.StudentDetails.Where(x => x.Id == Stu.Id).Select(x => x).FirstOrDefault();
                _student.Name = Stu.Name;
                _student.Age = Stu.Age;
                _student.City = Stu.City;
                _student.Gender = Stu.Gender;
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }

        public StudentDetail SetValues(int Id, string Name, int age, string City, string Gender)
        {
            StudentDetail stu = new StudentDetail();
            stu.Id = Id;
            stu.Name = Name;
            stu.Age = age;
            stu.City = City;
            stu.Gender = Gender;
            return stu;
        }

        public void ShowStatus(bool result, string Action) //Validate operations status
        {
            if (result)
            {
                if (Action.ToUpper()== "SAVE")
                {
                    MessageBox.Show("Saved Successfuly!..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Updated Successfully!..", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Successfully!..", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ClearFields();
            Display();
        }

        public void ClearFields() //Clear fields after insert or update
        {
            textBox_name.Text = "";
            textBox_age.Text = "";
            textBox_city.Text = "";
            cmbxGen.SelectedIndex = -1;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            StudentDetail stu = SetValues(Convert.ToInt32(label_id_hid.Text), textBox_name.Text, Convert.ToInt32(textBox_age.Text), textBox_city.Text, cmbxGen.SelectedItem.ToString());
            bool result = DeleteStudentDetails(stu);
            ShowStatus(result, "Delete");
        }

        public bool DeleteStudentDetails(StudentDetail Stu)
        {
            bool result = false;
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                StudentDetail _student = _entity.StudentDetails.Where(x => x.Id == Stu.Id).Select(x => x).FirstOrDefault();
                _entity.StudentDetails.Remove(_student);
                _entity.SaveChanges();
                result = true;
            }
            return result;
        }
    }
}
