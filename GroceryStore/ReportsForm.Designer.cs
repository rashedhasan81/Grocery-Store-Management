using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel topBar;
        private Label lblTitle;
        private ComboBox cmbProducts;
        private Button btnRefresh;
        private Button btnClose;
        private DataGridView dgvReviews;
        private Label lblStats;

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
            this.Text = "Reports - Product Reviews";
            this.ClientSize = new Size(980, 640);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Font = new Font("Segoe UI", 9.5f);
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── TOP BAR ──────────────────────────
            topBar = new Panel
            {
                Size = new Size(980, 68),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(topBar);

            lblTitle = new Label
            {
                Text = "Product Reviews",
                Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 18),
                AutoSize = true
            };
            topBar.Controls.Add(lblTitle);

            // ── PRODUCT SELECT ──────────────────
            cmbProducts = new ComboBox
            {
                Location = new Point(20, 86),
                Size = new Size(420, 28),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9.5f)
            };
            this.Controls.Add(cmbProducts);

            btnRefresh = new Button
            {
                Text = "Refresh",
                Location = new Point(456, 84),
                Size = new Size(100, 30),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRefresh.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnRefresh);

            btnClose = new Button
            {
                Text = "Close",
                Location = new Point(568, 84),
                Size = new Size(100, 30),
                BackColor = Color.LightGray,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnClose.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnClose);

            // ── STATS ───────────────────────────
            lblStats = new Label
            {
                Text = "Avg: —   Count: 0",
                Location = new Point(680, 88),
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45)
            };
            this.Controls.Add(lblStats);

            // ── DATA GRID ───────────────────────
            dgvReviews = new DataGridView
            {
                Location = new Point(20, 126),
                Size = new Size(940, 480),
                ReadOnly = true,
                AllowUserToAddRows = false,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false
            };

            dgvReviews.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 110, 58);
            dgvReviews.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvReviews.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvReviews.ColumnHeadersHeight = 36;
            dgvReviews.RowTemplate.Height = 34;
            dgvReviews.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 250, 245);
            dgvReviews.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 238, 220);
            dgvReviews.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Columns: hidden ReviewId, ProductName, Username, Rating, Comment, ReviewDate
            var colReviewId = new DataGridViewTextBoxColumn { Name = "colReviewId", Visible = false };
            var colProduct = new DataGridViewTextBoxColumn { Name = "colProduct", HeaderText = "Product", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var colUser = new DataGridViewTextBoxColumn { Name = "colUser", HeaderText = "Customer", Width = 150 };
            var colRating = new DataGridViewTextBoxColumn { Name = "colRating", HeaderText = "Rating", Width = 80 };
            var colComment = new DataGridViewTextBoxColumn { Name = "colComment", HeaderText = "Comment", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill };
            var colDate = new DataGridViewTextBoxColumn { Name = "colDate", HeaderText = "Date", Width = 150 };

            dgvReviews.Columns.AddRange(new DataGridViewColumn[] { colReviewId, colProduct, colUser, colRating, colComment, colDate });

            this.Controls.Add(dgvReviews);

            this.ResumeLayout(false);
        }
    }
}
