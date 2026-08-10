# BankAccountsApp

A desktop-based banking management system developed using C# Windows Forms and MySQL.
The application demonstrates Object-Oriented Programming, database integration,
account management, and basic banking operations.
<img width="1350" height="708" alt="banking-system" src="https://github.com/user-attachments/assets/4c65d2b5-20a4-44ad-b00a-5b2fe55233a4" />

## ✨ Key Features

- Create bank accounts
- Automatic account number generation
- Deposit money
- Withdraw money
- Calculate interest
- Search for accounts
- View account information
- Activate and manage accounts
- Store account data in MySQL
- Validate banking transactions

  ## 🛠️ Technologies Used

- C#
- .NET
- Windows Forms
- MySQL
- MySQL Connector/NET
- Object-Oriented Programming
- SQL
- Git
- GitHub

  ## 🏦 How It Works

The application allows users to manage bank accounts through a Windows Forms
interface. Account information is stored in a MySQL database.

Users can create accounts, perform deposits and withdrawals, search for
accounts, calculate interest, and manage account status.

## 📁 Project Structure

BankAccountsApp/
│
├── BankAccountsApp/
│   ├── BankAccount.cs
│   ├── SavingsAccount.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Form1.resx
│   └── Program.cs
│
├── .gitignore
├── .gitattributes
├── BankAccountsApp.slnx
└── README.md

## 7. Database

The application uses MySQL to store and manage bank account information.

Database credentials are not stored directly in the source code.
The database password is retrieved using the `BANK_DB_PASSWORD` Windows
environment variable.

## ⚙️ How to Run

### Requirements

- Windows
- Visual Studio
- .NET SDK
- MySQL Server
- MySQL Connector/NET

### Steps

1. Clone the repository.
2. Open `BankAccountsApp.slnx` in Visual Studio.
3. Create the required MySQL database.
4. Configure the `BANK_DB_PASSWORD` environment variable.
5. Build the project.
6. Run the application.

## 📚 What I Learned

Through this project, I strengthened my skills in:

- C# programming
- Object-Oriented Programming
- Windows Forms
- MySQL and SQL
- Database connectivity
- CRUD operations
- Input validation
- Git and GitHub
- Secure handling of database credentials

  ## 🚀 Future Improvements

- User authentication and authorization
- Transaction history
- Customer management
- PDF transaction reports
- Advanced search and filtering
- Role-based access control
- Automated testing
- Improved user interface

  ## 👩‍💻 Author

**Nishyirimbere Adelphine**

Business Information Technology Student  
University of Rwanda

Interested in software development, databases, and data analytics.
