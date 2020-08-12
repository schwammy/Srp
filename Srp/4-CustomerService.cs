using Shared;
using System.Collections.Generic;

namespace Not
{
    public class CustomerService
    {
        public Customer AddCustomer(Customer c)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomer()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveCustomer(Customer c)
        {
            throw new System.NotImplementedException();
        }

        public Customer UpdateCustomer(Customer c)
        {
            throw new System.NotImplementedException();
        }

        public List<string> AddToShoppingCart(int customerId, string product)
        {
            throw new System.NotImplementedException();
        }

        public List<string> CalculateCustomerTaxRecords(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetCustomerFeedback()
        {
            throw new System.NotImplementedException();
        }

    }
    
    public class CustomerSearchService
    {
        public List<Customer> GetCustomersByLocation(string location)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> GetCustomersByProductGroup()
        {
            throw new System.NotImplementedException();
        }
    }

    public class CustomerRankingService
    {
        public List<Customer> RankCustomersByFeedback(string product)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> RankCustomersByProduct(string product)
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> RankCustomersByRegion(string region)
        {
            throw new System.NotImplementedException();
        }
    }
}
