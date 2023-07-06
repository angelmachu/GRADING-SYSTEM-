using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GRADING_SYSTEM
{
    internal class StudentData //ATM class
    {
        public School School;

        internal static string Name = "Polytechnic University of the Philippines";

        public StudentData()

        {
            List<StudentAccounts> studentRecord = new List<StudentAccounts>();
            School = new School();

            StudentAccounts student1 = new StudentAccounts
            {
                studentNumber = "000-001",
                studentPin = "1234"
            };

            StudentAccounts student2 = new StudentAccounts
            {
                studentNumber = "000-002",
                studentPin = "4321"
            };

            StudentAccounts student3 = new StudentAccounts
            {
                 studentNumber = "000-003",
                 studentPin = "1111"
            };

            studentRecord.Add(student1);
            studentRecord.Add(student2);
            studentRecord.Add(student3);

            School.StudentAccounts = studentRecord;
        }

        public StudentAccounts CheckPin(string pin, string student)
        {
            foreach (var studentaccount in School.StudentAccounts)
            {
                if (studentaccount.studentPin == pin && studentaccount.studentNumber == student)
                {
                    return studentaccount;
                }
            }

            return null;
        }
    }
}
