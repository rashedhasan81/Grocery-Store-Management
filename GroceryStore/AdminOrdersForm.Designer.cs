namespace GroceryStore
{
    partial class AdminOrdersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();

            this.btnAccept = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();

            // ================= TITLE =================
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Orders";

            // ================= SEARCH =================
            this.txtSearch.Location = new System.Drawing.Point(25, 55);
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.PlaceholderText = "Search order / customer...";

            // ================= STATUS =================
            this.cmbStatus.Location = new System.Drawing.Point(260, 55);
            this.cmbStatus.Size = new System.Drawing.Size(160, 23);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[]
            {
                "All",
                "Processing",
                "Shipped",
                "Delivered",
                "Cancelled"
            });
            this.cmbStatus.SelectedIndex = 0;

            // ================= FILTER =================
            this.btnFilter.Text = "Filter";
            this.btnFilter.Location = new System.Drawing.Point(430, 54);
            this.btnFilter.Size = new System.Drawing.Size(90, 25);
            this.btnFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ================= GRID =================
            this.dgvOrders.Location = new System.Drawing.Point(25, 95);
            this.dgvOrders.Size = new System.Drawing.Size(850, 350);
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;

            // ================= BUTTONS =================

            // ACCEPT
            this.btnAccept.Text = "Accept";
            this.btnAccept.Location = new System.Drawing.Point(25, 470);
            this.btnAccept.Size = new System.Drawing.Size(140, 35);
            this.btnAccept.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // SHIP
            this.btnShip.Text = "Ship";
            this.btnShip.Location = new System.Drawing.Point(175, 470);
            this.btnShip.Size = new System.Drawing.Size(140, 35);
            this.btnShip.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShip.ForeColor = System.Drawing.Color.White;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // DELIVER
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.Location = new System.Drawing.Point(325, 470);
            this.btnDeliver.Size = new System.Drawing.Size(140, 35);
            this.btnDeliver.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDeliver.ForeColor = System.Drawing.Color.White;
            this.btnDeliver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // CANCEL
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Location = new System.Drawing.Point(475, 470);
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // PAYMENTS (new)
            this.btnPayments.Text = "Payments";
            this.btnPayments.Location = new System.Drawing.Point(625, 470);
            this.btnPayments.Size = new System.Drawing.Size(140, 35);
            this.btnPayments.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dgvOrders);

            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPayments);

            this.Text = "Admin Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvOrders;

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayments;
    }
}