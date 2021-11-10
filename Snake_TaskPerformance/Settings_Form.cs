using System;
using System.Collections;
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
    public partial class Settings_Form : MaterialSkin.Controls.MaterialForm
    {
        public Settings_Form()
        {
            InitializeComponent();
        }

        private void Settings_Form_Load(object sender, EventArgs e)
        {
            pictureHeadColor.BackColor = Color.FromName(Settings.Default["snake_head"].ToString());
            pictureBodyColor.BackColor = Color.FromName(Settings.Default["snake_body"].ToString());
            pointsPerF.Text = Settings.Default["point_per_food"].ToString();

                foreach (var obj in GameSettings.ColorList)
                {
                    head_colors.Items.Add(obj);
                    body_colors.Items.Add(obj);
                }

            head_colors.SelectedItem = Settings.Default["snake_head"].ToString();
            body_colors.SelectedItem = Settings.Default["snake_body"].ToString();
        }

        private void head_colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            String color = head_colors.SelectedItem.ToString();
            if (color == "Default")
            {
                pictureHeadColor.BackColor = Color.FromName("Cyan");
            }
            else
            {
                pictureHeadColor.BackColor = Color.FromName(color);
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

        private void Settings_Form_FormClosing(object sender, FormClosingEventArgs e)
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

        private void body_colors_SelectedIndexChanged(object sender, EventArgs e)
        {
            String color = body_colors.SelectedItem.ToString();
            if (color == "Default")
            {
                pictureBodyColor.BackColor = Color.FromName("DeepSkyBlue");
            }
            else
            {
                pictureBodyColor.BackColor = Color.FromName(color);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            int points = Convert.ToInt32(pointsPerF.Text);
            if (points == 1) {
                MessageBox.Show("MINIMUM POINTS REACHED!");
                label2.Enabled = false;
            }
            else
            {
                points--;
                pointsPerF.Text = Convert.ToString(points);
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label2.Enabled = true;
            int points = Convert.ToInt32(pointsPerF.Text);
            if (points == 9)
            {
                MessageBox.Show("MAXIMUM POINTS REACHED!");
                label1.Enabled = false;
            }
            else
            {
                points++;
                pointsPerF.Text = Convert.ToString(points);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Settings.Default["snake_head"] = head_colors.SelectedItem.ToString();
            Settings.Default["snake_body"] = body_colors.SelectedItem.ToString();
            Settings.Default["point_per_food"] = Convert.ToInt32(pointsPerF.Text);
            Settings.Default.Save();
            Visible = false;
            Snake snake = new Snake();
            snake.Visible = true;
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            String head = Settings.Default["snake_head"].ToString();
            String body = Settings.Default["snake_body"].ToString();
            int points = Convert.ToInt32(Settings.Default["point_per_food"].ToString());

            String cbHead = head_colors.SelectedItem.ToString();
            String cbBody= body_colors.SelectedItem.ToString();
            int lbPoint = Convert.ToInt32(pointsPerF.Text);

            if (!cbHead.Equals(head) || !cbBody.Equals(body) || points != lbPoint)
            {
                DialogResult dialog = MessageBox.Show("DO YOU WANT TO SAVE CHANGES?", "SAVE", MessageBoxButtons.YesNo);
                if (dialog.Equals(DialogResult.Yes))
                {
                    Settings.Default["snake_head"] = head_colors.SelectedItem.ToString();
                    Settings.Default["snake_body"] = body_colors.SelectedItem.ToString();
                    Settings.Default["point_per_food"] = Convert.ToInt32(pointsPerF.Text);
                    Settings.Default.Save();
                    Visible = false;
                    Snake snake = new Snake();
                    snake.Visible = true;
                    MessageBox.Show("SETTINGS SAVED!");
                }
                else if (dialog.Equals(DialogResult.No))
                {
                    Visible = false;
                    Snake snake = new Snake();
                    snake.Visible = true;
                    MessageBox.Show("SETTINGS DIDN'T SAVED!");
                }
            }
            else
            {
                Visible = false;
                Snake snake = new Snake();
                snake.Visible = true;
            }
        }
    }
}
