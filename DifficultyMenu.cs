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
    public partial class DifficultyMenu : Form
    {
        public DifficultyMenu()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Difficulty.DifficultyLevel = 1;
            Close();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Difficulty.DifficultyLevel = 2;
            Close();
        }
        private void Hard_Click(object sender, EventArgs e)
        {
            Difficulty.DifficultyLevel = 3;
            Close();
        }
    }
}
