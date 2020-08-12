using Shared;
using System.Collections.Generic;

namespace Not
{
    public interface ICustomerService
    {
        Customer AddCustomer(Customer c);
        Customer UpdateCustomer(Customer c);
        void RemoveCustomer(Customer c);
        List<Customer> GetCustomer();
        List<Customer> GetCustomersByProductGroup();
        List<Customer> GetCustomersByLocation(string location);
        List<string> CalculateCustomerTaxRecords(int customerId);
        List<string> GetCustomerFeedback();
        List<string> AddToShoppingCart(int customerId, string product);
        List<Customer> RankCustomersByRegion(string region);
        List<Customer> RankCustomersByProduct(string product);
        List<Customer> RankCustomersByFeedback(string product);
    }

}
