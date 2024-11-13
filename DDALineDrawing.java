package com.mycompany.ddalinedrawing;

import javax.swing.*;
import java.awt.*;

public class DDALineDrawing extends JPanel {
    private final int x1, y1, x2, y2;

    public DDALineDrawing(int x1, int y1, int x2, int y2) {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        int dx = x2 - x1, dy = y2 - y1;
        int steps = Math.max(Math.abs(dx), Math.abs(dy));
        float Xinc = (float) dx / steps, Yinc = (float) dy / steps;
        float X = x1, Y = y1;

        for (int i = 0; i <= steps; i++) {
            g.drawLine(Math.round(X), Math.round(Y), Math.round(X), Math.round(Y));
            X += Xinc;
            Y += Yinc;
        }
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame();
        frame.add(new DDALineDrawing(50, 50, 200, 150));
        frame.setSize(250, 250);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
