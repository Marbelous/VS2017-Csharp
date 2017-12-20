namespace DatabaseApp1
{
    partial class NewCustomer
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
            this.groupBoxAddAccount = new System.Windows.Forms.GroupBox();
            this.labelCustID = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.groupBoxCreateOrder = new System.Windows.Forms.GroupBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labelOrderAmount = new System.Windows.Forms.Label();
            this.numericUpDownOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.buttonFinishNewCustomer = new System.Windows.Forms.Button();
            this.buttonAddAnotherAccount = new System.Windows.Forms.Button();
            this.groupBoxAddAccount.SuspendLayout();
            this.groupBoxCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddAccount
            // 
            this.groupBoxAddAccount.Controls.Add(this.labelCustID);
            this.groupBoxAddAccount.Controls.Add(this.labelCustName);
            this.groupBoxAddAccount.Controls.Add(this.textBoxCustID);
            this.groupBoxAddAccount.Controls.Add(this.textBoxCustName);
            this.groupBoxAddAccount.Location = new System.Drawing.Point(12, 35);
            this.groupBoxAddAccount.Name = "groupBoxAddAccount";
            this.groupBoxAddAccount.Size = new System.Drawing.Size(294, 107);
            this.groupBoxAddAccount.TabIndex = 0;
            this.groupBoxAddAccount.TabStop = false;
            this.groupBoxAddAccount.Text = "Add Account";
            // 
            // labelCustID
            // 
            this.labelCustID.AutoSize = true;
            this.labelCustID.Location = new System.Drawing.Point(40, 64);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(68, 13);
            this.labelCustID.TabIndex = 1;
            this.labelCustID.Text = "Customer ID:";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Location = new System.Drawing.Point(40, 38);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(85, 13);
            this.labelCustName.TabIndex = 1;
            this.labelCustName.Text = "Customer Name:";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.Location = new System.Drawing.Point(131, 61);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.ReadOnly = true;
            this.textBoxCustID.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustID.TabIndex = 0;
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(131, 35);
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustName.TabIndex = 0;
            // 
            // groupBoxCreateOrder
            // 
            this.groupBoxCreateOrder.Controls.Add(this.labelOrderDate);
            this.groupBoxCreateOrder.Controls.Add(this.dateTimePickerOrderDate);
            this.groupBoxCreateOrder.Controls.Add(this.labelOrderAmount);
            this.groupBoxCreateOrder.Controls.Add(this.numericUpDownOrderAmount);
            this.groupBoxCreateOrder.Location = new System.Drawing.Point(12, 166);
            this.groupBoxCreateOrder.Name = "groupBoxCreateOrder";
            this.groupBoxCreateOrder.Size = new System.Drawing.Size(294, 107);
            this.groupBoxCreateOrder.TabIndex = 0;
            this.groupBoxCreateOrder.TabStop = false;
            this.groupBoxCreateOrder.Text = "Create Order";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(66, 73);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(59, 13);
            this.labelOrderDate.TabIndex = 3;
            this.labelOrderDate.Text = "OrderDate:";
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(131, 67);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerOrderDate.TabIndex = 2;
            // 
            // labelOrderAmount
            // 
            this.labelOrderAmount.AutoSize = true;
            this.labelOrderAmount.Location = new System.Drawing.Point(53, 35);
            this.labelOrderAmount.Name = "labelOrderAmount";
            this.labelOrderAmount.Size = new System.Drawing.Size(75, 13);
            this.labelOrderAmount.TabIndex = 1;
            this.labelOrderAmount.Text = "Order Amount:";
            // 
            // numericUpDownOrderAmount
            // 
            this.numericUpDownOrderAmount.Location = new System.Drawing.Point(131, 33);
            this.numericUpDownOrderAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownOrderAmount.Name = "numericUpDownOrderAmount";
            this.numericUpDownOrderAmount.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownOrderAmount.TabIndex = 0;
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.Location = new System.Drawing.Point(312, 119);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(99, 23);
            this.buttonCreateAccount.TabIndex = 1;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Location = new System.Drawing.Point(312, 250);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(99, 23);
            this.buttonPlaceOrder.TabIndex = 1;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // buttonFinishNewCustomer
            // 
            this.buttonFinishNewCustomer.Location = new System.Drawing.Point(366, 324);
            this.buttonFinishNewCustomer.Name = "buttonFinishNewCustomer";
            this.buttonFinishNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonFinishNewCustomer.TabIndex = 2;
            this.buttonFinishNewCustomer.Text = "Finish";
            this.buttonFinishNewCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddAnotherAccount
            // 
            this.buttonAddAnotherAccount.Location = new System.Drawing.Point(68, 324);
            this.buttonAddAnotherAccount.Name = "buttonAddAnotherAccount";
            this.buttonAddAnotherAccount.Size = new System.Drawing.Size(145, 23);
            this.buttonAddAnotherAccount.TabIndex = 3;
            this.buttonAddAnotherAccount.Text = "Add Another Account";
            this.buttonAddAnotherAccount.UseVisualStyleBackColor = true;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 359);
            this.Controls.Add(this.buttonAddAnotherAccount);
            this.Controls.Add(this.buttonFinishNewCustomer);
            this.Controls.Add(this.buttonPlaceOrder);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.groupBoxCreateOrder);
            this.Controls.Add(this.groupBoxAddAccount);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            this.groupBoxAddAccount.ResumeLayout(false);
            this.groupBoxAddAccount.PerformLayout();
            this.groupBoxCreateOrder.ResumeLayout(false);
            this.groupBoxCreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOrderAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddAccount;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.GroupBox groupBoxCreateOrder;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.Button buttonFinishNewCustomer;
        private System.Windows.Forms.Button buttonAddAnotherAccount;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label labelOrderAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownOrderAmount;
    }
}