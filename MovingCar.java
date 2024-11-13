
package com.mycompany.movingcar;

import java.awt.*;
import javax.swing.*;

public class MovingCar extends JPanel {

    private int x = 0;

    public MovingCar() {
        Timer timer = new Timer(100, e -> {
            x += 10;  // Move the car by 10 units on every tick
            repaint();  // Repaint the car in the new position
        });
        timer.start();
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);

        // Draw the car at the current position
        g.setColor(Color.RED);
        g.drawLine(x, 300, x + 210, 300);               // Body
        g.drawLine(x + 50, 300, x + 75, 270);           // Front diagonal
        g.drawLine(x + 75, 270, x + 150, 270);          // Top
        g.drawLine(x + 150, 270, x + 165, 300);         // Rear diagonal
        g.drawLine(x, 300, x, 330);                     // Left vertical
        g.drawLine(x + 210, 300, x + 210, 330);         // Right vertical
        g.drawOval(x + 65, 330, 30, 30);                // Left wheel
        g.drawOval(x + 145, 330, 30, 30);               // Right wheel
        g.fillOval(x + 65 + 13, 330 + 13, 4, 4);        // Left hub
        g.fillOval(x + 145 + 13, 330 + 13, 4, 4);       // Right hub
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Moving Car");
        MovingCar car = new MovingCar();
        frame.add(car);
        frame.setSize(800, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
