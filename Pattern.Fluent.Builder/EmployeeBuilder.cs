using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fluent.Builder
{
    public abstract class EmployeeBuilder
    {
        protected Employee _employee;

        public EmployeeBuilder()
        {
            _employee = new Employee();
        }

        public Employee Build() => _employee;
    }
}