using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheWay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GridSquare[,] grid;
        Point gridSize = new Point();

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "Generating grid";
            tabControl1.SelectTab(1);

            // set defaults
            int x = 10;
            int y = 10;

            if (
                int.TryParse(txtXaxis.Text, out x) &&
                int.TryParse(txtYaxis.Text, out y))
            {
                lblStatus.Text = "Drawing grid";
            }
            else
            {
                lblStatus.Text = "Invalid text: using default sizes";              
            }

            grid = new GridSquare[x, y];
            gridSize.X = x;
            gridSize.Y = y;
            for (int xPos = 0; xPos < x; xPos++)
            {
                for (int yPos = 0; yPos < y; yPos++)
                {
                    GridSquare square = new GridSquare(xPos, yPos);
                    grid[xPos, yPos] = square;
                }
            }


            DrawGrid(x, y);
        }


        public void DrawGrid(int xSize, int ySize)
        {
            Bitmap i = new Bitmap(panelVis.Width, panelVis.Height);
            Graphics g = Graphics.FromImage(i);
            int w = panelVis.Width / xSize;
            int h = panelVis.Height / ySize;
            Pen penNormal = new Pen(Color.Blue);
            Pen penObstacle = new Pen(Color.Red);
            Pen penStart = new Pen(Color.Green);
            Pen penEnd = new Pen(Color.Black);

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    GridSquare square = grid[x, y];
                    Pen pen = penNormal;

                    // draw in red for an obstacle
                    if (square.obstacle)
                    {
                        pen = penObstacle;
                    }

                    // change colour for the start
                    if (square.startPoint)
                    {
                        pen = penStart;
                    }

                    // change colour for the end
                    if (square.endPoint)
                    {
                        pen = penEnd;
                    }
                    g.DrawRectangle(pen, x * w, y * h, w, h);
                }
            }
            panelVis.BackgroundImage = i;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawGrid(gridSize.X, gridSize.Y);
        }       

        private void panelVis_MouseMove(object sender, MouseEventArgs e)
        {
            lblStatus.Text = ScreenToGrid(e.X, e.Y).ToString();
        }

        public Point ScreenToGrid(int screenX, int screenY)
        {
            Point p = new Point();
            p.X = screenX / (panelVis.Width / gridSize.Y);
            p.Y = screenY / (panelVis.Width / gridSize.X);
            return p;
        }

        //private void panelVis_MouseClick(object sender, MouseEventArgs e)
        //{
            //int X = e.X;
            //int Y = e.Y;
            //int i = X / gridSize.X;
            //int j = Y / gridSize.Y;

            //fill_in[i, j] = !fill_in[i, j];

            //if (fill_in[i, j])
            //{
            //    .FillRectangle(Brushes.Black, X, Y, gridSize.X, gridSize.Y);
            //}
            //else
            //{              
            //        (Brushes.White, X, Y, gridSize.X, gridSize.Y);
            //}
        //}
    }
}
