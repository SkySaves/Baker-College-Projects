# Java Project 1-1: Bank Account Management System

## Description

This Java project demonstrates the fundamentals of object-oriented programming through the creation of a simple bank account management system. It features a base class `BankAccount` that models a generic bank account, a derived class `CheckingAccount` that extends `BankAccount` to include specific functionalities like overdraft processing, and a `TestBankAccount` class to test the functionalities of these accounts.

## Features

- **BankAccount**: A class that models the basic attributes and behaviors of a bank account, such as depositing and withdrawing funds, along with account details like first name, last name, account ID, and balance.
- **CheckingAccount**: Inherits from `BankAccount` and adds specific features like processing withdrawals with an overdraft fee and managing an interest rate.
- **TestBankAccount**: Contains the `main` method to run the application. It demonstrates the creation of a `CheckingAccount`, deposit and withdrawal operations, and setting an interest rate.

## How to Run

Ensure you have Java installed on your system. Compile and run `TestBankAccount.java` to see the bank account system in action.


## Output
Running TestBankAccount simulates creating a checking account, making a deposit, attempting a withdrawal that triggers an overdraft fee, and displaying the account details including the interest rate.
