namespace ContactManagement
{
    partial class ContactForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListView_MainContacts = new ListView();
            lblContact = new Label();
            SuspendLayout();
            // 
            // ListView_MainContacts
            // 
            ListView_MainContacts.BackColor = SystemColors.MenuHighlight;
            ListView_MainContacts.Font = new Font("Verdana", 12F);
            ListView_MainContacts.ForeColor = Color.Black;
            ListView_MainContacts.FullRowSelect = true;
            ListView_MainContacts.GridLines = true;
            ListView_MainContacts.Location = new Point(123, 81);
            ListView_MainContacts.MultiSelect = false;
            ListView_MainContacts.Name = "ListView_MainContacts";
            ListView_MainContacts.Size = new Size(678, 506);
            ListView_MainContacts.TabIndex = 1;
            ListView_MainContacts.UseCompatibleStateImageBehavior = false;
            ListView_MainContacts.View = View.List;
            ListView_MainContacts.ItemSelectionChanged += ListView_MainContacts_ItemSelectionChanged;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblContact.ForeColor = SystemColors.HotTrack;
            lblContact.Location = new Point(123, 43);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(154, 35);
            lblContact.TabIndex = 2;
            lblContact.Text = "Contact List";
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1013, 600);
            Controls.Add(lblContact);
            Controls.Add(ListView_MainContacts);
            Name = "ContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView ListView_MainContacts;
        private Label lblContact;
    }
}
