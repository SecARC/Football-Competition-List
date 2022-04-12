using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace week13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void competition2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FootballMatch m = new FootballMatch()
            {
                Team1 = "Hatayspor",
                Team2 = "Göztepe",
                Tournament = "Dostluk Maçı",
                CompetitionDate = new DateTime(2021, 05, 28, 12, 00, 00),
                Score1=4,
                Score2=5
            };
            competition2.UpdateData(m);
            //competition2.Team1 = "Hatayspor";
            //competition2.Team2 = "Göztepe";
            //competition2.Tournament = "Dostluk Maçı";
            //competition2.Score = new Point(3, 3);
            //competition2.CompetitionDate = new DateTime(2021, 05, 28, 12, 00, 00);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            List<FootballMatch> list = new List<FootballMatch>();
            try
            {
                using (StreamReader reader = new StreamReader("maclar.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] arr = line.Split(',');

                        if(arr.Length >= 8)
                        {
                            if (string.IsNullOrEmpty(arr[0]))
                                continue;

                            FootballMatch match = new FootballMatch()
                            {
                                CompetitionDate = DateTime.Parse(arr[0] + " " + arr[1]),
                                RedCard1 = string.IsNullOrEmpty(arr[2]) ? 0 : Convert.ToInt32(arr[2]),
                                Team1 = arr[3],
                                Score1 = Convert.ToInt32(arr[4]),
                                Score2 = Convert.ToInt32(arr[5]),
                                Team2 = arr[6],
                                Tournament = "99-20 Türkiye 1.Lig",
                                RedCard2 = string.IsNullOrEmpty(arr[7]) ? 0 : Convert.ToInt32(arr[7])
                            };
                            list.Add(match);
                        }
                    }
                }
                dataGridView1.DataSource = list;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var list = dataGridView1.DataSource as List<FootballMatch>;

            if(list != null && e.RowIndex != -1)
            {
                var item = list[e.RowIndex];
                competition1.UpdateData(item);
            }
        }
    }
}
