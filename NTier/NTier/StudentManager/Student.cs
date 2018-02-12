using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.StudentManager
{
    class Student
    {
        public string no, name, sex, birthday, deptId;
        public Student(string no, string name, string sex, string birthday, string deptId)
        {
            this.no = no;
            this.name = name;
            this.sex = sex;
            this.birthday = birthday;
            this.deptId = deptId;
        }    

    }
}
