using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class OrdersForm
    {
        private DataGridView dgvOrders;
        private Label lblTitle;

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // ================= FORM =================
            this.Text = "📦 My Orders";
            this.Size = new Size(850, 520);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ================= TOP BAR =================
            Panel topBar = new Panel
            {
                Size = new Size(850, 60),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(topBar);

            lblTitle = new Label
            {
                Text = "📦 My Orders",
                Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 16),
                AutoSize = true
            };
            topBar.Controls.Add(lblTitle);

            // ================= DATAGRID =================
            dgvOrders = new DataGridView
            {
                Location = new Point(20, 80),
                Size = new Size(800, 380),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                GridColor = Color.FromArgb(220, 235, 220),
                Font = new Font("Segoe UI", 9.5f),
                EnableHeadersVisualStyles = false
            };

            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 80, 45);
            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dgvOrders.ColumnHeadersHeight = 38;

            dgvOrders.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 250, 245);
            dgvOrders.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 238, 220);
            dgvOrders.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvOrders.RowTemplate.Height = 35;

            // ── Columns (hidden raw OrderId, displayed Order Label, Date, Products, Total, Status, Review button)
            var colOrderIdRaw = new DataGridViewTextBoxColumn { Name = "colOrderIdRaw", Visible = false };
            var colOrderLabel = new DataGridViewTextBoxColumn { Name = "colOrderLabel", HeaderText = "Order ID", Width = 110 };
            var colDate = new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Date", Width = 100 };
            var colProducts = new DataGridViewTextBoxColumn { Name = "colProducts", HeaderText = "Products", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var colTotal = new DataGridViewTextBoxColumn { Name = "colTotal", HeaderText = "Total", Width = 100 };
            var colStatus = new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", Width = 110 };
            var colReview = new DataGridViewButtonColumn { Name = "colReview", HeaderText = "", Text = "Review", UseColumnTextForButtonValue = true, Width = 90 };

            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderIdRaw, colOrderLabel, colDate, colProducts, colTotal, colStatus, colReview });

            this.Controls.Add(dgvOrders);

            this.ResumeLayout(false);
        }
    }
}