using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.Fluent.Builder
{
    public class EmployeePositionBuilder<T>: EmployeeInfoBuilder<EmployeePositionBuilder<T>> where T: EmployeePositionBuilder<T>
    {
        public T AtPosition(string position)
        {
            _employee.Position = position;
            return (T)this;
        }
    }
}