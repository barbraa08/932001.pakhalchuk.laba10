using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Comparer : IComparer<Team>
        {
            public int Compare(Team x, Team y)
            {
                return x.points.CompareTo(y.points);
            }
        }

        public class Team
        {
            public string t;
            public double l;
            public int points;

            public Team()
            {
                t = "";
                l = 0;
                points = 0;
            }
        }

        int round = 0;
        Team[] teams = new Team[8];
        List<Team> summary = new List<Team>();
        Team team = new Team(), team1 = new Team();
        private void btResult_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dtGame.Rows.Clear();
            summary.Clear();


            var restT = new List<Team>(teams.Skip(1));
            int teamAm = 8;

            if (restT[round % restT.Count]?.Equals(default) == false)
            {
                int m = 0;
                double S = 0;
                double a = rand.NextDouble();
                S += Math.Log(a);
                while (S >= -teams[0].l)
                {
                    m++;
                    a = rand.NextDouble();
                    S += Math.Log(a);
                }
                teams[0].points += m;
                summary.Add(teams[0]);

                m = 0;
                S = 0;
                a = rand.NextDouble();
                S += Math.Log(a);
                while (S >= -restT[round % restT.Count].l)
                {
                    m++;
                    a = rand.NextDouble();
                    S += Math.Log(a);
                }
                restT[round % restT.Count].points += m;
                summary.Add(restT[round % restT.Count]);
            }

            for (var index = 1; index < teamAm / 2; index++)
            {
                var first = restT[(round + index) % restT.Count];
                var second = restT[(round + restT.Count - index) % restT.Count];
                if (first?.Equals(default) == false && second?.Equals(default) == false)
                {
                    int m = 0;
                    double S = 0;
                    double a = rand.NextDouble();
                    S += Math.Log(a);
                    while (S >= -first.l)
                    {
                        m++;
                        a = rand.NextDouble();
                        S += Math.Log(a);
                    }
                    first.points += m;
                    summary.Add(first);

                    m = 0;
                    S = 0;
                    a = rand.NextDouble();
                    S += Math.Log(a);
                    while (S >= -second.l)
                    {
                        m++;
                        a = rand.NextDouble();
                        S += Math.Log(a);
                    }
                    second.points += m;
                    summary.Add(second);
                }
            }

            Comparer comp = new Comparer();
            summary.Sort(comp);
            summary.Reverse();
            dtGame.ColumnCount = 3;
            dtGame.Columns[0].HeaderText = "POS";
            dtGame.Columns[1].HeaderText = "Team";
            dtGame.Columns[2].HeaderText = "Won";

            for (int i = 0; i < 8; i++)
            {
                if (round == 0) dtGame.Rows.Add();
                dtGame.Rows[i].Cells[0].Value = i + 1;
                dtGame.Rows[i].Cells[1].Value = summary[i].t;
                dtGame.Rows[i].Cells[2].Value = summary[i].points;
            }
            for (int i = 0; i < 8; i++)
                summary[i].points = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) { teams[i] = new Team(); }

            teams[0].t = "Chelsea"; teams[0].l = 1.9;
            teams[1].t = "Liverpool"; teams[1].l = 1.5;
            teams[2].t = "Arsenal"; teams[2].l = 1.4;
            teams[3].t = "Man City"; teams[3].l = 1.1;
            teams[4].t = "Tottenham"; teams[4].l = 0.9;
            teams[5].t = "Man Utd"; teams[5].l = 0.8;
            teams[6].t = "West Brom"; teams[6].l = 0.7;
            teams[7].t = "Everton"; teams[7].l = 0.5;
        }
    }
}
