import javax.swing.*;
import java.awt.*;

public class MainFrame extends JFrame{

    JLabel labelTask;
    JLabel labelResult;
    JTextField textFieldNum1;
    JTextField textFieldNum2;
    JButton button;

    int num1;
    int num2;

    String task;
    String result;

    public MainFrame() {
        super("Window");
        super.setBounds(500, 100, 150,150);
        super.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        Container container = super.getContentPane();
        GridLayout gridLayout = new GridLayout(5,1,4,4);
        container.setLayout(gridLayout);

        task = "<html>Задание: Даны два натуральных числа a и b, не равные нулю одновременно.<br>" +
                      "Вычислите Наибольший Общий Делитель (НОД) a и b.</html>";

        labelTask = new JLabel(task);
        textFieldNum1 = new JTextField("Введите 1ое число");
        textFieldNum2 = new JTextField("Введите 2ое число");
        button = new JButton("Вычислить");
        labelResult = new JLabel("Ответ");

        labelTask.setHorizontalAlignment(JLabel.CENTER);
        labelResult.setHorizontalAlignment(JLabel.CENTER);

        labelTask.setFont(new Font(Font.SERIF, Font.PLAIN, 14));
        textFieldNum1.setFont(new Font(Font.SERIF, Font.BOLD, 18));
        textFieldNum2.setFont(new Font(Font.SERIF, Font.BOLD, 18));
        button.setFont(new Font(Font.SERIF, Font.BOLD, 16));
        labelResult.setFont(new Font(Font.SERIF, Font.BOLD, 18));

        container.add(labelTask);
        container.add(textFieldNum1);
        container.add(textFieldNum2);
        container.add(button);
        container.add(labelResult);

        button.addActionListener(e -> {
            try {
                num1 = Integer.parseInt(textFieldNum1.getText());
                num2 = Integer.parseInt(textFieldNum2.getText());
                if (num1 <= 0 && num2 <= 0) {
                    result = "Числа не могут быть меньше или равны нулю";
                } else {
                    while (num1 != 0 && num2 != 0) {
                        if (num1 > num2) {
                            num1 = num1 % num2;
                        } else {
                            num2 = num2 % num1;
                        }
                    }
                    result = "Ответ: НОД = " + (num1 + num2);
                }
            } catch (NumberFormatException ex) {
                result = "Ошибка: неверный формат числа";
                textFieldNum1.setText("");
                textFieldNum2.setText("");
            }
            labelResult.setText(result);
        });

    }

}
