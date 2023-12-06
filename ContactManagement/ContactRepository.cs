using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagement
{
    public class ContactRepository
    {
        private static ContactRepository instance;
        private List<Contact> contacts;

        private ContactRepository()
        {
            // Initialize the collection
            contacts = new List<Contact>();
        }

        public static ContactRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactRepository();
                }
                return instance;
            }
        }

        public List<Contact> Contacts
        {
            get { return contacts; }
        }
    }
}
