using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6. Interface
{
    internal class Employeee:ICloneable,IComparable
        {
         public int Id { get; set; }
        
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employeee() { }
        public Employeee(int id,string name,double salary) {
            Id = id;
           Name = name;
            Salary = salary;
        }

        //copy constrouctor

        public Employeee(Employeee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
           
        }
        public override string ToString()
        {
            return $"{Id}::{Name} :: {Salary}";
        }

        //methode build in by interface ICloneable
        public object Clone()
        {
            return new Employeee(this); //refer to data (attributes) in this class Employeee
        }


        //methode build in by interface IComparable
        public int CompareTo(object? obj)
        {
            Employeee employeee =  obj as Employeee;
            if (this.Salary > employeee.Salary)
                return 1;
            else if(this .Salary < employeee.Salary)
                return -1;
            else
                return 0;
        }
    }
}
