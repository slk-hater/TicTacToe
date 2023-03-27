using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.App;

namespace TicTacToe
{
    //https://coolors.co/8b9474-6cae75-8bbd8b-c1cc99-f5a65b

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void LoadEvent(object sender, EventArgs e)
        {
            ControlBoxController.setup(this);
            PanelBuilder.build(this);

            GameHandler.main = this;
            GameHandler.PlayerImage = GameHandler.Cross;
            GameHandler.AIImage = GameHandler.Circle;
        }
        private void PaintEvent(object sender, PaintEventArgs e) => GridBuilder.build(e.Graphics);
       
        internal async void MakePlay(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            if (!GameHandler.Playable || !GameHandler.IsPlayerTurn)
                return;

            int x = int.Parse(panel.Name.Substring(1, 1));
            int y = int.Parse(panel.Name.Substring(3, 1));
            if (PanelBuilder.panels[x, y].BackgroundImage != null)
                return;
            PanelBuilder.panels[x, y].BackgroundImage = GameHandler.PlayerImage;
            GameHandler.PlayerMoves++;
            GameHandler.IsPlayerTurn = false;
            turnLbl.Text = "AI's turn";

            if (GameHandler.GetWinner() != "")
            {
                string winner = GameHandler.GetWinner();
                if (winner == "PLAYER") turnLbl.Text = "YOU WON!";
                else if (winner == "AI") turnLbl.Text = "AI WON!";
                else turnLbl.Text = "DRAW!";

                GameHandler.Playable = false;
                GameHandler.ShowWinner();

                await Task.Delay(3500);
                
                PanelBuilder.reset();
                GameHandler.Playable = true;

                if (winner == "PLAYER") GameHandler.IsPlayerTurn = true;
                else if (winner == "AI")
                {
                    GameHandler.IsPlayerTurn = false;
                    await MakeAIPlay();
                }
                turnLbl.Text = GameHandler.IsPlayerTurn ? "Your turn" : "AI's turn";
            }
            else
                await MakeAIPlay();
        }
        internal async Task MakeAIPlay() 
        {
            if (!GameHandler.Playable || GameHandler.IsPlayerTurn)
                return;

            await Task.Delay(GameHandler.random.Next(200, 500));

            int x = GameHandler.random.Next(0, GridBuilder.NUM_CELLS_ROW);
            int y = GameHandler.random.Next(0, GridBuilder.NUM_CELLS_ROW);
            if (PanelBuilder.panels[x, y].BackgroundImage != null)
            {
                await MakeAIPlay();
                return;
            }
            PanelBuilder.panels[x, y].BackgroundImage = GameHandler.AIImage;
            GameHandler.AIMoves++;
            GameHandler.IsPlayerTurn = true;
            turnLbl.Text = "Your turn";

            if (GameHandler.GetWinner() != "")
            {
                string winner = GameHandler.GetWinner();
                if (winner == "PLAYER") turnLbl.Text = "YOU WON!";
                else if (winner == "AI") turnLbl.Text = "AI WON!";
                else turnLbl.Text = "DRAW!";

                GameHandler.Playable = false;
                GameHandler.ShowWinner();

                await Task.Delay(3500);

                PanelBuilder.reset();
                GameHandler.Playable = true;

                if (winner == "PLAYER") GameHandler.IsPlayerTurn = true;
                else if (winner == "AI")
                {
                    GameHandler.IsPlayerTurn = false;
                    await MakeAIPlay();
                }
                turnLbl.Text = GameHandler.IsPlayerTurn ? "Your turn" : "AI's turn";
            }
        }

        private void HomeClickEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void ControlBoxMouseHoverEvent(object sender, EventArgs e)
        {
            if (!(sender is PictureBox pb)) return;
            ControlBoxController.toggleActive(pb);
        }
        private void LeaveClickEvent(object sender, EventArgs e) => this.Close();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void MoveFormEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
