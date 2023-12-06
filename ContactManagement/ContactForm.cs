using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManagement
{
    public partial class ContactForm : Form
    {
        #region Constructor
        public ContactForm()
        {
            InitializeComponent();

            // Display the list view by default
            LoadContacts();
        }
        #endregion

        #region Private Fields
        private List<Contact> contacts = ContactRepository.Instance.Contacts;
        #endregion

        #region Public Field and Property, Event, Delegate
        // Define a delegate and event for passing values
        public delegate void ValueChangedEventHandler(Contact selectedContact);
        public event ValueChangedEventHandler ValueChanged = delegate { };
        #endregion

        #region Private Methods
        private void LoadContacts()
        {
            // Create a new person object and add it to the collection

            for (int i = 1; i <= 50; i++)
            {
                contacts.Add(new Contact
                {
                    Id = i,
                    Name = $"Contact {i}",
                    Address = $"Address {i}",
                    PhoneNumber = $"Phone {i}",
                    Birthday = DateTime.Today.AddYears(-i),
                    Workplace = $"Workplace {i}"
                });
            }

            BindDataToListView();
        }

        //Bind ListView control with collection
        public void BindDataToListView()
        {
            ListView_MainContacts.Clear();
            foreach (var item in contacts)
            {
                ListView_MainContacts.Items.Add(item.Name);
            }
        }

        private void ListView_MainContacts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            foreach (ListViewItem item in this.ListView_MainContacts.SelectedItems)
            {
                Contact selectedContact = ContactRepository.Instance.Contacts.FirstOrDefault(x => x.Name == item.Text);

                // Raise the event to notify subscribers (ContactDetail form) about the value change
                OnValueChanged(selectedContact);
            }
        }

        #endregion

        #region Protected/Public Methods

        // Method to raise the ValueChanged event
        protected virtual void OnValueChanged(Contact selectedContact)
        {
            ValueChanged?.Invoke(selectedContact);
        }

        #endregion
    }
}
