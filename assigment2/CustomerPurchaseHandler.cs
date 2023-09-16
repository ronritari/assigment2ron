using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    internal class CustomerPurchaseHandler
    {
        Customer[] customers;
        Purchase[] purchases;

        public CustomerPurchaseHandler(Customer[] customers, Purchase[] purchases)
        {
            this.customers = customers;
            this.purchases = purchases;
        }

        public string SearchCustomer(int customerId)
        {
            // search customer by id and return customer and purchase information
            StringBuilder result = new StringBuilder();
            foreach (Customer customer in customers)
            {
                if (customer.ID() == customerId)
                {
                    result.AppendLine(customer.ToString());
                    foreach (int purchaseId in customer.PurchaseIDs())
                    {
                        Purchase purchase = FindPurchaseById(purchaseId);
                        if (purchase != null)
                        {
                            result.AppendLine(purchase.ToString());
                        }
                    }
                }
            }
            return result.ToString();
        }

        public string SearchPurchase(int purchaseId)
        {
            // search purchase by id and return purchase and customer information
            Purchase purchase = FindPurchaseById(purchaseId);
            if (purchase != null)
            {
                StringBuilder result = new StringBuilder();
                result.AppendLine(purchase.ToString());
                foreach (Customer customer in customers)
                {
                    if (Array.Exists(customer.PurchaseIDs(), id => id == purchaseId))
                    {
                        result.AppendLine(customer.ToString());
                    }
                }
                return result.ToString();
            }
            else
            {
                return "purchase not found.";
            }
        }

        private Purchase FindPurchaseById(int purchaseId)
        {
            foreach (Purchase purchase in purchases)
            {
                if (purchase.ID() == purchaseId)
                {
                    return purchase;
                }
            }
            return null;
        }
    }
}

