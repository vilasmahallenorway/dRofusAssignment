namespace ContactManagement
{
    partial class ContactDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewContactDetails = new ListView();
            Id = new ColumnHeader();
            ch_name = new ColumnHeader();
            ch_dob = new ColumnHeader();
            ch_phone = new ColumnHeader();
            ch_address = new ColumnHeader();
            ch_workplace = new ColumnHeader();
            btnCloseDetailsForm = new Button();
            txtName = new TextBox();
            txtDOB = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtWorkplace = new TextBox();
            btnUpdate = new Button();
            lblErrorMsg = new Label();
            lblIdHidden = new Label();
            SuspendLayout();
            // 
            // ListViewContactDetails
            // 
            ListViewContactDetails.BackColor = SystemColors.ButtonHighlight;
            ListViewContactDetails.Columns.AddRange(new ColumnHeader[] { Id, ch_name, ch_dob, ch_phone, ch_address, ch_workplace });
            ListViewContactDetails.Font = new Font("Segoe UI", 12F);
            ListViewContactDetails.ForeColor = SystemColors.Desktop;
            ListViewContactDetails.FullRowSelect = true;
            ListViewContactDetails.GridLines = true;
            ListViewContactDetails.Location = new Point(53, 47);
            ListViewContactDetails.MultiSelect = false;
            ListViewContactDetails.Name = "ListViewContactDetails";
            ListViewContactDetails.Size = new Size(756, 79);
            ListViewContactDetails.TabIndex = 1;
            ListViewContactDetails.UseCompatibleStateImageBehavior = false;
            ListViewContactDetails.View = View.Details;
            ListViewContactDetails.Click += ListViewContactDetails_Click;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 90;
            // 
            // ch_name
            // 
            ch_name.Text = "Name";
            ch_name.Width = 120;
            // 
            // ch_dob
            // 
            ch_dob.Text = "D.O.B";
            ch_dob.Width = 120;
            // 
            // ch_phone
            // 
            ch_phone.Text = "Phone";
            ch_phone.Width = 120;
            // 
            // ch_address
            // 
            ch_address.Text = "Address";
            ch_address.Width = 150;
            // 
            // ch_workplace
            // 
            ch_workplace.Text = "Workplace";
            ch_workplace.Width = 150;
            // 
            // btnCloseDetailsForm
            // 
            btnCloseDetailsForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCloseDetailsForm.Location = new Point(410, 248);
            btnCloseDetailsForm.Name = "btnCloseDetailsForm";
            btnCloseDetailsForm.Size = new Size(94, 37);
            btnCloseDetailsForm.TabIndex = 2;
            btnCloseDetailsForm.Text = "Close Form";
            btnCloseDetailsForm.UseVisualStyleBackColor = true;
            btnCloseDetailsForm.Click += btnCloseDetailsForm_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(124, 27);
            txtName.TabIndex = 3;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(264, 131);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(120, 27);
            txtDOB.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(501, 131);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(157, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(379, 131);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtWorkplace
            // 
            txtWorkplace.Location = new Point(658, 131);
            txtWorkplace.Name = "txtWorkplace";
            txtWorkplace.Size = new Size(151, 27);
            txtWorkplace.TabIndex = 7;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(274, 248);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 37);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.IndianRed;
            lblErrorMsg.Location = new Point(143, 175);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(162, 20);
            lblErrorMsg.TabIndex = 9;
            lblErrorMsg.Text = "Name fiels is required !";
            // 
            // lblIdHidden
            // 
            lblIdHidden.AutoSize = true;
            lblIdHidden.Location = new Point(788, 309);
            lblIdHidden.Name = "lblIdHidden";
            lblIdHidden.Size = new Size(0, 20);
            lblIdHidden.TabIndex = 10;
            // 
            // ContactDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 338);
            Controls.Add(lblIdHidden);
            Controls.Add(lblErrorMsg);
            Controls.Add(btnUpdate);
            Controls.Add(txtWorkplace);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtDOB);
            Controls.Add(txtName);
            Controls.Add(btnCloseDetailsForm);
            Controls.Add(ListViewContactDetails);
            ForeColor = SystemColors.Highlight;
            Name = "ContactDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact Details Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView ListViewContactDetails;
        private ColumnHeader ch_name;
        private ColumnHeader ch_dob;
        private ColumnHeader ch_phone;
        private ColumnHeader ch_address;
        private ColumnHeader ch_workplace;
        private Button btnCloseDetailsForm;
        private TextBox txtName;
        private TextBox txtDOB;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtWorkplace;
        private Button btnUpdate;
        private Label lblErrorMsg;
        private Label lblIdHidden;
        private ColumnHeader Id;
    }
}