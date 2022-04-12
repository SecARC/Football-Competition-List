using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week14_2
{
    public partial class Form1 : Form
    {
        int? oldScore = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            initGrid();
        }

        private void initGrid()
        {
            dataGridView1.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn textBoxColumn;
            DataGridViewComboBoxColumn comboBoxColumn;
            TeamRepository teamRepository = new TeamRepository();

            dataGridView1.Columns.Clear();
            textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.Name = "id";
            textBoxColumn.HeaderText = "ID";
            textBoxColumn.DataPropertyName = "id";
            textBoxColumn.Width = 80;
            textBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(textBoxColumn);

            comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "team1";
            comboBoxColumn.HeaderText = "Home Team";
            comboBoxColumn.DataPropertyName = "team1";
            comboBoxColumn.Width = 150;
            comboBoxColumn.DataSource = teamRepository.getTeams();
            comboBoxColumn.DisplayMember = "name";
            comboBoxColumn.ValueMember = "Self";
            dataGridView1.Columns.Add(comboBoxColumn);

            textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.Name = "score1";
            textBoxColumn.HeaderText = "Home Score";
            textBoxColumn.DataPropertyName = "score1";
            textBoxColumn.Width = 80;
            textBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns.Add(textBoxColumn);

            textBoxColumn = new DataGridViewTextBoxColumn();
            textBoxColumn.Name = "score2";
            textBoxColumn.HeaderText = "Away Score";
            textBoxColumn.DataPropertyName = "score2";
            textBoxColumn.Width = 80;
            textBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns.Add(textBoxColumn);

            comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "team2";
            comboBoxColumn.HeaderText = "Away Team";
            comboBoxColumn.DataPropertyName = "team2";
            comboBoxColumn.Width = 150;
            comboBoxColumn.DataSource = teamRepository.getTeams();
            comboBoxColumn.DisplayMember = "name";
            comboBoxColumn.ValueMember = "Self";
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompetitionRepository competitionRepository = new CompetitionRepository();

            dataGridView1.DataSource = competitionRepository.getCompetitions();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                e.Cancel = true;
                return;
            }
            if (e.ColumnIndex != dataGridView1.Columns["score1"].Index && e.ColumnIndex != dataGridView1.Columns["score2"].Index)
                e.Cancel = true;

            oldScore = (int?)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int? newScore = (int?)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            CompetitionRepository competitionRepository = new CompetitionRepository();

            if(newScore != oldScore)
            {
                var list = dataGridView1.DataSource as List<Competition>;

                competitionRepository.UpdateCompetition(list[e.RowIndex]);
            }
        }
    }
}
