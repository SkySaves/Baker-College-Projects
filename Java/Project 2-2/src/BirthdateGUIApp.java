import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

public class BirthdateGUIApp {
    public BirthdateGUIApp() {
        // main window
        JFrame frame = new JFrame("Age Calculator");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(300, 200);

        // Creating the panel and layout components
        JPanel panel = new JPanel();
        JTextField birthDateField = new JTextField(10);
        birthDateField.setToolTipText("Enter birthdate (MM/dd/yyyy)");
        JButton calculateButton = new JButton("Calculate Age");
        JLabel ageLabel = new JLabel("Enter your birthdate and click 'Calculate Age'");

        // add components
        panel.add(birthDateField);
        panel.add(calculateButton);
        panel.add(ageLabel);

        // ActionListener to button
        calculateButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String birthDateString = birthDateField.getText();
                SimpleDateFormat sdf = new SimpleDateFormat("MM/dd/yyyy");
                try {
                    Date birthDate = sdf.parse(birthDateString);
                    int age = calculateAge(birthDate);
                    ageLabel.setText("Your age is: " + age);
                } catch (ParseException parseException) {
                    ageLabel.setText("Invalid date format. Use MM/dd/yyyy");
                }
            }
        });

        // add the panel
        frame.add(panel);

        frame.setVisible(true);
    }

    private int calculateAge(Date birthDate) {
        Calendar birth = Calendar.getInstance();
        birth.setTime(birthDate);
        Calendar today = Calendar.getInstance();
        int age = today.get(Calendar.YEAR) - birth.get(Calendar.YEAR);
        if (today.get(Calendar.DAY_OF_YEAR) < birth.get(Calendar.DAY_OF_YEAR)) {
            age--;
        }
        return age;
    }

    public static void main(String[] args) {
        new BirthdateGUIApp();
    }
}
