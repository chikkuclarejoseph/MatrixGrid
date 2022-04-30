using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MatrixGrid2
{
    public partial class FormMatrixGrid : Form
    { 
        //Add the member variables
       // public FormMatrixGrid()

        public int m_Width;   //Width of the grid cell
        public int m_Height;  //Height of the cell
        public int m_NoOfRows;  //No of rows
        public int m_NoOfCols;  //No of columns
        public int m_Xoffset;
        public int m_Yoffset;
        public int m_iCounter = 2;
        public int m_GridSize = 8;

        public const int DEFAULT_X_OFFSET = 100;
        public const int DEFAULT_Y_OFFSET = 100;
        public const int DEFAULT_NO_ROWS = 3;
        public const int DEFAULT_NO_COLS = 3;
       public const int DEFAULT_WIDTH = 60;
        public const int DEFAULT_HEIGHT = 60;

        


        public FormMatrixGrid()
        {
            Initialize();
            InitializeComponent();
            bThreadStatus = false;
        }
        private void OnPaint(object sender, EventArgs e)
        {
            //DrawGrid();

        }

       
        public void Initialize()
        {

            m_NoOfRows = DEFAULT_NO_ROWS;
            m_NoOfCols = DEFAULT_NO_COLS;
            m_Width = DEFAULT_WIDTH;
            m_Height = DEFAULT_HEIGHT;
            m_Xoffset = DEFAULT_X_OFFSET;
            m_Yoffset = DEFAULT_Y_OFFSET;
        }

        private void DrawGrid()
        {
            Graphics boardLayout = this.CreateGraphics();
            Pen layoutPen = new Pen(Color.Red);
            layoutPen.Width = 5;

            while (m_iCounter <= m_GridSize)
           {
              Thread.Sleep(1000);
                if (m_iCounter != m_GridSize)
                {
                    int X = DEFAULT_X_OFFSET;
                    int Y = DEFAULT_Y_OFFSET;

                    for (int i = 0; i <= m_iCounter; i++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X + this.m_Width * this.m_iCounter, Y);
                        Y = Y + m_Height;
                    }
                    X = DEFAULT_X_OFFSET;
                    Y = DEFAULT_Y_OFFSET;
                    for (int j = 0; j <= m_iCounter; j++)
                    {
                        boardLayout.DrawLine(layoutPen, X, Y, X, Y + this.m_Height * this.m_iCounter);
                        X = X + m_Width;
                    }
                    m_iCounter++;
                    
                }
                else
                {
                    m_iCounter = 2;
                    Invalidate();

                }
            }
        }

       
       
       /* public void ThreadCounter()
        {
            try
            {
                while (true)
                {
                    m_iCounter++;
                    if (m_iCounter > m_GridSize)
                    {
                        m_iCounter = 2;
                    }
                    Invalidate();
                    Thread.Sleep(1000);
                }
            }
           catch (Exception ex)
           {
            }
        }*/

      

        private void FormMatrixGrid_Load(object sender, EventArgs e)
        {

        }
       
        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            MatrixGrid = new Thread(new ThreadStart(DrawGrid));
            MatrixGrid.Start();
            bThreadStatus = true;
        }

        private void toolStripButtonPause_Click(object sender, EventArgs e)
        {
            MatrixGrid.Suspend();
        }

        private void toolStripButtonResume_Click(object sender, EventArgs e)
        {
            MatrixGrid.Resume();
        }

        private void toolStripMenuItem33_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 4;
            this.Refresh();
        }

        private void toolStripMenuItem44_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 5;
            this.Refresh();
        }

        private void toolStripMenuItem55_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 6;
            this.Refresh();
        }

        private void toolStripMenuItem66_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 7;
            this.Refresh();
        }

        private void toolStripMenuItem77_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 8;
            this.Refresh();
        }

        private void toolStripMenuItem88_Click_1(object sender, EventArgs e)
        {
            m_GridSize = 9;
            this.Refresh();
        }
    }



}       
   