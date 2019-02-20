namespace PhoneBookExampleCSV
{
    partial class Form1
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
            this.btnGetAllPhoneNumbers = new System.Windows.Forms.Button();
            this.btnActivatePhoneNumber = new System.Windows.Forms.Button();
            this.lstvPhoneNumbers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbPhoneNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAllPhoneNumbers
            // 
            this.btnGetAllPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnGetAllPhoneNumbers.Location = new System.Drawing.Point(100, 30);
            this.btnGetAllPhoneNumbers.Name = "btnGetAllPhoneNumbers";
            this.btnGetAllPhoneNumbers.Size = new System.Drawing.Size(190, 70);
            this.btnGetAllPhoneNumbers.TabIndex = 0;
            this.btnGetAllPhoneNumbers.Text = "Get all phone numbers";
            this.btnGetAllPhoneNumbers.UseVisualStyleBackColor = true;
            this.btnGetAllPhoneNumbers.Click += new System.EventHandler(this.btnGetAllPhoneNumbers_Click);
            // 
            // btnActivatePhoneNumber
            // 
            this.btnActivatePhoneNumber.Enabled = false;
            this.btnActivatePhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnActivatePhoneNumber.Location = new System.Drawing.Point(510, 30);
            this.btnActivatePhoneNumber.Name = "btnActivatePhoneNumber";
            this.btnActivatePhoneNumber.Size = new System.Drawing.Size(190, 70);
            this.btnActivatePhoneNumber.TabIndex = 2;
            this.btnActivatePhoneNumber.Text = "Activate phone number";
            this.btnActivatePhoneNumber.UseVisualStyleBackColor = true;
            this.btnActivatePhoneNumber.Click += new System.EventHandler(this.btnActivatePhoneNumber_Click);
            // 
            // lstvPhoneNumbers
            // 
            this.lstvPhoneNumbers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstvPhoneNumbers.FullRowSelect = true;
            this.lstvPhoneNumbers.Location = new System.Drawing.Point(100, 220);
            this.lstvPhoneNumbers.Name = "lstvPhoneNumbers";
            this.lstvPhoneNumbers.Size = new System.Drawing.Size(600, 260);
            this.lstvPhoneNumbers.TabIndex = 3;
            this.lstvPhoneNumbers.UseCompatibleStateImageBehavior = false;
            this.lstvPhoneNumbers.View = System.Windows.Forms.View.Details;
            this.lstvPhoneNumbers.SelectedIndexChanged += new System.EventHandler(this.lstvPhoneNumbers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Surname";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone Number";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Activated";
            this.columnHeader4.Width = 150;
            // 
            // cmbPhoneNames
            // 
            this.cmbPhoneNames.Enabled = false;
            this.cmbPhoneNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbPhoneNames.FormattingEnabled = true;
            this.cmbPhoneNames.Location = new System.Drawing.Point(510, 140);
            this.cmbPhoneNames.Name = "cmbPhoneNames";
            this.cmbPhoneNames.Size = new System.Drawing.Size(190, 28);
            this.cmbPhoneNames.TabIndex = 4;
            this.cmbPhoneNames.SelectedIndexChanged += new System.EventHandler(this.cmbPhoneNames_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(96, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Get all phone numbers of a single customer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPhoneNames);
            this.Controls.Add(this.lstvPhoneNumbers);
            this.Controls.Add(this.btnActivatePhoneNumber);
            this.Controls.Add(this.btnGetAllPhoneNumbers);
            this.Name = "Form1";
            this.Text = "PhoneBookExampleCSV (by Anastasios Markoulidis)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAllPhoneNumbers;
        private System.Windows.Forms.Button btnActivatePhoneNumber;
        private System.Windows.Forms.ListView lstvPhoneNumbers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbPhoneNames;
        private System.Windows.Forms.Label label1;
    }
}

