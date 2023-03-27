using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.App
{
    public static class GameHandler
    {
        public static Main main;
        public static readonly Random random = new Random();

        public static Image Cross = Properties.Resources.cross;
        public static Image Circle = Properties.Resources.circle;

        public static bool Playable = true;

        public static int PlayerWins = 0;
        public static int PlayerMoves = 0;
        public static Image PlayerImage;
        public static bool IsPlayerTurn = true;

        public static int AIWins = 0;
        public static int AIMoves = 0;
        public static Image AIImage;

        public static bool IsPanelActive(Panel p) => p != null && p.BackgroundImage != null;
        public static void TogglePanels()
        {
            foreach(var panel in PanelBuilder.panels)
                panel.Enabled = !panel.Enabled;
        }
        public static string GetPlayer(Panel p)
        {
            string str = "";
            if (p.BackgroundImage == PlayerImage)
                str = "PLAYER";
            else if (p.BackgroundImage == AIImage)
                str = "AI";
            return str;
        }
        public static string GetWinner()
        {
            string winner = "";
            Panel[,] gridPanels = PanelBuilder.panels;

            // CHECK ROWS
            for (int r = 0; r < GridBuilder.NUM_CELLS_ROW; r++)
            {
                if (IsPanelActive(gridPanels[r, 0]) &&
                        gridPanels[r, 0].BackgroundImage == gridPanels[r, 1].BackgroundImage &&
                        gridPanels[r, 1].BackgroundImage == gridPanels[r, 2].BackgroundImage)
                    winner = GetPlayer(gridPanels[r, 0]);
            }

            // CHECK COLUMNS
            for (int c = 0; c < GridBuilder.NUM_CELLS_ROW; c++)
            {
                if (IsPanelActive(gridPanels[0, c]) &&
                        gridPanels[0, c].BackgroundImage == gridPanels[1, c].BackgroundImage &&
                        gridPanels[1, c].BackgroundImage == gridPanels[2, c].BackgroundImage)
                    winner = GetPlayer(gridPanels[0, c]);
            }

            // CHECK DIAGONALS
            if (IsPanelActive(gridPanels[0, 0]) &&
                    gridPanels[0, 0].BackgroundImage == gridPanels[1, 1].BackgroundImage &&
                    gridPanels[1, 1].BackgroundImage == gridPanels[2, 2].BackgroundImage)
                winner = GetPlayer(gridPanels[0, 0]);

            if (IsPanelActive(gridPanels[0, 2]) &&
                    gridPanels[0, 2].BackgroundImage == gridPanels[1, 1].BackgroundImage &&
                    gridPanels[1, 1].BackgroundImage == gridPanels[2, 0].BackgroundImage)
                winner = GetPlayer(gridPanels[0, 2]);

            bool empty = false;
            foreach (var panel in gridPanels)
                if (panel.BackgroundImage == null)
                    empty = true;

            if (!empty && winner == "")
                winner = "DRAW";

            return winner;
        }
        public static void ShowWinner()
        {
            /*Panel overlay = new Panel();
            overlay.Name = "overlayPnl";
            overlay.BackColor = Color.FromArgb(150, Color.Black);
            overlay.Dock = DockStyle.Fill;
            overlay.BringToFront();

            foreach (var panel in PanelBuilder.panels)
                panel.Parent = overlay;

            main.Controls.Add(overlay);*/
        }
    }
}
