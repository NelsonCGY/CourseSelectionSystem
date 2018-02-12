using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.TeacherManager
{
    class Teacher
    {
        public string workerNo;
        public string workerName;
        public string sex;
        public string deptId;
        public Teacher(string workerNo, string workerName, string sex, string deptId)
        {
            this.workerNo = workerNo;
            this.workerName = workerName;
            this.sex = sex;
            this.deptId = deptId;
        }
    }
}