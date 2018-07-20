﻿namespace do_account_checker
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
            this.lblUridium = new System.Windows.Forms.Label();
            this.lblUridiumText = new System.Windows.Forms.Label();
            this.pnlAccounts = new System.Windows.Forms.GroupBox();
            this.btnCollectAll = new System.Windows.Forms.Button();
            this.btnLoginAll = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.listAccounts = new System.Windows.Forms.ListView();
            this.pnlLogin.SuspendLayout();
            this.pnlAccountInformation.SuspendLayout();
            this.pnlAccounts.SuspendLayout();
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
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.White;
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
            this.pnlAccountInformation.Controls.Add(this.lblUridium);
            this.pnlAccountInformation.Controls.Add(this.lblUridiumText);
            this.pnlAccountInformation.Location = new System.Drawing.Point(218, 12);
            this.pnlAccountInformation.Name = "pnlAccountInformation";
            this.pnlAccountInformation.Size = new System.Drawing.Size(570, 160);
            this.pnlAccountInformation.TabIndex = 3;
            this.pnlAccountInformation.TabStop = false;
            this.pnlAccountInformation.Text = "Account Information";
            // 
            // lblUridium
            // 
            this.lblUridium.AutoSize = true;
            this.lblUridium.Location = new System.Drawing.Point(57, 23);
            this.lblUridium.Name = "lblUridium";
            this.lblUridium.Size = new System.Drawing.Size(0, 13);
            this.lblUridium.TabIndex = 1;
            // 
            // lblUridiumText
            // 
            this.lblUridiumText.AutoSize = true;
            this.lblUridiumText.Location = new System.Drawing.Point(6, 23);
            this.lblUridiumText.Name = "lblUridiumText";
            this.lblUridiumText.Size = new System.Drawing.Size(45, 13);
            this.lblUridiumText.TabIndex = 0;
            this.lblUridiumText.Text = "Uridium:";
            // 
            // pnlAccounts
            // 
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
            this.btnCollectAll.Location = new System.Drawing.Point(296, 231);
            this.btnCollectAll.Name = "btnCollectAll";
            this.btnCollectAll.Size = new System.Drawing.Size(93, 23);
            this.btnCollectAll.TabIndex = 4;
            this.btnCollectAll.Text = "Collect Daily All";
            this.btnCollectAll.UseVisualStyleBackColor = true;
            // 
            // btnLoginAll
            // 
            this.btnLoginAll.Location = new System.Drawing.Point(215, 231);
            this.btnLoginAll.Name = "btnLoginAll";
            this.btnLoginAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoginAll.TabIndex = 3;
            this.btnLoginAll.Text = "Login All";
            this.btnLoginAll.UseVisualStyleBackColor = true;
            // 
            // btnCollect
            // 
            this.btnCollect.Location = new System.Drawing.Point(90, 231);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(104, 23);
            this.btnCollect.TabIndex = 2;
            this.btnCollect.Text = "Collect Daily Login";
            this.btnCollect.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(9, 231);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // listAccounts
            // 
            this.listAccounts.Location = new System.Drawing.Point(0, 19);
            this.listAccounts.Name = "listAccounts";
            this.listAccounts.Size = new System.Drawing.Size(764, 206);
            this.listAccounts.TabIndex = 0;
            this.listAccounts.UseCompatibleStateImageBehavior = false;
            this.listAccounts.View = System.Windows.Forms.View.List;
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAccounts);
            this.Controls.Add(this.pnlAccountInformation);
            this.Controls.Add(this.pnlLogin);
            this.Name = "GuiForm";
            this.Text = "Darkorbit Account Manager";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlAccountInformation.ResumeLayout(false);
            this.pnlAccountInformation.PerformLayout();
            this.pnlAccounts.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblUridiumText;
        private System.Windows.Forms.Button btnSingleLogin;
        private System.Windows.Forms.GroupBox pnlAccounts;
        private System.Windows.Forms.Button btnCollectAll;
        private System.Windows.Forms.Button btnLoginAll;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ListView listAccounts;
    }
}

