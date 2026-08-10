namespace BankAccountsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AccountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            TotalBalanceLbl = new Label();
            TotalInterestLbl = new Label();
            SearchTxt = new TextBox();
            SearchBtn = new Button();
            ResetBtn = new Button();
            DeactivateBtn = new Button();
            RestoreBtn = new Button();

            ((System.ComponentModel.ISupportInitialize)AccountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();

            // label1 - Owner
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 46);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 0;
            label1.Text = "Owner:";

            // label2 - Amount
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 356);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "Amount:";

            // OwnerTxt
            OwnerTxt.Location = new Point(155, 60);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(218, 31);
            OwnerTxt.TabIndex = 2;

            // AccountNum
            AccountNum.Location = new Point(168, 371);
            AccountNum.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            AccountNum.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            AccountNum.Name = "AccountNum";
            AccountNum.Size = new Size(180, 31);
            AccountNum.TabIndex = 3;

            // BankAccountsGrid
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(545, 81);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(596, 219);
            BankAccountsGrid.TabIndex = 4;

            // DepositBtn
            DepositBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DepositBtn.Location = new Point(545, 424);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(257, 61);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;

            // WithdrawBtn
            WithdrawBtn = new Button();
            WithdrawBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithdrawBtn.Location = new Point(902, 424);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(239, 61);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;

            // CreateAccountBtn
            CreateAccountBtn.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccountBtn.Location = new Point(155, 191);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(215, 34);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;

            // label3 - Interest rate
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 94);
            label3.Name = "label3";
            label3.Size = new Size(211, 38);
            label3.TabIndex = 8;
            label3.Text = "interest rate(%):";

            // InterestRateNum
            InterestRateNum.Location = new Point(254, 103);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(119, 31);
            InterestRateNum.TabIndex = 9;

            // TotalBalanceLbl
            TotalBalanceLbl.AutoSize = true;
            TotalBalanceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalBalanceLbl.Location = new Point(535, 322);
            TotalBalanceLbl.Name = "TotalBalanceLbl";
            TotalBalanceLbl.Size = new Size(78, 32);
            TotalBalanceLbl.TabIndex = 10;
            TotalBalanceLbl.Text = "label4";

            // TotalInterestLbl
            TotalInterestLbl.AutoSize = true;
            TotalInterestLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalInterestLbl.Location = new Point(917, 322);
            TotalInterestLbl.Name = "TotalInterestLbl";
            TotalInterestLbl.Size = new Size(78, 32);
            TotalInterestLbl.TabIndex = 11;
            TotalInterestLbl.Text = "label4";

            // SearchTxt
            SearchTxt.Location = new Point(576, 39);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.Size = new Size(150, 31);
            SearchTxt.TabIndex = 12;

            // SearchBtn
            SearchBtn.Location = new Point(792, 44);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(112, 34);
            SearchBtn.TabIndex = 13;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;

            // ResetBtn
            ResetBtn.Location = new Point(978, 44);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(112, 34);
            ResetBtn.TabIndex = 14;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetBtn_Click;

            // DeactivateBtn
            DeactivateBtn.Location = new Point(545, 515);
            DeactivateBtn.Name = "DeactivateBtn";
            DeactivateBtn.Size = new Size(200, 40);
            DeactivateBtn.TabIndex = 15;
            DeactivateBtn.Text = "Deactivate";
            DeactivateBtn.UseVisualStyleBackColor = true;
            DeactivateBtn.Click += DeactivateBtn_Click;

            // RestoreBtn
            RestoreBtn.Location = new Point(770, 515);
            RestoreBtn.Name = "RestoreBtn";
            RestoreBtn.Size = new Size(200, 40);
            RestoreBtn.TabIndex = 16;
            RestoreBtn.Text = "Restore";
            RestoreBtn.UseVisualStyleBackColor = true;
            RestoreBtn.Click += RestoreBtn_Click;

            // Form1
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 655);
            Controls.Add(RestoreBtn);
            Controls.Add(DeactivateBtn);
            Controls.Add(ResetBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SearchTxt);
            Controls.Add(TotalInterestLbl);
            Controls.Add(TotalBalanceLbl);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AccountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Bank Accounts App";
            ((System.ComponentModel.ISupportInitialize)AccountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AccountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
        private Label TotalBalanceLbl;
        private Label TotalInterestLbl;
        private TextBox SearchTxt;
        private Button SearchBtn;
        private Button ResetBtn;
        private Button DeactivateBtn;
        private Button RestoreBtn;
    }
}
