using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class NameFrame : Form
    {
        public NameFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gameFrame = new GameFrame(textBox1.Text);
            gameFrame.Closed += (s, args) => this.Close();
            gameFrame.Show();
        }
    }
}
