public class TestBankAccount {
    public static void main(String[] args) {
        CheckingAccount myAccount = new CheckingAccount();
        myAccount.setFirstName("Hugh");
        myAccount.setLastName("Mungus"); 
        myAccount.setAccountID(123456);
        myAccount.deposit(500);
        myAccount.processWithdrawal(550); 
        myAccount.setInterestRate(4.20); 
        myAccount.displayAccount(); 
    }
}
