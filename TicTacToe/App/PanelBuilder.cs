using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public static class PanelBuilder
    {
        public static Panel[,] panels = new Panel[3,3];

        static Color BG_COLOR = Color.Transparent;
        static Color FORE_COLOR = Color.Black;
        static Size PANEL_SIZE = new Size(GridBuilder.CELL_SIZE-GridBuilder.PEN_WIDTH-3, GridBuilder.CELL_SIZE-GridBuilder.PEN_WIDTH-3);

        public static void build(Main main)
        {
            int y = GridBuilder.CONTAINER_OFFSET+GridBuilder.PEN_WIDTH;

            for(int r = 0; r < panels.GetLength(0); r++)
            {
                int x = 1;
                for (int c = 0; c < panels.GetLength(1); c++)
                {
                    Panel panel = new Panel();
                    panel.Name = $"r{r}c{c}Pnl";
                    panel.Tag = "Playable";
                    panel.BackColor = BG_COLOR;
                    panel.ForeColor = FORE_COLOR;
                    panel.Location = new Point(x, y);
                    panel.Size = PANEL_SIZE;
                    panel.BackgroundImageLayout = ImageLayout.Zoom;
                    panel.Click += main.MakePlay;
                    panels[r, c] = panel;
                    main.Controls.Add(panel);

                    x += GridBuilder.CELL_SIZE;
                }
                y += GridBuilder.CELL_SIZE;
            }
        }
        public static void reset()
        {
            foreach (var panel in panels)
                panel.BackgroundImage = null;
        }
    }
}
