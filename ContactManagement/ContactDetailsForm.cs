using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContactManagement
{
    public partial class ContactDetailsForm : Form
    {
        #region Private Fields
        private ContactForm contactFormInstance;

        // Access the shared collection from Form2
        private List<Contact> contacts = ContactRepository.Instance.Contacts;
        #endregion

        #region Constructor
        public ContactDetailsForm(ContactForm contactForm)
        {
            InitializeComponent();

            // Subscribe to the ValueChanged event of contactForm
            this.contactFormInstance = contactForm;
            this.contactFormInstance.ValueChanged += ContactForm_ValueChanged;

            // Attach the event handler to the FormClosing event
            this.FormClosing += ContactDetailsForm_FormClosing;
        }

        #endregion

        #region Private Methods

        // Event handler for the ValueChanged event of contactForm
        private void ContactForm_ValueChanged(Contact selectedContact)
        {
            if (selectedContact is null) return;

            // Update controls in Form2 based on the received value
            ListViewContactDetails.Items.Clear();
            ListViewItem listViewItem = new(selectedContact.Id.ToString());
            listViewItem.SubItems.Add(selectedContact.Name);
            listViewItem.SubItems.Add(selectedContact.Birthday.ToShortDateString());
            listViewItem.SubItems.Add(selectedContact.PhoneNumber);
            listViewItem.SubItems.Add(selectedContact.Address);
            listViewItem.SubItems.Add(selectedContact.Workplace);

            ListViewContactDetails.Items.Add(listViewItem);
        }

        // As soon as user select row all respective field value should copied to associated textbox for updation
        private void ListViewContactDetails_Click(object sender, EventArgs e)
        {
            lblIdHidden.Text = ListViewContactDetails.SelectedItems[0].SubItems[0].Text;
            txtName.Text = ListViewContactDetails.SelectedItems[0].SubItems[1].Text;
            txtDOB.Text = ListViewContactDetails.SelectedItems[0].SubItems[2].Text;
            txtPhone.Text = ListViewContactDetails.SelectedItems[0].SubItems[3].Text;
            txtAddress.Text = ListViewContactDetails.SelectedItems[0].SubItems[4].Text;
            txtWorkplace.Text = ListViewContactDetails.SelectedItems[0].SubItems[5].Text;
        }

        /// <summary>
        /// Update contact details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            { lblErrorMsg.Visible = true; return; }
            else { lblErrorMsg.Visible = false; }

            Contact updatedContact = new()
            {
                Id = Convert.ToInt32(lblIdHidden.Text),
                Name = txtName.Text,
                Birthday = Convert.ToDateTime(txtDOB.Text),
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Workplace = txtWorkplace.Text
            };
            ContactForm_ValueChanged(updatedContact);

            // Find the person in the collection
            Contact selectedContact = contacts.FirstOrDefault(p => p.Id == updatedContact.Id);

            if (selectedContact != null)
            {
                // Update the properties of the selected person
                ContactRepository.Instance.Contacts.Remove(selectedContact);
                ContactRepository.Instance.Contacts.Add(updatedContact);


                // Verify If Contact list changed
                List<Contact> lst = ContactRepository.Instance.Contacts.ToList();

                ClearAllTextboxes(this);
            }
        }

        #endregion

        #region Close button functionality

        private void btnCloseDetailsForm_Click(object sender, EventArgs e)
        {
            this.Close();
            ClearAllTextboxes(this);
            contactFormInstance.BindDataToListView();
        }

        private void ContactDetailsForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            ClearAllTextboxes(this);
            contactFormInstance.BindDataToListView();
        }

        #endregion

        #region Cleanup Controls

        /// <summary>
        /// Clear all textboxes 
        /// </summary>
        /// <param name="control"></param>
        private static void ClearAllTextboxes(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = string.Empty;
                }
            }
        }
        
        #endregion
    }
}
