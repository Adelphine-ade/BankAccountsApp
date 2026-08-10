using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        // 🔹 Create new account
        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerTxt.Text))
                return;

            decimal interestRate = InterestRateNum.Value;
            string accountNumber = Guid.NewGuid().ToString();

            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "INSERT INTO Accounts (Owner, AccountNumber, Balance, InterestRate, IsActive) " +
                               "VALUES (@Owner, @Acc, @Bal, @Rate, TRUE)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Owner", OwnerTxt.Text);
                cmd.Parameters.AddWithValue("@Acc", accountNumber);
                cmd.Parameters.AddWithValue("@Bal", 0);
                cmd.Parameters.AddWithValue("@Rate", interestRate);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Account created successfully!");
            OwnerTxt.Text = "";
            InterestRateNum.Value = 0;
            LoadData();
        }

        // 🔹 Deposit
        private void DepositBtn_Click(object sender, EventArgs e)
        {
            decimal amount = AccountNum.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Deposit amount must be greater than 0!");
                return;
            }

            if (BankAccountsGrid.CurrentRow != null)
            {
                string accountNumber = BankAccountsGrid.CurrentRow.Cells["AccountNumber"].Value.ToString();
                decimal currentBalance = Convert.ToDecimal(BankAccountsGrid.CurrentRow.Cells["Balance"].Value);
                decimal interestRate = Convert.ToDecimal(BankAccountsGrid.CurrentRow.Cells["InterestRate"].Value);

                decimal interestAmount = (interestRate / 100) * amount;
                decimal newBalance = currentBalance + amount + interestAmount;

                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    string query = "UPDATE Accounts SET Balance = @Balance WHERE AccountNumber = @Acc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Balance", newBalance);
                    cmd.Parameters.AddWithValue("@Acc", accountNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Deposit completed!");
                LoadData();
                AccountNum.Value = 0;
            }
        }

        // 🔹 Withdraw
        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            decimal amount = AccountNum.Value;
            if (amount <= 0)
            {
                MessageBox.Show("Withdrawal amount must be greater than 0!");
                return;
            }

            if (BankAccountsGrid.CurrentRow != null)
            {
                string accountNumber = BankAccountsGrid.CurrentRow.Cells["AccountNumber"].Value.ToString();
                decimal currentBalance = Convert.ToDecimal(BankAccountsGrid.CurrentRow.Cells["Balance"].Value);

                if (amount > currentBalance)
                {
                    MessageBox.Show("Not enough balance!");
                    return;
                }

                decimal newBalance = currentBalance - amount;

                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    string query = "UPDATE Accounts SET Balance = @Balance WHERE AccountNumber = @Acc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Balance", newBalance);
                    cmd.Parameters.AddWithValue("@Acc", accountNumber);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Withdrawal completed!");
                LoadData();
                AccountNum.Value = 0;
            }
        }

        // 🔹 Load data
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "SELECT * FROM Accounts WHERE IsActive = TRUE";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                BankAccountsGrid.DataSource = dt;

                decimal totalBalance = 0;
                decimal totalInterest = 0;
                foreach (DataRow row in dt.Rows)
                {
                    decimal balance = Convert.ToDecimal(row["Balance"]);
                    decimal rate = Convert.ToDecimal(row["InterestRate"]);

                    totalBalance += balance;
                    totalInterest += (balance * rate / 100);
                }

                TotalBalanceLbl.Text = $"Total Balance: {totalBalance:N2}";
                TotalInterestLbl.Text = $"Total Interest Earned: {totalInterest:N2}";
            }
        }

        // 🔹 Search
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchTxt.Text.Trim();
            using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                string query = "SELECT * FROM Accounts WHERE Owner LIKE @Owner";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Owner", "%" + searchText + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                BankAccountsGrid.DataSource = dt;
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SearchTxt.Text = "";
            LoadData();
        }

        private void DeactivateBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.CurrentRow != null)
            {
                string accountNumber = BankAccountsGrid.CurrentRow.Cells["AccountNumber"].Value.ToString();
                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    string query = "UPDATE Accounts SET IsActive = FALSE WHERE AccountNumber = @Acc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Acc", accountNumber);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadData();
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.CurrentRow != null)
            {
                string accountNumber = BankAccountsGrid.CurrentRow.Cells["AccountNumber"].Value.ToString();
                using (MySqlConnection conn = new MySqlConnection(DatabaseConfig.ConnectionString))
                {
                    string query = "UPDATE Accounts SET IsActive = TRUE WHERE AccountNumber = @Acc";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Acc", accountNumber);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadData();
            }
        }
    }
}
