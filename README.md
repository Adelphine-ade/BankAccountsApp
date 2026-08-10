# BankAccountsApp

A desktop-based banking management system built with C# Windows Forms and MySQL.

This project demonstrates practical application development using Object-Oriented Programming, database integration, and Windows Forms.

## 📌 Overview

BankAccountsApp allows users to manage bank accounts and perform common banking operations through a desktop interface.

The project was developed as a practical application of C#, Object-Oriented Programming, MySQL, and database connectivity.

## ✨ Key Features

- Create and manage bank accounts
- Automatic account number generation
- Deposit money
- Withdraw money
- Calculate account interest
- Search for accounts
- Manage account activation status
- Store account information in MySQL
- Validate banking transactions

## 🛠️ Technologies

- **C#**
- **.NET**
- **Windows Forms**
- **MySQL**
- **MySQL Connector/NET**
- **Object-Oriented Programming**
- **Git & GitHub**

## 🏦 Main Functionality

### Account Management

Create and manage customer bank accounts while storing account information in a MySQL database.

### Deposits

Users can deposit money into an account while the application validates the transaction.

### Withdrawals

The system validates withdrawals and helps prevent invalid transactions.

### Interest Calculation

The application supports interest calculations for applicable accounts.

### Account Search

Users can search for existing accounts and view their information.

### Account Status

The application supports account activation management.

## 🔐 Security

Database credentials are **not stored in the source code**.

The application retrieves the database password from a Windows environment variable:

```text
BANK_DB_PASSWORD
