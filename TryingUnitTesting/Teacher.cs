using System;

namespace TryingUnitTesting
{
    public class Teacher
    {
        private string _name;
        private double _salary;

        public string Name
        {
            get { return _name; }
            set { CheckName(value); _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { CheckSalary(value); _salary = value; }
        }

        public Teacher(string name, double salary)
        {
            CheckName(name);
            CheckSalary(salary);
            Name = name;
            Salary = salary;
        }

        private static void CheckSalary(double salary)
        {
            if (salary < 0)
            {
                throw new ArgumentOutOfRangeException("salary", salary, "salary must be positive");
            }
        }

        private static void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is null or empty");
            }
        }

        public override string ToString()
        {
            return string.Format("Teacher({0}, {1})", Name, Salary);
        }

    }
}
