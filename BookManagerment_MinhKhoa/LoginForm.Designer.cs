namespace BookManagerment_MinhKhoa
{
    partial class LoginForm
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
            lblHeader = new Label();
            grbAccountInfo = new GroupBox();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPasword = new TextBox();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            grbAccountInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(115, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(448, 81);
            lblHeader.TabIndex = 2;
            lblHeader.Text = "Book Manager";
            // 
            // grbAccountInfo
            // 
            grbAccountInfo.BackColor = Color.FromArgb(0, 192, 0);
            grbAccountInfo.Controls.Add(btnCancel);
            grbAccountInfo.Controls.Add(btnLogin);
            grbAccountInfo.Controls.Add(txtPasword);
            grbAccountInfo.Controls.Add(txtEmail);
            grbAccountInfo.Controls.Add(lblEmail);
            grbAccountInfo.Controls.Add(lblPassword);
            grbAccountInfo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAccountInfo.ForeColor = Color.Yellow;
            grbAccountInfo.Location = new Point(83, 115);
            grbAccountInfo.Name = "grbAccountInfo";
            grbAccountInfo.Size = new Size(490, 317);
            grbAccountInfo.TabIndex = 0;
            grbAccountInfo.TabStop = false;
            grbAccountInfo.Text = "Account Info";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Yellow;
            btnCancel.Location = new Point(272, 225);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 52);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Yellow;
            btnLogin.Location = new Point(53, 225);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(143, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPasword
            // 
            txtPasword.Location = new Point(174, 127);
            txtPasword.Name = "txtPasword";
            txtPasword.PasswordChar = '*';
            txtPasword.Size = new Size(279, 38);
            txtPasword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(279, 38);
            txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Yellow;
            lblEmail.Location = new Point(32, 49);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(73, 31);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Yellow;
            lblPassword.Location = new Point(32, 127);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 31);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(652, 481);
            Controls.Add(grbAccountInfo);
            Controls.Add(lblHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            grbAccountInfo.ResumeLayout(false);
            grbAccountInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHeader;
        private GroupBox grbAccountInfo;
        private Button btnLogin;
        private TextBox txtPasword;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPassword;
        private Button btnCancel;
    }
}