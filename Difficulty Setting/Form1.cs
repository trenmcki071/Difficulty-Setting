using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty_Setting
{
    public partial class selectDifficulty : Form
    {
        public selectDifficulty()
        {
            InitializeComponent();
        }
        string heroName;
        string difficultyLevel;
        private void Easy_Click(object sender, EventArgs e)
        {
            difficultyLevel = $"easy";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            heroName = textBox.Text;
        }

        private void Begin_Click(object sender, EventArgs e)
        {
            
            Message.Text = $"Welcome, {heroName}, Have a great time playing {difficultyLevel} mode";
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            difficultyLevel = $"medium";
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            difficultyLevel = $"hard";
        }
    }
}
