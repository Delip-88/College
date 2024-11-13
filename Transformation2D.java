
package com.mycompany.transformation2d;

import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import java.awt.geom.AffineTransform;

public class Transformation2D extends JPanel implements ActionListener {
    // Original triangle vertices
    int[] x = {50, 100, 120};
    int[] y = {50, 150, 80};

    // Variables for transformation
    double tx = 1.2, ty = 1.2;   // Translation factors
    double sx = 2, sy = 2; // Scaling factors
    double angle = Math.toRadians(45);      // Rotation angle in radians

    public Transformation2D() {
        // Setting up the GUI
        JFrame frame = new JFrame("2D Transformations");
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.add(this);
        frame.setVisible(true);
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        Graphics2D g2d = (Graphics2D) g;

        // Apply transformations using AffineTransform
        AffineTransform transform = new AffineTransform();

        // Uncomment the transformation you want to see and comment the others

        // 1. Translation
         applyTranslation(transform);

        // 2. Scaling
//         applyScaling(transform);

        // 3. Rotation
//        applyRotation(transform);

        // Apply the transformation to the Graphics2D object
        g2d.setTransform(transform);

        // Draw the transformed triangle
        g2d.setColor(Color.BLUE);
        g2d.drawPolygon(x, y, 3);
    }

    // Function to apply translation
    private void applyTranslation(AffineTransform transform) {
        transform.translate(tx, ty);
    }

    // Function to apply scaling
    private void applyScaling(AffineTransform transform) {
        transform.scale(sx, sy);
    }

    // Function to apply rotation
    private void applyRotation(AffineTransform transform) {
        int centerX = (x[0] + x[1] + x[2]) / 3;
        int centerY = (y[0] + y[1] + y[2]) / 3;
        transform.rotate(angle, centerX, centerY);
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        // Trigger the repaint of the JPanel
        repaint();
    }

    public static void main(String[] args) {
        new Transformation2D();
    }
}
