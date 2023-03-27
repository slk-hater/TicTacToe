using System.Drawing;

namespace TicTacToe
{
    public static class GridBuilder
    {
        public static int PEN_WIDTH = 3;
        static Color PEN_COLOR = Color.FromArgb(193, 204, 153);
        static Pen PEN = new Pen(PEN_COLOR, PEN_WIDTH);

        public static Size CONTAINER_SIZE = new Size(600, 600);
        public static int CONTAINER_OFFSET = 50;
        public static int NUM_CELLS_ROW = 3;
        public static int CELL_SIZE = CONTAINER_SIZE.Width/NUM_CELLS_ROW;

        public static void build(Graphics g)
        {
            g.TranslateTransform(0-PEN_WIDTH, CONTAINER_OFFSET-PEN_WIDTH+3);
            
            for (int y = 0; y < NUM_CELLS_ROW; y++)
                g.DrawLine(PEN, 0, y * CELL_SIZE, NUM_CELLS_ROW * CELL_SIZE, y * CELL_SIZE);
            for (int x = 0; x < NUM_CELLS_ROW; x++)
                g.DrawLine(PEN, x * CELL_SIZE, 0, x * CELL_SIZE, NUM_CELLS_ROW * CELL_SIZE);
        }
    }
}
