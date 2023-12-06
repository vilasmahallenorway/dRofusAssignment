using dRofusAssignment.Services;

namespace dRofusAssignment.Contract
{
    public class VendingMachine(List<IProduct> products) : IVendingMachine
    {
        #region Private Fields
        private decimal currentCredit;
        private readonly List<IProduct> products = products;
        #endregion

        #region Public Property/Methods
        public decimal CurrentCredit
        {
            get { return currentCredit; }
            set { currentCredit = value; }
        }
        #endregion

        #region Public Methods
        public void ListProducts()
        {
            Console.WriteLine("Available Products and Prices:");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }
            Console.WriteLine();
        }

        public void InsertMoney(decimal amount)
        {
            currentCredit += amount;
            Console.WriteLine($"Current credit is {currentCredit}");
        }

        public void RecallMoney()
        {
            Console.WriteLine($"Giving out {currentCredit}");
            currentCredit = 0;
        }

        public void OrderProduct(string productName)
        {
            var product = products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (product != null)
            {
                if (currentCredit >= product.Price)
                {

                    Console.WriteLine($"Giving out {product.Name}. Your remaining credit is : {currentCredit - product.Price}");
                    currentCredit -= product.Price;
                }
                else
                {
                    decimal missingCredit = product.Price - currentCredit;
                    Console.WriteLine($"Not enough credit, need {missingCredit} more.");
                }
            }
            else
            {
                Console.WriteLine("Invalid product name. Please enter a valid product name.");
            }
        }

        #endregion
    }
}
