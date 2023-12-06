using dRofusAssignment.Services;

namespace dRofusAssignment.Contract
{
    public class Product(string name, decimal price) : IProduct
    {
        public string Name { get; } = name;
        public decimal Price { get; } = price;
    }
}
