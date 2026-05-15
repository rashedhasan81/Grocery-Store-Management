using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class AdminPaymentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvPayments;
        private Button btnRefresh;
        private Button btnClose;

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

            // Form
            this.Text = "Payments";
            this.Size = new Size(900, 560);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Top bar
            Panel topBar = new Panel
            {
                Size = new Size(900, 56),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(topBar);

            Label lblTitle = new Label
            {
                Text = "Payments History",
                Font = new Font("Segoe UI", 13f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 14),
                AutoSize = true
            };
            topBar.Controls.Add(lblTitle);

            // Data grid
            dgvPayments = new DataGridView
            {
                Location = new Point(20, 72),
                Size = new Size(840, 400),
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
            dgvPayments.RowTemplate.Height = 34;
            dgvPayments.ColumnHeadersHeight = 36;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 80, 45);
            dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvPayments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 250, 245);
            dgvPayments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 238, 220);
            dgvPayments.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Columns
            var cId = new DataGridViewTextBoxColumn { Name = "PaymentId", HeaderText = "ID", Width = 60 };
            var cOrder = new DataGridViewTextBoxColumn { Name = "OrderId", HeaderText = "Order ID", Width = 80 };
            var cCustomer = new DataGridViewTextBoxColumn { Name = "Customer", HeaderText = "Customer", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var cMethod = new DataGridViewTextBoxColumn { Name = "Method", HeaderText = "Method", Width = 100 };
            var cAmount = new DataGridViewTextBoxColumn { Name = "Amount", HeaderText = "Amount (৳)", Width = 110 };
            var cPaidAt = new DataGridViewTextBoxColumn { Name = "PaidAt", HeaderText = "Paid At", Width = 150 };
            var cDetails = new DataGridViewTextBoxColumn { Name = "Details", HeaderText = "Details", Visible = false };

            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { cId, cOrder, cCustomer, cMethod, cAmount, cPaidAt, cDetails });

            this.Controls.Add(dgvPayments);

            // Buttons
            btnRefresh = new Button
            {
                Text = "Refresh",
                Size = new Size(100, 36),
                Location = new Point(20, 486),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                Cursor = Cursors.Hand
            };
            btnRefresh.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnRefresh);

            btnClose = new Button
            {
                Text = "Close",
                Size = new Size(100, 36),
                Location = new Point(760, 486),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnClose);

            this.ResumeLayout(false);
        }
    }
}