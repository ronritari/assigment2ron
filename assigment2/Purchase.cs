using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Purchase
    {
        int id;
        string date;
        double amount;
        string[] productNames;

        public Purchase(int id, string date, double amount, string[] productNames)
        {
            this.id = id;
            this.date = date;
            this.amount = amount;
            this.productNames = productNames;
        }

        public int ID()
        {
            return this.id;
        }

        public string[] ProductNames()
        {
            return this.productNames;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("purchase ID: " + id);
            sb.AppendLine("date: " + date);
            sb.AppendLine("amount: " + amount + "£");

            sb.AppendLine("products:");
            //lists the products
            foreach (string productName in productNames)
            {
                sb.AppendLine("  - " + productName);
            }

            return sb.ToString();
        }
    }
}