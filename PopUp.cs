using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }

        public void GameWin()
        {
            label1.Text = "You win!";
        }
        public void GameLose()
        {
            label1.Text = "You lose!";
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }
    }
}
