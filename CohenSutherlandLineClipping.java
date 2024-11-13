

package com.mycompany.cohensutherlandlineclipping;

import javax.swing.*;
import java.awt.*;

public class CohenSutherlandLineClipping extends JPanel {
    private final int W_xmin = 50, W_ymin = 50, W_xmax = 400, W_ymax = 400;
    private int x = 20, y = 30, x1 = 450, y1 = 420; // Hardcoded values for the initial and final points

    private final int INSIDE = 0; // 0000
    private final int LEFT = 1;   // 0001
    private final int RIGHT = 2;  // 0010
    private final int BOTTOM = 4; // 0100
    private final int TOP = 8;    // 1000

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        g.drawRect(W_xmin, W_ymin, W_xmax - W_xmin, W_ymax - W_ymin); // Drawing the clipping window
        g.drawLine(x, y, x1, y1); // Drawing the original line

        int[] clippedLine = cohenSutherlandClip(x, y, x1, y1);

        if (clippedLine != null) {
            g.setColor(Color.RED);
            g.drawLine(clippedLine[0], clippedLine[1], clippedLine[2], clippedLine[3]); // Drawing the clipped line
        } else {
            g.drawString("Line is completely outside the window", 20, 20);
        }
    }

    private int computeOutCode(int x, int y) {
        int code = INSIDE;

        if (x < W_xmin) {
            code |= LEFT;
        } else if (x > W_xmax) {
            code |= RIGHT;
        }
        if (y < W_ymin) {
            code |= BOTTOM;
        } else if (y > W_ymax) {
            code |= TOP;
        }

        return code;
    }

    private int[] cohenSutherlandClip(int x0, int y0, int x1, int y1) {
        int outcode0 = computeOutCode(x0, y0);
        int outcode1 = computeOutCode(x1, y1);
        boolean accept = false;

        while (true) {
            if ((outcode0 | outcode1) == 0) {
                // Both points are inside the window
                accept = true;
                break;
            } else if ((outcode0 & outcode1) != 0) {
                // Both points share an outside region, trivial reject
                break;
            } else {
                int outcodeOut;
                int x = 0, y = 0;

                // Pick the outside point
                outcodeOut = (outcode0 != 0) ? outcode0 : outcode1;

                // Find intersection point
                if ((outcodeOut & TOP) != 0) {
                    x = x0 + (x1 - x0) * (W_ymax - y0) / (y1 - y0);
                    y = W_ymax;
                } else if ((outcodeOut & BOTTOM) != 0) {
                    x = x0 + (x1 - x0) * (W_ymin - y0) / (y1 - y0);
                    y = W_ymin;
                } else if ((outcodeOut & RIGHT) != 0) {
                    y = y0 + (y1 - y0) * (W_xmax - x0) / (x1 - x0);
                    x = W_xmax;
                } else if ((outcodeOut & LEFT) != 0) {
                    y = y0 + (y1 - y0) * (W_xmin - x0) / (x1 - x0);
                    x = W_xmin;
                }

                if (outcodeOut == outcode0) {
                    x0 = x;
                    y0 = y;
                    outcode0 = computeOutCode(x0, y0);
                } else {
                    x1 = x;
                    y1 = y;
                    outcode1 = computeOutCode(x1, y1);
                }
            }
        }

        if (accept) {
            return new int[]{x0, y0, x1, y1};
        } else {
            return null;
        }
    }

    public static void main(String[] args) {
        JFrame frame = new JFrame();
        CohenSutherlandLineClipping panel = new CohenSutherlandLineClipping();
        frame.add(panel);
        frame.setSize(500, 500);
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setVisible(true);
    }
}
