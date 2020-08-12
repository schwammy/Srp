using Shared;

namespace Srp
{
    public class EmployeeRepository
    {
        public Employee GetEmployee()
        {
            return new Employee();
        }
        public Employee Add(Employee e)
        {
            return e;
        }
        public bool DeleteEmployee(int id)
        {
            return true;
        }

    }
}
