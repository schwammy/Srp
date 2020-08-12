using Shared;

namespace Srp
{
    public class Repository
    {
        public Employee GetPerson()
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

        public Manager GetManager()
        {
            return new Manager();
        }
        public Manager Add(Manager m)
        {
            return m;
        }
        public bool DeleteManager(int id)
        {
            return true;
        }
    }
}
