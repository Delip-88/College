
package com.mycompany.midpointcircledrawing;

import javax.swing.*;
import java.awt.*;

public class MidPointCircleDrawing extends JPanel {
    private final int x1, y1, radius;

    public MidPointCircleDrawing(int x1, int y1, int radius) {
        this.x1 = x1;
        this.y1 = y1;
        this.radius = radius;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        drawCircle(g, x1, y1, radius);
    }

    public void drawCircle(Graphics g, int x1, int y1, int radius) {
        int x = 0;
        int y = radius;
        int p = 1 - radius;

        // Draw the initial point on the circle
        plotCirclePoints(g, x1, y1, x, y);

        // Mid-point circle drawing algorithm
        while (x <= y) {
            x++;
            if (p < 0) {
                p += 2 * x + 1;
            } else {
                y--;
                p += 2 * (x - y) + 1;
            }
            plotCirclePoints(g, x1, y1, x, y); // Plot points for each (x, y)
        }
    }

    private void plotCirclePoints(Graphics g, int xc, int yc, int x, int y) {
        // Plot the 8 symmetrical points
        g.drawLine(xc + x, yc + y, xc + x, yc + y); // (x, y)
        g.drawLine(xc - x, yc + y, xc - x, yc + y); // (-x, y)
        g.drawLine(xc + x, yc - y, xc + x, yc - y); // (x, -y)
        g.drawLine(xc - x, yc - y, xc - x, yc - y); // (-x, -y)
        g.drawLine(xc + y, yc + x, xc + y, yc + x); // (y, x)
        g.drawLine(xc - y, yc + x, xc - y, yc + x); // (-y, x)
        g.drawLine(xc + y, yc - x, xc + y, yc - x); // (y, -x)
        g.drawLine(xc - y, yc - x, xc - y, yc - x); // (-y, -x)
    }

    public static void main(String[] args) {
        // Hard-coded values
        int x1 = 100, y1 = 100, radius = 50;

        JFrame frame = new JFrame();
        MidPointCircleDrawing panel = new MidPointCircleDrawing(x1, y1, radius);
        frame.add(panel);
        frame.setSize(250, 250);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
