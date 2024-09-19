using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareProject2
{
    public class Employee
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"[{EmployeeNo}] {Name}";
        }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Employee)) return false;
            Employee other = (Employee)obj;
            return other.EmployeeNo.Equals(EmployeeNo) && other.Name.Equals(Name);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash= hash* 23 + EmployeeNo.GetHashCode();
            hash= hash* 23 + Name.GetHashCode();
            return hash;
        }
    }
}

