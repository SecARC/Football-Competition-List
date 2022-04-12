using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week13_1
{
    public partial class Competition : UserControl
    {
        private DateTime m_date;
        private Point m_score;
        public string Team1 { get { return labelTeam1.Text; } set { labelTeam1.Text = value; } }
        public string Team2 { get { return labelTeam2.Text; } set { labelTeam2.Text = value; } }
        public string Tournament { get { return labelTournament.Text; } set { labelTournament.Text = value; } }
        public DateTime CompetitionDate { 
            get { return m_date; } 
            set { 
                m_date = value;
                if(m_date.Date == DateTime.Today)
                    labelDate.Text = m_date.ToString("HH:mm"); 
                else
                    labelDate.Text = m_date.ToString("dd/MM/yyyy HH:mm");
            } 
        }
        public Point Score { get { return m_score; } set { m_score = value; labelScore.Text = $"{m_score.X} - {m_score.Y}"; } }
        
        public Competition()
        {
            InitializeComponent();
        }

        private void Competition_Load(object sender, EventArgs e)
        {

        }

        public void UpdateData(FootballMatch data)
        {
            this.Team1 = data.Team1;
            this.Team2 = data.Team2;
            this.Tournament = data.Tournament;
            this.CompetitionDate = data.CompetitionDate;
            this.Score = new Point(data.Score1, data.Score2);
        }
    }
}
