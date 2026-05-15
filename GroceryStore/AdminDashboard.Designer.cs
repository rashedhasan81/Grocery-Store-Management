
namespace GroceryStore
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            lblStoreName = new Label();
            lblStoreSubtitle = new Label();
            pnlSideDiv = new Panel();
            btnNavDashboard = new Button();
            btnNavProducts = new Button();
            btnNavOrders = new Button();
            btnNavCustomers = new Button();
            btnLogout = new Button();
            btnNavReports = new Button();
            btnSuperAdminLogin = new Button();
            pnlAdminStrip = new Panel();
            lblAdminName = new Label();
            lblAdminRole = new Label();
            pnlTopBar = new Panel();
            lblPageTitle = new Label();
            lblClock = new Label();
            pnlContent = new Panel();
            pnlCardRow = new Panel();
            pnlCard1 = new Panel();
            lblC1Label = new Label();
            lblC1Value = new Label();
            lblC1Sub = new Label();
            pnlCard2 = new Panel();
            lblC2Label = new Label();
            lblC2Value = new Label();
            lblC2Sub = new Label();
            pnlCard3 = new Panel();
            lblC3Label = new Label();
            lblC3Value = new Label();
            lblC3Sub = new Label();
            pnlCard4 = new Panel();
            lblC4Label = new Label();
            lblC4Value = new Label();
            lblC4Sub = new Label();
            pnlBottomRow = new Panel();
            pnlOrdersBox = new Panel();
            lblOrdersTitle = new Label();
            dgvOrders = new DataGridView();
            pnlStockBox = new Panel();
            lblStockTitle = new Label();
            lstStock = new ListBox();
            timerClock = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            pnlAdminStrip.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCardRow.SuspendLayout();
            pnlCard1.SuspendLayout();
            pnlCard2.SuspendLayout();
            pnlCard3.SuspendLayout();
            pnlCard4.SuspendLayout();
            pnlBottomRow.SuspendLayout();
            pnlOrdersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            pnlStockBox.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(28, 37, 54);
            pnlSidebar.Controls.Add(lblStoreName);
            pnlSidebar.Controls.Add(lblStoreSubtitle);
            pnlSidebar.Controls.Add(pnlSideDiv);
            pnlSidebar.Controls.Add(btnNavDashboard);
            pnlSidebar.Controls.Add(btnNavProducts);
            pnlSidebar.Controls.Add(btnNavOrders);
            pnlSidebar.Controls.Add(btnNavCustomers);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnNavReports);
            pnlSidebar.Controls.Add(btnSuperAdminLogin);
            pnlSidebar.Controls.Add(pnlAdminStrip);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 880);
            pnlSidebar.TabIndex = 2;
            // 
            // lblStoreName
            // 
            lblStoreName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStoreName.ForeColor = Color.White;
            lblStoreName.Location = new Point(16, 24);
            lblStoreName.Name = "lblStoreName";
            lblStoreName.Size = new Size(208, 35);
            lblStoreName.TabIndex = 0;
            lblStoreName.Text = "GroceryStore";
            // 
            // lblStoreSubtitle
            // 
            lblStoreSubtitle.Font = new Font("Segoe UI", 8F);
            lblStoreSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            lblStoreSubtitle.Location = new Point(16, 59);
            lblStoreSubtitle.Name = "lblStoreSubtitle";
            lblStoreSubtitle.Size = new Size(208, 21);
            lblStoreSubtitle.TabIndex = 1;
            lblStoreSubtitle.Text = "Admin Panel";
            // 
            // pnlSideDiv
            // 
            pnlSideDiv.BackColor = Color.FromArgb(55, 65, 81);
            pnlSideDiv.Location = new Point(14, 93);
            pnlSideDiv.Margin = new Padding(3, 4, 3, 4);
            pnlSideDiv.Name = "pnlSideDiv";
            pnlSideDiv.Size = new Size(213, 1);
            pnlSideDiv.TabIndex = 2;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.FromArgb(37, 99, 235);
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Location = new Point(7, 109);
            btnNavDashboard.Margin = new Padding(3, 4, 3, 4);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(226, 48);
            btnNavDashboard.TabIndex = 3;
            btnNavDashboard.Text = "  Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += NavButton_Click;
            // 
            // btnNavProducts
            // 
            btnNavProducts.BackColor = Color.Transparent;
            btnNavProducts.Cursor = Cursors.Hand;
            btnNavProducts.FlatAppearance.BorderSize = 0;
            btnNavProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnNavProducts.FlatStyle = FlatStyle.Flat;
            btnNavProducts.Font = new Font("Segoe UI", 9.5F);
            btnNavProducts.ForeColor = Color.FromArgb(148, 163, 184);
            btnNavProducts.Location = new Point(7, 163);
            btnNavProducts.Margin = new Padding(3, 4, 3, 4);
            btnNavProducts.Name = "btnNavProducts";
            btnNavProducts.Size = new Size(226, 48);
            btnNavProducts.TabIndex = 4;
            btnNavProducts.Text = "  Products";
            btnNavProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProducts.UseVisualStyleBackColor = false;
            btnNavProducts.Click += btnNavProducts_Click;
            // 
            // btnNavOrders
            // 
            btnNavOrders.BackColor = Color.Transparent;
            btnNavOrders.Cursor = Cursors.Hand;
            btnNavOrders.FlatAppearance.BorderSize = 0;
            btnNavOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnNavOrders.FlatStyle = FlatStyle.Flat;
            btnNavOrders.Font = new Font("Segoe UI", 9.5F);
            btnNavOrders.ForeColor = Color.FromArgb(148, 163, 184);
            btnNavOrders.Location = new Point(7, 216);
            btnNavOrders.Margin = new Padding(3, 4, 3, 4);
            btnNavOrders.Name = "btnNavOrders";
            btnNavOrders.Size = new Size(226, 48);
            btnNavOrders.TabIndex = 5;
            btnNavOrders.Text = "  Orders";
            btnNavOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnNavOrders.UseVisualStyleBackColor = false;
            btnNavOrders.Click += btnNavOrders_Click;
            // 
            // btnNavCustomers
            // 
            btnNavCustomers.BackColor = Color.Transparent;
            btnNavCustomers.Cursor = Cursors.Hand;
            btnNavCustomers.FlatAppearance.BorderSize = 0;
            btnNavCustomers.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnNavCustomers.FlatStyle = FlatStyle.Flat;
            btnNavCustomers.Font = new Font("Segoe UI", 9.5F);
            btnNavCustomers.ForeColor = Color.FromArgb(148, 163, 184);
            btnNavCustomers.Location = new Point(6, 269);
            btnNavCustomers.Margin = new Padding(3, 4, 3, 4);
            btnNavCustomers.Name = "btnNavCustomers";
            btnNavCustomers.Size = new Size(226, 48);
            btnNavCustomers.TabIndex = 6;
            btnNavCustomers.Text = "  Customers";
            btnNavCustomers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCustomers.UseVisualStyleBackColor = false;
            btnNavCustomers.Click += btnNavCustomers_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9.5F);
            btnLogout.ForeColor = Color.FromArgb(148, 163, 184);
            btnLogout.Location = new Point(14, 380);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(226, 48);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNavReports
            // 
            btnNavReports.BackColor = Color.Transparent;
            btnNavReports.Cursor = Cursors.Hand;
            btnNavReports.FlatAppearance.BorderSize = 0;
            btnNavReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnNavReports.FlatStyle = FlatStyle.Flat;
            btnNavReports.Font = new Font("Segoe UI", 9.5F);
            btnNavReports.ForeColor = Color.FromArgb(148, 163, 184);
            btnNavReports.Location = new Point(7, 323);
            btnNavReports.Margin = new Padding(3, 4, 3, 4);
            btnNavReports.Name = "btnNavReports";
            btnNavReports.Size = new Size(226, 48);
            btnNavReports.TabIndex = 7;
            btnNavReports.Text = " Review";
            btnNavReports.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReports.UseVisualStyleBackColor = false;
            btnNavReports.Click += btnNavReports_Click;
            // 
            // btnSuperAdminLogin
            // 
            btnSuperAdminLogin.BackColor = Color.Transparent;
            btnSuperAdminLogin.Cursor = Cursors.Hand;
            btnSuperAdminLogin.FlatAppearance.BorderSize = 0;
            btnSuperAdminLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnSuperAdminLogin.FlatStyle = FlatStyle.Flat;
            btnSuperAdminLogin.Font = new Font("Segoe UI", 9.5F);
            btnSuperAdminLogin.ForeColor = Color.FromArgb(148, 163, 184);
            btnSuperAdminLogin.Location = new Point(7, 433);
            btnSuperAdminLogin.Margin = new Padding(3, 4, 3, 4);
            btnSuperAdminLogin.Name = "btnSuperAdminLogin";
            btnSuperAdminLogin.Size = new Size(226, 48);
            btnSuperAdminLogin.TabIndex = 8;
            btnSuperAdminLogin.Text = " Super Admin Login";
            btnSuperAdminLogin.TextAlign = ContentAlignment.MiddleLeft;
            btnSuperAdminLogin.UseVisualStyleBackColor = false;
            btnSuperAdminLogin.Click += btnSuperAdminLogin_Click;
            // 
            // pnlAdminStrip
            // 
            pnlAdminStrip.BackColor = Color.FromArgb(20, 27, 42);
            pnlAdminStrip.Controls.Add(lblAdminName);
            pnlAdminStrip.Controls.Add(lblAdminRole);
            pnlAdminStrip.Dock = DockStyle.Bottom;
            pnlAdminStrip.Location = new Point(0, 805);
            pnlAdminStrip.Margin = new Padding(3, 4, 3, 4);
            pnlAdminStrip.Name = "pnlAdminStrip";
            pnlAdminStrip.Size = new Size(240, 75);
            pnlAdminStrip.TabIndex = 9;
            // 
            // lblAdminName
            // 
            lblAdminName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(14, 13);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(213, 24);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "Admin User";
            // 
            // lblAdminRole
            // 
            lblAdminRole.Font = new Font("Segoe UI", 7.5F);
            lblAdminRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblAdminRole.Location = new Point(14, 40);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(213, 21);
            lblAdminRole.TabIndex = 1;
            lblAdminRole.Text = "Super Administrator";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.White;
            pnlTopBar.Controls.Add(lblPageTitle);
            pnlTopBar.Controls.Add(lblClock);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(240, 0);
            pnlTopBar.Margin = new Padding(3, 4, 3, 4);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1017, 69);
            pnlTopBar.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPageTitle.Location = new Point(21, 17);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(343, 35);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Font = new Font("Segoe UI", 9F);
            lblClock.ForeColor = Color.FromArgb(100, 116, 139);
            lblClock.Location = new Point(377, 23);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(159, 20);
            lblClock.TabIndex = 1;
            lblClock.Text = "02:12:20   14 May 2026";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Controls.Add(pnlCardRow);
            pnlContent.Controls.Add(pnlBottomRow);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(240, 69);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16, 19, 16, 19);
            pnlContent.Size = new Size(1017, 811);
            pnlContent.TabIndex = 0;
            // 
            // pnlCardRow
            // 
            pnlCardRow.BackColor = Color.Transparent;
            pnlCardRow.Controls.Add(pnlCard1);
            pnlCardRow.Controls.Add(pnlCard2);
            pnlCardRow.Controls.Add(pnlCard3);
            pnlCardRow.Controls.Add(pnlCard4);
            pnlCardRow.Dock = DockStyle.Top;
            pnlCardRow.Location = new Point(16, 19);
            pnlCardRow.Margin = new Padding(3, 4, 3, 4);
            pnlCardRow.Name = "pnlCardRow";
            pnlCardRow.Padding = new Padding(0, 0, 0, 13);
            pnlCardRow.Size = new Size(985, 147);
            pnlCardRow.TabIndex = 1;
            // 
            // pnlCard1
            // 
            pnlCard1.BackColor = Color.White;
            pnlCard1.Controls.Add(lblC1Label);
            pnlCard1.Controls.Add(lblC1Value);
            pnlCard1.Controls.Add(lblC1Sub);
            pnlCard1.Location = new Point(0, 0);
            pnlCard1.Margin = new Padding(3, 4, 3, 4);
            pnlCard1.Name = "pnlCard1";
            pnlCard1.Size = new Size(217, 128);
            pnlCard1.TabIndex = 0;
            // 
            // lblC1Label
            // 
            lblC1Label.Font = new Font("Segoe UI", 8F);
            lblC1Label.ForeColor = Color.FromArgb(100, 116, 139);
            lblC1Label.Location = new Point(14, 16);
            lblC1Label.Name = "lblC1Label";
            lblC1Label.Size = new Size(190, 20);
            lblC1Label.TabIndex = 0;
            lblC1Label.Text = "Total Products";
            // 
            // lblC1Value
            // 
            lblC1Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblC1Value.ForeColor = Color.FromArgb(30, 41, 59);
            lblC1Value.Location = new Point(11, 40);
            lblC1Value.Name = "lblC1Value";
            lblC1Value.Size = new Size(194, 51);
            lblC1Value.TabIndex = 1;
            lblC1Value.Text = "1,284";
            // 
            // lblC1Sub
            // 
            lblC1Sub.Font = new Font("Segoe UI", 7.5F);
            lblC1Sub.ForeColor = Color.FromArgb(100, 116, 139);
            lblC1Sub.Location = new Point(14, 93);
            lblC1Sub.Name = "lblC1Sub";
            lblC1Sub.Size = new Size(190, 19);
            lblC1Sub.TabIndex = 2;
            lblC1Sub.Text = "In inventory";
            // 
            // pnlCard2
            // 
            pnlCard2.BackColor = Color.White;
            pnlCard2.Controls.Add(lblC2Label);
            pnlCard2.Controls.Add(lblC2Value);
            pnlCard2.Controls.Add(lblC2Sub);
            pnlCard2.Location = new Point(229, 0);
            pnlCard2.Margin = new Padding(3, 4, 3, 4);
            pnlCard2.Name = "pnlCard2";
            pnlCard2.Size = new Size(217, 128);
            pnlCard2.TabIndex = 1;
            // 
            // lblC2Label
            // 
            lblC2Label.Font = new Font("Segoe UI", 8F);
            lblC2Label.ForeColor = Color.FromArgb(100, 116, 139);
            lblC2Label.Location = new Point(14, 16);
            lblC2Label.Name = "lblC2Label";
            lblC2Label.Size = new Size(190, 20);
            lblC2Label.TabIndex = 0;
            lblC2Label.Text = "Today's Orders";
            // 
            // lblC2Value
            // 
            lblC2Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblC2Value.ForeColor = Color.FromArgb(30, 41, 59);
            lblC2Value.Location = new Point(11, 40);
            lblC2Value.Name = "lblC2Value";
            lblC2Value.Size = new Size(194, 51);
            lblC2Value.TabIndex = 1;
            lblC2Value.Text = "87";
            // 
            // lblC2Sub
            // 
            lblC2Sub.Font = new Font("Segoe UI", 7.5F);
            lblC2Sub.ForeColor = Color.FromArgb(22, 163, 74);
            lblC2Sub.Location = new Point(14, 93);
            lblC2Sub.Name = "lblC2Sub";
            lblC2Sub.Size = new Size(190, 19);
            lblC2Sub.TabIndex = 2;
            lblC2Sub.Text = "+14% vs yesterday";
            // 
            // pnlCard3
            // 
            pnlCard3.BackColor = Color.White;
            pnlCard3.Controls.Add(lblC3Label);
            pnlCard3.Controls.Add(lblC3Value);
            pnlCard3.Controls.Add(lblC3Sub);
            pnlCard3.Location = new Point(457, 0);
            pnlCard3.Margin = new Padding(3, 4, 3, 4);
            pnlCard3.Name = "pnlCard3";
            pnlCard3.Size = new Size(217, 128);
            pnlCard3.TabIndex = 2;
            // 
            // lblC3Label
            // 
            lblC3Label.Font = new Font("Segoe UI", 8F);
            lblC3Label.ForeColor = Color.FromArgb(100, 116, 139);
            lblC3Label.Location = new Point(14, 16);
            lblC3Label.Name = "lblC3Label";
            lblC3Label.Size = new Size(190, 20);
            lblC3Label.TabIndex = 0;
            lblC3Label.Text = "Monthly Revenue";
            // 
            // lblC3Value
            // 
            lblC3Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblC3Value.ForeColor = Color.FromArgb(30, 41, 59);
            lblC3Value.Location = new Point(11, 40);
            lblC3Value.Name = "lblC3Value";
            lblC3Value.Size = new Size(194, 51);
            lblC3Value.TabIndex = 1;
            lblC3Value.Text = "৳34,580";
            // 
            // lblC3Sub
            // 
            lblC3Sub.Font = new Font("Segoe UI", 7.5F);
            lblC3Sub.ForeColor = Color.FromArgb(22, 163, 74);
            lblC3Sub.Location = new Point(14, 93);
            lblC3Sub.Name = "lblC3Sub";
            lblC3Sub.Size = new Size(190, 19);
            lblC3Sub.TabIndex = 2;
            lblC3Sub.Text = "+8.2% vs last month";
            // 
            // pnlCard4
            // 
            pnlCard4.BackColor = Color.White;
            pnlCard4.Controls.Add(lblC4Label);
            pnlCard4.Controls.Add(lblC4Value);
            pnlCard4.Controls.Add(lblC4Sub);
            pnlCard4.Location = new Point(686, 0);
            pnlCard4.Margin = new Padding(3, 4, 3, 4);
            pnlCard4.Name = "pnlCard4";
            pnlCard4.Size = new Size(217, 128);
            pnlCard4.TabIndex = 3;
            // 
            // lblC4Label
            // 
            lblC4Label.Font = new Font("Segoe UI", 8F);
            lblC4Label.ForeColor = Color.FromArgb(100, 116, 139);
            lblC4Label.Location = new Point(14, 16);
            lblC4Label.Name = "lblC4Label";
            lblC4Label.Size = new Size(190, 20);
            lblC4Label.TabIndex = 0;
            lblC4Label.Text = "Low Stock Items";
            // 
            // lblC4Value
            // 
            lblC4Value.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblC4Value.ForeColor = Color.FromArgb(220, 38, 38);
            lblC4Value.Location = new Point(11, 40);
            lblC4Value.Name = "lblC4Value";
            lblC4Value.Size = new Size(194, 51);
            lblC4Value.TabIndex = 1;
            lblC4Value.Text = "23";
            // 
            // lblC4Sub
            // 
            lblC4Sub.Font = new Font("Segoe UI", 7.5F);
            lblC4Sub.ForeColor = Color.FromArgb(220, 38, 38);
            lblC4Sub.Location = new Point(14, 93);
            lblC4Sub.Name = "lblC4Sub";
            lblC4Sub.Size = new Size(190, 19);
            lblC4Sub.TabIndex = 2;
            lblC4Sub.Text = "Needs restocking";
            // 
            // pnlBottomRow
            // 
            pnlBottomRow.BackColor = Color.Transparent;
            pnlBottomRow.Controls.Add(pnlOrdersBox);
            pnlBottomRow.Controls.Add(pnlStockBox);
            pnlBottomRow.Dock = DockStyle.Fill;
            pnlBottomRow.Location = new Point(16, 19);
            pnlBottomRow.Margin = new Padding(3, 4, 3, 4);
            pnlBottomRow.Name = "pnlBottomRow";
            pnlBottomRow.Size = new Size(985, 773);
            pnlBottomRow.TabIndex = 0;
            // 
            // pnlOrdersBox
            // 
            pnlOrdersBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlOrdersBox.BackColor = Color.White;
            pnlOrdersBox.Controls.Add(lblOrdersTitle);
            pnlOrdersBox.Controls.Add(dgvOrders);
            pnlOrdersBox.Location = new Point(0, 0);
            pnlOrdersBox.Margin = new Padding(3, 4, 3, 4);
            pnlOrdersBox.Name = "pnlOrdersBox";
            pnlOrdersBox.Size = new Size(640, 1093);
            pnlOrdersBox.TabIndex = 0;
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblOrdersTitle.Location = new Point(14, 16);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(343, 27);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "Recent Orders";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 116, 139);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrders.EnableHeadersVisualStyles = false;
            dgvOrders.GridColor = Color.FromArgb(241, 245, 249);
            dgvOrders.Location = new Point(11, 53);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 32;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(617, 1027);
            dgvOrders.TabIndex = 1;
            // 
            // pnlStockBox
            // 
            pnlStockBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlStockBox.BackColor = Color.White;
            pnlStockBox.Controls.Add(lblStockTitle);
            pnlStockBox.Controls.Add(lstStock);
            pnlStockBox.Location = new Point(1412, 0);
            pnlStockBox.Margin = new Padding(3, 4, 3, 4);
            pnlStockBox.Name = "pnlStockBox";
            pnlStockBox.Size = new Size(297, 1093);
            pnlStockBox.TabIndex = 1;
            // 
            // lblStockTitle
            // 
            lblStockTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStockTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblStockTitle.Location = new Point(14, 16);
            lblStockTitle.Name = "lblStockTitle";
            lblStockTitle.Size = new Size(270, 27);
            lblStockTitle.TabIndex = 0;
            lblStockTitle.Text = "Low Stock Alert";
            // 
            // lstStock
            // 
            lstStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstStock.BorderStyle = BorderStyle.None;
            lstStock.Font = new Font("Segoe UI", 9F);
            lstStock.ForeColor = Color.FromArgb(30, 41, 59);
            lstStock.Location = new Point(11, 53);
            lstStock.Margin = new Padding(3, 4, 3, 4);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(274, 1000);
            lstStock.TabIndex = 1;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 880);
            Controls.Add(pnlContent);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(980, 731);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GroceryStore - Admin Dashboard";
            pnlSidebar.ResumeLayout(false);
            pnlAdminStrip.ResumeLayout(false);
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlCardRow.ResumeLayout(false);
            pnlCard1.ResumeLayout(false);
            pnlCard2.ResumeLayout(false);
            pnlCard3.ResumeLayout(false);
            pnlCard4.ResumeLayout(false);
            pnlBottomRow.ResumeLayout(false);
            pnlOrdersBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            pnlStockBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        // ── Control fields ────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreSubtitle;
        private System.Windows.Forms.Panel pnlSideDiv;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavProducts;
        private System.Windows.Forms.Button btnNavOrders;
        private System.Windows.Forms.Button btnNavCustomers;
        private System.Windows.Forms.Button btnNavReports;
        private System.Windows.Forms.Panel pnlAdminStrip;
        private System.Windows.Forms.Label lblAdminName;
        private System.Windows.Forms.Label lblAdminRole;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlCardRow;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblC1Label;
        private System.Windows.Forms.Label lblC1Value;
        private System.Windows.Forms.Label lblC1Sub;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblC2Label;
        private System.Windows.Forms.Label lblC2Value;
        private System.Windows.Forms.Label lblC2Sub;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblC3Label;
        private System.Windows.Forms.Label lblC3Value;
        private System.Windows.Forms.Label lblC3Sub;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblC4Label;
        private System.Windows.Forms.Label lblC4Value;
        private System.Windows.Forms.Label lblC4Sub;
        private System.Windows.Forms.Panel pnlBottomRow;
        private System.Windows.Forms.Panel pnlOrdersBox;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Panel pnlStockBox;
        private System.Windows.Forms.Label lblStockTitle;
        private System.Windows.Forms.ListBox lstStock;
        private System.Windows.Forms.Timer timerClock;
        private Button btnLogout;
        private System.Windows.Forms.Button btnSuperAdminLogin;
    }
}
