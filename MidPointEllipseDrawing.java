
package com.mycompany.midpointellipsedrawing;

import javax.swing.*;
import java.awt.*;

public class MidPointEllipseDrawing extends JPanel {
    private final int xc, yc, rx, ry;

    public MidPointEllipseDrawing(int xc, int yc, int rx, int ry) {
        this.xc = xc;
        this.yc = yc;
        this.rx = rx;
        this.ry = ry;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        drawEllipse(g, xc, yc, rx, ry);
    }

    public void drawEllipse(Graphics g, int xc, int yc, int rx, int ry) {
        int x = 0;
        int y = ry;
        double p;

        // Region 1
        p = ry * ry - rx * rx * ry + 0.25 * rx * rx;
        while (2.0 * ry * ry * x <= 2.0 * rx * rx * y) {
            plotEllipsePoints(g, xc, yc, x, y);
            if (p < 0) {
                x++;
                p = p + 2 * ry * ry * x + ry * ry;
            } else {
                x++;
                y--;
                p = p + 2 * ry * ry * x - 2 * rx * rx * y - ry * ry;
            }
        }

        // Region 2
        p = ry * ry * (x + 0.5) * (x + 0.5) + rx * rx * (y - 1) * (y - 1) - rx * rx * ry * ry;
        while (y > 0) {
            plotEllipsePoints(g, xc, yc, x, y);
            if (p <= 0) {
                x++;
                y--;
                p = p + 2 * ry * ry * x - 2 * rx * rx * y + rx * rx;
            } else {
                y--;
                p = p - 2 * rx * rx * y + rx * rx;
            }
        }
    }

    private void plotEllipsePoints(Graphics g, int xc, int yc, int x, int y) {
        // Plot the 4 symmetrical points for an ellipse
        g.drawLine(xc + x, yc + y, xc + x, yc + y);
        g.drawLine(xc - x, yc + y, xc - x, yc + y);
        g.drawLine(xc + x, yc - y, xc + x, yc - y);
        g.drawLine(xc - x, yc - y, xc - x, yc - y);
    }

    public static void main(String[] args) {
        // Hard-coded values for center and radii
        int xc = 200, yc = 200, rx = 100, ry = 60;

        JFrame frame = new JFrame();
        MidPointEllipseDrawing panel = new MidPointEllipseDrawing(xc, yc, rx, ry);
        frame.add(panel);
        frame.setSize(400, 400);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
