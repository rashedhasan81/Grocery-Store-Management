using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroceryStore
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Label lblName;
        private Label lblEmail;
        private Label lblPhone;

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;

        private Button btnUpdate;

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
            this.Text = "👤 My Profile";
            this.Size = new Size(600, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(244, 248, 245);
            this.Font = new Font("Segoe UI", 9.5f);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ================= TOP BAR =================
            Panel topBar = new Panel
            {
                Size = new Size(600, 60),
                Location = new Point(0, 0),
                BackColor = Color.White
            };
            this.Controls.Add(topBar);

            lblTitle = new Label
            {
                Text = "👤 My Profile",
                Font = new Font("Segoe UI", 14f, FontStyle.Bold),
                ForeColor = Color.FromArgb(25, 80, 45),
                Location = new Point(20, 16),
                AutoSize = true
            };
            topBar.Controls.Add(lblTitle);

            // ================= NAME =================
            lblName = CreateLabel("Username:", 80);
            txtName = CreateTextBox(80, true);

            // ================= EMAIL =================
            lblEmail = CreateLabel("Email:", 140);
            txtEmail = CreateTextBox(140, false);

            // ================= PHONE =================
            lblPhone = CreateLabel("Phone:", 200);
            txtPhone = CreateTextBox(200, false);

            // ================= UPDATE BUTTON =================
            btnUpdate = new Button
            {
                Text = "💾 Update Profile",
                Size = new Size(180, 40),
                Location = new Point(200, 270),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(25, 80, 45),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Click += btnUpdate_Click;
            this.Controls.Add(btnUpdate);

            this.ResumeLayout(false);
        }

        // ================= HELPERS =================
        private Label CreateLabel(string text, int y)
        {
            Label lbl = new Label
            {
                Text = text,
                Location = new Point(60, y),
                Size = new Size(120, 25),
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.FromArgb(60, 60, 60)
            };
            this.Controls.Add(lbl);
            return lbl;
        }

        private TextBox CreateTextBox(int y, bool readOnly)
        {
            TextBox txt = new TextBox
            {
                Location = new Point(180, y),
                Size = new Size(320, 28),
                ReadOnly = readOnly,
                Font = new Font("Segoe UI", 10f),
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(txt);
            return txt;
        }
    }
}