
namespace GroceryStore
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lgnbtn = new Button();
            label8 = new Label();
            createbtn = new Button();
            checkBox1 = new CheckBox();
            confirmpasstxt = new TextBox();
            passtxt = new TextBox();
            phntxt = new TextBox();
            label7 = new Label();
            mailtxt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            usertxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lgnbtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(createbtn);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(confirmpasstxt);
            panel1.Controls.Add(passtxt);
            panel1.Controls.Add(phntxt);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(mailtxt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(usertxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(322, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 546);
            panel1.TabIndex = 0;
            // 
            // lgnbtn
            // 
            lgnbtn.Location = new Point(251, 492);
            lgnbtn.Name = "lgnbtn";
            lgnbtn.Size = new Size(78, 29);
            lgnbtn.TabIndex = 7;
            lgnbtn.Text = "LogIn";
            lgnbtn.UseVisualStyleBackColor = true;
            lgnbtn.Click += lgnbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Display", 8F);
            label8.Location = new Point(104, 496);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 6;
            label8.Text = "Already have an account?";
            // 
            // createbtn
            // 
            createbtn.BackColor = Color.DarkOliveGreen;
            createbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            createbtn.ForeColor = SystemColors.ControlLightLight;
            createbtn.Location = new Point(107, 433);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(216, 46);
            createbtn.TabIndex = 5;
            createbtn.Text = "Create Account";
            createbtn.UseVisualStyleBackColor = false;
            createbtn.Click += createbtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tw Cen MT", 8F);
            checkBox1.Location = new Point(42, 406);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(329, 20);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "I agree to the terms and condition and privacy policy";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // confirmpasstxt
            // 
            confirmpasstxt.BackColor = Color.FromArgb(224, 224, 224);
            confirmpasstxt.BorderStyle = BorderStyle.FixedSingle;
            confirmpasstxt.Font = new Font("Segoe UI", 9.5F);
            confirmpasstxt.Location = new Point(40, 363);
            confirmpasstxt.Name = "confirmpasstxt";
            confirmpasstxt.PasswordChar = '*';
            confirmpasstxt.Size = new Size(348, 29);
            confirmpasstxt.TabIndex = 3;
            // 
            // passtxt
            // 
            passtxt.BackColor = Color.FromArgb(224, 224, 224);
            passtxt.BorderStyle = BorderStyle.FixedSingle;
            passtxt.Font = new Font("Segoe UI", 9.5F);
            passtxt.Location = new Point(40, 304);
            passtxt.Name = "passtxt";
            passtxt.PasswordChar = '*';
            passtxt.Size = new Size(348, 29);
            passtxt.TabIndex = 3;
            // 
            // phntxt
            // 
            phntxt.BackColor = Color.FromArgb(224, 224, 224);
            phntxt.BorderStyle = BorderStyle.FixedSingle;
            phntxt.Font = new Font("Segoe UI", 9.5F);
            phntxt.Location = new Point(40, 242);
            phntxt.Name = "phntxt";
            phntxt.Size = new Size(348, 29);
            phntxt.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Bold);
            label7.ForeColor = Color.DarkRed;
            label7.Location = new Point(42, 342);
            label7.Name = "label7";
            label7.Size = new Size(120, 16);
            label7.TabIndex = 2;
            label7.Text = "Confirm Password";
            // 
            // mailtxt
            // 
            mailtxt.BackColor = Color.FromArgb(224, 224, 224);
            mailtxt.BorderStyle = BorderStyle.FixedSingle;
            mailtxt.Font = new Font("Segoe UI", 9.5F);
            mailtxt.Location = new Point(40, 178);
            mailtxt.Name = "mailtxt";
            mailtxt.Size = new Size(348, 29);
            mailtxt.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Bold);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(42, 283);
            label6.Name = "label6";
            label6.Size = new Size(109, 16);
            label6.TabIndex = 2;
            label6.Text = "Create Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Bold);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(42, 219);
            label5.Name = "label5";
            label5.Size = new Size(100, 16);
            label5.TabIndex = 2;
            label5.Text = "Phone Number";
            // 
            // usertxt
            // 
            usertxt.BackColor = Color.FromArgb(224, 224, 224);
            usertxt.BorderStyle = BorderStyle.FixedSingle;
            usertxt.Font = new Font("Segoe UI", 9.5F);
            usertxt.Location = new Point(40, 116);
            usertxt.Name = "usertxt";
            usertxt.Size = new Size(348, 29);
            usertxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Bold);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(42, 155);
            label4.Name = "label4";
            label4.Size = new Size(92, 16);
            label4.TabIndex = 2;
            label4.Text = "Email address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 7F, FontStyle.Bold);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(43, 94);
            label3.Name = "label3";
            label3.Size = new Size(68, 16);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 8F);
            label2.Location = new Point(107, 44);
            label2.Name = "label2";
            label2.Size = new Size(262, 19);
            label2.TabIndex = 1;
            label2.Text = "Join FreshBasket for easy grocery shopping";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(130, 14);
            label1.Name = "label1";
            label1.Size = new Size(224, 30);
            label1.TabIndex = 0;
            label1.Text = "Create Your Account";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg_gem;
            ClientSize = new Size(1134, 629);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "signup";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Signup_Load(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox mailtxt;
        private TextBox usertxt;
        private Label label4;
        private TextBox phntxt;
        private Label label6;
        private Label label5;
        private TextBox confirmpasstxt;
        private TextBox passtxt;
        private Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button createbtn;
        private CheckBox checkBox1;
        private Button lgnbtn;
        private Label label8;
    }
}