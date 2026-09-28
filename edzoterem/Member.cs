using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace edzoterem
{
    public class Member
    {
        private string _name {get; set;}
        private int _age {get; set;}
        private bool _isStudent {get; set;}
        private int _visits {get; set;}
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public bool IsStudent { get { return _isStudent; } set { _isStudent = value; } }
        public int Visits { get { return _visits; } set { _visits = value; } }
        public Member(string name, int age, bool isStudent)
        {
            _name = name;
            _age = age;
            _isStudent = isStudent;
            _visits = 0;
        }
        public void CheckIn()
        {
            Visits++;
        }
        public string Describe()
        {
            string student = string.Empty;
            if (IsStudent)
            {
                student = "diák";
            }
            else
            {
                student = "normál";
            }
            return $"{Name} ({Age} éves, {student}) - {Visits} látogatás";
        }

    }
}
