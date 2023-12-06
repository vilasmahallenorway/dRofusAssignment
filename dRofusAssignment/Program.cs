using dRofusAssignment.Contract;
using dRofusAssignment.Services;

// all products
List<IProduct> products = PopulateProducts();

// pass collection for further process
VendingMachine vendingMachine = new(products);

while (true)
{
    DisplayVendingMachineMenu();

    string userChoice = Console.ReadLine();
    PerformActionOnUserChoice(vendingMachine, userChoice);
}

static void DisplayVendingMachineMenu()
{
    Console.WriteLine("Vending Machine Menu:");
    
    Console.WriteLine("1. List all products and their corresponding prices");
    Console.WriteLine("2. Insert money");
    Console.WriteLine("3. Recall money");
    Console.WriteLine("4. Order product");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
}

static void PerformActionOnUserChoice(VendingMachine vendingMachine, string userChoice)
{
    switch (userChoice)
    {
        case "1":
            vendingMachine.ListProducts();
            break;
        case "2":
            Console.Write("Enter the amount to insert: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                vendingMachine.InsertMoney(amount);
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid numeric value.");
            }
            break;
        case "3":
            vendingMachine.RecallMoney();
            break;
        case "4":
            Console.Write("Enter the product name: ");
            string productName = Console.ReadLine();
            vendingMachine.OrderProduct(productName);
            break;
        case "5":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

static List<IProduct> PopulateProducts()
{
    return
        [
            new Product("Coke", 20),
            new Product("Fanta", 20),
            new Product("Ringnes Christmas Soda", 20),
            new Product("Limca", 20),
            new Product("Green Tea", 20),
            new Product("Hot Chocolate", 20),
            new Product("Totenflak crisps", 20),
            new Product("Pizza", 20),
            new Product("Møsbrømlefse ", 20),
            new Product("Peanøtt kubbe ", 20)
            
        ];
}