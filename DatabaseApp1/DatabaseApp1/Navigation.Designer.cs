namespace DatabaseApp1
{
    partial class Navigation
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
            this.buttonQuitApp = new System.Windows.Forms.Button();
            this.FillCancelbutton = new System.Windows.Forms.Button();
            this.buttonAddAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonQuitApp
            // 
            this.buttonQuitApp.BackColor = System.Drawing.Color.Red;
            this.buttonQuitApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonQuitApp.FlatAppearance.BorderSize = 5;
            this.buttonQuitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitApp.Location = new System.Drawing.Point(480, 432);
            this.buttonQuitApp.Name = "buttonQuitApp";
            this.buttonQuitApp.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitApp.TabIndex = 7;
            this.buttonQuitApp.Text = "QUIT";
            this.buttonQuitApp.UseVisualStyleBackColor = false;
            this.buttonQuitApp.Click += new System.EventHandler(this.buttonQuitApp_Click);
            // 
            // FillCancelbutton
            // 
            this.FillCancelbutton.Location = new System.Drawing.Point(213, 173);
            this.FillCancelbutton.Name = "FillCancelbutton";
            this.FillCancelbutton.Size = new System.Drawing.Size(120, 23);
            this.FillCancelbutton.TabIndex = 6;
            this.FillCancelbutton.Text = "Fill or cancel an order";
            this.FillCancelbutton.UseVisualStyleBackColor = true;
            this.FillCancelbutton.Click += new System.EventHandler(this.FillCancelbutton_Click);
            // 
            // buttonAddAccount
            // 
            this.buttonAddAccount.Location = new System.Drawing.Point(217, 119);
            this.buttonAddAccount.Name = "buttonAddAccount";
            this.buttonAddAccount.Size = new System.Drawing.Size(112, 23);
            this.buttonAddAccount.TabIndex = 5;
            this.buttonAddAccount.Text = "Add an account";
            this.buttonAddAccount.UseVisualStyleBackColor = true;
            this.buttonAddAccount.Click += new System.EventHandler(this.buttonAddAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What do you want to do today?";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 467);
            this.Controls.Add(this.buttonQuitApp);
            this.Controls.Add(this.FillCancelbutton);
            this.Controls.Add(this.buttonAddAccount);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuitApp;
        private System.Windows.Forms.Button FillCancelbutton;
        private System.Windows.Forms.Button buttonAddAccount;
        private System.Windows.Forms.Label label1;
    }
}

