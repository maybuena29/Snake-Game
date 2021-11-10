using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_TaskPerformance
{
    public partial class GameOver : MaterialSkin.Controls.MaterialForm
    {

        MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; " +
            "database=mydb_highscores; " +
            "username=root; password=;  " +
            "SslMode = none;");

        public void executeQuery(String query)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("THANKYOU!");
                }
                else
                {
                    MessageBox.Show("DIDN'T SUCCESS!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public GameOver()
        {
            InitializeComponent();
            lblGameOver.Text = GameSettings.Score.ToString();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            StringBuilder playerName = new StringBuilder(txtName.Text.ToString());

            if (playerName.ToString().Equals(""))
            {
                MessageBox.Show("PLEASE ENTER YOUR NAME!");
                return;
            }
            else
            {
                String insertData = "INSERT INTO highscore (Name, Score)VALUES('" + playerName + "', '" + GameSettings.Score + "')";
                executeQuery(insertData);
                Visible = false;
                Close();
                Snake snake = new Snake();
                snake.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog.Equals(DialogResult.Yes))
            {
                MessageBox.Show("THANK YOU FOR PLAYING!");
                Environment.Exit(0);
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
    }
}
