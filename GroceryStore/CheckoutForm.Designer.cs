namespace GroceryStore
{
    partial class CheckoutForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvCheckoutItems;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.RadioButton rbBkash;
        private System.Windows.Forms.RadioButton rbNagad;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.Panel pnlMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblTxn;
        private System.Windows.Forms.TextBox txtTxnId;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblCardNum;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvCheckoutItems = new DataGridView();
            lblTotalLabel = new Label();
            lblTotal = new Label();
            grpPayment = new GroupBox();
            rbBkash = new RadioButton();
            rbNagad = new RadioButton();
            rbCard = new RadioButton();
            pnlMobile = new Panel();
            lblMobile = new Label();
            txtMobile = new TextBox();
            lblTxn = new Label();
            txtTxnId = new TextBox();
            pnlCard = new Panel();
            lblCardNum = new Label();
            txtCardNumber = new TextBox();
            lblCardName = new Label();
            txtCardName = new TextBox();
            lblExpiry = new Label();
            txtExpiry = new TextBox();
            lblCvv = new Label();
            txtCvv = new TextBox();
            btnPay = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // Form
            Text = "Checkout";
            ClientSize = new Size(760, 520);
            StartPosition = FormStartPosition.CenterParent;
            Font = new Font("Segoe UI", 9.5f);
            BackColor = Color.White;

            // dgvCheckoutItems
            dgvCheckoutItems.Location = new Point(16, 16);
            dgvCheckoutItems.Size = new Size(520, 380);
            dgvCheckoutItems.ReadOnly = true;
            dgvCheckoutItems.AllowUserToAddRows = false;
            dgvCheckoutItems.RowHeadersVisible = false;
            dgvCheckoutItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCheckoutItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCheckoutItems.ColumnHeadersHeight = 36;
            dgvCheckoutItems.EnableHeadersVisualStyles = false;
            dgvCheckoutItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(27, 110, 58);
            dgvCheckoutItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCheckoutItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            dgvCheckoutItems.RowTemplate.Height = 32;
            // columns (Id hidden, Name, Price, Qty, Subtotal)
            var colId = new DataGridViewTextBoxColumn { Name = "colProductId", Visible = false };
            var colName = new DataGridViewTextBoxColumn { Name = "colProductName", HeaderText = "Product" };
            var colPrice = new DataGridViewTextBoxColumn { Name = "colPrice", HeaderText = "Price", Width = 80 };
            var colQty = new DataGridViewTextBoxColumn { Name = "colQty", HeaderText = "Qty", Width = 60 };
            var colSubtotal = new DataGridViewTextBoxColumn { Name = "colSubtotal", HeaderText = "Subtotal", Width = 90 };
            dgvCheckoutItems.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPrice, colQty, colSubtotal });

            Controls.Add(dgvCheckoutItems);

            // Total labels
            lblTotalLabel.Text = "Total:";
            lblTotalLabel.Location = new Point(360, 406);
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            lblTotalLabel.ForeColor = Color.FromArgb(25, 80, 45);
            Controls.Add(lblTotalLabel);

            lblTotal.Text = "৳ 0.00";
            lblTotal.Location = new Point(420, 404);
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(27, 110, 58);
            Controls.Add(lblTotal);

            // Payment group
            grpPayment.Text = "Payment Method";
            grpPayment.Location = new Point(548, 16);
            grpPayment.Size = new Size(196, 260);
            grpPayment.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            Controls.Add(grpPayment);

            // radio buttons
            rbBkash.Text = "bKash";
            rbBkash.Location = new Point(16, 28);
            rbBkash.AutoSize = true;
            grpPayment.Controls.Add(rbBkash);

            rbNagad.Text = "Nagad";
            rbNagad.Location = new Point(16, 58);
            rbNagad.AutoSize = true;
            grpPayment.Controls.Add(rbNagad);

            rbCard.Text = "Card (Visa/Master)";
            rbCard.Location = new Point(16, 88);
            rbCard.AutoSize = true;
            grpPayment.Controls.Add(rbCard);

            // Mobile payment panel (phone + txn)
            pnlMobile.Location = new Point(12, 120);
            pnlMobile.Size = new Size(170, 110);
            pnlMobile.BorderStyle = BorderStyle.None;
            grpPayment.Controls.Add(pnlMobile);

            lblMobile.Text = "Phone:";
            lblMobile.Location = new Point(0, 0);
            lblMobile.AutoSize = true;
            pnlMobile.Controls.Add(lblMobile);

            txtMobile.Location = new Point(0, 22);
            txtMobile.Size = new Size(168, 26);
            pnlMobile.Controls.Add(txtMobile);

            lblTxn.Text = "Transaction ID:";
            lblTxn.Location = new Point(0, 52);
            lblTxn.AutoSize = true;
            pnlMobile.Controls.Add(lblTxn);

            txtTxnId.Location = new Point(0, 74);
            txtTxnId.Size = new Size(168, 26);
            pnlMobile.Controls.Add(txtTxnId);

            // Card panel
            pnlCard.Location = new Point(12, 120);
            pnlCard.Size = new Size(170, 140);
            pnlCard.BorderStyle = BorderStyle.None;
            grpPayment.Controls.Add(pnlCard);

            lblCardNum.Text = "Card Number:";
            lblCardNum.Location = new Point(0, 0);
            lblCardNum.AutoSize = true;
            pnlCard.Controls.Add(lblCardNum);

            txtCardNumber.Location = new Point(0, 22);
            txtCardNumber.Size = new Size(168, 26);
            pnlCard.Controls.Add(txtCardNumber);

            lblCardName.Text = "Name on Card:";
            lblCardName.Location = new Point(0, 52);
            lblCardName.AutoSize = true;
            pnlCard.Controls.Add(lblCardName);

            txtCardName.Location = new Point(0, 74);
            txtCardName.Size = new Size(168, 26);
            pnlCard.Controls.Add(txtCardName);

            lblExpiry.Text = "Expiry (MM/YY):";
            lblExpiry.Location = new Point(0, 104);
            lblExpiry.AutoSize = true;
            pnlCard.Controls.Add(lblExpiry);

            txtExpiry.Location = new Point(0, 126);
            txtExpiry.Size = new Size(80, 26);
            pnlCard.Controls.Add(txtExpiry);

            lblCvv.Text = "CVV:";
            lblCvv.Location = new Point(92, 104);
            lblCvv.AutoSize = true;
            pnlCard.Controls.Add(lblCvv);

            txtCvv.Location = new Point(92, 126);
            txtCvv.Size = new Size(76, 26);
            pnlCard.Controls.Add(txtCvv);

            // Initially hide detail panels
            pnlMobile.Visible = false;
            pnlCard.Visible = false;

            // Buttons
            btnPay.Text = "Pay & Place Order";
            btnPay.Size = new Size(180, 36);
            btnPay.Location = new Point(548, 300);
            btnPay.BackColor = Color.FromArgb(27, 110, 58);
            btnPay.ForeColor = Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;
            Controls.Add(btnPay);

            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(180, 36);
            btnCancel.Location = new Point(548, 346);
            btnCancel.BackColor = Color.LightGray;
            btnCancel.ForeColor = Color.Black;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            Controls.Add(btnCancel);

            Name = "CheckoutForm";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}