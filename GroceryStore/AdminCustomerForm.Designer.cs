namespace GroceryStore
{
    partial class AdminCustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer

        private void InitializeComponent()
        {
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();

            // TITLE
            this.Text = "Admin Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(900, 550);

            // SEARCH
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Size = new System.Drawing.Size(250, 25);
            this.txtSearch.PlaceholderText = "Search username / phone";

            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(280, 20);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // GRID
            this.dgvCustomers.Location = new System.Drawing.Point(20, 60);
            this.dgvCustomers.Size = new System.Drawing.Size(850, 350);
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);

            // ADD
            this.btnAdd.Text = "Add";
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 430);
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // UPDATE
            this.btnUpdate.Text = "Update";
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(160, 430);
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // DELETE
            this.btnDelete.Text = "Delete";
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(300, 430);
            this.btnDelete.Size = new System.Drawing.Size(120, 35);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // ADD CONTROLS
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}