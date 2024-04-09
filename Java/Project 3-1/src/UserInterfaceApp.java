import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.FileWriter;
import java.io.IOException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Random;

public class UserInterfaceApp {
    private JTextArea textArea;

    public UserInterfaceApp() {
        JFrame frame = new JFrame("User Interface I");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(500, 400);

        textArea = new JTextArea();
        JScrollPane scrollPane = new JScrollPane(textArea);
        frame.add(scrollPane);

        JMenuBar menuBar = new JMenuBar();
        JMenu menu = new JMenu("Options");
        menuBar.add(menu);

        JMenuItem menuItemDate = new JMenuItem("Show Date/Time");
        menuItemDate.addActionListener(e -> showDateTime());
        menu.add(menuItemDate);

        JMenuItem menuItemSave = new JMenuItem("Save Log");
        menuItemSave.addActionListener(e -> saveLog());
        menu.add(menuItemSave);

        JMenuItem menuItemColor = new JMenuItem("Change Background Color");
        menuItemColor.addActionListener(e -> changeBackgroundColor());
        menu.add(menuItemColor);

        JMenuItem menuItemExit = new JMenuItem("Exit");
        menuItemExit.addActionListener(e -> System.exit(0));
        menu.add(menuItemExit);

        frame.setJMenuBar(menuBar);
        frame.setVisible(true);
    }

    private void showDateTime() {
        SimpleDateFormat dateFormat = new SimpleDateFormat("MM/dd/yyyy, hh:mm a");
        textArea.setText(dateFormat.format(new Date()));
    }

    private void saveLog() {
        try (FileWriter writer = new FileWriter("log.txt")) {
            writer.write(textArea.getText());
        } catch (IOException ex) {
            ex.printStackTrace();
        }
    }

    private void changeBackgroundColor() {
        Random rand = new Random();
        Color greenHue = new Color(rand.nextFloat(), 0.5f + rand.nextFloat() * 0.5f, rand.nextFloat());
        textArea.setBackground(greenHue);
        textArea.setOpaque(true);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> new UserInterfaceApp());
    }
}
