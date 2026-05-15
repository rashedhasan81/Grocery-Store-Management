namespace GroceryStore
{
    partial class SuperAdminLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();

            // 
            // SuperAdminLogin
            // 
            Text = "Super Admin Login";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new System.Drawing.Size(380, 200);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(16, 16);
            lblTitle.Text = "Super Admin Authentication";

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(18, 56);
            lblUsername.Text = "Username";

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(110, 52);
            txtUsername.Size = new System.Drawing.Size(250, 27);

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(18, 96);
            lblPassword.Text = "Password";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(110, 92);
            txtPassword.Size = new System.Drawing.Size(250, 27);
            txtPassword.UseSystemPasswordChar = true;

            // btnCancel
            btnCancel.Location = new System.Drawing.Point(110, 140);
            btnCancel.Size = new System.Drawing.Size(110, 30);
            btnCancel.Text = "Cancel";
            btnCancel.Click += (s, e) => DialogResult = DialogResult.Cancel;

            // btnLogin
            btnLogin.Location = new System.Drawing.Point(250, 140);
            btnLogin.Size = new System.Drawing.Size(110, 30);
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;

            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}