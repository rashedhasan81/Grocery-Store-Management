using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemove;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // ── FORM ─────────────────────────────
            this.Text = "🛒  My Cart";
            this.Size = new Size(860, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── TOP BAR ──────────────────────────
            Panel topBar = new Panel
            {
                Size = new Size(860, 56),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(topBar);

            Label lblTitle = new Label
            {
                Text = "🛒  My Cart",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 14),
                AutoSize = true
            };
            topBar.Controls.Add(lblTitle);

            // ── DATA GRID ────────────────────────
            dgvCart = new DataGridView
            {
                Location = new Point(20, 72),
                Size = new Size(818, 340),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(210, 235, 215),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Font = new Font("Segoe UI", 9.5f),
                EnableHeadersVisualStyles = false
            };
            dgvCart.RowTemplate.Height = 34;
            dgvCart.ColumnHeadersHeight = 36;
            dgvCart.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 80, 45);
            dgvCart.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCart.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvCart.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(242, 250, 245);
            dgvCart.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 238, 220);
            dgvCart.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ── COLUMNS ──────────────────────────
            DataGridViewTextBoxColumn colProduct = new DataGridViewTextBoxColumn();
            colProduct.Name = "colProduct";
            colProduct.HeaderText = "Product";
            colProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCart.Columns.Add(colProduct);

            DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
            colQty.Name = "colQty";
            colQty.HeaderText = "Quantity";
            colQty.Width = 90;
            dgvCart.Columns.Add(colQty);

            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.Name = "colPrice";
            colPrice.HeaderText = "Unit Price (৳)";
            colPrice.Width = 120;
            dgvCart.Columns.Add(colPrice);

            DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
            colSubtotal.Name = "colSubtotal";
            colSubtotal.HeaderText = "Subtotal (৳)";
            colSubtotal.Width = 120;
            dgvCart.Columns.Add(colSubtotal);

            this.Controls.Add(dgvCart);

            // ── FOOTER PANEL ─────────────────────
            Panel footer = new Panel
            {
                Size = new Size(860, 70),
                Location = new Point(0, 422),
                BackColor = Color.White
            };
            this.Controls.Add(footer);

            // separator line
            Label sep = new Label
            {
                Size = new Size(820, 1),
                Location = new Point(20, 0),
                BackColor = Color.FromArgb(210, 235, 215)
            };
            footer.Controls.Add(sep);

            lblTotal = new Label
            {
                Text = "Total:  ৳ 0.00",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 20),
                AutoSize = true
            };
            footer.Controls.Add(lblTotal);

            btnRemove = new Button
            {
                Text = "Remove Item",
                Size = new Size(130, 36),
                Location = new Point(560, 17),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Color.FromArgb(176, 48, 48),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnRemove.FlatAppearance.BorderColor = Color.FromArgb(176, 48, 48);
            btnRemove.FlatAppearance.BorderSize = 1;
            footer.Controls.Add(btnRemove);

            btnCheckout = new Button
            {
                Text = "Checkout  →",
                Size = new Size(130, 36),
                Location = new Point(704, 17),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(25, 80, 45),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnCheckout.FlatAppearance.BorderSize = 0;
            footer.Controls.Add(btnCheckout);

            this.ResumeLayout(false);
        }
    }
}