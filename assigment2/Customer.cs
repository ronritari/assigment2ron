//This is Customer.cs file

namespace assignment2
{
    class Customer
    {
        string name;
        int id;
        int[] purchaseIDs;

        public Customer(string name, int id, int[] purchaseIDs)
        {
            this.name = name;
            this.id = id;
            this.purchaseIDs = purchaseIDs;
        }

        public int ID()
        {
            return this.id;
        }

        public int[] PurchaseIDs()
        {
            return this.purchaseIDs;
        }

        public override string ToString()
        {
            return "customer: " + name + ", ID: " + id;
        }
    }
}