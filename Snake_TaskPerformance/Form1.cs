using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snake_TaskPerformance.Properties;

namespace Snake_TaskPerformance
{
    public partial class Snake : MaterialSkin.Controls.MaterialForm
    {
        private SolidBrush brushes = GameSettings.snakeHead;

        public Snake()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Visible = false;
            StartGame startGame = new StartGame();
            startGame.Visible = true;
        }

        private void btn_highscore_Click(object sender, EventArgs e)
        {
            Visible = false;
            Highscore highscore = new Highscore();
            highscore.Visible = true;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog.Equals(DialogResult.Yes))
            {
                MessageBox.Show("THANK YOU FOR PLAYING!");
                Environment.Exit(0);
            }
        }

        private void Snake_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog.Equals(DialogResult.Yes))
            {
                MessageBox.Show("THANK YOU FOR PLAYING!");
                Environment.Exit(0);
            }
            else if (dialog.Equals(DialogResult.No))
            {
                e.Cancel = true;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.F4))
            {
                DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
                if (dialog.Equals(DialogResult.Yes))
                {
                    MessageBox.Show("THANK YOU FOR PLAYING!");
                    Environment.Exit(0);
                }
                else if (dialog.Equals(DialogResult.No))
                {
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Visible = false;
            Settings_Form settings = new Settings_Form();
            settings.Visible = true;
        }
    }
}
