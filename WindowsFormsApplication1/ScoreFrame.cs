using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedProject1;

namespace WindowsFormsApplication1
{
    public partial class ScoreFrame : Form
    {
        #region setup dragBar

        private const int WmNclbuttondown = 0xA1;
        private const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
            int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        #endregion

       

        public ScoreFrame(List<GameInformation> list)
        {
            InitializeComponent();


            foreach (GameInformation score in list)
                scorePanel.Rows.Add(score.DateTime.ToString(CultureInfo.InvariantCulture), score.Player1, score.Player2, score.Score);

            scorePanel.Sort(scorePanel.Columns[3],ListSortDirection.Descending);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menubarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            menubarPanel_MouseDown(sender, e);
        }
    }
}
