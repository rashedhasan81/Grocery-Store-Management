namespace GroceryStore
{
    partial class SuperAdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkIsActive;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.DataGridView dgvAdmins;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            chkIsActive = new CheckBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvAdmins = new DataGridView();
            lblName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 27);
            txtName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(120, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(309, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(309, 27);
            txtPassword.TabIndex = 5;
            // 
            // chkIsActive
            // 
            chkIsActive.Location = new Point(120, 140);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(104, 24);
            chkIsActive.TabIndex = 6;
            chkIsActive.Text = "Is Active";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(108, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(202, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 31);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(300, 180);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 31);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // dgvAdmins
            // 
            dgvAdmins.ColumnHeadersHeight = 29;
            dgvAdmins.Location = new Point(20, 230);
            dgvAdmins.Name = "dgvAdmins";
            dgvAdmins.RowHeadersWidth = 51;
            dgvAdmins.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdmins.Size = new Size(550, 200);
            dgvAdmins.TabIndex = 11;
            dgvAdmins.CellClick += dgvAdmins_CellClick;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(20, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(20, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(100, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // backbtn
            // 
            backbtn.Location = new Point(495, 180);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(75, 31);
            backbtn.TabIndex = 10;
            backbtn.Text = "Back";
            backbtn.Click += backbtn_Click;
            // 
            // SuperAdminForm
            // 
            ClientSize = new Size(600, 460);
            Controls.Add(lblName);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(chkIsActive);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(backbtn);
            Controls.Add(btnClear);
            Controls.Add(dgvAdmins);
            Name = "SuperAdminForm";
            Text = "Super Admin Panel - GroceryStore";
            ((System.ComponentModel.ISupportInitialize)dgvAdmins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button backbtn;
    }
}