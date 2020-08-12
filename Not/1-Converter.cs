using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not
{
    public class Converter
    {
        public CustomerListItemDto ToListItem(Customer c)
        {
            return new CustomerListItemDto();
        }
        public CustomerDetailDto ToDetails(Customer c)
        {
            return new CustomerDetailDto();
        }

        public Customer ToCustomer(CustomerEditDto c)
        {
            return new Customer();
        }

        public Employee ToEmployee(string a, string b, string c)
        {
            return new Employee();
        }
    }
}
