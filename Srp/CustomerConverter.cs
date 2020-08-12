using Shared;

namespace Srp
{
    public class CustomerConverter
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
    }
}
