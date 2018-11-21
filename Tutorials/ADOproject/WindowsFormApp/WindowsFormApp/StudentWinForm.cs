using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using System.Configuration;

using Tuc.School.LogicTier;

namespace Tuc.School.WinFormApp
{
    class StudentWinForm
    {
        public DataSet GetStudent(string connectionString)
        {
            StudentData studentData = new StudentData();

            return studentData.GetStudentDB(connectionString);
        }

        public DataSet GetSchools(string connectionString)
        {
            StudentData schoolData = new StudentData();

            return schoolData.getSchoolsDB(connectionString);
        }

        public void insertSchool(string connectionString, string insertSQL)
        {
            StudentData schoolData = new StudentData();
            schoolData.getSchoolsDB(connectionString);
        }
    }
}
