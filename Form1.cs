using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi_proekt
{
    public partial class Form1 : Form, View
    {
        private GeneticController g;
        private Tour tour;
        private Thread myThread;

        public Tour BestTour
        {
            get { return tour; } set { tour = value; }
        }

        public Form1()
        {
            InitializeComponent();
            g = GeneticController.Instance();
            g.height = panel1.Height;
            g.weidth = panel1.Width;
            g.addFormView(this);
            g.addConsoleView(new ConsoleView());
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            
            if(tour==null || tour.tour.Count < 5)
            {
                MessageBox.Show("Города не инициализированы");
                return;
            }
            g.initPopulation(tour.tour);
            if (checkBox1.Checked)
            {
                g.slowMotion = true;
            }
            else
            {
                g.slowMotion = false;
            }
            myThread = new Thread(new ThreadStart(g.start));
            myThread.Start();
            startButton.Enabled = false;
            citygenButton.Enabled = false;
            
           
        }

        public void UpdateState(Tour tour, int gen)
        {
            BestTour = tour;
            panel1.Invalidate();
            populationLabel.Text = "Поколение: " + gen;
            distanceLabel.Text = "Минимальная дистанция: " + BestTour.distance;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (tour == null)
                return;
            Graphics gr = panel1.CreateGraphics();
            gr.Clear(Color.White);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Black, 2);
            
            for (int i =0; i < tour.tour.Count; i++)
            {
                gr.DrawLine(pen, new Point(tour.tour[i].x, tour.tour[i].y), new Point(tour.tour[(i + 1) % tour.tour.Count].x, tour.tour[(i + 1) % tour.tour.Count].y));
            }
            foreach (City c in tour.tour)
            {
                if (c == tour.tour[0])
                {
                    myBrush.Color = Color.Green;
                }
                else
                {
                    myBrush.Color = Color.Red;
                }
                gr.FillEllipse(myBrush, c.x - 5, c.y - 5, 10, 10);
            }

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            g.stop();
            startButton.Enabled = true;
            citygenButton.Enabled = true ;
        }

        private void citygenButton_Click(object sender, EventArgs e)
        {
            g.numCities = Convert.ToInt32(numericUpDown1.Value);
            tour = Tour.random(g.numCities);
            UpdateState(BestTour, 1);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myThread != null)
            {
                myThread.Abort();
            }
            Application.Exit();
        }

        private void обАлгоритмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
