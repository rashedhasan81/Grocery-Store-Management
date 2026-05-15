namespace GroceryStore
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.NumericUpDown nudQuantity;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            btnAddToCart = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            nudQuantity = new NumericUpDown();

            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();

            // Form
            ClientSize = new Size(800, 500);
            Text = "Products";
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9.5f);
            StartPosition = FormStartPosition.CenterScreen;

            // txtSearch
            txtSearch.Location = new Point(20, 22);
            txtSearch.Size = new Size(260, 28);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5f);
            txtSearch.TabIndex = 1;

            // btnSearch
            btnSearch.Location = new Point(292, 21);
            btnSearch.Size = new Size(90, 30);
            btnSearch.Text = "Search";
            btnSearch.Font = new Font("Segoe UI", 9.5f);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(27, 110, 58);
            btnSearch.BackColor = Color.FromArgb(27, 110, 58);
            btnSearch.ForeColor = Color.White;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.TabIndex = 2;

            // dgvProducts
            dgvProducts.Location = new Point(20, 66);
            dgvProducts.Size = new Size(755, 340);
            dgvProducts.TabIndex = 0;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.BorderStyle = BorderStyle.FixedSingle;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.GridColor = Color.FromArgb(200, 230, 208);
            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.RowTemplate.Height = 34;
            dgvProducts.Font = new Font("Segoe UI", 9.5f);
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersHeight = 36;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 110, 58);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(220, 242, 230);
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 251, 246);

            // btnAddToCart
            btnAddToCart.Location = new Point(20, 424);
            btnAddToCart.Size = new Size(130, 36);
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            btnAddToCart.FlatStyle = FlatStyle.Flat;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.BackColor = Color.FromArgb(27, 110, 58);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Cursor = Cursors.Hand;
            btnAddToCart.TabIndex = 3;

            // Quantity selector
            nudQuantity.Location = new Point(170, 424);
            nudQuantity.Size = new Size(80, 36);
            nudQuantity.Minimum = 1;
            nudQuantity.Maximum = 100;
            nudQuantity.Value = 1;
            nudQuantity.Font = new Font("Segoe UI", 9.5f);
            nudQuantity.TabIndex = 4;

            Controls.Add(dgvProducts);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnAddToCart);
            Controls.Add(nudQuantity);

            Name = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}