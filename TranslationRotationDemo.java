
package com.mycompany.translationrotationdemo;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.AffineTransform;

public class TranslationRotationDemo extends JPanel {
    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;

        // Set anti-aliasing for smoother drawing
        g2d.setRenderingHint(RenderingHints.KEY_ANTIALIASING, RenderingHints.VALUE_ANTIALIAS_ON);

        // Initial Rectangle Coordinates (Top-Left Corner)
        int rectWidth = 100, rectHeight = 50;
        int x = 50, y = 150;

        // Draw Original Rectangle Outline
        g2d.setColor(Color.BLUE);
        g2d.drawRect(x, y, rectWidth, rectHeight);

        // Save original transform
        AffineTransform originalTransform = g2d.getTransform();

        // Translation and Rotation Transformation on Right Side
        AffineTransform transform = new AffineTransform();
        int translateX = 200, translateY = 0;  // Translate to the right
        double rotationAngle = Math.toRadians(45);  // Rotate by 45 degrees

        // Apply translation and rotation
        transform.translate(x + translateX + rectWidth / 2, y + translateY + rectHeight / 2);  // Translate to center of the right side
        transform.rotate(rotationAngle);  // Apply rotation
        transform.translate(-rectWidth / 2, -rectHeight / 2);  // Move back to draw from the top-left

        // Set the transformation to g2d
        g2d.setTransform(transform);

        // Draw Transformed Rectangle Outline
        g2d.setColor(Color.RED);
        g2d.drawRect(0, 0, rectWidth, rectHeight);  // Draw at the origin since transformation applied

        // Reset transformation to original
        g2d.setTransform(originalTransform);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Translation and Rotation Demo");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 400);
        frame.add(new TranslationRotationDemo());
        frame.setVisible(true);
    }
}
