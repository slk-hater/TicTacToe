using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe.App
{
    public static class ControlBoxController
    {
        public static Image HomeImage = Properties.Resources.home;
        public static Image HomeActiveImage = Properties.Resources.homeActive;
        public static PictureBox HomeButton;

        public static Image LeaveImage = Properties.Resources.leave;
        public static Image LeaveActiveImage = Properties.Resources.leaveActive;
        public static PictureBox LeaveButton;

        public static Image[] Stickers = { Properties.Resources.desert };

        public static void setup(Main main)
        { 
            Panel container = main.Controls.OfType<Panel>().Where(p => p.Name == "controlBoxPnl").First();
            HomeButton = container.Controls.OfType<PictureBox>().Where(pb => pb.Name == "homePb").First();
            HomeButton.Image = HomeImage;

            LeaveButton = container.Controls.OfType<PictureBox>().Where(pb => pb.Name == "leavePb").First();
            LeaveButton.Image = LeaveImage;
        }
        public static void toggleActive(PictureBox pb)
        {
            if(pb == HomeButton) HomeButton.Image = HomeButton.Image == HomeImage ? HomeActiveImage : HomeImage;
            
            if(pb == LeaveButton) LeaveButton.Image = LeaveButton.Image == LeaveImage ? LeaveActiveImage : LeaveImage;
        }
    }
}
