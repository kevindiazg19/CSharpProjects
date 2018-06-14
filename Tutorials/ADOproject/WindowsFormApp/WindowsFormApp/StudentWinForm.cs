using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

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
    }
}
