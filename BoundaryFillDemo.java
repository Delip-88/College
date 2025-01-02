package com.mycompany.boundaryfilldemo;

import javax.swing.*;
import java.awt.*;
import java.awt.image.BufferedImage;

public class BoundaryFillDemo extends JPanel {
    private final BufferedImage canvas;
    private final int width = 400, height = 400;

    public BoundaryFillDemo() {
        canvas = new BufferedImage(width, height, BufferedImage.TYPE_INT_ARGB);
        drawInitialShape();
    }

    private void drawInitialShape() {
        Graphics2D g = canvas.createGraphics();
        g.setColor(Color.WHITE); // Fill the rectangle with white
        g.fillRect(100, 100, 200, 200); // Draw a filled rectangle
        g.setColor(Color.BLACK); // Set the boundary color to black
        g.drawRect(100, 100, 200, 200); // Draw the rectangle boundary
        g.dispose();
    }

    private void boundaryFill(int x, int y, Color fillColor, Color boundaryColor) {
        if (x < 0 || x >= width || y < 0 || y >= height) return;
        Color currentColor = new Color(canvas.getRGB(x, y), true);
        if (currentColor.equals(boundaryColor) || currentColor.equals(fillColor)) return;

        canvas.setRGB(x, y, fillColor.getRGB());

        boundaryFill(x + 1, y, fillColor, boundaryColor);
        boundaryFill(x - 1, y, fillColor, boundaryColor);
        boundaryFill(x, y + 1, fillColor, boundaryColor);
        boundaryFill(x, y - 1, fillColor, boundaryColor);
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawImage(canvas, 0, 0, null);
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame("Boundary Fill Demo");
        BoundaryFillDemo panel = new BoundaryFillDemo();

        frame.add(panel);
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);

        // Start the boundary fill on the rectangle
        SwingUtilities.invokeLater(() -> {
            panel.boundaryFill(150, 150, Color.BLACK, Color.RED); // Fill with black, boundary is white
            panel.repaint();
        });
    }
}
