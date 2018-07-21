namespace do_account_checker
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLogin = new System.Windows.Forms.GroupBox();
            this.btnSingleLogin = new System.Windows.Forms.Button();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlAccountInformation = new System.Windows.Forms.GroupBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCreditsNOEDIT = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblUserIdNOEDIT = new System.Windows.Forms.Label();
            this.lblUridium = new System.Windows.Forms.Label();
            this.lblUridiumNOEDIT = new System.Windows.Forms.Label();
            this.pnlAccounts = new System.Windows.Forms.GroupBox();
            this.btnCollectAll = new System.Windows.Forms.Button();
            this.btnLoginAll = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.listAccounts = new System.Windows.Forms.ListView();
            this.flowlayAccountInformations = new System.Windows.Forms.FlowLayoutPanel();
            this.columnUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReload = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.pnlAccountInformation.SuspendLayout();
            this.pnlAccounts.SuspendLayout();
            this.flowlayAccountInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.btnSingleLogin);
            this.pnlLogin.Controls.Add(this.pnlStatus);
            this.pnlLogin.Controls.Add(this.lblStatus);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.btnAddAccount);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Location = new System.Drawing.Point(12, 12);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(200, 160);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.TabStop = false;
            this.pnlLogin.Text = "Login";
            // 
            // btnSingleLogin
            // 
            this.btnSingleLogin.Location = new System.Drawing.Point(6, 104);
            this.btnSingleLogin.Name = "btnSingleLogin";
            this.btnSingleLogin.Size = new System.Drawing.Size(188, 23);
            this.btnSingleLogin.TabIndex = 6;
            this.btnSingleLogin.Text = "Login w/o adding";
            this.btnSingleLogin.UseVisualStyleBackColor = true;
            this.btnSingleLogin.Click += new System.EventHandler(this.BtnSingleLogin_Click);
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Orange;
            this.pnlStatus.Location = new System.Drawing.Point(79, 138);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(115, 13);
            this.pnlStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 138);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Login status:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(79, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(115, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Ctest2018";
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(6, 75);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(188, 23);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.BtnAddAccount_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(79, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(115, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "ctest2018";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 54);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 26);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // pnlAccountInformation
            // 
            this.pnlAccountInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccountInformation.Controls.Add(this.flowlayAccountInformations);
            this.pnlAccountInformation.Location = new System.Drawing.Point(218, 12);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.Size = new System.Drawing.Size(570, 160);
            this.pnlAccountInformation.TabIndex = 3;
            this.pnlAccountInformation.TabStop = false;
            this.pnlAccountInformation.Text = "Account Information";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(3, 65);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(0, 13);
            this.lblCredits.TabIndex = 5;
            // 
            // lblCreditsNOEDIT
            // 
            this.lblCreditsNOEDIT.AutoSize = true;
            this.lblCreditsNOEDIT.Location = new System.Drawing.Point(3, 52);
            this.lblCreditsNOEDIT.Name = "lblCreditsNOEDIT";
            this.lblCreditsNOEDIT.Size = new System.Drawing.Size(42, 13);
            this.lblCreditsNOEDIT.TabIndex = 4;
            this.lblCreditsNOEDIT.Text = "Credits:";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(3, 13);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(0, 13);
            this.lblUserId.TabIndex = 1;
            // 
            // lblUserIdNOEDIT
            // 
            this.lblUserIdNOEDIT.AutoSize = true;
            this.lblUserIdNOEDIT.Location = new System.Drawing.Point(3, 0);
            this.lblUserIdNOEDIT.Name = "lblUserIdNOEDIT";
            this.lblUserIdNOEDIT.Size = new System.Drawing.Size(46, 13);
            this.lblUserIdNOEDIT.TabIndex = 0;
            this.lblUserIdNOEDIT.Text = "User ID:";
            // 
            // lblUridium
            // 
            this.lblUridium.AutoSize = true;
            this.lblUridium.Location = new System.Drawing.Point(3, 39);
            this.lblUridium.Name = "lblUridium";
            this.lblUridium.Size = new System.Drawing.Size(0, 13);
            this.lblUridium.TabIndex = 3;
            // 
            // lblUridiumNOEDIT
            // 
            this.lblUridiumNOEDIT.AutoSize = true;
            this.lblUridiumNOEDIT.Location = new System.Drawing.Point(3, 26);
            this.lblUridiumNOEDIT.Name = "lblUridiumNOEDIT";
            this.lblUridiumNOEDIT.Size = new System.Drawing.Size(45, 13);
            this.lblUridiumNOEDIT.TabIndex = 2;
            this.lblUridiumNOEDIT.Text = "Uridium:";
            // 
            // pnlAccounts
            // 
            this.pnlAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAccounts.Controls.Add(this.btnReload);
            this.pnlAccounts.Controls.Add(this.btnCollectAll);
            this.pnlAccounts.Controls.Add(this.btnLoginAll);
            this.pnlAccounts.Controls.Add(this.btnCollect);
            this.pnlAccounts.Controls.Add(this.btnLogin);
            this.pnlAccounts.Controls.Add(this.listAccounts);
            this.pnlAccounts.Location = new System.Drawing.Point(12, 178);
            this.pnlAccounts.Name = "pnlAccounts";
            this.pnlAccounts.Size = new System.Drawing.Size(776, 260);
            this.pnlAccounts.TabIndex = 4;
            this.pnlAccounts.TabStop = false;
            this.pnlAccounts.Text = "Accounts";
            // 
            // btnCollectAll
            // 
            this.btnCollectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollectAll.Location = new System.Drawing.Point(296, 231);
            this.btnCollectAll.Name = "btnCollectAll";
            this.btnCollectAll.Size = new System.Drawing.Size(93, 23);
            this.btnCollectAll.TabIndex = 4;
            this.btnCollectAll.Text = "Collect Daily All";
            this.btnCollectAll.UseVisualStyleBackColor = true;
            // 
            // btnLoginAll
            // 
            this.btnLoginAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoginAll.Location = new System.Drawing.Point(215, 231);
            this.btnLoginAll.Name = "btnLoginAll";
            this.btnLoginAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAll.TabIndex = 3;
            this.btnLoginAll.Text = "Login All";
            this.btnLoginAll.UseVisualStyleBackColor = true;
            // 
            // btnCollect
            // 
            this.btnCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCollect.Location = new System.Drawing.Point(90, 231);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(104, 23);
            this.btnCollect.TabIndex = 2;
            this.btnCollect.Text = "Collect Daily Login";
            this.btnCollect.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.Location = new System.Drawing.Point(9, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // listAccounts
            // 
            this.listAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnUsername,
            this.columnStatus});
            this.listAccounts.FullRowSelect = true;
            this.listAccounts.GridLines = true;
            this.listAccounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listAccounts.Location = new System.Drawing.Point(9, 19);
            this.listAccounts.MultiSelect = false;
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(755, 206);
            this.listAccounts.TabIndex = 0;
            this.listAccounts.UseCompatibleStateImageBehavior = false;
            this.listAccounts.View = System.Windows.Forms.View.Details;
            // 
            // flowlayAccountInformations
            // 
            this.flowlayAccountInformations.Controls.Add(this.lblUserIdNOEDIT);
            this.flowlayAccountInformations.Controls.Add(this.lblUserId);
            this.flowlayAccountInformations.Controls.Add(this.lblUridiumNOEDIT);
            this.flowlayAccountInformations.Controls.Add(this.lblUridium);
            this.flowlayAccountInformations.Controls.Add(this.lblCreditsNOEDIT);
            this.flowlayAccountInformations.Controls.Add(this.lblCredits);
            this.flowlayAccountInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowlayAccountInformations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlayAccountInformations.Location = new System.Drawing.Point(3, 16);
            this.flowlayAccountInformations.Name = "flowlayAccountInformations";
            this.flowlayAccountInformations.Size = new System.Drawing.Size(564, 141);
            this.flowlayAccountInformations.TabIndex = 6;
            // 
            // columnUsername
            // 
            this.columnUsername.Text = "Username";
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Login Status";
            this.columnStatus.Width = 691;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(694, 231);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(70, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "⭮ Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAccounts);
            this.Controls.Add(this.pnlAccountInformation);
            this.Controls.Add(this.pnlLogin);
            this.Name = "MainForm";
            this.Text = "Darkorbit Account Manager";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccounts.ResumeLayout(false);
            this.flowlayAccountInformations.ResumeLayout(false);
            this.flowlayAccountInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlLogin;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.GroupBox pnlAccountInformation;
        private System.Windows.Forms.Label lblUridium;
        private System.Windows.Forms.Label lblUridiumNOEDIT;
        private System.Windows.Forms.Button btnSingleLogin;
        private System.Windows.Forms.GroupBox pnlAccounts;
        private System.Windows.Forms.Button btnCollectAll;
        private System.Windows.Forms.Button btnLoginAll;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView listAccounts;
        private System.Windows.Forms.Label lblUserIdNOEDIT;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblCreditsNOEDIT;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.FlowLayoutPanel flowlayAccountInformations;
        private System.Windows.Forms.ColumnHeader columnUsername;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button btnReload;
    }
}

