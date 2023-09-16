
namespace assignment2
{
    class Program
    {

        static void Main()
        {
            // customers and purchases
            Customer[] customers = new Customer[]
            {
                new Customer("ron", 1, new int[] { 101, 102 }),
                new Customer("miika", 2, new int[] { 103 }),
                
            };

            Purchase[] purchases = new Purchase[]
            {
                new Purchase(101, "14.9.2023", 50.0, new string[] { "jeans", "t-shirt" }),
                new Purchase(102, "15.9.2023", 30.0, new string[] { "dvd" }),
                new Purchase(103, "16.9.2023", 25.0, new string[] { "book", "umbrella" }),
               
            };

            CustomerPurchaseHandler handler = new CustomerPurchaseHandler(customers, purchases);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Choose:");
                Console.WriteLine("1. search by Customer ID");
                Console.WriteLine("2. search by Purchase ID");
                Console.WriteLine("3. exit");
                Console.Write("enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //Lists the customer name and id to search
                        Console.WriteLine("customer IDs:");
                        foreach (Customer customer in customers)
                        {
                            Console.WriteLine(customer.ToString());
                        }

                        Console.Write("enter customer ID to search: ");
                        if (int.TryParse(Console.ReadLine(), out int customerIdToSearch))
                        {
                            string customerInfo = handler.SearchCustomer(customerIdToSearch);
                            Console.WriteLine(customerInfo);
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case "2":
                        //lists the purchases but no names
                        Console.WriteLine("purchase IDs:");
                        foreach (Purchase purchase in purchases)
                        {
                            Console.WriteLine("purchase ID: " + purchase.ID());
                        }

                        Console.Write("enter purchase ID to search: ");
                        if (int.TryParse(Console.ReadLine(), out int purchaseIdToSearch))
                        {
                            string purchaseInfo = handler.SearchPurchase(purchaseIdToSearch);
                            Console.WriteLine(purchaseInfo);
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
            }
        }
        
    }
}