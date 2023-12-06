using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dRofusAssignment.Services
{
    public interface IVendingMachine
    {
        void ListProducts();
        void InsertMoney(decimal amount);
        void RecallMoney();
        void OrderProduct(string productName);
    }
}
