using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string sqlQuery;
        static string connect = "server=localhost;uid=root;pwd=;database=premier_league;";
        public MySqlConnection sqlConnect = new MySqlConnection(connect);
        public MySqlCommand sqlCommand;
        public MySqlDataReader sqlReader;
        public MySqlDataAdapter sqlAdapter;

        DataTable home = new DataTable();
        DataTable away = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "SELECT t.team_id as `ID Tim`, t.team_name as `Nama Tim`, m.manager_name as `Nama Manager`,date_format(a.match_date, '%e %M, %Y') as 'Tanggal', concat(a.goal_home,' - ',a.goal_away) as 'Goal' IF(m2.manager_name IS NULL,'----',m2.manager_name) as `Nama Asisten Manager`,p.player_name as `Nama Kapten`, home_stadium as `Stadium`, capacity as `Kapasitas` FROM team t LEFT JOIN manager m2 ON  t.assmanager_id = m2.manager_id ,manager m, player p LEFT JOIN match a on t.team_id = a.team_home WHERE t.manager_id = m.manager_id AND t.captain_id = p.player_id ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(home);
            sqlAdapter.Fill(away);
            comboHome.ValueMember = "ID Tim";
            comboHome.DisplayMember = "Nama Tim";
            comboHome.DataSource = home;
            comboAway.ValueMember = "ID Tim";
            comboAway.DisplayMember = "Nama Tim";
            comboAway.DataSource = away;
        }

        private void comboHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = comboHome.SelectedIndex;
            homeMan.Text = home.Rows[position]["Nama Manager"].ToString();
            homeCap.Text = home.Rows[position]["Nama Kapten"].ToString();
            stadium.Text = home.Rows[position]["Stadium"].ToString();
            capacity.Text = home.Rows[position]["Kapasitas"].ToString();
        }

        private void comboAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = comboAway.SelectedIndex;
            awayMan.Text = away.Rows[position]["Nama Manager"].ToString();
            awayCap.Text = away.Rows[position]["Nama Kapten"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
