import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class MetzgerBankGUIApp {
    private double balance = 0.0; // balance

    public MetzgerBankGUIApp() {
        // window settup
        JFrame frame = new JFrame("Simple Bank GUI");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(200, 150);

        // panel and components
        JPanel panel = new JPanel();
        JButton depositButton = new JButton("Deposit $10");
        JButton withdrawButton = new JButton("Withdraw $10");
        JLabel balanceLabel = new JLabel("Balance: $" + balance);

        // deposit button
        depositButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                balance += 10; // add $10
                balanceLabel.setText("Balance: $" + String.format("%.2f", balance));
                if (balance >= 100000) {
                    JOptionPane.showMessageDialog(frame, "wow you've been clicking for a while...");
                }
            }
        });

        //  withdraw button
        withdrawButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                if (balance >= 10) {
                    balance -= 10; // Subtract $10
                    balanceLabel.setText("Balance: $" + balance);
                } else {
                    JOptionPane.showMessageDialog(frame, "You do not have enough funds do to that.");
                }
            }
        });

        // add components to the panel
        panel.add(depositButton);
        panel.add(withdrawButton);
        panel.add(balanceLabel);

        // add the panel to the frame
        frame.add(panel);

        // display
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        new MetzgerBankGUIApp();
    }
}
