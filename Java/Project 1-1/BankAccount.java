public class BankAccount {
    String firstName, lastName;
    int accountID; // unique ID
    double balance = 0.0; // start with zero balance.

    // constructor
    public BankAccount() {
        // starting with zero balance.
    }

    // tdeposit some cash
    public void deposit(double amount) {
        balance += amount; // ading the amount to balance
    }

    // take out some cash
    public void withdrawal(double amount) {
        if (balance >= amount) {
            balance -= amount; // subtracting the amount from balance
        } else {
            System.out.println("Not enough funds.");
        }
    }

    // setters and getters
    public void setFirstName(String firstName) {
        this.firstName = firstName; // setting the first name
    }

    public String getFirstName() {
        return firstName; // getting the first name.
    }

    public void setLastName(String lastName) {
        this.lastName = lastName; // setting the last name.
    }

    public String getLastName() {
        return lastName; // getting the last name
    }

    public void setAccountID(int accountID) {
        this.accountID = accountID; // setting the account ID
    }

    public int getAccountID() {
        return accountID; // getting the account ID
    }


    public double getBalance() {
        return balance; 
    }

    // everything you need to know about the account
    public void accountSummary() {
        System.out.println("Account ID: " + accountID + " | Name: " + firstName + " " + lastName + " | Balance: $" + balance);
    }
}
