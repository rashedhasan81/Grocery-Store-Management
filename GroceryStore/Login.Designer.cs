namespace GroceryStore
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            userbox = new TextBox();
            userl = new Label();
            passl = new Label();
            passbox = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            loginbtn = new Button();
            goforsignl = new Label();
            signupbtn = new Button();
            pictureBox2 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(356, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(424, 436);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userbox
            // 
            userbox.Font = new Font("Segoe UI", 11F);
            userbox.Location = new Point(394, 111);
            userbox.Name = "userbox";
            userbox.PlaceholderText = "Enter your UserName";
            userbox.Size = new Size(328, 32);
            userbox.TabIndex = 1;
            // 
            // userl
            // 
            userl.AutoSize = true;
            userl.BackColor = Color.Purple;
            userl.Font = new Font("Segoe UI", 11F);
            userl.ForeColor = Color.White;
            userl.Location = new Point(394, 78);
            userl.Name = "userl";
            userl.Size = new Size(104, 25);
            userl.TabIndex = 2;
            userl.Text = "UserName:";
            // 
            // passl
            // 
            passl.AutoSize = true;
            passl.BackColor = Color.Purple;
            passl.Font = new Font("Segoe UI", 11F);
            passl.ForeColor = Color.White;
            passl.Location = new Point(394, 165);
            passl.Name = "passl";
            passl.Size = new Size(95, 25);
            passl.TabIndex = 2;
            passl.Text = "Password:";
            // 
            // passbox
            // 
            passbox.Font = new Font("Segoe UI", 11F);
            passbox.Location = new Point(394, 199);
            passbox.Name = "passbox";
            passbox.PasswordChar = '*';
            passbox.PlaceholderText = "Enter your password";
            passbox.Size = new Size(328, 32);
            passbox.TabIndex = 1;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Green;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(421, 269);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(277, 65);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "Log In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // goforsignl
            // 
            goforsignl.AutoSize = true;
            goforsignl.BackColor = Color.Purple;
            goforsignl.Font = new Font("Segoe UI Emoji", 10F);
            goforsignl.ForeColor = Color.White;
            goforsignl.Location = new Point(449, 360);
            goforsignl.Name = "goforsignl";
            goforsignl.Size = new Size(224, 22);
            goforsignl.TabIndex = 2;
            goforsignl.Text = "Don't you have an account?";
            // 
            // signupbtn
            // 
            signupbtn.Cursor = Cursors.Hand;
            signupbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            signupbtn.Location = new Point(481, 397);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(164, 34);
            signupbtn.TabIndex = 4;
            signupbtn.Text = "Sign Up";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(338, 362);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Firebrick;
            checkBox1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(105, 470);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 26);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Admin Login";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 541);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox2);
            Controls.Add(signupbtn);
            Controls.Add(loginbtn);
            Controls.Add(passl);
            Controls.Add(goforsignl);
            Controls.Add(userl);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox userbox;
        private Label userl;
        private Label passl;
        private TextBox passbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button loginbtn;
        private Label goforsignl;
        private Button signupbtn;
        private PictureBox pictureBox2;
        private CheckBox checkBox1;
    }
}