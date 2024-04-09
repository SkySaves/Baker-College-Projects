public class CheckingAccount extends BankAccount {
    double interestRate;

    // constructor
    public CheckingAccount() {
        super(); // calling the parent constructor
    }

    //  fee
    public void processWithdrawal(double amount) {
        if (getBalance() < amount) {
            System.out.println("Overdraft! You're being charged a $30 fee.");
            super.withdrawal(amount + 30); // Withdraw the amount plus fee.
        } else {
            super.withdrawal(amount);
        }
    }

    // displaying everything and a bit more.
    public void displayAccount() {
        super.accountSummary(); // Showing the basic info.
        System.out.println("Interest Rate: " + interestRate + "%");
    }

    //  in case we need to change the rate.
    public void setInterestRate(double interestRate) {
        this.interestRate = interestRate; // setting the interest rate
    }

    public double getInterestRate() {
        return interestRate; // getting the interest rate
    }
}
