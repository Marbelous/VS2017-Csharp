namespace DatabaseApp1
{
    partial class FillOrCancel
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
            this.labelOrderID = new System.Windows.Forms.Label();
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.buttonFindOrder = new System.Windows.Forms.Button();
            this.labelFillDate = new System.Windows.Forms.Label();
            this.dateTimePickerFillDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCancelOrder = new System.Windows.Forms.Button();
            this.buttonFillOrder = new System.Windows.Forms.Button();
            this.buttonFillCancelFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(82, 17);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(50, 13);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID:";
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(138, 12);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderID.TabIndex = 1;
            // 
            // buttonFindOrder
            // 
            this.buttonFindOrder.Location = new System.Drawing.Point(244, 12);
            this.buttonFindOrder.Name = "buttonFindOrder";
            this.buttonFindOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonFindOrder.TabIndex = 2;
            this.buttonFindOrder.Text = "Find Order";
            this.buttonFindOrder.UseVisualStyleBackColor = true;
            // 
            // labelFillDate
            // 
            this.labelFillDate.AutoSize = true;
            this.labelFillDate.Location = new System.Drawing.Point(66, 59);
            this.labelFillDate.Name = "labelFillDate";
            this.labelFillDate.Size = new System.Drawing.Size(147, 13);
            this.labelFillDate.TabIndex = 3;
            this.labelFillDate.Text = "If filling an order, specify date:";
            // 
            // dateTimePickerFillDate
            // 
            this.dateTimePickerFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFillDate.Location = new System.Drawing.Point(219, 53);
            this.dateTimePickerFillDate.Name = "dateTimePickerFillDate";
            this.dateTimePickerFillDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerFillDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(421, 170);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonCancelOrder
            // 
            this.buttonCancelOrder.Location = new System.Drawing.Point(67, 289);
            this.buttonCancelOrder.Name = "buttonCancelOrder";
            this.buttonCancelOrder.Size = new System.Drawing.Size(84, 23);
            this.buttonCancelOrder.TabIndex = 6;
            this.buttonCancelOrder.Text = "Cancel Order";
            this.buttonCancelOrder.UseVisualStyleBackColor = true;
            // 
            // buttonFillOrder
            // 
            this.buttonFillOrder.Location = new System.Drawing.Point(171, 289);
            this.buttonFillOrder.Name = "buttonFillOrder";
            this.buttonFillOrder.Size = new System.Drawing.Size(84, 23);
            this.buttonFillOrder.TabIndex = 6;
            this.buttonFillOrder.Text = "Fill Order";
            this.buttonFillOrder.UseVisualStyleBackColor = true;
            // 
            // buttonFillCancelFinish
            // 
            this.buttonFillCancelFinish.Location = new System.Drawing.Point(349, 289);
            this.buttonFillCancelFinish.Name = "buttonFillCancelFinish";
            this.buttonFillCancelFinish.Size = new System.Drawing.Size(84, 23);
            this.buttonFillCancelFinish.TabIndex = 6;
            this.buttonFillCancelFinish.Text = "Finish";
            this.buttonFillCancelFinish.UseVisualStyleBackColor = true;
            // 
            // FillOrCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 331);
            this.Controls.Add(this.buttonFillCancelFinish);
            this.Controls.Add(this.buttonFillOrder);
            this.Controls.Add(this.buttonCancelOrder);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerFillDate);
            this.Controls.Add(this.labelFillDate);
            this.Controls.Add(this.buttonFindOrder);
            this.Controls.Add(this.textBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Name = "FillOrCancel";
            this.Text = "FillOrCancel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.Button buttonFindOrder;
        private System.Windows.Forms.Label labelFillDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFillDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCancelOrder;
        private System.Windows.Forms.Button buttonFillOrder;
        private System.Windows.Forms.Button buttonFillCancelFinish;
    }
}