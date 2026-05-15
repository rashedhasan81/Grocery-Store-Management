using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class CustomerReview
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblOrder;
        private Label lblRating;
        private Label lblComment;

        private TextBox txtOrderId;
        private NumericUpDown numRating;
        private TextBox txtComment;

        private Button btnSubmit;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // ================= FORM =================
            this.Text = "Submit Review";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            // ================= TITLE =================
            lblTitle = new Label();
            lblTitle.Text = "Write a Review";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(100, 20);
            lblTitle.AutoSize = true;

            // ================= ORDER =================
            lblOrder = new Label();
            lblOrder.Text = "Order ID:";
            lblOrder.Location = new Point(30, 80);

            txtOrderId = new TextBox();
            txtOrderId.Location = new Point(120, 75);
            txtOrderId.Width = 200;
            txtOrderId.ReadOnly = true;

            // ================= RATING =================
            lblRating = new Label();
            lblRating.Text = "Rating (1-5):";
            lblRating.Location = new Point(30, 120);

            numRating = new NumericUpDown();
            numRating.Location = new Point(120, 115);
            numRating.Minimum = 1;
            numRating.Maximum = 5;
            numRating.Value = 5;

            // ================= COMMENT =================
            lblComment = new Label();
            lblComment.Text = "Comment:";
            lblComment.Location = new Point(30, 160);

            txtComment = new TextBox();
            txtComment.Location = new Point(120, 155);
            txtComment.Size = new Size(200, 60);
            txtComment.Multiline = true;

            // ================= BUTTONS =================
            btnSubmit = new Button();
            btnSubmit.Text = "Submit";
            btnSubmit.Size = new Size(100, 35);
            btnSubmit.Location = new Point(60, 240);
            btnSubmit.BackColor = Color.Green;
            btnSubmit.ForeColor = Color.White;
            btnSubmit.FlatStyle = FlatStyle.Flat;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.Location = new Point(200, 240);
            btnCancel.BackColor = Color.Gray;
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;

            // ================= ADD =================
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblOrder);
            this.Controls.Add(txtOrderId);
            this.Controls.Add(lblRating);
            this.Controls.Add(numRating);
            this.Controls.Add(lblComment);
            this.Controls.Add(txtComment);
            this.Controls.Add(btnSubmit);
            this.Controls.Add(btnCancel);

            this.ResumeLayout(false);
        }
    }
}