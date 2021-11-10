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
    public partial class Highscore : MaterialSkin.Controls.MaterialForm
    {
        public Highscore()
        {
            InitializeComponent();
        }
        
        //MY DATABASE CONNECTION
        MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306; database=mydb_highscores; " +
                                                            "username=root; password=;  SslMode = none;");

        public void populateMyDGV()
        {
            String selectQ = "SELECT * FROM highscore";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQ, connection);
            adapter.Fill(table);
            myDGV.DataSource = table;
        }

        private void Highscore_Load(object sender, EventArgs e)
        {
            populateMyDGV();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Snake snake = new Snake();
            snake.Visible = true;
        }
        private void Highscore_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("DO YOU WANT TO EXIT?", "EXIT", MessageBoxButtons.YesNo);
            if (dialog.Equals(DialogResult.Yes))
            {
                MessageBox.Show("THANK YOU FOR PLAYING!");
                Environment.Exit(0);
            }
            else if(dialog.Equals(DialogResult.No))
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
    }
}
